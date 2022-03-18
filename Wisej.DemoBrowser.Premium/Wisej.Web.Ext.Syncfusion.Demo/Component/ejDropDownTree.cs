using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejDropDownTree : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejDropDownTree()
		{
			InitializeComponent();

			this.ejDropDownTree1.Instance.change += new WidgetEventHandler(ejDropDownTree1_WidgetEvent);
			this.ejDropDownTree1.Instance.select += new WidgetEventHandler(ejDropDownTree1_WidgetEvent);
			this.ejDropDownTree1.Instance.checkChange += new WidgetEventHandler(ejDropDownTree1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDropDownTree1.Options.showRoundedCorner = this.checkBox1.Checked;
			this.ejDropDownTree1.Options.popupSettings = new 
			{ 
				showPopupOnLoad = this.checkBox2.Checked,
				height = $"{this.numericUpDownPopupHeight.Value}px"
			};

			this.ejDropDownTree1.Update();
		}

		private void ejDropDownTree1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
