using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxGallery : TestBase
	{
		public dxGallery()
		{
			InitializeComponent();

			this.dxGallery1.Instance.onItemClick += new WidgetEventHandler(dxGallery1_WidgetEvent);
		}

		private void dxGallery1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxGallery1.Options.loop = this.checkBox1.Checked;
			this.dxGallery1.Options.showIndicator = this.checkBox5.Checked;
			this.dxGallery1.Options.showNavButtons = this.checkBox6.Checked;
			this.dxGallery1.Options.swipeEnabled = this.checkBox7.Checked;

			this.dxGallery1.Update();
		}
	}
}
