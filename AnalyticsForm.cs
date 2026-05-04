using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace POGOY_H2___CPE262_Final_Project
{
    public partial class AnalyticsForm : Form
    {
        public AnalyticsForm()
        {
            InitializeComponent();
        }

        private void PlotColumnChart(string query, string xField, string yField, string seriesName)
        {
            chartAnalytics.Series.Clear();
            chartAnalytics.ChartAreas.Clear();
            chartAnalytics.Titles.Clear();
            chartAnalytics.Legends.Clear();

            ChartArea area = new ChartArea();

            area.BackColor = Color.Transparent;

            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisX.TitleForeColor = Color.White;
            area.AxisY.TitleForeColor = Color.White;

            area.AxisX.MajorGrid.LineColor = Color.FromArgb(40, Color.White);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(40, Color.White);

            chartAnalytics.ChartAreas.Add(area);

            area.Area3DStyle.Enable3D = true;
            area.Area3DStyle.Inclination = 10;
            area.Area3DStyle.Rotation = 4;
            area.Area3DStyle.Perspective = 10;

            var series = new Series(seriesName)
            {
                ["DrawingStyle"] = "Cylinder",
                ChartType = SeriesChartType.Column,
                IsXValueIndexed = true,
                IsVisibleInLegend = false
            };
            series["PointWidth"] = "0.6";
            series.Color = Color.DarkOrange;
            series.BackGradientStyle = GradientStyle.TopBottom;
            series.BackSecondaryColor = Color.Orange;
            series.ShadowOffset = 3;
            series.LabelForeColor = Color.White;

            chartAnalytics.Series.Add(series);

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                using (var cmd = new OleDbCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string x = reader[xField]?.ToString() ?? string.Empty;

                        double y = 0;
                        object yObj = reader[yField];
                        if (yObj != DBNull.Value && yObj != null)
                        {
                            switch (Type.GetTypeCode(yObj.GetType()))
                            {
                                case TypeCode.Int16:
                                case TypeCode.Int32:
                                case TypeCode.Int64:
                                case TypeCode.UInt16:
                                case TypeCode.UInt32:
                                case TypeCode.UInt64:
                                case TypeCode.Decimal:
                                case TypeCode.Double:
                                case TypeCode.Single:
                                    y = Convert.ToDouble(yObj);
                                    break;
                                default:
                                    double.TryParse(yObj.ToString(), out y);
                                    break;
                            }
                        }

                        series.Points.AddXY(x, y);
                    }
                }
            }
            foreach (var lg in chartAnalytics.Legends)
                lg.ForeColor = Color.White;
            for (int i = 0; i < chartAnalytics.Titles.Count; i++)
                chartAnalytics.Titles[i].ForeColor = Color.White;

            var ca = chartAnalytics.ChartAreas[0];
            ca.AxisX.Interval = 1;
            ca.AxisX.LabelStyle.Angle = 0;
            ca.AxisY.Minimum = 0;
            ca.AxisX.IsMarginVisible = false;

            int count = chartAnalytics.Series[seriesName].Points.Count;
            double min = 0.5;
            double max = Math.Max(1.5, count + 0.5);
            ca.AxisX.Minimum = min;
            ca.AxisX.Maximum = max;

            chartAnalytics.Invalidate();
        }

        private void LoadJobsPerCategory()
        {
            PlotColumnChart("SELECT Category, TotalJobs FROM qryJobsPerCategory", "Category", "TotalJobs", "Jobs");
        }

        private void LoadApplicationsStatus()
        {
            PlotColumnChart("SELECT Status, Total FROM qryApplicationsStatus", "Status", "Total", "Applications");
        }

        private void LoadJobsPerLocation()
        {
            PlotColumnChart("SELECT Location, TotalJobs FROM qryJobsPerLocation", "Location", "TotalJobs", "Jobs per Location");
        }

        private void LoadTopJobs()
        {
            PlotColumnChart("SELECT Title, TotalApplicants FROM qryTopJobs", "Title", "TotalApplicants", "Top Jobs");
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            chartAnalytics.Series.Clear();
            chartAnalytics.ChartAreas.Clear();
            chartAnalytics.ChartAreas.Add(new ChartArea());
            LoadJobsPerCategory();
        }

        private void btnJobsPerCategory_Click(object sender, EventArgs e)
        {
            LoadJobsPerCategory();
        }

        private void btnJobsPerLocation_Click(object sender, EventArgs e)
        {
            LoadJobsPerLocation();
        }

        private void btnApplicationsStatus_Click(object sender, EventArgs e)
        {
            LoadApplicationsStatus();
        }

        private void btnTopJobs_Click(object sender, EventArgs e)
        {
            LoadTopJobs();
        }
    }
}