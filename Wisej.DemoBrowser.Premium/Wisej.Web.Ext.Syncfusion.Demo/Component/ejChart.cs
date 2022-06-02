using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejChart : TestBase
	{
		public ejChart()
		{
			InitializeComponent();

			this.ejChart1.Instance.onLegendItemClick += new WidgetEventHandler(ejChart1_WidgetEvent);
			this.ejChart1.Instance.onChartDoubleClick += new WidgetEventHandler(ejChart1_WidgetEvent);
			this.ejChart1.Instance.onPointRegionClick += new WidgetEventHandler(ejChart1_WidgetEvent);
		}

		private void ejChart_Load(object sender, EventArgs e)
		{
			this.ejChart1.Options.primaryXAxis = new
			{
				range = new
				{
					min = 2005,
					max = 2011,
					interval = 1
				},
				title = new
				{
					text = "Year"
				},
				valueType = "category"
			};
			this.ejChart1.Options.primaryYAxis = new
			{
				labelFormat = "{value}%",
				title = new
				{
					text = "Efficiency"
				},
				range = new
				{
					min = 25,
					max = 50,
					interval = 5
				}
			};
			this.ejChart1.Options.commonSeriesOptions = new
			{
				type = "line",
				enableAnimation = true,
				tooltip = new
				{
					visible = true,
					template = "Tooltip"
				},
				marker = new
				{
					shape = "circle",
					size = new
					{
						height = 10,
						width = 10
					},
					visible = true
				},
				border = new
				{
					width = 2
				}
			};
			this.ejChart1.Options.series = new object[]
			{
				new
				{
					points = new object[]
					{
						new {x = 2005, y = 28}, new {x = 2006, y = 25}, new {x = 2007, y = 26}, new {x = 2008, y = 27},
						new {x = 2009, y = 32}, new {x = 2010, y = 35}, new {x = 2011, y = 30}
					},
					name = "India"
				},
				new
				{
					points = new object[]
					{
						new {x = 2005, y = 31}, new {x = 2006, y = 28}, new {x = 2007, y = 30}, new {x = 2008, y = 36},
						new {x = 2009, y = 36}, new {x = 2010, y = 39}, new {x = 2011, y = 37}
					},
					name = "Germany"
				},
				new
				{
					points = new object[]
					{
						new {x = 2005, y = 36}, new {x = 2006, y = 32}, new {x = 2007, y = 34}, new {x = 2008, y = 41},
						new {x = 2009, y = 42}, new {x = 2010, y = 42}, new {x = 2011, y = 43}
					},
					name = "England"
				},
				new
				{
					points = new object[]
					{
						new {x = 2005, y = 39}, new {x = 2006, y = 36}, new {x = 2007, y = 40}, new {x = 2008, y = 44},
						new {x = 2009, y = 45}, new {x = 2010, y = 48}, new {x = 2011, y = 46}
					},
					name = "France"
				}
			};
			this.ejChart1.Options.isResponsive = true;
			this.ejChart1.Options.title = new
			{
				text = "Efficiency of oil-fired power production"
			};
			this.ejChart1.Options.legend = new
			{
				visible = true
			};
		}
		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejChart1.Options.title.text = this.textBoxTitle.Text;
			this.ejChart1.Options.legend.alignment = this.comboBoxLegendAlignment.Text;

			this.ejChart1.Update();
		}

		private void ejChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			this.ejChart1.ExportImage((result) =>
			{
				using (var stream = new MemoryStream())
				{
					result.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
					stream.Position = 0;
					Application.Download(stream, "chartExport.png");
				}
			});
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			this.ejChart1.Instance.print($"id_{this.ejChart1.Handle}_container");
		}
	}
}