using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Newtonsoft.Json;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using ClosedXML.Excel;

namespace DataAccessLayer
{
    public class CandleEntity
    {
        public long TimeStamp { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public DateTime Time { get; set; }

        static public CandleEntity EmptyCandle()
        {
            CandleEntity emptycandle = new CandleEntity();
            emptycandle.TimeStamp = -1;
            return emptycandle;
        }
    }

    public interface IRepository
    { 
        CandleEntity Get(int id);
        List<CandleEntity> List();
        void FillModel(string path, IReader reader);
        int GiveNumberOfCandles();
    }
    public class CandleModel : IRepository
    {
        private List<CandleEntity> Candles;
        public CandleEntity Get(int id)
        {
            return Candles[id];
        }
        public List<CandleEntity> List()
        {
            return Candles;
        }
        public int GiveNumberOfCandles()
        {
            if (Candles == null)
            {
                return -1;
            }
            else
            {
                return Candles.Count;
            }
        }
        public void FillModel(string path, IReader reader)
        {
            Candles = reader.ReadCandles(path);
        }
        public void Clear()
        {
            if (Candles != null)
            {
                Candles.Clear();
            }
        }
    }
    public interface IReader
    {
        List<CandleEntity> ReadCandles(string path);
    }
    public class JsonFileReader:IReader
    {

        public List<CandleEntity> ReadCandles(string path)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            StreamReader reader = new StreamReader(path);
            JsonTextReader jsonreader = new JsonTextReader(reader);
            RootObject file = serializer.Deserialize<RootObject>(jsonreader);

            List<CandleEntity> candles = new List<CandleEntity>(file.t.Count); 
            for(int i = 0;i< file.t.Count; i++)
            {
                candles.Add(new CandleEntity());
                candles[i].Time = new DateTime(file.t[i]*10000000);
                candles[i].High =  (decimal)file.h[i];
                candles[i].Close = (decimal)file.c[i];
                candles[i].Open = (decimal)file.o[i];
                candles[i].Low = (decimal)file.l[i];
                candles[i].Time.AddYears(1970);
                candles[i].TimeStamp = candles[i].Time.Hour*10000+candles[i].Time.Minute*100;
            }
            return candles;
        }
    }
    public class ExcelReader : IReader
    {
        public List<CandleEntity> ReadCandles(string path)
        {
            ////Создаём приложение.
            //Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            ////Открываем книгу.                                                                                                                                                        
            //Workbook ObjWorkBook = ObjExcel.Workbooks.Open(path, 0, false, 5, "", "", false,XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            ////Выбираем таблицу(лист).
            //Worksheet ObjWorkSheet;
            //ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];
            //Range xlRange = ObjWorkSheet.UsedRange;
            var workbook = new XLWorkbook(path);
            var xlRange = workbook.Worksheet(1);

            List<CandleEntity> candles = new List<CandleEntity>(xlRange.LastRowUsed().RowNumber());
            for (int i = 2; i<= xlRange.LastRowUsed().RowNumber(); i++)
            {
                candles.Add(new CandleEntity());
                candles[i-2].Time = new DateTime();
                string time = xlRange.Cell(i, 3).GetValue<string>();
                DateTime date = DateTime.ParseExact(time, "yyyyMMdd", CultureInfo.InvariantCulture);
                candles[i-2].TimeStamp = xlRange.Cell(i, 4).GetValue<long>();
                candles[i-2].Open = xlRange.Cell(i, 5).GetValue<decimal>();
                candles[i-2].High = xlRange.Cell(i, 6).GetValue<decimal>();
                candles[i-2].Low = xlRange.Cell(i, 7).GetValue<decimal>();
                candles[i-2].Close = xlRange.Cell(i, 8).GetValue<decimal>();
            }
            return candles;

        }
    }
    public class RootObject
    {
        public List<long> t { get; set; }
        public List<double> c { get; set; }
        public List<double> o { get; set; }
        public List<double> h { get; set; }
        public List<double> l { get; set; }
        public List<int> v { get; set; }
        public string s { get; set; }
        public int nextTime { get; set; }
    }

    //public class CandleContext : DbContext
    //{
    //    public CandleContext() : base("DBConnection") { }
    //    public DbSet<CandleEntity> Candles { get; set; }
    //}
    //public class CandleRepository : IDisposable, IRepository
    //{
    //    private CandleContext db = new CandleContext();
    //    public void Save(CandleEntity b)
    //    {
    //        db.Candles.Add(b);
    //        db.SaveChanges();
    //    }
    //    public IEnumerable<CandleEntity> List()
    //    {
    //        return db.Candles;
    //    }
    //    public CandleEntity Get(int id)
    //    {
    //        return db.Candles.Find(id);
    //    }

    //    #region IDisposable Support
    //    private bool disposedValue = false; // Для определения избыточных вызовов

    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!disposedValue)
    //        {
    //            if (disposing)
    //            {
    //                // TODO: освободить управляемое состояние (управляемые объекты).
    //                if (db != null)
    //                {
    //                    db.Dispose();
    //                    db = null;
    //                }
    //            }

    //            // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
    //            // TODO: задать большим полям значение NULL.

    //            disposedValue = true;
    //        }
    //    }

    //    // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
    //    // ~BookRepository() {
    //    //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
    //    //   Dispose(false);
    //    // }

    //    // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
    //    public void Dispose()
    //    {
    //        // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
    //        Dispose(true);
    //        // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
    //        GC.SuppressFinalize(this);
    //    }
    //    #endregion

    //}
}
