using System;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igColorPicker : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igColorPicker()
		{
			InitializeComponent();

			this.igColorPicker1.Instance.colorSelected += new WidgetEventHandler(igColorPicker_WidgetEvent);
		}

		private void igColorPicker_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			this.label4.BackColor = System.Drawing.Color.FromName(e.Data);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igColorPicker1.Update();
		}
	}
}
