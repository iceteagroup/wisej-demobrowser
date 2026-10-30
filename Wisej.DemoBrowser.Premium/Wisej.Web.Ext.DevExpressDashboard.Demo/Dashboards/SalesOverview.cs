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
		// connection name used by the JSON data sources in the dashboards.
		private const string OrderDetailsConnection = "OrderDetailsJson";

		// the JSON data is read once and shared by all sessions.
		private static readonly Lazy<string> OrderDetailsJson =
			new Lazy<string>(() => File.ReadAllText(Application.MapPath("Data/OrderDetails.json")));

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

			//supply the JSON data by connection name instead of embedding it in the dashboard xml
			this._configurator.ConfigureDataConnection += this.Configurator_ConfigureDataConnection;

			//copy the dashboard xml file to the session's temp folder so that it is loaded as the first dashboard
			var tempPath = Program.TempPath;
			Directory.CreateDirectory(tempPath);
			File.Copy(Application.MapPath("Data/Dashboards/dashboard1.xml"), Path.Combine(tempPath, "dashboard1.xml"), true);

			//set the folder to store the dashboards in
			this._configurator.SetDashboardStorage(new DashboardFileStorage(tempPath));
		}

		private void Configurator_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e)
		{
			if (e.ConnectionName == OrderDetailsConnection)
			{
				e.ConnectionParameters = new JsonSourceConnectionParameters
				{
					JsonSource = new CustomJsonSource(OrderDetailsJson.Value)
				};
			}
		}

		private DataSourceInMemoryStorage CreateDataSourceStorage()
		{
			var storage = new DataSourceInMemoryStorage();
			var jsonDataSource = new DashboardJsonDataSource("Order Details (JSON)");

			jsonDataSource.RootElement = "data";
			jsonDataSource.ConnectionName = OrderDetailsConnection;

			storage.RegisterDataSource("jsonDataSource", jsonDataSource.SaveToXml());

			return storage;
		}

		private void dxDashboard1_WebRequest(object sender, WebRequestEventArgs e)
		{
			this._dashboardHelper.ProcessRequest(sender, e);
		}
	}
}
