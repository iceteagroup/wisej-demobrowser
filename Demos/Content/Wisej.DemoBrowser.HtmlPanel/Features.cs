using System;
using System.IO;
using Wisej.DemoBrowser.Common;

namespace Wisej.DemoBrowser.HtmlPanel
{
    public partial class Features : DemoView
	{
		private string RESOURCE_URL = "Wisej.DemoBrowser.HtmlPanel.Sample.html";

		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			LoadHtmlFile();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			LoadHtmlFile();
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			this.htmlPanelPreview.Html = this.aceEditorSource.Text;
		}

		private void LoadHtmlFile()
		{
			using (var fs = this.GetType().Assembly.GetManifestResourceStream(RESOURCE_URL))
			{
				using (var reader = new StreamReader(fs))
				{
					var html = reader.ReadToEnd();

					this.aceEditorSource.Text = html;
					this.htmlPanelPreview.Html = html;
				}

				this.aceEditorSource.Instance.navigateFileStart();
			}
		}
	}
}
