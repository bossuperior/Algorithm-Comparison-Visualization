using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Application = System.Windows.Forms.Application;
    public class Chart : Form //extends Form from .NET Framework
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        public Chart()
        {
            // Initialize the Chart
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart1.Dock = DockStyle.Fill; // Fill ให้เต็มหน้าต่างเวลาขยาย
            this.Controls.Add(chart1);

            // Add Chart Area
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Set X and Y axis labels
            chart1.ChartAreas[0].AxisX.Title = "x"; // x label
            chart1.ChartAreas[0].AxisY.Title = "y"; // y label

            // Clear default series and add new series
            chart1.Series.Clear(); // remove default series
            Series data = chart1.Series.Add("Data");
            data.ChartType = SeriesChartType.Line; //เส้นกราฟ
            data.MarkerStyle = MarkerStyle.Circle; //จุดของกราฟ

            // Add points to the series and update the chart in real-time
            for (int n = 1; n < 100; n++)
            {
                data.Points.AddXY(n, n * n); // add x-y point >> x = y^2
                chart1.Update(); // real-time updating
            }
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new Chart());
        }
    }

