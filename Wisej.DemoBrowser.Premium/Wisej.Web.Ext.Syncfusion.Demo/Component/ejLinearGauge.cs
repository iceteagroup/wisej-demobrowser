using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejLinearGauge : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejLinearGauge()
		{
			InitializeComponent();

			this.ejLinearGauge1.Instance.onMouseClick += new WidgetEventHandler(ejLinearGauge1_WidgetEvent);
			this.ejLinearGauge1.Instance.onRightClick += new WidgetEventHandler(ejLinearGauge1_WidgetEvent);
			this.ejLinearGauge1.Instance.onDoubleClick += new WidgetEventHandler(ejLinearGauge1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejLinearGauge1.Options.value = this.numericUpDownVal.Value;
			this.ejLinearGauge1.Options.orientation = this.comboBoxOrientation.Text;
			this.ejLinearGauge1.Options.outerCustomLabelPosition = this.comboBoxLabelPosition.Text;

			this.ejLinearGauge1.Update();
		}

		private void ejLinearGauge1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			this.ejLinearGauge1.Instance.exportImage("ejLinearGauge", "jpeg");
		}
	}
}
