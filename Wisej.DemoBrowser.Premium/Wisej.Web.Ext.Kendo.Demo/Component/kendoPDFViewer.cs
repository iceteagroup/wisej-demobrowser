using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoPDFViewer : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoPDFViewer()
		{
			InitializeComponent();

			this.kendoPDFViewer1.Instance.onOpen += new WidgetEventHandler(kendoPDFViewer1_WidgetEvent);
		}

		private void kendoPDFViewer1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kendoPDFViewer1.Instance.zoom(this.numericUpDownZoom.Value);
			this.kendoPDFViewer1.Options.zoomRate = this.numericUpDownZoomRate.Value;

			this.kendoPDFViewer1.Update();
        }
    }
}
