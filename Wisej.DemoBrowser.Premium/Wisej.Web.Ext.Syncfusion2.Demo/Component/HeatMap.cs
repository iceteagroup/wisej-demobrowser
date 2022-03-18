using System;
using System.Collections.Generic;
using System.Drawing;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class HeatMap : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public HeatMap()
		{
			InitializeComponent();

            this.heatMap1.Instance.cellClick += new WidgetEventHandler(heatMap1_WidgetEvent);

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
                if(result == DialogResult.OK)
                    this.buttonFromColor.BackColor = colorDialogFrom.Color;
            });
        }

        private void buttonToColor_Click(object sender, EventArgs e)
        {
            this.colorDialogTo.ShowDialog((result) =>
            {
                if (result == DialogResult.OK)
                    this.buttonToColor.BackColor = colorDialogTo.Color;
            });
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            List<object> palette = new List<object>();
            palette.Add(new
            {
                value = 0,
                color = ColorTranslator.ToHtml(buttonFromColor.BackColor)
            });
            palette.Add(new
            {
                value = 100,
                color = ColorTranslator.ToHtml(buttonToColor.BackColor)
            });

            this.heatMap1.Options.paletteSettings.palette = palette.ToArray();
            this.heatMap1.Options.allowSelection = this.checkBoxSelection.Checked;
            this.heatMap1.Options.cellSettings.showLabel = this.checkBoxCellLabel.Checked;

            this.heatMap1.Update();
        }
    }
}
