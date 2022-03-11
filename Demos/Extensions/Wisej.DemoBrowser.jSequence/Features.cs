using System;
using System.Drawing;
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

			_selectedButton = btnDefault;
			SelectButton(btnDefault);
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

		private void LoadDefault()
		{
			sequence.UML = @"Andrew->Alex: Says Hello
Note right of Alex: Alex thinks about it
Alex-->Andrew: How are you?
Andrew->>Alex: I am good thanks!";
			txtUml.Text = sequence.UML;
		}

		private void LoadTitle()
		{
			sequence.UML = @"Title: Here is a title
A->B: Normal line
B-->C: Dashed line
C->>D: Open arrow
D-->>A: Dashed open arrow";
			txtUml.Text = sequence.UML;
		}

		private void LoadComment()
		{
			sequence.UML = @"# Example of a comment.
Note left of A: Note to the\n left of A
Note right of A: Note to the\n right of A
Note over A: Note over A
Note over A,B: Note over both A and B";
			txtUml.Text = sequence.UML;
		}

		private void LoadParticipant()
		{
			sequence.UML = @"participant C
participant B
participant A
Note right of A: By listing the participants\n you can change their order";
			txtUml.Text = sequence.UML;
		}

		private void button_Click(object sender, EventArgs e)
		{
			var button = (Button)sender;
			switch (button.Text)
			{
				case "Title Showcase":
					LoadTitle();
					break;

				case "Comments showcase":
					LoadComment();
					break;

				case "Participants showcase":
					LoadParticipant();
					break;

				default:
					LoadDefault();
					break;
			}

			if (this._selectedButton != null)
				UnselectButton(this._selectedButton);

			this._selectedButton = button;

			SelectButton(button);
		}
		private Button _selectedButton;
		
		private void SelectButton(Button button)
		{
			button.ForeColor = Color.FromArgb(0,56,160);
		}

		private void UnselectButton(Button button)
		{
			button.ForeColor = Color.Black;
		}
	}
}
