using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTreeMap : TestBase
	{
		public ejTreeMap()
		{
			InitializeComponent();

			this.ejTreeMap1.Instance.onClick += new WidgetEventHandler(ejTreeMap1_WidgetEvent);
			this.ejTreeMap1.Instance.onDoubleClick += new WidgetEventHandler(ejTreeMap1_WidgetEvent);
		}

		private void ejTreeMap_Load(object sender, EventArgs e)
		{
			this.ejTreeMap1.Options.dataSource = new object[]
			{
				new
				{
					Continent = "Asia",
					Country = "Indonesia",
					Growth = 3, Population = 237641326
				},
				new
				{
					Continent = "Asia",
					Country = "Russia",
					Growth = 2, Population = 152518015
				},
				new
				{
					Continent = "Asia",
					Country = "Malaysia",
					Growth = 1, Population = 29672000
				},
				new
				{
					Continent = "North America",
					Country = "United States",
					Growth = 4, Population = 315645000
				},
				new
				{
					Continent = "North America",
					Country = "Mexico",
					Growth = 2, Population = 112336538
				},
				new
				{
					Continent = "North America",
					Country = "Canada",
					Growth = 1, Population = 39056064
				},
				new
				{
					Continent = "South America",
					Country = "Colombia",
					Growth = 1, Population = 47000000
				},
				new
				{
					Continent = "South America",
					Country = "Brazil",
					Growth = 3, Population = 193946886
				},
				new
				{
					Continent = "Africa",
					Country = "Nigeria",
					Growth = 2, Population = 170901000
				},
				new
				{
					Continent = "Africa",
					Country = "Egypt",
					Growth = 1, Population = 83661000
				},
				new
				{
					Continent = "Europe",
					Country = "Germany",
					Growth = 1, Population = 81993000
				},
				new
				{
					Continent = "Europe",
					Country = "France",
					Growth = 1, Population = 65605000
				},
				new
				{
					Continent = "Europe",
					Country = "UK",
					Growth = 1, Population = 63181775
				}
			};
			this.ejTreeMap1.Options.colorValuePath = "Population";
			this.ejTreeMap1.Options.borderThickness = 0;
			this.ejTreeMap1.Options.weightValuePath = "Population";
			this.ejTreeMap1.Options.showLegend = true;
			this.ejTreeMap1.Options.showTooltip = true;
			this.ejTreeMap1.Options.tooltipTemplate = "template";
			this.ejTreeMap1.Options.enableGradient = true;
			this.ejTreeMap1.Options.leafItemSettings = new
			{
				showLabels = true,
				labelPath = "Country"
			};
			this.ejTreeMap1.Options.legendSettings = new
			{
				leftLabel = "20000000",
				width = 150,
				height = 20,
				rightLabel = "300000000",
				title = "Population",
				mode = "interactive",
				dockPosition = "top",
				alignment = "center"
			};
			this.ejTreeMap1.Options.rangeColorMapping = new object[]
			{
				new
				{
					from = 29671000, to = 315646000, gradientColors = new object[]
					{
						"#fde6cc", "#fab665"
					}
				}
			};
			this.ejTreeMap1.Options.levels = new object[]
			{
				new
				{
					groupPath = "Continent",
					groupGap = 5, headerHeight = 25, showHeader = true, headerTemplate = "headertemplate"
				}
			};
		}

		private void ejTreeMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTreeMap1.Options.enableGradient = this.checkBox2.Checked;
			this.ejTreeMap1.Options.highlightOnSelection = this.checkBox3.Checked;
			this.ejTreeMap1.Options.itemsLayoutMode = this.comboBox1.SelectedItem;
			this.ejTreeMap1.Options.groupSelectionMode = this.comboBox2.SelectedItem;

			this.ejTreeMap1.Update();
		}
	}
}