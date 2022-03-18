using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class DataTable : ViewBase
	{
		public DataTable()
		{
			InitializeComponent();

			this.dataTable1.Instance.itemClick += new WidgetEventHandler(dataTable1_WidgetEvent);
		}

		private void dataTable1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
