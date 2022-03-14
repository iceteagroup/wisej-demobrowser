using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace Wisej.DemoBrowser.ChartJS
{
	public partial class Radar : DemoView
	{
		private Random rand = new Random();

		public Radar()
		{
			InitializeComponent();
		}

		private void Scatter_Load(object sender, EventArgs e)
		{
			AddDataSet();

			//Add labels
			string[] labels = new string[12];
			for (int i = 0; i < 12; i++)
			{
				labels[i] = $"Value {i}";
			}

			this.chartJS1.Labels = labels;

		}

		private void AddDataSet()
		{
			this.chartJS1.DataSets.Add(new RadarDataSet()
			{
				Label = $"Radar Data Set {this.chartJS1.DataSets.Count + 1}",
				Data = GenerateData() ,
				BackgroundColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255))
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

		private object[] GenerateData()
		{
			var data = new object[12];
			for (var i = 0; i < 12; i++) data[i] = rand.Next(100);

			return data;
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			var dataSetCount = this.chartJS1.DataSets.Count;
			if (dataSetCount > 0)
				this.chartJS1.DataSets.RemoveAt(dataSetCount - 1);	
		}
	}
}
