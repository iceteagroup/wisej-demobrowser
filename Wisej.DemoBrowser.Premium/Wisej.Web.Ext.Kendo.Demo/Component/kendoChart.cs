using System;
using System.IO;
using System.Net;
using System.Web;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoChart : TestBase
	{
		public kendoChart()
		{
			InitializeComponent();

			this.kendoChart1.Instance.onLegendItemClick += new WidgetEventHandler(kendoChart1_WidgetEvent);
			this.kendoChart1.Instance.onSeriesClick += new WidgetEventHandler(kendoChart1_WidgetEvent);
			this.kendoChart1.Instance.onSelect += new WidgetEventHandler(kendoChart1_WidgetEvent);
		}

		private void kendoChart_Load(object sender, EventArgs e)
		{
			this.kendoChart1.Options.theme = "material";

			this.kendoChart1.Options.title = new
			{
				text = "Site Visitors Stats \n /thousands/"
			};

			this.kendoChart1.Options.legend = new
			{
				visible = false
			};

			this.kendoChart1.Options.seriesDefaults = new
			{
				type = "bar"
			};

			this.kendoChart1.Options.series = new[]
			{
				new
				{
					name = "Total Visits",
					data = new int[]
					{
						56000,
						63000,
						74000,
						91000,
						117000,
						138000
					}
				},
				new
				{
					name = "Unique Visitors",
					data = new int[]
					{
						52000,
						34000,
						23000,
						48000,
						67000,
						83000
					}
				}
			};

			this.kendoChart1.Options.valuesAxis = new
			{
				max = 140000,
				line = new {visible = false},
				minorGridLines = new {visible = true},
				labels = new {rotation = "auto"}
			};

			

			this.kendoChart1.Options.tooltip = new {visible = true, template = "#= series.name #: #= value #"};
		}

		private void kendoChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var base64 = "";
			var format = this.comboBox1.SelectedItem.ToString().ToLower();
			switch (format)
			{
				case "svg":
					base64 = await this.kendoChart1.Instance.exportSVGAsync();
					break;
				case "png":
					base64 = await this.kendoChart1.Instance.exportImageAsync();
					break;
				case "pdf":
					base64 = await this.kendoChart1.Instance.exportPDFAsync();
					break;
			}

			ProcessFile(base64, $"kendoChart.{format}");
		}

		private void ProcessFile(string base64Data, string fileName)
		{
			if (string.IsNullOrEmpty(base64Data))
				return;

			var base64 = base64Data.Split(new[] { ',' })[1];
			var bytes = Convert.FromBase64String(base64);
			using (var ms = new MemoryStream(bytes))
			{
				Application.Download(ms, fileName);
			}
		}

		private void AssignCategoryAxisLabels()
		{
			var categoryAxis = new
			{
				labels = new { visible = this.checkBox3.Checked },
				categories = new string[]
				{
					"Jan",
					"Feb",
					"Mar",
					"Apr",
					"May",
					"Jun"
				},
				majorguidelines = new { visible = this.checkBox1.Checked }
			};
			this.kendoChart1.Options.categoryAxis = categoryAxis;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoChart1.Options.transitions = this.checkBox1.Checked;
			this.kendoChart1.Options.pannable = this.checkBox2.Checked;

			AssignCategoryAxisLabels();

			this.kendoChart1.Update();
		}
	}
}
