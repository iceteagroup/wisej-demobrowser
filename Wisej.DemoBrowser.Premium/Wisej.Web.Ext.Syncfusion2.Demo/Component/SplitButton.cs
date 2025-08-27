using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class SplitButton : TestBase
	{
		public SplitButton()
		{
			InitializeComponent();

			this.splitButton1.Instance.onClick += new WidgetEventHandler(splitButton1_WidgetEvent);
			this.splitButton1.Instance.onSelect += new WidgetEventHandler(splitButton1_WidgetEvent);
		}

		private void SplitButton_Load(object sender, EventArgs e)
		{
			this.splitButton1.Options.items = new object[]
			{
				new
				{
					text = "Paste",
					iconCss = "e-btn-icons e-paste"
				},
				new
				{
					text = "Paste Special",
					iconCss = "e-btn-icons e-paste-special"
				},
				new
				{
					text = "Paste as Formula",
					iconCss = "e-btn-icons e-paste-formula"
				},
				new
				{
					text = "Paste as Hyperlink",
					iconCss = "e-btn-icons e-paste-hyperlink"
				}
			};
			this.splitButton1.Options.content = "Paste";
		}

		private void splitButton1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.splitButton1.Options.disabled = this.checkBoxDisabled.Checked;

			this.splitButton1.Update();
		}
	}
}