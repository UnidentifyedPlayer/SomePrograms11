   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   [ WSciChart.Drawing, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823i eSciChart.Charting.DrawingTools, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823X TSciChart.Core, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823\	 XSciChart.Charting, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823X
 TSciChart.Data, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e8239s)http://schemas.abtsoftware.co.uk/scichart    	 
 5   	   e aSciChart.Examples.ExternalDependencies, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=nullDext:http://schemas.abtsoftware.co.uk/scichart/exampleExternals  5   	   )localclr-namespace:WpfApplication1  5   	   -   5          � Title$  
MainWindow��5   	   $	��600��6   $	��900��6)    � 	Resources 5      ��%    5      .��5      � -   5         �Name$ grid1��5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   $	��124��6,   �� 5      .+�5   
   �� -   5        $��btnOpenFile��5      $��10,227,4,305q�6>   .��6T   	Open file6_   �� 5   
   -   5        $��
StopButton��5       $
��Stop��6   $
��Left=�6L   $��	10,72,0,0q�6g   $	��Top=�6z   $	��100��6�   $��26��6�   �� 5   
   -   5        $��ClearButton��5   ;   $��Clear��6   $
��Left=�6P   $��	10,41,0,0q�6k   $	��Top=�6~   $	��100��6�   $��26��6�   �� 5   
   -   5        $��StartButton��5   !   $��Start��6   $
��Left=�6Q   $��	10,10,0,0q�6l   $	��Top=�6   $	��100��6�   $��26��6�   k  eSciChart.Examples.ExternalDependencies.Controls.SciChartInteractionToolbar.SciChartInteractionToolbar  5   
      TargetSurface 6)   ��  �� ElementName$ sciChart��5      / 	 )SciChart.Charting.Visuals.SciChartSurface  5   
   -   5        $��sciChart��5      $��0q�6,   $��0q�68   $��13,0,0,0q�6L   $��1��6^      RenderableSeries 5      I 	 CSciChart.Charting.Visuals.RenderableSeries.FastLineRenderableSeries  -   5          Name$ lineRenderSeries��5   -   E 	 ?SciChart.Charting.Visuals.RenderableSeries.BaseRenderableSeries   Stroke$ 	#FF99EE99��6G   	   StrokeThickness$	 2��6Z   
   XAxis
 5$      9 	 3SciChart.Charting.Visuals.Axes.CategoryDateTimeAxis  5%      -	   5        $��AxisX��5%   )      YAxis 5)      0 	 *SciChart.Charting.Visuals.Axes.NumericAxis  5*      -
   5        $��AxisY��5*   H   - 	 'SciChart.Charting.Visuals.Axes.AxisCore   GrowByK 	 ESciChart.Charting.Common.Databinding.StringToDoubleRangeTypeConverter$ 0.1, 0.1 6       DrawMajorBands . 6H      ChartModifier 5/      4	 	 .SciChart.Charting.ChartModifiers.ModifierGroup	  50       	  ChildModifiers. 52      ?
 	 9SciChart.Charting.ChartModifiers.RubberBandXyZoomModifier
  8 	 2SciChart.Charting.ChartModifiers.ChartModifierBase   	ExecuteOn$ MouseLeftButton=�61    
  RubberBandFill �	#33FFFFFF 
  RubberBandStroke �	#AAFFFFFF  
  RubberBandStrokeDashArray$	 2 2R�54   1   6 	 0SciChart.Charting.ChartModifiers.ZoomPanModifier  56      $ MouseRightButton=�6(   : 	 4SciChart.Charting.ChartModifiers.ZoomPanModifierBase   	ClipModeX$
 None=�6E   8 	 2SciChart.Charting.ChartModifiers.YAxisDragModifier  58      ; 	 5SciChart.Charting.ChartModifiers.AxisDragModifierBase   DragMode$ Scale=�6*   8 	 2SciChart.Charting.ChartModifiers.XAxisDragModifier  5:      $	 Pan=�6*   = 	 7SciChart.Charting.ChartModifiers.MouseWheelZoomModifier  5<      : 	 4SciChart.Charting.ChartModifiers.ZoomExtentsModifier  5>      $ MouseDoubleClick=�6,   5?      5A      5B      5D      