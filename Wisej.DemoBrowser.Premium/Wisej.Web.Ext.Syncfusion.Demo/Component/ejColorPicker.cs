using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejColorPicker : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejColorPicker()
		{
			InitializeComponent();

			this.ejColorPicker1.Instance.onChange += new WidgetEventHandler(ejColorPicker1_WidgetEvent);
		}

		private void ejColorPicker_Load(object sender, EventArgs e)
		{
			this.ejColorPicker1.Options.value = "Choose Color";
		}

		private void ejColorPicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$@"<b>{e.Type}</b><br/>
				{e.Data}",
				MessageBoxIcon.Information);

			if (e.Type == "select")
				this.textBoxColor.Text = e.Data?.value ?? "";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			ejColorPicker1.Options.value = textBoxColor.Text;
		}
	}
}
