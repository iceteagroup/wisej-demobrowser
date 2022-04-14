using System;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoStockChart : TestBase
	{
		public kendoStockChart()
		{
			InitializeComponent();

			this.kendoStockChart1.Instance.onPlotAreaClick += new WidgetEventHandler(kendoStockChart1_WidgetEvent);
		}

		private void kendoStockChart_Load(object sender, EventArgs e)
		{
			var postbackUrl = ((Widget)this.kendoStockChart1).GetPostbackURL();
			this.kendoStockChart1.Options.dataSource = new
			{
				transport = new
				{
					read = new
					{
						url = $"./{postbackUrl}&action=load",
						dataType = "json"
					}
				},
				schema = new
				{
					model = new
					{
						fields = new
						{
							Date = new
							{
								type = "date"
							}
						}
					}
				}
			};
		}

		private void kendoStockChart1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request["action"])
			{
				case "load":
					e.Response.Write(File.ReadAllText(Application.MapPath("Data/Stock/Boeing.json")));
					break;
			}
		}

		private void kendoStockChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
