using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTagCloud : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejTagCloud()
		{
			InitializeComponent();

			this.ejTagCloud1.Instance.click += new WidgetEventHandler(ejTagCloud1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTagCloud1.Options.showTitle = this.checkBox1.Checked;
			this.ejTagCloud1.Options.format = this.comboBoxFormat.Text;
			this.ejTagCloud1.Options.minFontSize = $"{this.numericUpDownMinimumFontSize.Value}px";
			this.ejTagCloud1.Options.maxFontSize = $"{this.numericUpDownMaximumFontSize.Value}px";

			this.ejTagCloud1.Update();
		}

		private void ejTagCloud1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
