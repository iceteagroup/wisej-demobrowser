using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTimeline : TestBase
	{
		public kendoTimeline()
		{
			InitializeComponent();
            this.Load += KendoTimeline_Load;
			this.kendoTimeline1.Instance.onChange += new WidgetEventHandler(kendoTimeline1_WidgetEvent);
		}

        private void KendoTimeline_Load(object sender, EventArgs e)
        {
			this.comboBoxOrientation.SelectedIndex = 0;
		}

	
        private void kendoTimeline1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kendoTimeline1.Options.showDateLabels = this.checkBoxShowDateLabel.Checked;
			this.kendoTimeline1.Options.orientation = this.comboBoxOrientation.SelectedItem.ToString()?.ToLower();

			this.kendoTimeline1.Update();
        }
    }
}
