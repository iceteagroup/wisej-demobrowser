using System;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Toolbar : TestBase
	{
		public Toolbar()
		{
			InitializeComponent();

			this.toolbar1.Instance.clicked += new WidgetEventHandler(toolbar1_WidgetEvent);
		}

		private void toolbar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.toolbar1.Options.overflowMode = this.comboBoxOverflowMode.Text;
			this.toolbar1.Options.enableCollision = this.checkBoxEnableCollision.Checked;

			this.toolbar1.Update();
        }
    }
}
