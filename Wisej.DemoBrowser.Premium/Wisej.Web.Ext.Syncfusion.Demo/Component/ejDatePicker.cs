using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejDatePicker : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejDatePicker()
		{
			InitializeComponent();

			this.ejDatePicker1.Instance.onOpen += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
			this.ejDatePicker1.Instance.onClose += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
			this.ejDatePicker1.Instance.onSelect += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
			this.ejDatePicker1.Instance.onChange += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
		}

		private void ejDatePicker_Load(object sender, EventArgs e)
		{
			this.ejDatePicker1.Options.value = null;
			this.ejDatePicker1.Options.showOtherMonths = true;
			this.ejDatePicker1.Options.enableStrictMode = true;
		}

		private void ejDatePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDatePicker1.Options.enableStrictMode = this.checkBox1.Checked;
			this.ejDatePicker1.Options.showOtherMonths = this.checkBox2.Checked;
			this.ejDatePicker1.Options.allowDrillDown = this.checkBox3.Checked;
			this.ejDatePicker1.Options.displayInline = this.checkBox4.Checked;
			this.ejDatePicker1.Options.showDisabledRange = this.checkBox5.Checked;
			this.ejDatePicker1.Options.showFooter = this.checkBox6.Checked;

			this.ejDatePicker1.Update();
		}
	}
}
