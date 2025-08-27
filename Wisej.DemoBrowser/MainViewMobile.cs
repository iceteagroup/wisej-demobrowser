using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.DemoBrowser.Common;
using Wisej.Web;


namespace Wisej.DemoBrowser
{
	public partial class MainViewMobile : Page
	{
		private List<DemoView> viewStack = new List<DemoView>();

		public MainViewMobile()
		{
			InitializeComponent();
		}

		private void MainViewMobile_Load(object sender, EventArgs e)
		{
			SwitchView(typeof(DemosListView));
		}

		private void SwitchView(Type type, Core.DynamicObject config=null, string role=null, string name=null)
		{
			var newView = (MobileDemoView)Activator.CreateInstance(type, config, role, name);
			newView.ViewRequested += NewView_ViewRequested;

			this.viewStack.Add(newView);

			newView.Dock = DockStyle.Fill;

			if (this.panelContainer.Controls.Count > 0)
				this.panelContainer.Controls.Last().Hide();

			this.panelContainer.Controls.Add(newView);
		}

		private void NewView_ViewRequested(object sender, WidgetEventArgs e)
		{
			SwitchView(e.Data.type, e.Data.config, e.Data.role, e.Data.name);
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			if (this.viewStack.Count == 1)
				return;

			this.viewStack.Remove(this.viewStack.Last());

			this.panelContainer.Controls.Last().Dispose();
			this.panelContainer.Controls.Last().Show();
        }
	}
}
