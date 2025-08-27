using System;
using System.IO;
using System.Reflection;
using System.Linq;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.AspNetPanel
{
	public partial class Features : DemoView
	{
		private string RESOURCE_URL = "Wisej.DemoBrowser.AspNetPanel.Sample.aspx";

		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			LoadAspxFile();
		}


		private void LoadAspxFile()
		{
			using (var fs = this.GetType().Assembly.GetManifestResourceStream(RESOURCE_URL))
			{
				using (var reader = new StreamReader(fs))
				{
					var aspx = reader.ReadToEnd();

					this.aceEditorSource.Text = aspx;
				}

				this.aceEditorSource.Instance.navigateFileStart();
			}
		}
	}
}
