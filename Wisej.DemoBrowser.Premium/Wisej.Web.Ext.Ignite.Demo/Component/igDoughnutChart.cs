using System;
using System.IO;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igDoughnutChart : TestBase
	{
		public igDoughnutChart()
		{
			InitializeComponent();

			this.igDoughnutChart1.Instance.onSliceClick += new WidgetEventHandler(igDoughnutChart_WidgetEvent);
		}

		private void igDoughnutChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igDoughnutChart1.Options.allowSliceExplosion = this.checkBox1.Checked;
			this.igDoughnutChart1.Options.allowSliceSelection = this.checkBox2.Checked;
			this.igDoughnutChart1.Options.innerExtent = this.numericUpDown2.Value;
		
			this.igDoughnutChart1.Update();

		}

		private void buttonAddItem_Click(object sender, EventArgs e)
		{
			this.igDoughnutChart1.AddItem(new 
			{ 
				CountryName = this.textBox1.Text, 
				Pop1990 = this.numericUpDown1.Value 
			}, 0);
		}
	}
}
