using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace Wisej.DemoBrowser.ChartJS
{
	public partial class Doughnut : DemoView
	{
		private Random rand = new Random();
		private Color[] backgroundColors = new Color[12];


		public Doughnut()
		{
			InitializeComponent();
		}

		private void Doughnut_Load(object sender, EventArgs e)
		{
			AddDataSet();
			AddDataSet();
			AddDataSet();

			//Add labels and background colors
			var labels = new string[12];
			for (var i = 0; i < 12; i++)
			{
				labels[i] = $"Value {i+1}";

				backgroundColors[i] = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
			}

			chartJS1.Labels = labels;
		}

		private void AddDataSet()
		{
			chartJS1.DataSets.Add(new DoughnutDataSet()
			{
				Label = $"Doughnut Data Set {chartJS1.DataSets.Count + 1}",
				Data = GenerateData(),
				BackgroundColor = backgroundColors
			});
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AddDataSet();
		}

		private void chartJS1_ChartClick(object sender, ChartClickEventArgs e)
		{
			AlertBox.Show($"{((Control) sender).Text}: {e.SelectedValue}");
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			var dataSetCount = chartJS1.DataSets.Count;
			if (dataSetCount > 0)
				chartJS1.DataSets.RemoveAt(dataSetCount - 1);
		}

		private object[] GenerateData()
		{
			var data = new object[12];
			for (var i = 0; i < 12; i++) data[i] = rand.Next(10) + rand.NextDouble();


			return data;
		}
	}
}