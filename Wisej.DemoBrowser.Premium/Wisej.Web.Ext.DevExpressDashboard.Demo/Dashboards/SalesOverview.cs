using DevExpress.CodeParser;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Json;
using DevExpress.DataAccess.Web;
using System;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExpressDashboard.Demo.Dashboards
{
	public partial class SalesOverview : TestBase
	{
		private DashboardConfigurator _configurator;
		private DashboardHelper _dashboardHelper;

		public SalesOverview()
		{
			InitializeComponent();
		}

		private void SalesOverview_Load(object sender, EventArgs e)
		{
			this.dxDashboard1.Options.endpoint = $"{this.dxDashboard1.GetServiceURL()}";

			this._configurator = new DashboardConfigurator();
			this._dashboardHelper = new DashboardHelper(this._configurator);

			var storage = CreateDataSourceStorage();

			this._configurator.SetDataSourceStorage(storage);

			//copy the dashboard xml file to the temp folder so that it is loaded as the first dashboard
			System.IO.File.Copy(Application.MapPath("Data/Dashboards/dashboard1.xml"), Application.MapPath("Temp/dashboard1.xml"),true);

			//set the folder to store the dashboards in
			this._configurator.SetDashboardStorage(new DashboardFileStorage(Application.MapPath("Temp")));
		}

		private DataSourceInMemoryStorage CreateDataSourceStorage()
		{
			var storage = new DataSourceInMemoryStorage();
			var jsonDataSource = new DashboardJsonDataSource("Order Details (JSON)");
			var json = File.ReadAllText(Application.MapPath("Data/OrderDetails.json"));

			jsonDataSource.RootElement = "data";
			jsonDataSource.JsonSource = new CustomJsonSource(json);

			storage.RegisterDataSource("jsonDataSource", jsonDataSource.SaveToXml());

			return storage;
		}

		private void dxDashboard1_WebRequest(object sender, WebRequestEventArgs e)
		{
			this._dashboardHelper.ProcessRequest(sender, e);
		}
	}
}
