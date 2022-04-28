using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxSparkline : TestBase
	{
		public dxSparkline()
		{
			InitializeComponent();
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

			this.comboBoxPointSymbol.SelectedIndex = 0;
        }

        private void dxSparkline1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.dxSparkline1.Options.type = this.comboBoxPointSymbol.SelectedItem.ToString();

			this.dxSparkline1.Update();
        }
    }
}
