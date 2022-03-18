using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoMediaPlayer : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoMediaPlayer()
		{
			InitializeComponent();

			this.kendoMediaPlayer1.Instance.end += new WidgetEventHandler(kendoMediaPlayer1_WidgetEvent);
			this.kendoMediaPlayer1.Instance.play += new WidgetEventHandler(kendoMediaPlayer1_WidgetEvent);
			this.kendoMediaPlayer1.Instance.pause += new WidgetEventHandler(kendoMediaPlayer1_WidgetEvent);
		}

		private void kendoMediaPlayer1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
