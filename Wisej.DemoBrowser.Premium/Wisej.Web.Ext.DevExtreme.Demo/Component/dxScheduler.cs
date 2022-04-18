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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

			this.comboBoxCurrentView.SelectedIndex = 2;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.dxScheduler1.Options.editing.allowAdding = this.comboBoxCurrentView.Text;
			this.dxScheduler1.Options.editing.allowDragging = this.comboBoxCurrentView.Text;
			this.dxScheduler1.Options.editing.allowResizing = this.comboBoxCurrentView.Text;
			this.dxScheduler1.Options.editing.allowUpdating = this.comboBoxCurrentView.Text;
			this.dxScheduler1.Options.editing.allowDeleting = this.comboBoxCurrentView.Text;
			this.dxScheduler1.Options.editing.allowTimeZoneEditing = this.comboBoxCurrentView.Text;
			this.dxScheduler1.Options.currentView = this.comboBoxCurrentView.SelectedItem.ToString();

			this.dxScheduler1.Update();
        }
    }
}
