using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoSlider : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoSlider()
		{
			InitializeComponent();

			this.kendoSlider1.Instance.onChange += new WidgetEventHandler(kendoSlider1_WidgetEvent);
		}

		private void kendoSlider1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

			this.comboBoxTickPlacement.SelectedIndex = 0;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kendoSlider1.Options.showButtons = this.checkBoxShowButtons.Checked;
			this.kendoSlider1.Options.orientation = this.comboBoxTickPlacement.SelectedItem.ToString()?.ToLower();

			this.kendoSlider1.Update();
        }
    }
}
