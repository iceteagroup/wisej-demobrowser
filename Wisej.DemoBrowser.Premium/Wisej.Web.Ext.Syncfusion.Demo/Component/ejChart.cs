using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejChart : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejChart()
		{
			InitializeComponent();

			this.ejChart1.Instance.chartClick += new WidgetEventHandler(ejChart1_WidgetEvent);

			this.ejChart1.Instance.legendItemClick += new WidgetEventHandler(ejChart1_WidgetEvent);

			this.ejChart1.Instance.chartDoubleClick += new WidgetEventHandler(ejChart1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejChart1.Options.title.text = this.textBoxTitle.Text;
			this.ejChart1.Options.legend.alignment = this.comboBoxLegendAlignment.Text;

			ejChart1.Update();
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
