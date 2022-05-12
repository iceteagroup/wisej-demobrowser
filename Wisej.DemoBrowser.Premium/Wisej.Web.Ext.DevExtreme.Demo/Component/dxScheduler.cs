using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxScheduler : TestBase
	{
		public dxScheduler()
		{
			InitializeComponent();

			this.dxScheduler1.Instance.onAppointmentClick += new WidgetEventHandler(dxScheduler1_WidgetEvent);
			this.dxScheduler1.Instance.onAppointmentAdded += new WidgetEventHandler(dxScheduler1_WidgetEvent);
			this.dxScheduler1.Instance.onAppointmentDeleted += new WidgetEventHandler(dxScheduler1_WidgetEvent);
		}

		private void dxScheduler1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.dxScheduler1.Options.currentView = this.comboBoxCurrentView.SelectedItem;
			this.dxScheduler1.Options.editing.allowAdding = this.checkBoxAllowAdding.Checked;
			this.dxScheduler1.Options.editing.allowUpdating = this.checkBoxAllowUpdating.Text;
			this.dxScheduler1.Options.editing.allowDragging = this.checkBoxAllowDragging.Checked;
			this.dxScheduler1.Options.editing.allowResizing = this.checkBoxAllowResizing.Checked;
			this.dxScheduler1.Options.editing.allowDeleting = this.checkBoxAllowDeleting.Checked;

			this.dxScheduler1.Update();
        }

        private void dxScheduler_Load(object sender, EventArgs e)
        {
			this.comboBoxCurrentView.SelectedIndex = 2;
		}
	}
}
