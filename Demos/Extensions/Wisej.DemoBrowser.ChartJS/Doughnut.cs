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

		public Doughnut()
		{
			InitializeComponent();
		}

		private void Scatter_Load(object sender, EventArgs e)
		{
			AddDataSet();
		}

		private void AddDataSet()
		{
			this.chartJS1.DataSets.Add(new DoughnutDataSet()
			{
				Label = $"Doughnut Data Set {this.chartJS1.DataSets.Count + 1}",
				Data = GenerateData(),
				BackgroundColor = new []{Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255))}
			});
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

		private object[] GenerateData()
		{
			var data = new object[1];
			data[0] = rand.Next(10)+rand.NextDouble();

			return data;
		}
	}
}
