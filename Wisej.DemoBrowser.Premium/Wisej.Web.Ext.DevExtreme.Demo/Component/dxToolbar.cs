using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxToolbar : TestBase
	{
		public dxToolbar()
		{
			InitializeComponent();

			this.dxToolbar1.Instance.itemClick += new WidgetEventHandler(dxToolbar1_WidgetEvent);
			this.dxToolbar1.Instance.valueChanged += new WidgetEventHandler(dxToolbar1_WidgetEvent);
		}

		private void dxToolbar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			switch (e.Type)
			{
				case "itemClick":
					var text = e.Data.itemData.text ?? e.Data.itemData.options?.type ?? e.Data.itemData.options?.icon;
					dxBase.Notify($"Clicked {text}", "info", 2500);
					break;

				case "valueChanged":
					var index = e.Data.value;
					dxBase.Notify($"Selected item {index}", "info", 2500);
					break;

				default:
					AlertBox.Show(
						$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
						MessageBoxIcon.Information);

					Application.Play(MessageBoxIcon.Information);
					break;
			}	
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxToolbar1.Options.hoverStateEnabled = this.checkBox1.Checked;
			this.dxToolbar1.Options.rtlEnabled = this.checkBox2.Checked;

			this.dxToolbar1.Update();
		}
	}
}
