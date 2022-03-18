using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxFileManager : TestBase
	{
		public dxFileManager()
		{
			InitializeComponent();

			this.dxFileManager1.Instance.selectedFileOpened += new WidgetEventHandler(dxFileManager1_WidgetEvent);

			this.dxFileManager1.Instance.currentDirectoryChanged += new WidgetEventHandler(dxFileManager1_WidgetEvent);
		}

		private void dxFileManager1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			// Guarantees the existence of Options.itemView.
			this.dxFileManager1.Options.itemView = new { mode = this.comboBox1.SelectedItem, showFolders = this.checkBox1.Checked };
			this.dxFileManager1.Options.allowedFileExtensions = checkedListBox1.CheckedItems;
			this.dxFileManager1.Options.activeStateEnabled = this.checkBox2.Checked;

			this.dxFileManager1.Update();
		}

		private void checkedListBox1_AfterItemCheck(object sender, ItemCheckEventArgs e)
		{
			var comboString = "";
			foreach (var checkedItem in checkedListBox1.CheckedItems)
			{
				comboString += $"{checkedItem}, ";
			}
			this.userComboBox1.Text = comboString;
		}
	}
}
