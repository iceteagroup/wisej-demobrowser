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
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.flowLayoutPanelExamples.SuspendLayout();
            this.SuspendLayout();
            // 
            // sequence
            // 
            this.sequence.Anchor = Wisej.Web.AnchorStyles.None;
            this.sequence.Location = new System.Drawing.Point(680, 55);
            this.sequence.Name = "sequence";
            this.sequence.Size = new System.Drawing.Size(550, 364);
            this.sequence.TabIndex = 3;
            this.sequence.Text = "sequence4";
            this.sequence.UML = "Andrew->Alex: Says Hello\r\nNote right of Alex: Alex thinks about it\r\nAlex-->Andrew" +
    ": How are you?\r\nAndrew->>Alex: I am good thanks!";
            // 
            // cmbThemes
            // 
            this.cmbThemes.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbThemes.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbThemes.Items.AddRange(new object[] {
            "Simple",
            "Hand"});
            this.cmbThemes.LabelText = "Themes";
            this.cmbThemes.Location = new System.Drawing.Point(192, 67);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(437, 42);
            this.cmbThemes.TabIndex = 5;
            this.cmbThemes.SelectedIndexChanged += new System.EventHandler(this.cmbThemes_SelectedIndexChanged);
            // 
            // txtUml
            // 
            this.txtUml.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtUml.LabelText = "UML ";
            this.txtUml.Location = new System.Drawing.Point(192, 145);
            this.txtUml.Multiline = true;
            this.txtUml.Name = "txtUml";
            this.txtUml.Size = new System.Drawing.Size(437, 207);
            this.txtUml.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(335, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 35);
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
            this.flowLayoutPanelExamples.Controls.Add(this.button1);
            this.flowLayoutPanelExamples.Controls.Add(this.button2);
            this.flowLayoutPanelExamples.Controls.Add(this.button3);
            this.flowLayoutPanelExamples.Controls.Add(this.button4);
            this.flowLayoutPanelExamples.CssStyle = "border-right: 1px solid #E5E8E9;";
            this.flowLayoutPanelExamples.Dock = Wisej.Web.DockStyle.Left;
            this.flowLayoutPanelExamples.HeaderPosition = Wisej.Web.HeaderPosition.Left;
            this.flowLayoutPanelExamples.HeaderSize = 40;
            this.flowLayoutPanelExamples.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelExamples.Name = "flowLayoutPanelExamples";
            this.flowLayoutPanelExamples.Padding = new Wisej.Web.Padding(16, 0, 0, 0);
            this.flowLayoutPanelExamples.RestoreBounds = new System.Drawing.Rectangle(0, 0, 232, 474);
            this.flowLayoutPanelExamples.ShowHeader = true;
            this.flowLayoutPanelExamples.Size = new System.Drawing.Size(40, 474);
            this.flowLayoutPanelExamples.TabIndex = 8;
            this.flowLayoutPanelExamples.Text = "Examples";
            // 
            // button1
            // 
            this.button1.AppearanceKey = "button-demo";
            this.flowLayoutPanelExamples.SetFillWeight(this.button1, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.button1, true);
            this.button1.Focusable = false;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageSource = "icon-right";
            this.button1.Location = new System.Drawing.Point(19, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Default";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.AppearanceKey = "button-demo";
            this.flowLayoutPanelExamples.SetFillWeight(this.button2, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.button2, true);
            this.button2.Focusable = false;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageSource = "icon-right";
            this.button2.Location = new System.Drawing.Point(19, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Diagram with a title";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.AppearanceKey = "button-demo";
            this.flowLayoutPanelExamples.SetFillWeight(this.button3, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.button3, true);
            this.button3.Focusable = false;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageSource = "icon-right";
            this.button3.Location = new System.Drawing.Point(19, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Diagram with comments";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.AppearanceKey = "button-demo";
            this.flowLayoutPanelExamples.SetFillWeight(this.button4, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.button4, true);
            this.button4.Focusable = false;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageSource = "icon-right";
            this.button4.Location = new System.Drawing.Point(19, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Participants showcase";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.flowLayoutPanelExamples);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUml);
            this.Controls.Add(this.cmbThemes);
            this.Controls.Add(this.sequence);
            this.MinimumSize = new System.Drawing.Size(978, 340);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.flowLayoutPanelExamples.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Web.Ext.jSequence.Sequence sequence;
        private Web.ComboBox cmbThemes;
        private Web.TextBox txtUml;
        private Web.Button btnUpdate;
		private Web.FlowLayoutPanel flowLayoutPanelExamples;
		private Web.Button button1;
		private Web.Button button2;
		private Web.Button button3;
		private Web.Button button4;
	}
}
