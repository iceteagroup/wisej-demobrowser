using System;
using System.Drawing;
using System.Windows.Forms;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS3;

namespace Wisej.DemoBrowser.TableLayoutPanel
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }



        private void FillBarChart()
        {
            string[] labels = new string[30];
            for (int i = 0; i < 30; i++)
            {
                labels[i] = $"Day {i}";
            }

            this.chartJS31.Labels = labels;
            BarDataSet bds = new BarDataSet();
            object[] obj = new object[30];


            var rand = new Random();
            for (int i = 0; i < 30; i++)
            {

                obj[i] = rand.Next(1, 5);
            }

            bds.Data = obj;
            bds.BackgroundColor = new[] { System.Drawing.Color.FromArgb(39, 38, 64) };
            chartJS31.DataSets.Add(bds);

        }

        private void FillLeadToOppRatioChart()
        {
            PieDataSet pds = new PieDataSet();
            pds.Label = "Lead to Opp. Ratio";

            object[] x = new object[2];
            x[0] = 22;
            x[1] = 100;
            pds.Data = x;
            pds.BackgroundColor = new Color[] { Color.FromArgb(0, 100, 102), Color.FromName("@controlText") };
            chartJS32.DataSets.Add(pds);
        }

        private void FillLeadToOppRatioChart2()
        {
            PieDataSet pds = new PieDataSet();
            pds.Label = "Lead to Opp. Ratio";

            object[] x = new object[2];
            x[0] = 43;
            x[1] = 100;
            pds.Data = x;
            pds.BackgroundColor = new Color[] { Color.FromArgb(0, 100, 102), Color.FromName("@controlText") };
            chartJS33.DataSets.Add(pds);
        }

        private void FillManagersCharts(ChartJS3 chart)
        {
            string[] labels = new string[30];
            for (int i = 0; i < 30; i++)
            {
                labels[i] = $"Day {i}";
            }

            chart.Labels = labels;

            LineDataSet bds = new LineDataSet();
            object[] obj = new object[30];


            var rand = new Random();
            for (int i = 0; i < 30; i++)
            {

                obj[i] = rand.Next(1, 5);
            }

            bds.Data = obj;
            bds.BackgroundColor = Color.FromArgb(0, 100, 102);
            chart.DataSets.Add(bds);
        }
        private void Features2_Load(object sender, EventArgs e)
        {
            FillBarChart();
            FillLeadToOppRatioChart();
            FillLeadToOppRatioChart2();
            FillManagersCharts(chartJS34);
            FillManagersCharts(chartJS35);
        }
    }
}
