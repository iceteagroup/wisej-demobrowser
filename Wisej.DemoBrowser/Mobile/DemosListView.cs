using Microsoft.Ajax.Utilities;
using System;
using System.IO;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace Wisej.DemoBrowser
{
	public partial class DemosListView : MobileDemoView
    {
        private string role = null;

        private dynamic config = null;

		public DemosListView()
		{
			InitializeComponent();
		}

        public DemosListView(Core.DynamicObject config=null, string role=null, string name=null)
        {
            InitializeComponent();

			this.role = role;
			this.config = config;

			if (!String.IsNullOrEmpty(name))
				this.labelTitle.Text = name;
        }

        private int _itemWidth;

		private void DemosListView_Load(object sender, EventArgs e)
		{
			// ScreenSize is different on Android vs. iOS.
			var screenSize = Application.Browser.ScreenSize;
			var screenWidth = Math.Min(screenSize.Width, screenSize.Height);
			
			this._itemWidth = (screenWidth - 32) / 2 - 20;

			if (this.role == null)
			{
                PopulateCategoriesList();
            }
			else
			{
				switch (this.role)
				{
					case "category":
						PopulateControlsList(this.config);
						break;

					case "control":
						PopulateDemosList(this.config);
						break;
				}
			}
				
		}

		private void DemoNode_ViewRequested(object sender, WidgetEventArgs e)
		{
            this.OnViewRequested(e);
        }

		private void PopulateCategoriesList()
		{
			var text = File.ReadAllText(Path.Combine(Application.MapPath("DemoBrowser.json")));
			var data = Core.WisejSerializer.Parse(text);

			this.flowLayoutPanelDemos.Controls.Clear();
			foreach (Core.DynamicObject.Member category in data)
			{
				var demoNode = new TestItemView(category.Name, category.Value, "category")
				{
					Width = this._itemWidth
				};
				demoNode.ViewRequested += DemoNode_ViewRequested;

				this.flowLayoutPanelDemos.Controls.Add(demoNode);
			}
		}

		private void PopulateControlsList(dynamic config)
		{
			this.flowLayoutPanelDemos.Controls.Clear();
			foreach (Core.DynamicObject.Member control in config)
			{
				if (control.Name == "Overview")
				{
					var categoryOverview = (dynamic) control.Value;
                    var culture = Application.CurrentCulture.TwoLetterISOLanguageName;
                    var description = categoryOverview[$"description-{culture}"] ?? categoryOverview["description-en"];

					this.labelDescription.Text = description;

					continue;
				}

				var demoNode = new TestItemView(control.Name, control.Value, "control")
				{
					Width = this._itemWidth
				};
				demoNode.ViewRequested += DemoNode_ViewRequested;

				this.flowLayoutPanelDemos.Controls.Add(demoNode);
			}
		}

		private void PopulateDemosList(dynamic config)
		{
			var overview = config["Features"];
            var culture = Application.CurrentCulture.TwoLetterISOLanguageName;
            var description = overview[$"description-{culture}"] ?? overview["description-en"];

			this.labelDescription.Text = description;

            this.flowLayoutPanelDemos.Controls.Clear();

            foreach (Core.DynamicObject.Member demo in config)
			{
                var demoNode = new TestItemView(demo.Name, demo.Value, "demo")
				{
					Width = this._itemWidth
				};
				demoNode.ViewRequested += DemoNode_ViewRequested;

				this.flowLayoutPanelDemos.Controls.Add(demoNode);
			}
		}

		private void flowLayoutPanelApps_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.NewValue == 0)
				this.Maximize();
			else
				this.Minimize();
		}
	}
}
