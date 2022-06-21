using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoStepper : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoStepper()
		{
			InitializeComponent();

			this.kendoStepper1.Instance.onSelect += new WidgetEventHandler(kendoStepper1_WidgetEvent);
		}
		private void kendoStepper_Load(object sender, EventArgs e)
		{
			this.kendoStepper1.Options.linear = false;
			this.kendoStepper1.Options.steps = new object[]
			{
				new
				{
					label = "Personal Info",
					icon = "user"
				},
				new
				{
					label = "Education",
					icon = "dictionary-add",
					error = true
				},
				new
				{
					label = "Experience",
					icon = "flip-vertical",
					selected = true
				},
				new
				{
					label = "Attachments",
					icon = "attachment"
				},
				new
				{
					label = "Review",
					icon = "preview",
					enabled = false
				},
				new
				{
					label = "Submit",
					icon = "file-add"
				}
			};

		}

		private void kendoStepper1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonAddStep_Click(object sender, EventArgs e)
		{
			await this.kendoStepper1.Instance.insertAtAsync(this.nudIndex.Value, new { label = this.textBoxStepName.Text });
		}
	}
}
