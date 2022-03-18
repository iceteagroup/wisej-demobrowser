using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSparkline : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejSparkline()
		{
			InitializeComponent();

			this.ejSparkline1.Instance.click += new WidgetEventHandler(ejSparkline1_WidgetEvent);
		}

		private void ejSparkline1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSparkline1.Options.type = this.comboBox1.SelectedItem.ToString().ToLower();
			this.ejSparkline1.Options.markerSettings = new
			{
				visible = this.checkBox2.Checked,
				fill = "black"
			};
			this.ejSparkline1.Options.axisLineSettings = new
			{
				visible = this.checkBox3.Checked,
				color = "black"
			};

			this.ejSparkline1.Update();
		}
	}
}
