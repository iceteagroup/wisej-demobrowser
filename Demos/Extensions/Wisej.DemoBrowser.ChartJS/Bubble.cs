using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace Wisej.DemoBrowser.ChartJS
{
	public partial class Bubble : DemoView
	{
		private Random rand = new Random();

		public Bubble()
		{
			InitializeComponent();
		}

		private void Bubble_Load(object sender, EventArgs e)
		{
			AddDataSet();
			AddDataSet();
			AddDataSet();
		}

		private void AddDataSet()
		{
			chartJS1.DataSets.Add(new DataSet()
			{
				Label = $"Bubble Data Set {chartJS1.DataSets.Count + 1}",
				Data = new[]
				{
					new {x = rand.Next(100), y = rand.Next(100)},
					new {x = rand.Next(100), y = rand.Next(100)},
					new {x = rand.Next(100), y = rand.Next(100)},
					new {x = rand.Next(100), y = rand.Next(100)},
					new {x = rand.Next(100), y = rand.Next(100)},
					new {x = rand.Next(100), y = rand.Next(100)},
					new {x = rand.Next(100), y = rand.Next(100)},
					new {x = rand.Next(100), y = rand.Next(100)},
					new {x = rand.Next(100), y = rand.Next(100)},
					new {x = rand.Next(100), y = rand.Next(100)},
					new {x = rand.Next(100), y = rand.Next(100)}
				},
				BackgroundColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255))
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
	}
}