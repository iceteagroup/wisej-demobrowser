using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejBarcode : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejBarcode()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejBarcode1.Options.text = this.textBox3.Text;
			this.ejBarcode1.Options.value = this.textBox3.Text;
			this.ejBarcode1.Options.symbologyType = this.comboBox1.Text;
			this.ejBarcode1.Options.darkBarColor = this.textBox1.Text;
			this.ejBarcode1.Options.lightBarColor = this.textBox2.Text;

			this.ejBarcode1.Update();
		}
	}
}
