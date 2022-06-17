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

		private void igDataChart_Load(object sender, EventArgs e)
		{
			this.igDataChart1.Options.title = "Population per Country";
			this.igDataChart1.Options.subtitle = "Largest projected populations for 2015";
			this.igDataChart1.Options.dataSource = new dynamic[]
			{
				new {CountryName = "China", Pop1995 = 1216, Pop2005 = 1297, Pop2015 = 1361, Pop2025 = 1394},
				new {CountryName = "India", Pop1995 = 920, Pop2005 = 1090, Pop2015 = 1251, Pop2025 = 1396},
				new {CountryName = "United States", Pop1995 = 266, Pop2005 = 295, Pop2015 = 322, Pop2025 = 351},
				new {CountryName = "Indonesia", Pop1995 = 197, Pop2005 = 229, Pop2015 = 256, Pop2025 = 277},
				new {CountryName = "Brazil", Pop1995 = 161, Pop2005 = 186, Pop2015 = 204, Pop2025 = 218}
			};
			this.igDataChart1.Options.axes = new dynamic[]
			{
				new {name = "NameAxis", type = "categoryX", title = "Country", label = "CountryName"},
				new {name = "PopulationAxis", type = "numericY", minimumValue = 0, title = "Millions of People"},
			};

			AssignDataChartSeries();
		}

		private void AssignDataChartSeries()
		{
			var series = new
			{
				name = "2015 Population",
				type = "column",
				isHighlightingEnabled = true,
				isTransitionInEnabled = true,
				xAxis = "NameAxis",
				yAxis = "PopulationAxis",
				valueMemberPath = this.comboBox2.SelectedItem
			};
			this.igDataChart1.Options.series = series;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igDataChart1.Options.title = textBoxTitle.Text;
			this.igDataChart1.Options.subtitle = textBoxSubtitle.Text;

			AssignDataChartSeries();
			
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
			this.igDataChart1.Instance.addItem(new
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
