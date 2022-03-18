using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxPieChart : TestBase
	{
		public dxPieChart()
		{
			InitializeComponent();

			this.dxPieChart1.Instance.pointClick += new WidgetEventHandler(dxPieChart1_WidgetEvent);
			this.dxPieChart1.Instance.legendClick += new WidgetEventHandler(dxPieChart1_WidgetEvent);
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
			this.dxPieChart1.Options.paletteExtensionMode = this.comboBox2.SelectedItem;
			this.dxPieChart1.Options.segmentsDirection = this.comboBox3.SelectedItem;
			this.dxPieChart1.Options.type = this.comboBox4.SelectedItem;

			this.dxPieChart1.Update();
		}
	}
}
