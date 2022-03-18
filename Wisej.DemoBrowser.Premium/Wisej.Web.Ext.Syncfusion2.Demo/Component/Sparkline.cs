using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Sparkline : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public Sparkline()
		{
			InitializeComponent();
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

			this.sparkline1.Options.type = this.comboBox1.Text;
			this.sparkline1.Update();
        }
    }
}
