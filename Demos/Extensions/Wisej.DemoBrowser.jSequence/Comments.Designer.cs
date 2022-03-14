namespace Wisej.DemoBrowser.jSequence
{
	partial class Comments
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.sequence = new Wisej.Web.Ext.jSequence.Sequence();
            this.txtUml = new Wisej.Web.TextBox();
            this.btnUpdate = new Wisej.Web.Button();
            this.cmbThemes = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // sequence
            // 
            this.sequence.Anchor = Wisej.Web.AnchorStyles.None;
            this.sequence.CssStyle = "overflow: visible;";
            this.sequence.Location = new System.Drawing.Point(727, 51);
            this.sequence.Name = "sequence";
            this.sequence.Size = new System.Drawing.Size(439, 372);
            this.sequence.TabIndex = 8;
            this.sequence.Text = "sequence4";
            this.sequence.UML = "# Example of a comment.\nNote left of A: Note to the\\n left of A\nNote right of A: " +
    "Note to the\\n right of A\nNote over A: Note over A\nNote over A,B: Note over both " +
    "A and B";
            // 
            // txtUml
            // 
            this.txtUml.AcceptsReturn = true;
            this.txtUml.AcceptsTab = true;
            this.txtUml.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtUml.LabelText = "UML ";
            this.txtUml.Location = new System.Drawing.Point(256, 143);
            this.txtUml.Multiline = true;
            this.txtUml.Name = "txtUml";
            this.txtUml.Size = new System.Drawing.Size(390, 206);
            this.txtUml.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(256, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(390, 35);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbThemes
            // 
            this.cmbThemes.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbThemes.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbThemes.Items.AddRange(new object[] {
            "Simple",
            "Hand"});
            this.cmbThemes.LabelText = "Themes";
            this.cmbThemes.Location = new System.Drawing.Point(256, 84);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(390, 57);
            this.cmbThemes.TabIndex = 9;
            // 
            // Comments
            // 
            this.Controls.Add(this.sequence);
            this.Controls.Add(this.txtUml);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbThemes);
            this.MinimumSize = new System.Drawing.Size(978, 340);
            this.Name = "Comments";
            this.Load += new System.EventHandler(this.Comments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Ext.jSequence.Sequence sequence;
		private Web.TextBox txtUml;
		private Web.Button btnUpdate;
		private Web.ComboBox cmbThemes;
	}
}
