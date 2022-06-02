using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSlider : TestBase
	{
		public ejSlider()
		{
			InitializeComponent();

			this.ejSlider1.Instance.onChange += new WidgetEventHandler(ejSlider1_WidgetEvent);
		}

		private void ejSlider_Load(object sender, EventArgs e)
		{
			//ejSlider1
			this.ejSlider1.Options.sliderType = "range";
			this.ejSlider1.Options.values = new object[]
			{
				30, 60
			};

			//ejSlider2
			this.ejSlider2.Options.value = 60;
			this.ejSlider2.Options.sliderType = "minrange";
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