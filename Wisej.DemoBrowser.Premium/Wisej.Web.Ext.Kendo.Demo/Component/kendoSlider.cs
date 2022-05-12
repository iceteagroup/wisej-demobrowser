using System;
using System.Linq;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoSlider : TestBase
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			var sliders = this.panel.Controls.Where(c => c is Kendo.kendoSlider);

			foreach (Kendo.kendoSlider slider in sliders)
            {
				slider.Options.value = this.numericUpDownValue.Value;
				slider.Options.showButtons = this.checkBoxShowButtons.Checked;
				slider.Options.tickPlacement = this.comboBoxTickPlacement.SelectedItem.ToString()?.ToLower();

				slider.Update();
			}
        }
	}
}
