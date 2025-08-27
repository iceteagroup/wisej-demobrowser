using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace Wisej.DemoBrowser.ChartJS
{
	public partial class Bar : DemoView
	{
		private Random rand = new Random();

		public Bar()
		{
			InitializeComponent();
		}

		private void Bar_Load(object sender, EventArgs e)
		{
			AddDataSet();
			AddDataSet();
			AddDataSet();
		}

		private void AddDataSet()
		{
			chartJS1.DataSets.Add(new BarDataSet()
			{
				Label = $"Bar Data Set {chartJS1.DataSets.Count + 1}",
				Data = GenerateData(),
				BackgroundColor = new[] {Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255))}
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

		private object[] GenerateData()
		{
			var data = new object[12];
			for (var i = 0; i < 12; i++) data[i] = rand.Next(100);

			return data;
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			var dataSetCount = chartJS1.DataSets.Count;
			if (dataSetCount > 0)
				chartJS1.DataSets.RemoveAt(dataSetCount - 1);
		}

        
    }
}