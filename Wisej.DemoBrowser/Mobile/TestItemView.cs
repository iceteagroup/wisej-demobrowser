using Bogus.DataSets;
using Microsoft.Ajax.Utilities;
using System;
using Wisej.Web;

namespace Wisej.DemoBrowser
{
	public partial class TestItemView : Web.UserControl
	{
		private string name;

		private string role;

		private dynamic config;

        #region Constructors

        public TestItemView()
		{
			InitializeComponent();
		}

		public TestItemView(string name, dynamic config, string role)
		{
			InitializeComponent();

			this.role = role;
			this.name = name;
			this.config = config;
		}

        #endregion

        public event WidgetEventHandler ViewRequested;

        private void OnViewRequested(WidgetEventArgs e)
		{
			this.ViewRequested?.Invoke(this, e);
		}

		private void AppItem_Load(object sender, EventArgs e)
		{
			this.labelTitle.Text = name;
			this.pictureBoxIcon.ImageSource = config.imageSource ?? GetImageSource(config);

			PopulateContentLabels(this.config);
		}

		private void PopulateContentLabels(dynamic config)
		{
			switch (this.role)
			{
				case "category":
				case "control":
                    var i = 0;
                    foreach (Core.DynamicObject.Member entry in config)
                    {
                        this.flowLayoutPanelMain.Controls[$"labelContent{++i}"].Text = $"&bull; {entry.Name}";

                        if (i == 2)
                            return;
                    }
                    break;

				case "demo":
                    var culture = Application.CurrentCulture.TwoLetterISOLanguageName;
                    var description = config[$"description-{culture}"] ?? config["description-en"];

                    this.labelContent1.AutoSize = true;
					this.labelContent1.Text = description;
					break;
			}
        }

		private string GetImageSource(dynamic config)
		{
            foreach (Core.DynamicObject.Member entry in config)
			{
				string imageSource = ((dynamic)entry.Value).imageSource;
				if (imageSource != null)
				{
                    return imageSource;
                }
				else
				{
                    foreach (Core.DynamicObject.Member demo in (dynamic)entry.Value)
					{
						imageSource = ((dynamic)demo.Value).imageSource;
						return imageSource;
                    }
                }
            }

			return "";
        }

		private void AppItemView_Click(object sender, EventArgs e)
		{
			Type type = null;

			switch (this.role)
			{
				case "category":
				case "control":
					type = typeof(DemosListView);
					break;

				case "demo":
					type = typeof(MobileDemoView);
					break;
			}

			this.OnViewRequested(new WidgetEventArgs("ViewRequested", new 
			{
				type,
				this.config, 
				this.role,
				this.name,
			}));
		}
	}
}
