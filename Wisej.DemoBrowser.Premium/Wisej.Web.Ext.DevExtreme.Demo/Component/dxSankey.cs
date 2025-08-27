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

			this.dxSankey1.Instance.onLinkClick += new WidgetEventHandler(dxSankey1_WidgetEvent);
			this.dxSankey1.Instance.onNodeClick += new WidgetEventHandler(dxSankey1_WidgetEvent);
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

        private void dxSankey_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;

			this.dxSankey1.Options = new
			{
				dataSource = new object[]
                {
                    new
                    {
						source = "Spain",
						target = "United States of America",
						weight = 2
					},
					new
					{
						source = "Germany",
						target = "United States of America",
						weight = 8
					},
					new
					{
						source = "France",
						target = "United States of America",
						weight = 4
					},
					new
					{
						source = "Germany",
						target = "Great Britain",
						weight = 2
					},
					new
					{
						source = "France",
						target = "Great Britain",
						weight = 4
					},
					new
					{
						source = "United States of America",
						target = "Australia",
						weight = 6
					},
					new
					{
						source = "United States of America",
						target = "New Zealand",
						weight = 5
					},
					new
					{
						source = "United States of America",
						target = "Japan",
						weight = 3
					},
					new
					{
						source = "Great Britain",
						target = "New Zealand",
						weight = 4
					},
					new
					{
						source = "Great Britain",
						target = "Japan",
						weight = 1
					}
				},
				sourceField = "source",
				targetField = "target",
				weightField = "weight",
				title = "Commodity Turnover in 2017",
				link = new
                {
					colorMode = "gradient"
                }
			};

			this.dxSankey1.Update();
		}
	}
}
