using System;
using System.IO;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxSankey : TestBase
	{
		public dxSankey()
		{
			InitializeComponent();

			this.dxSankey1.Instance.linkClick += new WidgetEventHandler(dxSankey1_WidgetEvent);
			this.dxSankey1.Instance.nodeClick += new WidgetEventHandler(dxSankey1_WidgetEvent);
		}

		private void dxSankey1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var data = await this.dxSankey1.Instance.svgAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(Regex.Unescape(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "sankey.html");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxSankey1.Options.label = new
			{
				visible = this.checkBox1.Checked
			};
			this.dxSankey1.Options.link = new
			{
				colorMode = this.comboBox2.SelectedItem
			};
			this.dxSankey1.Options.alignment = this.comboBox1.SelectedItem;
			this.dxSankey1.Options.node = new
			{
				width = this.numericUpDown1.Value,
				padding = this.numericUpDown2.Value
			};

			this.dxSankey1.Update();
		}
	}
}
