using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoMultiSelect : TestBase
	{
		public kendoMultiSelect()
		{
			InitializeComponent();

			this.kendoMultiSelect1.Instance.onSelect += new WidgetEventHandler(kendoMultiSelect1_WidgetEvent);
		}

		private void kendoMultiSelect1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tagTextBoxDataSource.Text))
            {
				var data = this.tagTextBoxDataSource.Text.Split(',');
				var items = data.Select(d => new
				{
					value = Guid.NewGuid().ToString(),
					text = d
				});

				await this.kendoMultiSelect1.Instance.setDataSourceAsync(items);
			}

			this.kendoMultiSelect1.Options.autoClose = this.checkBoxAutoClose.Checked;

			this.kendoMultiSelect1.Update();
        }
    }
}
