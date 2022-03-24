using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Slider : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public Slider()
		{
			InitializeComponent();

			this.slider1.Instance.onChange += new WidgetEventHandler(slider1_change);
		}

        private void slider1_change(object sender, WidgetEventArgs e)
        {
			AlertBox.Show(
							$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
							MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

			this.slider1.Options.orientation = this.comboBoxOrientation.Text;
			this.slider1.Options.showButtons = this.checkBoxShowButton.Checked;
			this.slider1.Update();
        }
    }
}
