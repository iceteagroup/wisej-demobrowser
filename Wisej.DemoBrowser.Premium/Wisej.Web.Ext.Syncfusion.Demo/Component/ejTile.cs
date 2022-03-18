using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTile : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejTile()
		{
			InitializeComponent();

			ejTile1.Instance.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			ejTile2.Instance.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			ejTile3.Instance.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			ejTile4.Instance.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			ejTile5.Instance.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			ejTile6.Instance.mouseDown += new WidgetEventHandler(ejTile_WidgetEvent);

		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTile8.Options.allowSelection = this.checkBox2.Checked;
			this.ejTile8.Options.showRoundedCorner = this.checkBox3.Checked;
			this.ejTile8.Options.imagePosition = this.comboBox1.SelectedItem;
			this.ejTile8.Update();

			this.ejTile5.Options.badge = new {
				enabled = true,
				value = (int)this.numericUpDown1.Value
			};

			this.ejTile5.Update();


			this.ejTile1.Options.liveTile.enabled = this.checkBox1.Checked;
			this.ejTile6.Options.liveTile.enabled = this.checkBox1.Checked;
			this.ejTile1.Update();
			this.ejTile6.Update();


		}

		private void ejTile_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
