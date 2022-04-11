using System;
using System.Drawing;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDropDownList : TestBase
	{
		public kendoDropDownList()
		{
			InitializeComponent();

			this.kendoDropDownListColor.Instance.onChange += new WidgetEventHandler(kendoDropDownListColor_WidgetEvent);
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

		private async void kendoDropDownListColor_WidgetEvent(object sender, WidgetEventArgs e)
		{
			var value = await this.kendoDropDownListColor.Instance.valueAsync();
			this.pictureBox1.Image = Image.FromFile(Application.MapPath($"Images/DropDownList/{value}"));
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kendoDropDownListColor.Options.filterTitle = this.textBox1.Text;
			this.kendoDropDownListColor.Options.filter = this.comboBoxFilter.SelectedText;

			this.kendoDropDownListColor.Update();
        }
    }
}
