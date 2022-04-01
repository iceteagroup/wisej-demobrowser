using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.TourPanel;

namespace Wisej.DemoBrowser.TourPanel
{
	public partial class Features : DemoView
	{

		private Wisej.Web.Ext.TourPanel.TourPanel tourPanel;

		public Features()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AlertBox.Show("Clicked");
		}

		private void buttonStartTour_Click(object sender, EventArgs e)
		{
			this.tourPanel = new Web.Ext.TourPanel.TourPanel();
			this.tourPanel.Steps = GetSteps();
			this.tourPanel.AutoPlay = true;

            this.tourPanel.Ended += TourPanel_Ended;

			this.tourPanel.Show();
		}

        private void TourPanel_Ended(object sender, EventArgs e)
        {
			AlertBox.Show("The tour has completed.");
        }

        private TourStep[] GetSteps()
        {
			return new[]
			{
				new TourStep
				{
					Title = "Button",
					Text = "This is the <b>Wisej.Web.Button</b>. A Button can be clicked by using the mouse, ENTER key, or SPACEBAR if the button has focus.",
					Target = this.button
				},
				new TourStep
				{
					Title = "Calendar",
					Text = "This is the <b>Wisej.Web.MonthCalendar</b>.The MonthCalendar control allows the user to select a date using a visual display.",
					Target = this.monthCalendar1
				},
				new TourStep
				{
					Title = "ComboBox",
					Text = "This is the <b>Wisej.Web.ComboBox</b>.The ComboBox control displays a text box combined with a ListBox, which enables the user to select items from the list or enter a new value.",
					Target = this.comboBox1
				},
				new TourStep
				{
					Title = "TextBox",
					Text = "This is the <b>Wisej.Web.TextBox</b>.The TextBox control allows the user to enter unformatted text in an application.",
					Target = this.textBox1
				},
				new TourStep
				{
					Title = "Demo",
					Text = "This is the demo container.",
					Target = this
				},
				new TourStep
				{
					Title = "Demos",
					Text = "This is the list of demos.",
					Target = Application.MainPage.Controls["panelComponents"]
                }
			};
		}
    }
}
