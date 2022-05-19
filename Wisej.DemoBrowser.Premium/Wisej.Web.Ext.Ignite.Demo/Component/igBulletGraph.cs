using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igBulletGraph : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igBulletGraph()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igBulletGraph1.Options.minimumValue = (double)this.numericUpDown1.Value;
			this.igBulletGraph1.Options.maximumValue = (double)this.numericUpDown2.Value;
			this.igBulletGraph1.Options.valueInnerExtent = (double)this.numericUpDown3.Value;
			this.igBulletGraph1.Options.valueOuterExtent = (double)this.numericUpDown4.Value;

			this.igBulletGraph1.Update();
		}
	}
}
