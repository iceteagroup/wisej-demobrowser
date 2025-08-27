﻿using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxFunnel : TestBase
	{
		public dxFunnel()
		{
			InitializeComponent();

			this.dxFunnel1.Instance.onItemClick += new WidgetEventHandler(dxFunnel1_WidgetEvent);
			this.dxFunnel1.Instance.onLegendClick += new WidgetEventHandler(dxFunnel1_WidgetEvent);
		}

		private void dxFunnel_Load(object sender, EventArgs e)
		{
			this.dxFunnel1.Options.argumentField = "action";
			this.dxFunnel1.Options.dataSource = new[]
			{
				new {
					action = "Visited the Website",
					users = 9152
				},
				new {
					action = "Downloaded a Trial",
					users = 6879
				},
				new {
					action = "Contacted Support",
					users = 5121
				},
				new {
					action = "Subscribed",
					users = 2224
				},
				new {
					action = "Renewed",
					users = 1670
				}
			};
			this.dxFunnel1.Options.position = "inside";
			this.dxFunnel1.Options.valueField = "users";
		}

		private void dxFunnel1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxFunnel1.Options.palette = this.comboBox2.Text;
			this.dxFunnel1.Options.algorithm = this.comboBox1.Text;
			this.dxFunnel1.Options.hoverEnabled = this.checkBox1.Checked;
			this.dxFunnel1.Options.inverted = this.checkBox2.Checked;
			this.dxFunnel1.Options.sortData = this.checkBox3.Checked;

			this.dxFunnel1.Update();
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var data = await this.dxFunnel1.Instance.svgAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(Regex.Unescape(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "funnel.svg");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}
	}
}
