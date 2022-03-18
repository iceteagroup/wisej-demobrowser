using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxRangeSlider : TestBase
	{
		public dxRangeSlider()
		{
			InitializeComponent();

			this.dxRangeSlider1.Instance.valueChanged += new WidgetEventHandler(dxRangeSlider1_WidgetEvent);
		}

		private void dxRangeSlider1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxRangeSlider1.Options.isValid = this.checkBox1.Checked;
			this.dxRangeSlider1.Options.showRange = this.checkBox2.Checked;
			this.dxRangeSlider1.Options.start = this.numericUpDown1.Value;
			this.dxRangeSlider1.Options.end = this.numericUpDown2.Value;
			this.dxRangeSlider1.Options.startName = this.textBox1.Text;
			this.dxRangeSlider1.Options.endName = this.textBox2.Text;

			this.dxRangeSlider1.Update();
		}
	}
}
