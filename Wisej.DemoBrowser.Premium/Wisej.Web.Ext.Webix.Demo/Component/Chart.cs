using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Chart : ViewBase
	{
		private void Chart_Load(object sender, EventArgs e)
		{
			chart1.Options.type = "bar";
			chart1.Options.value = "#sales#";
			chart1.Options.label = "#sales#";
			chart1.Options.barWidth = 35;
			chart1.Options.radius = 0;
			chart1.Options.gradient = "falling";
			chart1.Options.data = new dynamic[]
			{
				new
				{
					id = "1",
					sales = 20,
					year = "02"
				},
				new
				{
					id = "2",
					sales = 55,
					year = "03"
				},
				new
				{
					id = "3",
					sales = 40,
					year = "04"
				},
				new
				{
					id = "4",
					sales = 78,
					year = "05"
				}
			};
		}

		public Chart()
		{
			InitializeComponent();

			this.chart1.Instance.onItemClick += new WidgetEventHandler(chart1_WidgetEvent);
		}

		private void chart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.chart1.Options.type = this.comboBoxChartType.SelectedItem.ToString();

			this.chart1.Update();
        }
    }
}