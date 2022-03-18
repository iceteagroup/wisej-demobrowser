using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Kanban : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public Kanban()
		{
			InitializeComponent();

			this.kanban1.Instance.cardClick += new WidgetEventHandler(kanban1_WidgetEvent);
			this.kanban1.Instance.dataSourceChanged += new WidgetEventHandler(kanban1_WidgetEvent);
		}

		private void kanban1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
        {

			this.kanban1.Options.allowKeyboard = this.checkBoxKeyboard.Checked;
			this.kanban1.Options.showEmptyColumn = this.checkBoxEmptyColumn.Checked;
			this.kanban1.Options.allowDragAndDrop = this.checkBoxDragAndDrop.Checked;
			for (int i=0;i<4;i++)
				this.kanban1.Options.columns[i].allowToggle = this.checkBoxColumnToggle.Checked;

			this.kanban1.Update();
        }
    }
}
