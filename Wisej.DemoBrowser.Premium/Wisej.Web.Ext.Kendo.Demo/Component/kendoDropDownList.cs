using System;
using System.Drawing;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDropDownList : TestBase
	{
		public kendoDropDownList()
		{
			InitializeComponent();

			this.kendoDropDownListColor.Instance.change += new WidgetEventHandler(kendoDropDownListColor_WidgetEvent);
		}

		private void kendoDropDownList_Load(object sender, EventArgs e)
		{
			// color picker.
			this.kendoDropDownListColor.Options.dataSource = new[] {
				new {
					Color = "Orange",
					Value = "orange-cap.png",
				},
				new {
					Color = "Black",
					Value = "black-cap.png",
				},
				new {
					Color = "Gray",
					Value = "gray-cap.png",
				},
			};
			this.kendoDropDownListColor.Options.value = "orange-cap.png";
			this.kendoDropDownListColor.Options.dataTextField = "Color";
			this.kendoDropDownListColor.Options.dataValueField = "Value";

			// size picker.
			this.kendoDropDownListSize.Options.dataSource = new[] {
				"Small",
				"Medium",
				"Large",
				"Extra Large"
			};
			this.kendoDropDownListSize.Options.value = "Small";
		}

		private void kendoDropDownListColor_WidgetEvent(object sender, WidgetEventArgs e)
		{
			if (!String.IsNullOrEmpty(e.Data))
				this.pictureBox1.Image = Image.FromFile(Application.MapPath($"Images/DropDownList/{e.Data}"));
		}
	}
}
