   M S B A M L   `   `   `  ????B  >Hibredu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Hibredu.DataHibredu.Data  5   	   b ^Syncfusion.SfChart.WPF, Version=20.3500.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89eGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPFSyncfusion.UI.Xaml.Charts 5   	       Hibredu.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Hibredu.Data     5   	   ^
syncfusionGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPF     5   	     ? Title$  Hibredu??5	   	   $
??5000??6   $	??800??6'    ? DataContext 5
         Hibredu.Data.Context  5   
   .??5      ?? .??5   
   ?? .+?5      ?? .+?5      ?  ? RowDefinitions 5      ?? 5      $??45 ?6(   ?? 5      ?? 5      .+?5      ?? $??18(?6   $??Center=?5      $??Center=?5      $??5q?63   $??0??5      $??Student registration??6%   &   System.Windows.Controls.DataGrid  5      -   5          Name$ StudentDataGrid??5         AutoGenerateColumns$ False??68      
IsReadOnly$
 True??6T   $??1??5          ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6(   $??5q?68   $ ?? IsSynchronizedWithCurrentItem$
 TrueY?6C      Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Student Id??61   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6E   ?? *Id+  5$      $
	 Name??61   
 6?   ?? *Name+  5%      $	 Average??61   
 6B   ?? *	Average+  5&      $	 	Frequency??61   
 6D   ?? *	Frequency+4  .System.Windows.Controls.DataGridTemplateColumn  5)      $	 Delete Student register??65      CellTemplate 5*   "   ?? 5+   &   .R?5,   *   ?? -   5        $??Delete??5,   1   6B   5-   '   5/      51      ? 53      $??2??6   .+?55      ?? $??0??6!   $??5q?61   $??1q?6<   
???   ?._?56      ?? $??5q?6)   .+?57   "   ?? $??Add new student??6(   $
??Bold"?6B   $??Center=?58   $   $??Center=?6A   $??5q?6\   ? 5:   "   -   5        $??NewStudentGrid??5:   '    5;   &   ?? 5<   *   ?? 5=   *   ?? 5>   *   ?? 5?   *    ? ColumnDefinitions 5B   &   ?? 5C   *   ?? 5D   *   .+?5G   &   ?? $??0??6,   $??0??69   $
??Name??6I   ?? 5H   &   $??0??6.   $??1??6;   ??6K   ?? *Name+?? 5J   &   $??1??6,   $??0??69   $??Average??6I   ?? 5K   &   $??1??6.   $??1??6;   ??6K   ?? *	Average+?? 5M   &   $??2??6,   $??0??69   $??	Frequency??6I   ?? 5N   &   $??2??6.   $??1??6;   ??6K   ?? *	Frequency+?? 5Q   &   -   5        $??4??5Q   -   $??2??6:   $	??150??6N   $??Add student register??6Z   $??15q?5R   )   $??Center=?5S   )   $??Center=?5T   )   5U   #   5V      5W      5Z      5[      5\      ?? 5^      .+?5_      ?? $??18(?6   $??Center=?5`      $??Center=?5a      $??5q?63   $??0??5b      $??Students data analysis??6%   ? 5d      .+?5e      '  !Syncfusion.UI.Xaml.Charts.SfChart  )	  #Syncfusion.UI.Xaml.Charts.ChartBase 	  Header$" Graph of average per student??6)   $	??300??6O   $??	30,0,30,0q?6\      PrimaryAxis 5g      ,
  &Syncfusion.UI.Xaml.Charts.CategoryAxis
  5h      )  #Syncfusion.UI.Xaml.Charts.ChartAxis   Header$ Student name??66   $??16(?6L      SecondaryAxis 5k      -  'Syncfusion.UI.Xaml.Charts.NumericalAxis  5l      $ Average??67   $??16(?6H      Series. 5o      ,  &Syncfusion.UI.Xaml.Charts.ColumnSeries  -   5          Name$ StudentsDataAverage??5o   2   /  )Syncfusion.UI.Xaml.Charts.ChartSeriesBase   ListenPropertyChange$
 True??6P      XBindingPath$
 Name??6?   ,  &Syncfusion.UI.Xaml.Charts.XyDataSeries   YBindingPath$ Average??6?      ItemsSource 6m   ?? *StudentsData+ ?? Mode$ OneTime=?/  )Syncfusion.UI.Xaml.Charts.AdornmentSeries   AdornmentsInfo 5p      2  ,Syncfusion.UI.Xaml.Charts.ChartAdornmentInfo  5q   "   6  0Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase   	ShowLabel$
 True??6@   5r   #   5t      5v      5w      5x      ?? 5z      .+?5{      ? $	??294??6    5|      ?? 5}      $??0* ?6+   ?? 5~       5?      ?? 5?      $	??400 ?6(   .+?5?        $$ Graph of frequency per student??6)   $??30,10,30,88q?6Q   $??2??6f   $??2??6w    5?      
  5?      $ Student name??66   $??16(?6L    5?        5?      $ 	Frequency??67   $??16(?6J   . 5?        -   5        $ StudentsDataFrequency??5?   2   $
 True??6R   $
 Name??6?   $ 	Frequency??6?    6o   ?? *StudentsData+$ OneTime=? 5?        5?   "   $
 True??6@   5?   #   5?      5?      5?      5?      ?? 5?      $	??199??6   .+?5?      ? $	??500??6   .+?5?      ?? $??20(?6   $??Center=?5?      $	??Top=?5?      $??5q?60   $??0??5?      $??Student parameters??6%   ?? 5?      $??16(?6   $??Center=?5?      $	??Top=?5?      $??0,44,0,0q?60   $??0??5?      $ ??Number of grades in ranges??6%     5?      -   5        $ StudentesInGradeRange??5?      $ False??6>   $
 True??6Z   $ * 6l   $??
5,94,5,-27q?6|   $
 TrueY?6?    5?        5?      $	 	0.0 - 2.5??61   
 6D   ?? *	column1+  5?      $	 	2.5 - 5.0??61   
 6D   ?? *	column2+  5?      $	 	5.0 - 7.5??61   
 6D   ?? *	column3+  5?      $	 
7.5 - 10.0??61   
 6E   ?? *	column4+5?      5?      5?      ?? 5?      $	??150??6   .+?5?      ? $	??500??6   .+?5?      ?? $??16(?6   $??Center=?5?      $	??Top=?5?      $??0??5?      $!??Student frequency in ranges??6%     5?      -   5        $ StudentesInFrequencyRange??5?      $ False??6B   $
 True??6^   $ * 6p   $??	5,46,5,21q?6?   $
 TrueY?6?    5?        5?      $	 0.00 - 0.25??61   
 6F   ?? *	column1+  5?      $	 0.25 - 0.50??61   
 6F   ?? *	column2+  5?      $	 0.50 - 0.75??61   
 6F   ?? *	column3+  5?      $	 0.75 - 1.00??61   
 6F   ?? *	column4+5?      5?      5?      ?? 5?      $	??150??6   .+?5?      ? $	??500??6   .+?5?      ?? $??16(?6   $??Center=?5?      $	??Top=?5?      $??0??5?      $??Student grade info??6%     5?      -	   5        $ StudentesAverageInfo??5?      $ False??6=   $
 True??6Y   $ * 6k   $??-25,46,-30,21q?6{   $
 TrueY?6?    5?        5?      $	 Average??61   
 6B   ?? *	column1+  5?      $	 Median??61   
 6A   ?? *	column2+  5?      $	 Standard deviation??61   
 6M   ?? *	column3+  5?      $	 Minimum??61   
 6B   ?? *	column4+  5?      $	 Maximum??61   
 6B   ?? *	column5+5?      5?      5?      ?? 5?      $	??150??6   .+?5?      ? $	??500??6   .+?5?      ?? $??16(?6   $??Center=?5?      $	??Top=?5?      $??0??5?      $??Student frequency info??6%     5?      -
   5        $ StudentesFrequencyInfo??5?      $ False??6?   $
 True??6[   $ * 6m   $??-26,46,-29,21q?6}   $
 TrueY?6?    5?        5?      $	 Average??61   
 6B   ?? *	column1+  5?      $	 Median??61   
 6A   ?? *	column2+  5?      $	 Standard deviation??61   
 6M   ?? *	column3+  5?      $	 Minimum??61   
 6B   ?? *	column4+  5?      $	 Maximum??61   
 6B   ?? *	column5+5?      5?      5?      5?      5?      5?      