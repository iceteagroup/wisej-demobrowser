using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Menu : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public Menu()
		{
			InitializeComponent();

			this.menu1.Instance.onSelect += new WidgetEventHandler(menu1_WidgetEvent);
		}
		 private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.menu1.Options.orientation = this.comboBoxOrientation.Text;

			this.menu1.Update();
        }

		private void menu1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
