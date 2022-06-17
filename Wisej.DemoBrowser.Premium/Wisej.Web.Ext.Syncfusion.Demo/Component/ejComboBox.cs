using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejComboBox : TestBase
	{
		public ejComboBox()
		{
			InitializeComponent();

			this.ejComboBox1.Instance.onOpen += new WidgetEventHandler(ejComboBox1_WidgetEvent);
			this.ejComboBox1.Instance.onSelect += new WidgetEventHandler(ejComboBox1_WidgetEvent);
			this.ejComboBox1.Instance.onCustomValueSpecifier += new WidgetEventHandler(ejComboBox1_WidgetEvent);
		}

		private void ejComboBox_Load(object sender, EventArgs e)
		{
			this.ejComboBox1.Options.autofill = true;
			this.ejComboBox1.Options.fields = new
			{
				text = "game",
				value = "id"
			};
			this.ejComboBox1.Options.placeholder = "Select a game";
			this.ejComboBox1.Options.index = -1;
			this.ejComboBox1.Options.popupHeight = "200px";
			this.ejComboBox1.Options.popupWidth = "250px";
			this.ejComboBox1.Options.dataSource = new object[]
			{
				new
				{
					id = "level1",
					game = "American Football"
				},
				new
				{
					id = "level2",
					game = "Badminton"
				},
				new
				{
					id = "level3",
					game = "Basketball"
				},
				new
				{
					id = "level4",
					game = "Cricket"
				},
				new
				{
					id = "level5",
					game = "Football"
				},
				new
				{
					id = "level6",
					game = "Golf"
				},
				new
				{
					id = "level7",
					game = "Hockey"
				},
				new
				{
					id = "level8",
					game = "Rugby"
				},
				new
				{
					id = "level9",
					game = "Snooker"
				},
				new
				{
					id = "level10",
					game = "Tennis"
				}
			};
			this.ejComboBox1.Options.value = "";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejComboBox1.Options.autofill = this.checkBoxAutofill.Checked;
			this.ejComboBox1.Options.showClearButton = this.checkBoxShowClearButton.Checked;

			this.ejComboBox1.Update();
		}

		private void ejComboBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}