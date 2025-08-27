using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Barcode : ViewBase
	{
		private void Barcode_Load(object sender, EventArgs e)
		{
			barcode1.Options.data = new dynamic[]
			{
				new
				{
					id = "barcode",
					type = "ean13",
					value = "123456789012"
				}
			};
		}

		public Barcode()
		{
			InitializeComponent();
		}
	}
}
