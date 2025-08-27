﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxRangeSelector : TestBase
	{
		public dxRangeSelector()
		{
			InitializeComponent();

			this.dxRangeSelector1.Instance.onValueChanged += new WidgetEventHandler(dxRangeSelector1_WidgetEvent);
		}

		private void dxRangeSelector1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxRangeSelector1.Options.behavior = new
			{
				allowSlidersSwap = this.checkBox1.Checked,
				snapToTicks = this.checkBox5.Checked
			};

			this.dxRangeSelector1.Options.value = new
			{
				startValue = this.numericUpDown1.Value,
				endValue = this.numericUpDown2.Value,
				length = this.comboBox1.SelectedItem
			};

			this.dxRangeSelector1.Update();
		}

        private async void buttonExport_Click(object sender, EventArgs e)
		{
			var data = await this.dxRangeSelector1.Instance.svgAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(Regex.Unescape(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "rangeSelector.html");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}

        private void dxRangeSelector_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;

			this.dxRangeSelector1.Options = new
			{
				scale = new { startValue = 15000, endValue = 150000, minorTickInterval = 500, tickInterval = 15000, label = new { format = "currency" } },
				slideMarker = new { format = "currency" },
				value = new
                {
					startValue = "40000",
					endValue = "80000",
					length = "day"
				},
				title = "Select House Price Range"
			};

			this.dxRangeSelector1.Update();
		}
	}
}
