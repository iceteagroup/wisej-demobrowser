using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxHtmlEditor : TestBase
	{
		public dxHtmlEditor()
		{
			InitializeComponent();

			this.dxHtmlEditor1.Instance.valueChanged += new WidgetEventHandler(dxHtmlEditor1_WidgetEvent);
		}

		private void dxHtmlEditor1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxHtmlEditor1.Options.valueType = this.comboBox1.SelectedItem;
			this.dxHtmlEditor1.Options.isValid = this.checkBox1.Checked;
			this.dxHtmlEditor1.Options.toolbar = new
			{
				items = this.checkedListBox1.CheckedItems
			};
			this.dxHtmlEditor1.Options.mediaResizing = new
			{
				enabled = this.checkBox2.Checked
			};

			this.dxHtmlEditor1.Update();
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
