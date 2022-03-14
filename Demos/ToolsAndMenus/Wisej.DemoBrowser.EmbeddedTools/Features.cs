using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.EmbeddedTools
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Tool_Click(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show("Tool Clicked");
		}

		private bool _checked = false;

		private void checkedListBox1_ToolClick(object sender, ToolClickEventArgs e)
		{
			if (!_checked)
			{
				checkedListBox1.Tools[0].ToolTipText = "Check All";
				checkedListBox1.Tools[0].ImageSource = "checkbox";
				_checked = true;

				for (int i = 0; i < checkedListBox1.Items.Count; i++)
				{
					checkedListBox1.SetItemCheckState(i,CheckState.Checked);
				}

				AlertBox.Show("Checked All Items");
			}
			else
			{
				checkedListBox1.Tools[0].ToolTipText = "Uncheck All";
				checkedListBox1.Tools[0].ImageSource = "checkbox-checked";
				_checked = false;

				for (int i = 0; i < checkedListBox1.Items.Count; i++)
				{
					checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
				}

				AlertBox.Show("Unchecked All Items");
			}
		}

		private void comboBox1_ToolClick(object sender, ToolClickEventArgs e)
		{
			if (comboBox1.SelectedIndex > -1) AlertBox.Show($"Selected Item is: {comboBox1.Text}");
		}

		private void Features_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
		}
	}
}