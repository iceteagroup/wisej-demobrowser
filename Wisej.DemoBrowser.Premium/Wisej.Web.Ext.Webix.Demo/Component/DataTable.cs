using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class DataTable : ViewBase
	{
		public DataTable()
		{
			InitializeComponent();

			this.dataTable1.Instance.onItemClick += new WidgetEventHandler(dataTable1_WidgetEvent);
		}

		private void dataTable1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void DataTable_Load(object sender, EventArgs e)
        {
			dataTable1.Options.autoConfig = true;
			dataTable1.Options.data = new dynamic[]
			{
				new
				{
					id = 1,
					title = "The Shawshank Redemption",
					year = 1994,
					votes = 678790,
					rating = 9.2,
					rank = 1
				},
				new
				{
					id = 2,
					title = "The Godfather",
					year = 1972,
					votes = 511495,
					rating = 9.2,
					rank = 2
				}
			};
		}
    }
}
