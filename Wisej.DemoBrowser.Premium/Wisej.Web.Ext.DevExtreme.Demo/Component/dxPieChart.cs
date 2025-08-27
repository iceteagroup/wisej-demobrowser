using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxPieChart : TestBase
	{
		public dxPieChart()
		{
			InitializeComponent();

			this.dxPieChart1.Instance.onPointClick += new WidgetEventHandler(dxPieChart1_WidgetEvent);
			this.dxPieChart1.Instance.onLegendClick += new WidgetEventHandler(dxPieChart1_WidgetEvent);
		}
        private void dxPieChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxPieChart1.Options.animation = new
			{
				enabled = this.checkBox1.Checked
			};
			this.dxPieChart1.Options.diameter = (this.numericUpDown1.Value == 0) ? "undefined" : this.numericUpDown1.Value.ToString();
			this.dxPieChart1.Options.innerRadius = this.numericUpDown2.Value;
			this.dxPieChart1.Options.palette = this.comboBox1.SelectedItem;
			this.dxPieChart1.Options.segmentsDirection = this.comboBox3.SelectedItem;

			this.dxPieChart1.Update();
		}

        private void dxPieChart_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;
			this.comboBox3.SelectedIndex = 0;

			this.dxPieChart1.Options = new
			{
				palette = "bright",
				dataSource = new object[]
                {
					new
                    {
						country = "Russia",
						area = 12
                    },
					new
					{
						country = "Canada",
						area = 7
					},
					new
					{
						country = "USA",
						area = 7
					},
					new
					{
						country = "China",
						area = 7
					},
					new
					{
						country = "Brazil",
						area = 6
					},
					new
					{
						country = "Auatralia",
						area = 5
					},
					new
					{
						country = "India",
						area = 2
					},
					new
					{
						country = "Other",
						area = 55
					}
				},
				series = new object[]
                {
					new
                    {
						argumentField = "country",
						valueField = "area",
						label = new
                        {
							visible = true,
							connector = new
                            {
								visible = true,
								width = 1
                            }
                        }
					}
                },
				title = "Area of Countries",
				export = new
                {
					enabled = true
                }
			};

			this.dxPieChart1.Update();
		}
	}
}
