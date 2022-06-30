

using System;
using System.Drawing;
using System.IO;
using static Wisej.Web.Widget;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxChart : TestBase
	{
		public dxChart()
		{
			InitializeComponent();

			this.dxChart1.Instance.onPointClick += new WidgetEventHandler(dxChart1_WidgetEvent);
			this.dxChart1.Instance.onLegendClick += new WidgetEventHandler(dxChart1_WidgetEvent);
		}

		private void dxChart_Load(object sender, EventArgs e)
		{
			this.dxChart1.Options.palette = "Harmony Light";
			this.dxChart1.Options.dataSource = new[]
			{
				new { complaint = "Delayed delivery", count = 1123, cumulativePercentage = 41 },
				new { complaint = "Cold pizza", count = 780, cumulativePercentage = 70 },
				new { complaint = "Damaged pizza", count = 321, cumulativePercentage = 82 },
				new { complaint = "Wrong size delivered", count = 222, cumulativePercentage = 90 },
				new { complaint = "Not enough cheese", count = 120, cumulativePercentage = 95 },
				new { complaint = "Incorrect billing", count = 89, cumulativePercentage = 98 },
				new { complaint =  "Underbaked or Overbaked", count = 52, cumulativePercentage = 100 }
			};
			this.dxChart1.Options.title = "Pizza Shop Complaints";
			this.dxChart1.Options.argumentAxis = new
			{
				label = new
				{
					overlappingBehavior = "stagger"
				}
			};
			this.dxChart1.Options.commonSeriesSettings = new Wisej.Core.DynamicObject();
			this.dxChart1.Options.commonSeriesSettings.argumentField = "complaint";
			this.dxChart1.Options.commonSeriesSettings.type = "line";
			
			this.dxChart1.Options.valueAxis = new dynamic[]
			{
				new
				{
					name = "frequency",
					position = "left",
					tickInterval = 300,
				},
				new
				{
					name = "percentage",
					position = "right",
					showZero = true,
					constantLines = new[]
					{
						new
						{
							value = 80,
							color = Color.Orange,
							dashStyle = "dash",
							width = 2,
							label = new { visible = false }
						}
					},
					tickInterval = 20,
					valueMarginsEnabled = false
				},
			};
			this.dxChart1.Options.series = new[]
			{
				new
				{
					type = "bar",
					valueField = "count",
					axis = "frequency",
					name = "Complaint frequency",
					color = Color.LightBlue
				},
				new
                {
					type = "spline",
					valueField = "cumulativePercentage",
					axis = "percentage",
					name = "Cumulative percentage",
					color = Color.Red
                }
			};
			this.dxChart1.Options.legend = new
			{
				verticalAlignment = "top",
				horizontalAlignment = "center"
			};

			this.comboBox1.SelectedIndex = 0;
		}

		private void dxChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			var data = JSON.Parse(e.Files[0].InputStream);

			this.dxChart1.Options.dataSource = data;

			this.dxChart1.Update();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxChart1.Options.rotated = this.checkBoxRotated.Checked;
			this.dxChart1.Options.adjustOnZoom = this.checkBoxAdjustOnZoom.Checked;
			this.dxChart1.Options.autoHidePointMarkers = this.checkBoxAutoHidePointMarkers.Checked;
			this.dxChart1.Options.zoomAndPan = new {
				allowMouseWheel = true,
				dragToZoom = this.checkBox4.Checked,
				dragBoxStyle = new {
					color = "#ff0000",
					opacity = 0.3
				},
				panKey = this.comboBox1.SelectedItem,
				valueAxis = "both"
			};
		}
	}
}
