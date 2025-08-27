using System;
using System.Drawing;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxBullet : TestBase
	{
		public dxBullet()
		{
			InitializeComponent();
		}

		private void dxBullet_Load(object sender, EventArgs e)
		{
			this.dxBullet1.Options = new
			{
				value = 23,
				target = 20,
				color = Color.DarkRed,
			};

			this.dxBullet2.Options = new
			{
				value = 24,
				target = 22,
				color = Color.DarkOrange
			};

			this.dxBullet3.Options = new
			{
				value = 35,
				target = 24,
				color = Color.DarkGreen
			};

			this.dxBullet4.Options = new
			{
				value = 29,
				target = 25,
				color = Color.DarkBlue
			};
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
