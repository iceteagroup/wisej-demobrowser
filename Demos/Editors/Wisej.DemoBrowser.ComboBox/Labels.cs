using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ComboBox
{
	public partial class Labels : DemoView
	{
		public Labels()
		{
			InitializeComponent();
		}

		private void Labels_Load(object sender, EventArgs e)
		{
			foreach (var control in this.Controls)
			{
				var combobox = control as Web.ComboBox ?? null;
				if (combobox != null)
				{
					combobox.DataSource = new[]
					{
						"New York City",
						"Chicago",
						"Washington DC",
						"London",
						"Berlin",
						"Rome",
						"Hannover"
					};
					combobox.SelectedIndex = -1;
				}
			}
		}
	}
}
