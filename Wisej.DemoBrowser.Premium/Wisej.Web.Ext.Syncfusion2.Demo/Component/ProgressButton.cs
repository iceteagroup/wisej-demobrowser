using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class ProgressButton : TestBase
	{
		public ProgressButton()
		{
			InitializeComponent();
		}

		private void ProgressButton_Load(object sender, EventArgs e)
		{
			//progressButton1
			this.progressButton1.Options.content = "Spin Left";

			//progressButton2
			this.progressButton2.Options.content = "Spin Right";
			this.progressButton2.Options.spinSettings = new
			{
				position = "Right"
			};

			//progressButton3
			this.progressButton3.Options.content = "Spin Top";
			this.progressButton3.Options.spinSettings = new
			{
				position = "Top"
			};

			//progressButton4
			this.progressButton4.Options.content = "Spin Bottom";
			this.progressButton4.Options.spinSettings = new
			{
				position = "Bottom"
			};

			//progressButton5
			this.progressButton5.Options.content = "Zoom Out";
			this.progressButton5.Options.animationSettings = new
			{
				effect = "ZoomOut"
			};
			this.progressButton5.Options.spinSettings = new
			{
				position = "Center"
			};

			//progressButton6
			this.progressButton6.Options.content = "Slide Left";
			this.progressButton6.Options.enableProgress = true;
			this.progressButton6.Options.animationSettings = new
			{
				effect = "SlideLeft"
			};
			this.progressButton6.Options.spinSettings = new
			{
				position = "Center"
			};
			this.progressButton6.Options.cssClass = "e-flat e-success";

			//progressButton7
			this.progressButton7.Options.content = "Slide Right";
			this.progressButton7.Options.enableProgress = true;
			this.progressButton7.Options.animationSettings = new
			{
				effect = "SlideRight"
			};
			this.progressButton7.Options.spinSettings = new
			{
				position = "Center"
			};
			this.progressButton7.Options.cssClass = "e-flat e-success";

			//progressButton8
			this.progressButton8.Options.content = "Zoom In";
			this.progressButton8.Options.enableProgress = true;
			this.progressButton8.Options.animationSettings = new
			{
				effect = "ZoomIn"
			};
			this.progressButton8.Options.spinSettings = new
			{
				position = "Center"
			};
			this.progressButton8.Options.cssClass = "e-round-corner e-danger";

			//progressButton9
			this.progressButton9.Options.content = "Download";
			this.progressButton9.Options.duration = 4000;
			this.progressButton9.Options.enableProgress = true;
			this.progressButton9.Options.cssClass = "e-hide-spinner e-progress-top";
			this.progressButton9.Options.iconCss = "e-btn-sb-icons e-download-icon";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.progressButton8.Options.isToggle = this.checkBoxIsToggle.Checked;
			this.progressButton8.Options.duration = this.numericUpDownDuration.Value;
			this.progressButton8.Options.enableProgress = this.checkBoxProgress.Checked;

			this.progressButton8.Instance.refresh();
			this.progressButton8.Update();
		}
	}
}