namespace Wisej.DemoBrowser.jSequence
{
    partial class Features
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
            this.cmbThemes = new Wisej.Web.ComboBox();
            this.txtUml = new Wisej.Web.TextBox();
            this.btnUpdate = new Wisej.Web.Button();
            this.flowLayoutPanelExamples = new Wisej.Web.FlowLayoutPanel();
            this.btnDefault = new Wisej.Web.Button();
            this.btnTitle = new Wisej.Web.Button();
            this.btnComments = new Wisej.Web.Button();
            this.btnParticipants = new Wisej.Web.Button();
            this.flowLayoutPanelExamples.SuspendLayout();
            this.SuspendLayout();
            // 
            // sequence
            // 
            this.sequence.Anchor = Wisej.Web.AnchorStyles.None;
            this.sequence.BackColor = System.Drawing.Color.White;
            this.sequence.Location = new System.Drawing.Point(368, 37);
            this.sequence.Name = "sequence";
            this.sequence.Size = new System.Drawing.Size(687, 401);
            this.sequence.TabIndex = 3;
            this.sequence.Text = "sequence4";
            this.sequence.UML = "Andrew->Alex: Says Hello\r\nNote right of Alex: Alex thinks about it\r\nAlex-->Andrew" +
    ": How are you?\r\nAndrew->>Alex: I am good thanks!";
            // 
            // cmbThemes
            // 
            this.cmbThemes.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbThemes.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanelExamples.SetFillWeight(this.cmbThemes, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.cmbThemes, true);
            this.cmbThemes.Items.AddRange(new object[] {
            "Simple",
            "Hand"});
            this.cmbThemes.LabelText = "Themes";
            this.cmbThemes.Location = new System.Drawing.Point(19, 175);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(218, 53);
            this.cmbThemes.TabIndex = 5;
            this.cmbThemes.SelectedIndexChanged += new System.EventHandler(this.cmbThemes_SelectedIndexChanged);
            // 
            // txtUml
            // 
            this.txtUml.Anchor = Wisej.Web.AnchorStyles.None;
            this.flowLayoutPanelExamples.SetFillWeight(this.txtUml, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.txtUml, true);
            this.txtUml.LabelText = "UML ";
            this.txtUml.Location = new System.Drawing.Point(19, 234);
            this.txtUml.Multiline = true;
            this.txtUml.Name = "txtUml";
            this.txtUml.Size = new System.Drawing.Size(218, 158);
            this.txtUml.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = Wisej.Web.AnchorStyles.None;
            this.flowLayoutPanelExamples.SetFillWeight(this.btnUpdate, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.btnUpdate, true);
            this.btnUpdate.Location = new System.Drawing.Point(19, 398);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(218, 35);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // flowLayoutPanelExamples
            // 
            this.flowLayoutPanelExamples.AppearanceKey = "panel-demo";
            this.flowLayoutPanelExamples.AutoShow = Wisej.Web.PanelAutoShowMode.OnPointerOver;
            this.flowLayoutPanelExamples.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanelExamples.Collapsed = true;
            this.flowLayoutPanelExamples.CollapseSide = Wisej.Web.HeaderPosition.Left;
            this.flowLayoutPanelExamples.Controls.Add(this.btnDefault);
            this.flowLayoutPanelExamples.Controls.Add(this.btnTitle);
            this.flowLayoutPanelExamples.Controls.Add(this.btnComments);
            this.flowLayoutPanelExamples.Controls.Add(this.btnParticipants);
            this.flowLayoutPanelExamples.Controls.Add(this.cmbThemes);
            this.flowLayoutPanelExamples.Controls.Add(this.txtUml);
            this.flowLayoutPanelExamples.Controls.Add(this.btnUpdate);
            this.flowLayoutPanelExamples.CssStyle = "border-right: 1px solid #E5E8E9;";
            this.flowLayoutPanelExamples.Dock = Wisej.Web.DockStyle.Left;
            this.flowLayoutPanelExamples.HeaderPosition = Wisej.Web.HeaderPosition.Left;
            this.flowLayoutPanelExamples.HeaderSize = 40;
            this.flowLayoutPanelExamples.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelExamples.Name = "flowLayoutPanelExamples";
            this.flowLayoutPanelExamples.Padding = new Wisej.Web.Padding(16, 0, 0, 0);
            this.flowLayoutPanelExamples.RestoreBounds = new System.Drawing.Rectangle(0, 0, 280, 474);
            this.flowLayoutPanelExamples.ShowHeader = true;
            this.flowLayoutPanelExamples.Size = new System.Drawing.Size(40, 474);
            this.flowLayoutPanelExamples.TabIndex = 8;
            this.flowLayoutPanelExamples.Text = "Configuration";
            // 
            // btnDefault
            // 
            this.btnDefault.AppearanceKey = "button-demo";
            this.btnDefault.CharacterCasing = Wisej.Web.CharacterCasing.Capitalize;
            this.flowLayoutPanelExamples.SetFillWeight(this.btnDefault, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.btnDefault, true);
            this.btnDefault.Focusable = false;
            this.btnDefault.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefault.ImageSource = "icon-right";
            this.btnDefault.Location = new System.Drawing.Point(19, 3);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(218, 37);
            this.btnDefault.TabIndex = 0;
            this.btnDefault.Text = "Default";
            this.btnDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefault.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.AppearanceKey = "button-demo";
            this.btnTitle.CharacterCasing = Wisej.Web.CharacterCasing.Capitalize;
            this.flowLayoutPanelExamples.SetFillWeight(this.btnTitle, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.btnTitle, true);
            this.btnTitle.Focusable = false;
            this.btnTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.ImageSource = "icon-right";
            this.btnTitle.Location = new System.Drawing.Point(19, 46);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(218, 37);
            this.btnTitle.TabIndex = 1;
            this.btnTitle.Text = "Title Showcase";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.Click += new System.EventHandler(this.button_Click);
            // 
            // btnComments
            // 
            this.btnComments.AppearanceKey = "button-demo";
            this.btnComments.CharacterCasing = Wisej.Web.CharacterCasing.Capitalize;
            this.flowLayoutPanelExamples.SetFillWeight(this.btnComments, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.btnComments, true);
            this.btnComments.Focusable = false;
            this.btnComments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComments.ImageSource = "icon-right";
            this.btnComments.Location = new System.Drawing.Point(19, 89);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(218, 37);
            this.btnComments.TabIndex = 2;
            this.btnComments.Text = "Comments showcase";
            this.btnComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComments.Click += new System.EventHandler(this.button_Click);
            // 
            // btnParticipants
            // 
            this.btnParticipants.AppearanceKey = "button-demo";
            this.btnParticipants.CharacterCasing = Wisej.Web.CharacterCasing.Capitalize;
            this.flowLayoutPanelExamples.SetFillWeight(this.btnParticipants, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.btnParticipants, true);
            this.btnParticipants.Focusable = false;
            this.btnParticipants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParticipants.ImageSource = "icon-right";
            this.btnParticipants.Location = new System.Drawing.Point(19, 132);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(218, 37);
            this.btnParticipants.TabIndex = 3;
            this.btnParticipants.Text = "Participants showcase";
            this.btnParticipants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParticipants.Click += new System.EventHandler(this.button_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.sequence);
            this.Controls.Add(this.flowLayoutPanelExamples);
            this.MinimumSize = new System.Drawing.Size(978, 340);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.flowLayoutPanelExamples.ResumeLayout(false);
            this.flowLayoutPanelExamples.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Web.Ext.jSequence.Sequence sequence;
        private Web.ComboBox cmbThemes;
        private Web.TextBox txtUml;
        private Web.Button btnUpdate;
		private Web.FlowLayoutPanel flowLayoutPanelExamples;
		private Web.Button btnDefault;
		private Web.Button btnTitle;
		private Web.Button btnComments;
		private Web.Button btnParticipants;
	}
}
