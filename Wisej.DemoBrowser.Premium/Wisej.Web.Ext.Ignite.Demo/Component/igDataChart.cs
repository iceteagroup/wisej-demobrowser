using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igDataChart : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igDataChart()
		{
			InitializeComponent();

			this.igDataChart1.Instance.onAxisRangeChanged += new WidgetEventHandler(igDataChart_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igDataChart1.Options.title = textBoxTitle.Text;
			this.igDataChart1.Options.subtitle = textBoxSubtitle.Text;
			this.igDataChart1.Options.series[0].valueMemberPath = this.comboBox2.SelectedItem;

			this.igDataChart1.Update();
		}

		private void igDataChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			this.igDataChart1.Options.dataSource = JSON.Parse(e.Files[0].InputStream);

			this.igDataChart1.Update();
		}

		private void buttonExportImage_Click(object sender, EventArgs e)
		{
			this.igDataChart1.Call("exportImageData");
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var rand = new Random();
			this.igDataChart1.AddItem(new
			{
				CountryName = this.textBoxCountry.Text,
				Pop1995 = rand.Next(300, 1000),
				Pop2005 = rand.Next(300, 1000),
				Pop2015 = rand.Next(300, 1000),
				Pop2025 = rand.Next(300, 1000)
			});
		}
	}
}
