ͼ������������.


1. ����һ�� WinForm ���ڡ�

2. �� Chart �ؼ������봰���У������ô�С��

3. ��� Chart �ؼ� �� Series ���ԣ� �����Ի��� Ĭ��ֻ��һ�� Series1 ������Ϊ ��״ͼ (Column).

��������ƽ׶Σ� ����ͼ������ͣ� Ҳ�����ں���Ĵ��������������͡�
����� Series �����ƺ���Ҫ��
�����Ĳ������룬 ��������� ���ơ�



4. ��� Chart �ؼ� �� ChartAreas ���ԣ� �����Ի���  Ĭ��ֻ��һ�� ChartArea1��

��������ƽ׶Σ� ���� ͼ��� 3D Ч����  Ҳ�����ں���Ĵ����������á�
����� ChartAreas �����ƺ���Ҫ��
�����Ĳ������룬 ��������� ���ơ�




--------------------------------------------------------------------------------
������Ĵ���.
--------------------------------------------------------------------------------

// ����ͨ������Ĵ��룬 ���ֶ� �����������ݡ�
chart1.Series["Series1"].Points.AddY( ���� );


// Ĭ�ϵ� Area.
chart1.Series["Series1"].ChartType = SeriesChartType.Area;

// ƽ���� Area.
chart1.Series["Series1"].ChartType = SeriesChartType.SplineArea;

// ���ϼƵ� Area.
chart1.Series["Series1"].ChartType = SeriesChartType.StackedArea;

// ���ϼƣ�����ٷֱȵ�  Area.
chart1.Series["Series1"].ChartType = SeriesChartType.StackedArea100;



--------------------------------------------------------------------------------
����״ͼ�Ĵ���.
--------------------------------------------------------------------------------

// ����ͨ������Ĵ��룬 ���ֶ� �����������ݡ�
chart1.Series["Series1"].Points.AddY( ���� );

// Ĭ�ϵ� Bar ������.
chart1.Series["Series1"].ChartType = SeriesChartType.Bar;

// Ĭ�ϵ� Column  ������.
chart1.Series["Series1"].ChartType = SeriesChartType.Column;

// ���ϼƵ� Bar ������.
chart1.Series["Series1"].ChartType = SeriesChartType.StackedBar;

// ���ϼƵ� Column  ������.
chart1.Series["Series1"].ChartType = SeriesChartType.StackedColumn;

// ���ϼƣ�����ٷֱȵ� Bar ������.
chart1.Series["Series1"].ChartType = SeriesChartType.StackedBar100;

// ���ϼƣ�����ٷֱȵ� Column  ������.
chart1.Series["Series1"].ChartType = SeriesChartType.StackedColumn100;




--------------------------------------------------------------------------------
���ߵĴ���.
--------------------------------------------------------------------------------

// ����ͨ������Ĵ��룬 ���ֶ� �����������ݡ�
chart1.Series["Series1"].Points.AddY( ���� );

// ���� ͼ�������Ϊ ��.  SeriesChartType.Line
chart1.Series["Series1"].ChartType = SeriesChartType.Line;

// SeriesChartType.Spline Ҳ���ߣ����Ǹ�ƽ��һЩ
chart1.Series["Series2"].ChartType = SeriesChartType.Spline;

// SeriesChartType.StepLine Ҳ���ߣ� һ��һ�������ġ�
chart1.Series["Series2"].ChartType = SeriesChartType.StepLine;

// ���� ͼ�������Ϊ FastLine  (���ϲ���ʾ����)
chart1.Series["Series1"].ChartType = SeriesChartType.FastLine;




--------------------------------------------------------------------------------
����ͼ�Ĵ���.
--------------------------------------------------------------------------------

// ��ͼ��Ҫ���� x �� y.  Ҳ���� ��ֵ �� �������.
double[] yValues = { 65.62, 75.54, 60.45, 34.73, 85.42 };
string[] xValues = { "France", "Canada", "Germany", "USA", "Italy" };
chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);


// ���� ͼ�������Ϊ ��ͼ  ʵ��
chart1.Series["Series1"].ChartType = SeriesChartType.Pie;

// ���� ͼ�������Ϊ ��ͼ  ����
chart1.Series["Series1"].ChartType = SeriesChartType.Doughnut;









--------------------------------------------------------------------------------
����Ĵ���.
--------------------------------------------------------------------------------

// ����ͨ������Ĵ��룬 ���ֶ� �����������ݡ�
chart1.Series["Series1"].Points.AddY( ���� );

// ���� ͼ�������Ϊ ��  �����Ͻ�����ʾ��ֵ��
chart1.Series["Series1"].ChartType = SeriesChartType.FastPoint;

// ���� ͼ�������Ϊ ��
chart1.Series["Series1"].ChartType = SeriesChartType.Point;

// ���� ͼ�������Ϊ ���
chart1.Series["Series1"].ChartType = SeriesChartType.Bubble;







�ο�ҳ��:

https://msdn.microsoft.com/zh-tw/library/dd456632.aspx


