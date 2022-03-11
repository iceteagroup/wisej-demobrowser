using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.jSequence
{
	public partial class Comments : DemoView
	{
		public Comments()
		{
			InitializeComponent();
		}

		private void Comments_Load(object sender, EventArgs e)
		{
			txtUml.Text = sequence.UML;
			cmbThemes.SelectedIndex = 1;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			this.sequence.UML = this.txtUml.Text;
		}
	}
}
