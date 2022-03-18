using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejAutocomplete : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejAutocomplete()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var selectedVal = await this.ejAutocomplete1.Instance.getValueAsync();

			AlertBox.Show(selectedVal);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejAutocomplete1.Options.autoFocus = this.checkBox1.Checked;
			this.ejAutocomplete1.Options.caseSensitiveSearch = this.checkBox2.Checked;
			this.ejAutocomplete1.Options.highlightSearch = this.checkBox3.Checked;
			this.ejAutocomplete1.Options.showEmptyResultText = this.checkBox4.Checked;
			this.ejAutocomplete1.Options.showResetIcon = this.checkBox5.Checked;
			this.ejAutocomplete1.Options.showPopupButton = this.checkBox6.Checked;

			this.ejAutocomplete1.Update();
		}
	}
}
