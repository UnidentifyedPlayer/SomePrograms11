using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Business_Logic;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SciChart.Charting.DrawingTools.TradingAnnotations.ViewModels;
using SciChart.Charting.Model.ChartSeries;
using SciChart.Charting.Visuals.Annotations;
using SciChart.Charting.Model.DataSeries;
using SciChart.Charting.Visuals.RenderableSeries;
using SciChart.Examples.ExternalDependencies.Data;
using System.Timers;
using SciChart.Charting.ChartModifiers;
using SciChart.Charting.Visuals.Axes;
using SciChart.Charting.Common.Helpers;
using SciChart.Data.Model;
using System.IO;
using Microsoft.Win32;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Logic logic = new Logic();
        private OhlcDataSeries<DateTime, double> dataSeries = new OhlcDataSeries<DateTime, double>();
        Thread calculationThread;
        ChartData currentdata;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CandlestickChartExampleView_OnLoaded(object sender, RoutedEventArgs e)
        {
            sciChart.RenderableSeries[0].DataSeries = dataSeries;
        }
        private void StartButton_OnClick(object sender, RoutedEventArgs e)
        {
            calculationThread = new Thread(() => AddChartData());
            calculationThread.IsBackground = true;
            calculationThread.Start();
            StartButton.IsEnabled = false;
            btnOpenFile.IsEnabled = false;
        }
        private void AddADX()
        {
            int size = 20;

            var nextAdxPoint = currentdata.ADX;

            CustomAnnotation annotation = null;

            var uri = new Uri(AppDomain.CurrentDomain.BaseDirectory + "up.png", UriKind.RelativeOrAbsolute);
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = uri;
            bi.EndInit();

            Image arrow = new Image()
            {
                Source = bi,
                Width = size,
                Height = size
            };
            annotation = new CustomAnnotation()
            {
                X1 = logic.CurrentIndex,
                Y1 = nextAdxPoint,
                Content = arrow,
                ContentTemplate = (DataTemplate)sciChart.Resources["AnnotationTemplate"],
                VerticalAnchorPoint = VerticalAnchorPoint.Bottom,
                HorizontalAnchorPoint = HorizontalAnchorPoint.Center
            };
            sciChart.Annotations.Add(annotation);
        }
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                logic.NewDataBase(openFileDialog.FileName);
        }
        private void AddChartData()
        {
            while(!logic.IsEndReached)
            {
                logic.PullNext();
                Thread.Sleep(500);
                currentdata = logic.GiveNextPoint();
                //if(currentdata)
                dataSeries.Append(currentdata.CandleInfo.Time,
                     (double)currentdata.CandleInfo.Open,
                        (double)currentdata.CandleInfo.High,
                        (double)currentdata.CandleInfo.Low,
                        (double)currentdata.CandleInfo.Close);
                if (dataSeries.Count == 1)
                {
                    sciChart.Dispatcher.Invoke(() => sciChart.ZoomExtents());
                }
                sciChart.Dispatcher.Invoke(() => AddADX());
                sciChart.Dispatcher.Invoke(() => RefreshData());
            }
        }
        private void RefreshData()
        {
            sciChart.RenderableSeries[0].DataSeries = dataSeries;
            AxisX.VisibleRange = new IndexRange(dataSeries.Count - 20, dataSeries.Count - 1);
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            btnOpenFile.IsEnabled = true;
            sciChart.Annotations.Clear();
            dataSeries.Clear();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculationThread != null && calculationThread.IsAlive)
            {
                calculationThread.Abort();
                StartButton.IsEnabled = true;
            }
        }
    }
}
