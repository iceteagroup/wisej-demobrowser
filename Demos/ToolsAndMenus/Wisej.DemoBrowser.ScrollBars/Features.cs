using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ScrollBars
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			AlertBox.Show($"Orientation: {e.ScrollOrientation}<br>Type: {e.Type}<br>Old: {e.OldValue}<br>New: {e.NewValue}");
		}

		private void Features_Load(object sender, EventArgs e)
		{
			foreach (var control in this.Controls)
			{
				var scroll = control as ScrollBar ?? null;
				if (scroll != null)
					scroll.Scroll += ScrollBar_Scroll;
			}
		}
	}
}
