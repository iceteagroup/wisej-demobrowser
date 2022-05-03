using System;
using System.Drawing;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxSparkline : TestBase
	{
		public dxSparkline()
		{
			InitializeComponent();
		}

        private void dxSparkline1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private async void button1_Click(object sender, EventArgs e)
        {
			var result = await this.colorDialog1.ShowDialogAsync();
			if(result == DialogResult.OK)
            {
				string color = ColorTranslator.ToHtml(this.colorDialog1.Color);
				
				this.button1.Text = color;
				this.button1.BackColor = this.colorDialog1.Color;
				
				this.dxSparkline1.Options.lineColor = color;
				
				this.dxSparkline1.Update();
			}
		}
    }
}
