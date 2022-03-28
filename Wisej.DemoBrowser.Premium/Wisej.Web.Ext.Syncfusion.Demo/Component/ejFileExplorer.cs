using System;
using System.IO;
using Wisej.Core;
using System.Linq;
using Wisej.Web;
using System.Web;
using Syncfusion.JavaScript;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejFileExplorer : TestBase
	{
		public ejFileExplorer()
		{
			InitializeComponent();
		}
		private void ejFileExplorer_Load(object sender, EventArgs e)
		{
			this.ejFileExplorer1.Options = new
			{
				showFooter = true,
				showToolbar = true,
				layout = "tile",
				path = Application.MapPath("Data")
			};
		}

		private void ejFileExplorer1_WebRequest(object sender, WebRequestEventArgs e)
		{
			try
			{
				var helper = new FileExplorerOperations();

				if (e.Request.HttpMethod == "POST")
				{
					var data = JSON.Parse(e.Request.InputStream);
					switch (data.ActionType)
					{
						case "Read":
							e.Response.Write(JSON.Stringify(helper.Read(data.Path, data.ExtensionsAllow)));
							break;

						default:
							AlertBox.Show($"Action not implemented {data.ActionType}", MessageBoxIcon.Stop);
							break;
					}
				}
				else
				{
					switch (e.Request["ActionType"])
					{
						case "Download":
							helper.Download(e.Request["Path"], e.Request.QueryString.GetValues("Names"));
							break;

						case "GetImage":
							helper.GetImage(e.Request["Path"], e.Request["CanCompress"].ToLower() == "true");
							break;
					}
				}
			} 
			catch
			{
				AlertBox.Show("Feature not implemented.", MessageBoxIcon.Error);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejFileExplorer1.Options.showFooter = this.checkBox1.Checked;
			this.ejFileExplorer1.Options.showToolbar = this.checkBox2.Checked;
			this.ejFileExplorer1.Options.layout = this.comboBox1.Text.ToLower();
			this.ejFileExplorer1.Options.allowMultiSelection = this.checkBox4.Checked;
			this.ejFileExplorer1.Options.showCheckbox = this.checkBox5.Checked;
			this.ejFileExplorer1.Options.showContextMenu = this.checkBox6.Checked;
			this.ejFileExplorer1.Options.showThumbnail = this.checkBox7.Checked;

			this.ejFileExplorer1.Update();
		}
	}
}
