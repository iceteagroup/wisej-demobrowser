using System;
using Wisej.DemoBrowser.Common;

namespace Wisej.DemoBrowser.jSequence
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			txtUml.Text = sequence.UML;
			cmbThemes.SelectedIndex = 1;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (txtUml.Text == "") return;
			sequence.UML = txtUml.Text;
		}

		private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
		{
			sequence.Theme = cmbThemes.Text;
		}
	}
}
