using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace Wisej.DemoBrowser.ChartJS
{
	public partial class PolarArea : DemoView
	{
		private Random rand = new Random();
		private List<string> labels = new List<string>();
		private List<Color> backgroundColors = new List<Color>();
		private List<object> data = new List<object>();

		public PolarArea()
		{
			InitializeComponent();
		}

		private void PolarArea_Load(object sender, EventArgs e)
		{
			//Add labels
			for (var i = 0; i < 12; i++)
			{
				labels.Add($"Value {i+1}");

				backgroundColors.Add(Color.FromArgb(60,rand.Next(255), rand.Next(255), rand.Next(255)));

				data.Add(rand.Next(100) + rand.NextDouble());
			}

			chartJS1.Labels = labels.ToArray();

			chartJS1.DataSets.Add(new PolarAreaDataSet()
			{
				Label = $"PolarArea Data Set {chartJS1.DataSets.Count + 1}",
				Data = data.ToArray(),
				BackgroundColor = backgroundColors.ToArray()
			});
		}

		private void AddData()
		{
			var dataSet = chartJS1.DataSets[0];

			backgroundColors.Add(Color.FromArgb(200,rand.Next(255), rand.Next(255), rand.Next(255)));
			data.Add(rand.Next(100) + rand.NextDouble());
			labels.Add($"Value {labels.Count + 1}");
			var newDataSet = new PolarAreaDataSet()
			{
				Label = $"PolarArea Data Set {chartJS1.DataSets.Count + 1}",
				Data = data.ToArray(),
				BackgroundColor = backgroundColors.ToArray()
			};

			RefreshDataSource(newDataSet);
		}

		private void RemoveData()
		{
			var dataSet = chartJS1.DataSets[0];

			if (backgroundColors.Count > 0 && labels.Count > 0 && data.Count > 0)
			{
				backgroundColors.RemoveAt(backgroundColors.Count - 1);
				data.RemoveAt(data.Count - 1);
				labels.RemoveAt(labels.Count - 1);
			}

			var newDataSet = new PolarAreaDataSet()
			{
				Label = $"PolarArea Data Set {chartJS1.DataSets.Count + 1}",
				Data = data.ToArray(),
				BackgroundColor = backgroundColors.ToArray()
			};

			RefreshDataSource(newDataSet);
		}

		private void RefreshDataSource(PolarAreaDataSet ds)
		{
			chartJS1.DataSets[0] = ds;
			chartJS1.Labels = labels.ToArray();
			chartJS1.UpdateData();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AddData();
		}

		private void chartJS1_ChartClick(object sender, ChartClickEventArgs e)
		{
			AlertBox.Show($"{((Control) sender).Text}: {e.SelectedValue}");
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			RemoveData();
		}
	}
}