using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace Wisej.DemoBrowser.ChartJS
{
	public partial class Pie : DemoView
	{
		private Random rand = new Random();
		private Color[] backgroundColors = new Color[12];

		public Pie()
		{
			InitializeComponent();
		}

		private void Pie_Load(object sender, EventArgs e)
		{
			AddDataSet();

			//Add labels and background colors
			string[] labels = new string[12];
			for (int i = 0; i < 12; i++)
			{
				labels[i] = $"Value {i+1}";

				backgroundColors[i] = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
			}

			this.chartJS1.Labels = labels;
		}

		private void AddDataSet()
		{
			this.chartJS1.DataSets.Add(new PieDataSet()
			{
				Label = $"Pie Data Set {this.chartJS1.DataSets.Count + 1}",
				Data = GenerateData(),
				BackgroundColor = backgroundColors
			});
		}
		private object[] GenerateData()
		{
			var data = new object[12];
			for (int i = 0; i < 12; i++)
			{
				data[i] = rand.Next(100);
			}

			return data;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AddDataSet();
		}

		private void chartJS1_ChartClick(object sender, ChartClickEventArgs e)
		{
			AlertBox.Show($"{((Control)sender).Text}: {e.SelectedValue}");
		}


		private void buttonRemove_Click(object sender, EventArgs e)
		{
			var dataSetCount = this.chartJS1.DataSets.Count;
			if (dataSetCount > 0)
				this.chartJS1.DataSets.RemoveAt(dataSetCount - 1);	
		}
	}
}
