using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxFilterBuilder : TestBase
	{
		public dxFilterBuilder()
		{
			InitializeComponent();

			this.dxFilterBuilder1.Instance.onEditorPrepared += new WidgetEventHandler(dxFilterBuilder1_WidgetEvent);
		}

		private void dxFilterBuilder1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
    }
}
