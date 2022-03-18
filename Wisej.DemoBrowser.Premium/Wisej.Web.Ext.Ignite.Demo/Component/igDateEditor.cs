using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igDateEditor : TestBase
	{
		public igDateEditor()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igDateEditor1.Options.buttonType = this.comboBox1.SelectedItem ?? "none";
			this.igDateEditor1.Options.selectionOnFocus = this.comboBox2.SelectedItem;
			this.igDateEditor1.Options.dataMode = this.comboBox3.SelectedItem;
			this.igDateEditor1.Options.revertIfNotValid = this.checkBox1.Checked;

			this.igDateEditor1.Update();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var data = await this.igDateEditor1.Instance.getSelectedDateAsync();

			AlertBox.Show(data.ToString());
		}
	}
}
