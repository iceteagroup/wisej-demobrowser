using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoRating : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoRating()
		{
			InitializeComponent();

			this.kendoRating1.Instance.onChange += new WidgetEventHandler(kendoRating1_WidgetEvent);
		}

		private void kendoRating1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoRating1.Instance.value(this.numericUpDown1.Value);
			this.kendoRating1.Options.min = this.numericUpDown2.Value;
			this.kendoRating1.Options.max = this.numericUpDown3.Value;
			this.kendoRating1.Options.precision = this.comboBox1.SelectedItem;
			this.kendoRating1.Options.selectValueOnFocus = this.checkBox1.Checked;

			this.kendoRating1.Update();
		}
	}
}
