using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.jSequence;

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

        private void navItem1_Click(object sender, EventArgs e)
        {
            sequence.UML = @"Andrew->Alex: Says Hello
Note right of Alex: Alex thinks about it
Alex-->Andrew: How are you?
Andrew->>Alex: I am good thanks!";
            txtUml.Text = sequence.UML;
        }

        private void navItem2_Click(object sender, EventArgs e)
        {
            sequence.UML = @"Title: Here is a title
A->B: Normal line
B-->C: Dashed line
C->>D: Open arrow
D-->>A: Dashed open arrow";
            txtUml.Text = sequence.UML;
        }

        private void navItem3_Click(object sender, EventArgs e)
        {
            sequence.UML = @"# Example of a comment.
Note left of A: Note to the\n left of A
Note right of A: Note to the\n right of A
Note over A: Note over A
Note over A,B: Note over both A and B";
            txtUml.Text = sequence.UML;
        }

        private void navItem4_Click(object sender, EventArgs e)
        {
            sequence.UML = @"participant C
participant B
participant A
Note right of A: By listing the participants\n you can change their order";
            txtUml.Text = sequence.UML;
        }
    }
}
