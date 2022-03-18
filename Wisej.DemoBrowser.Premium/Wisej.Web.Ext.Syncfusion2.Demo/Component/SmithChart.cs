using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class SmithChart : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public SmithChart()
		{
			InitializeComponent();

            this.smithChart1.Instance.tooltipRender += new WidgetEventHandler(smithChart1_tooltipRender);

        }

        private void smithChart1_tooltipRender(object sender, WidgetEventArgs e)
        {
            AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
                                        MessageBoxIcon.Information);

            Application.Play(MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.smithChart1.Options.series[0].marker.shape = this.comboBoxShaprType.Text;
            this.smithChart1.Options.series[1].marker.shape = this.comboBoxShaprType.Text;
            this.smithChart1.Options.series[1].marker.visible = this.checkBoxMarkerVisible.Checked;
            this.smithChart1.Options.series[0].marker.visible = this.checkBoxMarkerVisible.Checked;
            this.smithChart1.Options.legendSettings.visible = this.checkBoxLegendVisibility.Checked;

            this.smithChart1.Update();
        }
    }
}
