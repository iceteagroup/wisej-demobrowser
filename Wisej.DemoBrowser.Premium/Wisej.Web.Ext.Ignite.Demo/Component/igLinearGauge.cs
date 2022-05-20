using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igLinearGauge : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igLinearGauge()
		{
			InitializeComponent();

			this.igLinearGauge1.Instance.onValueChanged += new WidgetEventHandler(igLinearGauge_WidgetEvent);
		}

		private void igLinearGauge_Load(object sender, EventArgs e)
		{
			//igLinearGauge1 Configuration
			this.igLinearGauge1.Options.ranges = new dynamic[]{new {brush="#FDB881", name="bad", startValue = 0, endValue = 20, },
				new {brush="#F18B36", name="acceptable", startValue = 20, endValue = 35, },
				new {brush="#D2660D", name="good", startValue = 35, endValue = 100, },
			};
			this.igLinearGauge1.Options.value = 40;
			this.igLinearGauge1.Options.needleStrokeThickness = 2;
			this.igLinearGauge1.Options.formatLabel = "formatLabel";
			this.igLinearGauge1.Options.isNeedleDraggingEnabled = true;

			//igLinearGauge2 Configuration
			this.igLinearGauge2.Options.ranges = new dynamic[]{new {brush="#ABD652", name="bad", startValue = 0, endValue = 45, },
				new {brush="#739F19", name="acceptable", startValue = 45, endValue = 65, },
				new {brush="#527211", name="good", startValue = 65, endValue = 100, },
			};
			this.igLinearGauge2.Options.value = 35;
			this.igLinearGauge2.Options.labelExtent = 0.76;
			this.igLinearGauge2.Options.tickStartExtent = 0.5;
			this.igLinearGauge2.Options.minorTickEndExtent = 0.54;
			this.igLinearGauge2.Options.minorTickStartExtent = 0.65;
			this.igLinearGauge2.Options.needleStrokeThickness = 2;


			//igLinearGauge3 Configuration
			this.igLinearGauge3.Options.ranges = new dynamic[]{new {name="bad", startValue = 0, endValue = 10, },
				new {name="acceptable", startValue = 10, endValue = 35, },
				new {name="good", startValue = 35, endValue = 100, },
			};
			this.igLinearGauge3.Options.value = 25;
			this.igLinearGauge3.Options.labelExtent = 0.76;
			this.igLinearGauge3.Options.tickBrush = "#F79646";
			this.igLinearGauge3.Options.minorTickBrush = "#F79646";
			this.igLinearGauge3.Options.fontBrush = "#11719A";
			this.igLinearGauge3.Options.ticksPreTerminal = 10;
			this.igLinearGauge3.Options.ticksPostInitial = 10;
			this.igLinearGauge3.Options.labelsPostInitial = 20;
			this.igLinearGauge3.Options.labelsPreTerminal = 20;
		}

		private void igLinearGauge_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igLinearGauge1.Value = (double) this.numericUpDown1.Value;
			this.igLinearGauge1.Options.isNeedleDraggingEnabled = this.checkBox1.Checked;
			this.igLinearGauge1.Options.isScaleInverted = this.checkBox2.Checked;
			this.igLinearGauge1.Options.minorTickCount = this.numericUpDown2.Value;
			this.igLinearGauge1.Options.scaleInnerExtent = this.numericUpDown3.Value;
			this.igLinearGauge1.Options.scaleOuterExtent = this.numericUpDown4.Value;

			this.igLinearGauge1.Update();
		}

		
	}
}
