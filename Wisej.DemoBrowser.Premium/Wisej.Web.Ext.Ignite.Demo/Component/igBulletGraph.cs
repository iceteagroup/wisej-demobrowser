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
			this.igBulletGraph1.MinimumValue = (double)this.numericUpDown1.Value;
			this.igBulletGraph1.MaximumValue = (double)this.numericUpDown2.Value;
			this.igBulletGraph1.ValueInnerExtent = (double)this.numericUpDown3.Value;
			this.igBulletGraph1.ValueOuterExtent = (double)this.numericUpDown4.Value;

			this.igBulletGraph1.Update();
		}
	}
}
