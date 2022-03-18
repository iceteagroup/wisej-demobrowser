using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxLinearGauge : TestBase
	{
		public dxLinearGauge()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxLinearGauge1.Options.animation = new
			{
				enabled = this.checkBox1.Checked,
				duration = this.numericUpDown1.Value
			};
			this.dxLinearGauge1.Options.rangeContainer = new
			{
				backgroundColor = this.textBox1.Text
			};
			this.dxLinearGauge1.Options.value = this.numericUpDown2.Value;

			this.dxLinearGauge1.Update();
		}
	}
}
