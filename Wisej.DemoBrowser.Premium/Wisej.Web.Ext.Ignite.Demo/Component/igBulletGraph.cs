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

		private void igBulletGraph_Load(object sender, EventArgs e)
		{
			//igBulletGraph1 Configuration
			this.igBulletGraph1.Options.ranges = new dynamic[]
			{
				new {brush = "#803E01", name = "bad", startValue = 0, endValue = 5000},
				new {brush = "#BA5A05", name = "acceptable", startValue = 5000, endValue = 6000},
				new {brush = "#FF7A04", name = "good", startValue = 6000, endValue = 10000}
			};

			this.igBulletGraph1.Options.minimumValue = 0;
			this.igBulletGraph1.Options.maximumValue = 10000;
			this.igBulletGraph1.Options.value = 6500;
			this.igBulletGraph1.Options.targetValue = 7000;
			this.igBulletGraph1.Options.formatLabel = "formatLabel";
			this.igBulletGraph1.Options.valueInnerExtent = 0.5;
			this.igBulletGraph1.Options.valueOuterExtent = 0.65;

			//igBulletGraph2 Configuration
			this.igBulletGraph2.Options.ranges = new dynamic[]
			{
				new {brush = "#566509", name = "bad", startValue = 0, endValue = 3000},
				new {brush = "#7F950C", name = "acceptable", startValue = 3000, endValue = 4000},
				new {brush = "#AABF31", name = "good", startValue = 4000, endValue = 10000}
			};
			this.igBulletGraph2.Options.minimumValue = 0;
			this.igBulletGraph2.Options.maximumValue = 10000;
			this.igBulletGraph2.Options.value = 5000;
			this.igBulletGraph2.Options.targetValue = 6000;
			this.igBulletGraph2.Options.formatLabel = "formatLabel";
			this.igBulletGraph2.Options.valueInnerExtent = 0.5;
			this.igBulletGraph2.Options.valueOuterExtent = 0.65;

			//igBulletGraph3 Configuration
			this.igBulletGraph3.Options.ranges = new dynamic[]
			{
				new {brush = "#566509", name = "bad", startValue = 0, endValue = 250},
				new {brush = "#7F950C", name = "acceptable", startValue = 250, endValue = 300},
				new {brush = "#AABF31", name = "good", startValue = 300, endValue = 500}
			};
			this.igBulletGraph3.Options.minimumValue = 0;
			this.igBulletGraph3.Options.maximumValue = 500;
			this.igBulletGraph3.Options.value = 350;
			this.igBulletGraph3.Options.targetValue = 400;
			this.igBulletGraph3.Options.formatLabel = "formatLabel";
			this.igBulletGraph3.Options.valueInnerExtent = 0.35;
			this.igBulletGraph3.Options.valueOuterExtent = 0.8;

		}
	}
}
