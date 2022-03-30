using System;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejCheckBox : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejCheckBox()
		{
			InitializeComponent();

			this.ejCheckBox1.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox2.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox3.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox4.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox5.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox6.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox7.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox8.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox9.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
		}

		private void ejCheckBoxes_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejCheckBox1.Options.enableTriState = this.checkBox2.Checked;
			this.ejCheckBox1.Options.showRoundedCorner = this.checkBox1.Checked;

			this.ejCheckBox1.Update();
		}
	}
}
