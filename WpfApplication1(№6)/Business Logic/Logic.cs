using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Text.RegularExpressions;
using System.Threading;

namespace Business_Logic
{
    public class Logic
    {
        public bool IsEndReached { get; private set; }
        public int CurrentIndex { get; private set; }
        private int CandleCount { get; set; }
        private IRepository CandleData;
        private List<ChartData> CalculationQueue;
        public Logic()
        {
            CandleData = new CandleModel();
            CalculationQueue = new List<ChartData>(14);
            IsEndReached = true;
            CurrentIndex = 0;
            CandleCount = 0;
        }
        public void NewDataBase(string path)
        {
            if (Regex.IsMatch(path, ".json$"))
            {
                CandleData.FillModel(path, new JsonFileReader());
            }
            if(Regex.IsMatch(path, ".xlsx$"))
            {
                CandleData.FillModel(path, new ExcelReader());
            }
            CurrentIndex = 0;
            CandleCount = CandleData.GiveNumberOfCandles();
            IsEndReached = false;
        }
        public ChartData  GiveNextPoint()
        {
            if (!IsEndReached)
            {
                ChartData newdata = CalculationQueue[CalculationQueue.Count - 1];
                PullNext();
                return newdata;
            }
            else
            {
                return new ChartData(CandleEntity.EmptyCandle());
            }
        }
        public void PullNext()
        {
            if (CurrentIndex < CandleCount)
            {
                if (CandleData == null)
                {
                    return;
                }
                if (CalculationQueue.Count == 14)
                {
                    CalculationQueue.RemoveAt(0);
                }
                CalculationQueue.Add(new ChartData(CandleData.Get(CurrentIndex)));
                ComputeData();
                CurrentIndex++;
            }
            else
            {
                IsEndReached = true;
            }
        }
        private void ComputeData()
        {
            decimal TrueRange = 0;
            decimal DMPositive = 0;
            decimal DMNegative = 0;
            int length = CalculationQueue.Count - 1;
            if (length == 0)
            {
                TrueRange = CalculationQueue[0].CandleInfo.High - CalculationQueue[0].CandleInfo.Low;
                DMPositive = 0;
                DMNegative = 0;
            }
            else
            {
                TrueRange = Math.Max(CalculationQueue[length].CandleInfo.High, CalculationQueue[length - 1].CandleInfo.Close) - Math.Min(CalculationQueue[length].CandleInfo.Low, CalculationQueue[length - 1].CandleInfo.Close);
                decimal MPos = CalculationQueue[length].CandleInfo.High - CalculationQueue[length - 1].CandleInfo.High;
                decimal MNeg = CalculationQueue[length - 1].CandleInfo.Low - CalculationQueue[length].CandleInfo.Low;
                if (MPos > MNeg && MPos > 0)
                {
                   DMPositive = MPos;
                }
                if (MNeg > MPos && MNeg < 0)
                {
                    DMNegative = MNeg;
                }

            }
            float alpha = 2 / (length + 1);
            CalculationQueue[length].DIPositive += alpha * (float)(DMPositive / TrueRange);
            CalculationQueue[length].DINegative += alpha * (float)(DMNegative /TrueRange);
            for (int i = 1; i <= length; i++)
            {
                CalculationQueue[length].DIPositive += (1 - i * alpha) * CalculationQueue[length - i].DIPositive;
                CalculationQueue[length].DINegative += (1 - i * alpha) * CalculationQueue[length - i].DINegative;
            }
            CalculationQueue[length].DXI = 100 * (Math.Abs(CalculationQueue[length].DIPositive - CalculationQueue[length].DINegative)) / (CalculationQueue[length].DIPositive + CalculationQueue[length].DINegative);
            CalculationQueue[length].ADX = alpha * CalculationQueue[length].DXI;
            for (int i = 1; i <= length; i++)
            {
                CalculationQueue[length].ADX += (1 - i * alpha) * CalculationQueue[length - i].DXI;
            }
        }

    }
    public class ChartData
    {
        public CandleEntity CandleInfo;
        public float DIPositive { get; set; }
        public float DINegative { get; set; }
        public float DXI { get; set; }
        public float ADX { get; set; }
        public  ChartData(CandleEntity candle)
        {
            CandleInfo = candle;
            DIPositive = 0;
            DINegative = 0;
            DXI = 0;
            ADX = 0;
        }
    }
}
