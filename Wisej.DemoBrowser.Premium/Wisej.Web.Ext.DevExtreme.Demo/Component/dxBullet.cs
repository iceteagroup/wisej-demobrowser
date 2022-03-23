using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxBullet : TestBase
	{
		public dxBullet()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxBullet1.Options.showTarget = this.checkBox1.Checked;
			this.dxBullet1.Options.showZeroLevel = this.checkBox2.Checked;
			this.dxBullet1.Options.value = this.numericUpDown1.Value;
			this.dxBullet1.Options.target = this.numericUpDown2.Value;
			this.dxBullet1.Options.startScaleValue = this.numericUpDown3.Value;

			this.dxBullet1.Update();
		}
	}
}
