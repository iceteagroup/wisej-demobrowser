using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSlider : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejSlider()
		{
			InitializeComponent();

			this.ejSlider1.Instance.change += new WidgetEventHandler(ejSlider1_WidgetEvent);
		}

		private void ejSlider1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSlider1.Options.allowMouseWheel = this.checkBox1.Checked;
			this.ejSlider1.Options.showButtons = this.checkBox2.Checked;
			this.ejSlider1.Options.showScale = this.checkBox3.Checked;
			this.ejSlider1.Options.showSmallTicks = this.checkBox4.Checked;
			this.ejSlider1.Options.sliderType = this.comboBox1.SelectedItem.ToString().ToLower();

			this.ejSlider1.Update();
		}
	}
}
