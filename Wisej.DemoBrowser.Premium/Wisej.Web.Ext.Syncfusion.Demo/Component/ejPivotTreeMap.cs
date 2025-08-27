using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejPivotTreeMap : TestBase
	{
		public ejPivotTreeMap()
		{
			InitializeComponent();
		}

		private void ejPivotTreeMap_Load(object sender, EventArgs e)
		{
			this.ejPivotTreeMap1.Options.dataSource = new
			{
				data = "http://bi.syncfusion.com/olap/msmdpump.dll",
				catalog = "Adventure Works DW 2008 SE",
				cube = "Adventure Works",
				rows = new object[]
				{
					new
					{
						fieldName = "[Customer].[Customer Geography]"
					}
				},
				columns = new object[]
				{
					new
					{
						fieldName = "[Date].[Fiscal]"
					}
				},
				values = new object[]
				{
					new
					{
						measures = new object[]
						{
							new
							{
								fieldName = "[Measures].[Customer Count]"
							}
						},
						axis = "columns"
					}
				}
			};
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejPivotTreeMap1.Instance.getJsonRecordsAsync();

			using (var ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(data);
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "ejPivotTreeMapData.json");
				}
				catch (Exception ex)
				{
					AlertBox.Show(ex.Message);
				}
			}
		}
	}
}