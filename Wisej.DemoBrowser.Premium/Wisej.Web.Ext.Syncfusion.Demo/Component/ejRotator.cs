using System;
using System.Globalization;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejRotator : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejRotator()
		{
			InitializeComponent();

			this.ejRotator1.Instance.pagerClick += new WidgetEventHandler(this.ejRotator1_pagerClick);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejRotator1.Options.showCaption = this.checkBox1.Checked;
			this.ejRotator1.Options.showPlayButton = this.checkBox2.Checked;
			this.ejRotator1.Options.animationType =
				char.ToLower(this.comboBox1.Text[0]) + this.comboBox1.Text.Substring(1);

			this.ejRotator1.Update();
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
			this.ejRotator1.Instance.play();
		}

		private void buttonPause_Click(object sender, EventArgs e)
		{
			this.ejRotator1.Instance.pause();
		}

		private void ejRotator1_pagerClick(object sender, WidgetEventArgs e)
		{
			AlertBox.Show($"Slide Index: {e.Data.activeItemIndex}");
		}
	}
}
