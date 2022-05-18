using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxLookup : TestBase
	{
		public dxLookup()
		{
			InitializeComponent();
		}

		private void dxLookup1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxLookup1.Options.isValid = this.checkBox4.Checked;
			this.dxLookup1.Options.searchEnabled = this.checkBox5.Checked;
			this.dxLookup1.Options.closeOnOutsideClick = this.checkBox3.Checked;
			this.dxLookup1.Options.applyValueMode = this.comboBox1.SelectedItem;
			this.dxLookup1.Options.cleanSearchOnOpening = this.checkBox2.Checked;

			this.dxLookup1.Update();
		}

        private void dxLookup_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;
		}
	}
}
