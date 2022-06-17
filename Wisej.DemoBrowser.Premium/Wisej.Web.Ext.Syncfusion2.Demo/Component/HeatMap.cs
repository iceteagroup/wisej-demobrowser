using System;
using System.Collections.Generic;
using System.Drawing;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class HeatMap : TestBase
	{
		public HeatMap()
		{
			InitializeComponent();

			this.heatMap1.Instance.onCellClick += new WidgetEventHandler(heatMap1_WidgetEvent);
		}

		private void HeatMap_Load(object sender, EventArgs e)
		{
			var heatMapDataSource = new object[11];
			heatMapDataSource[0] = new int[]
			{
				73, 39, 26, 39, 94, 0
			};
			heatMapDataSource[1] = new int[]
			{
				93, 58, 53, 38, 26, 68
			};
			heatMapDataSource[2] = new int[]
			{
				99,
				28,
				22,
				4,
				66,
				90
			};
			heatMapDataSource[3] = new int[]
			{
				14,
				26,
				97,
				69,
				69,
				3
			};
			heatMapDataSource[4] = new int[]
			{
				7,
				46,
				47,
				47,
				88,
				6
			};
			heatMapDataSource[5] = new int[]
			{
				41,
				55,
				73,
				23,
				3,
				79
			};
			heatMapDataSource[6] = new int[]
			{
				56,
				69,
				21,
				86,
				3,
				33
			};
			heatMapDataSource[7] = new int[]
			{
				45,
				7,
				53,
				81,
				95,
				79
			};
			heatMapDataSource[8] = new int[]
			{
				60,
				77,
				74,
				68,
				88,
				51
			};
			heatMapDataSource[9] = new int[]
			{
				25,
				25,
				10,
				12,
				78,
				14
			};
			heatMapDataSource[10] = new int[]
			{
				25,
				56,
				55,
				58,
				12,
				82
			};
			heatMapDataSource[10] = new int[]
			{
				74,
				33,
				88,
				23,
				86,
				59
			};

			this.heatMap1.Options.dataSource = heatMapDataSource;


			this.heatMap1.Options.paletteSettings.palette[0].value = 0;
			this.heatMap1.Options.paletteSettings.palette[0].color = "#11D7B6";

			this.heatMap1.Options.paletteSettings.palette[1].value = 100;
			this.heatMap1.Options.paletteSettings.palette[1].color = "#126DD6";

			this.heatMap1.Options.cellSettings.showLabel = this.checkBoxCellLabel.Checked;
		}

		private void heatMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
						MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonFromColor_Click(object sender, EventArgs e)
		{
			this.colorDialogFrom.ShowDialog((result) =>
			{
				if (result == DialogResult.OK)
					this.buttonFromColor.BackColor = this.colorDialogFrom.Color;
			});
		}

		private void buttonToColor_Click(object sender, EventArgs e)
		{
			this.colorDialogTo.ShowDialog((result) =>
			{
				if (result == DialogResult.OK)
					this.buttonToColor.BackColor = this.colorDialogTo.Color;
			});
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var palette = new List<object>();
			palette.Add(new
			{
				value = 0,
				color = ColorTranslator.ToHtml(this.buttonFromColor.BackColor)
			});
			palette.Add(new
			{
				value = 100,
				color = ColorTranslator.ToHtml(this.buttonToColor.BackColor)
			});

			this.heatMap1.Options.paletteSettings.palette = palette.ToArray();
			this.heatMap1.Options.allowSelection = this.checkBoxSelection.Checked;
			this.heatMap1.Options.cellSettings.showLabel = this.checkBoxCellLabel.Checked;

			this.heatMap1.Update();
		}
	}
}