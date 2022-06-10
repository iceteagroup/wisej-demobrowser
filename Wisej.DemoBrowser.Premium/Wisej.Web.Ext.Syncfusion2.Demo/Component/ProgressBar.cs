using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class ProgressBar : TestBase
	{
		public ProgressBar()
		{
			InitializeComponent();
		}

		private void ProgressBar_Load(object sender, EventArgs e)
		{
			this.progressBar1.Options.value = 70;
			this.progressBar1.Options.trackThickness = 15;
			this.progressBar1.Options.progressThickness = 15;
			this.progressBar1.Options.showProgressValue = true;
			this.progressBar1.Options.height = "30";
			this.progressBar1.Options.animation = new
			{
				enable = true,
				duration = 2000,
				delay = 0
			};
		}

		private void checkBoxAnimationEnable_CheckedChanged(object sender, EventArgs e)
		{
			this.numericUpDownAnimationDuration.Enabled = this.checkBoxAnimationEnable.Checked;
			this.numericUpDownAnimationDelay.Enabled = this.checkBoxAnimationEnable.Checked;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.progressBar1.Options.animation.enable = this.checkBoxAnimationEnable.Checked;
			this.progressBar1.Options.animation.delay = this.numericUpDownAnimationDelay.Value;
			this.progressBar1.Options.animation.duration = this.numericUpDownAnimationDuration.Value;

			this.progressBar1.Options.type = this.comboBoxType.Text;
			this.progressBar1.Options.isStriped = this.checkBoxIsIndeterminate.Checked;
			this.progressBar1.Options.isIndeterminate = this.checkBoxIsIndeterminate.Checked;
			this.progressBar1.Options.enablePieProgress = this.checkBoxIsIndeterminate.Checked;
			this.progressBar1.Options.enableProgressSegments = this.checkBoxIsIndeterminate.Checked;

			if (this.comboBoxType.Text == "Circular")
			{
				this.progressBar1.Options.width = "160px";
				this.progressBar1.Options.height = "160px";
			}

			this.progressBar1.Options.value = 70;
			this.progressBar1.Instance.refresh();
			this.progressBar1.Update();
		}
	}
}