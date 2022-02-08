using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.AceEditor
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void checkBoxIndent_CheckedChanged(object sender, EventArgs e)
		{
			this.aceEditor1.DisplayIndentGuides = this.checkBoxIndent.Checked;
		}

		private void checkBoxGutter_CheckedChanged(object sender, EventArgs e)
		{
			this.aceEditor1.ShowGutter = this.checkBoxGutter.Checked;
		}

		private void checkBoxLineNumbers_CheckedChanged(object sender, EventArgs e)
		{
			this.aceEditor1.ShowLineNumbers = this.checkBoxLineNumbers.Checked;
		}

		private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.aceEditor1.Language = (string)this.comboBoxLanguage.SelectedItem;
		}

		private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.aceEditor1.Theme = (string)this.comboBoxTheme.SelectedItem;
		}

		private void checkBoxPrintMargin_CheckedChanged(object sender, EventArgs e)
		{
			this.aceEditor1.ShowPrintMargin = this.checkBoxPrintMargin.Checked;
		}
	}
}
