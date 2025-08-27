using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.MonthCalendar
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			AlertBox.Show($"Dates Changed {e.Start} - {e.End}");
		}
	}
}
