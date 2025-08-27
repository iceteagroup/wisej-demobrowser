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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            this.sequence = new Wisej.Web.Ext.jSequence.Sequence();
            this.cmbThemes = new Wisej.Web.ComboBox();
            this.txtUml = new Wisej.Web.TextBox();
            this.btnUpdate = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sequence
            // 
            this.sequence.Anchor = Wisej.Web.AnchorStyles.None;
            this.sequence.CssStyle = "overflow: visible;";
            this.flowLayoutPanel1.SetFillWeight(this.sequence, 1);
            this.sequence.Location = new System.Drawing.Point(644, 3);
            this.sequence.MinimumSize = new System.Drawing.Size(320, 0);
            this.sequence.Name = "sequence";
            this.sequence.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("sequence.ResponsiveProfiles"))));
            this.sequence.Size = new System.Drawing.Size(636, 323);
            this.sequence.TabIndex = 3;
            this.sequence.Text = "sequence4";
            this.sequence.UML = "Andrew->Alex: Says Hello\r\nNote right of Alex: Alex thinks about it\r\nAlex-->Andrew" +
    ": How are you?\r\nAndrew->>Alex: I am good thanks!";
            this.sequence.ElementClick += new Wisej.Web.Ext.jSequence.ElementClickEventHandler(this.sequence_ElementClick);
            // 
            // cmbThemes
            // 
            this.cmbThemes.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbThemes.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbThemes.Items.AddRange(new object[] {
            "Simple",
            "Hand"});
            this.cmbThemes.LabelText = "Themes";
            this.cmbThemes.Location = new System.Drawing.Point(162, 8);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("cmbThemes.ResponsiveProfiles"))));
            this.cmbThemes.Size = new System.Drawing.Size(310, 53);
            this.cmbThemes.TabIndex = 5;
            this.cmbThemes.SelectedIndexChanged += new System.EventHandler(this.cmbThemes_SelectedIndexChanged);
            // 
            // txtUml
            // 
            this.txtUml.AcceptsReturn = true;
            this.txtUml.AcceptsTab = true;
            this.txtUml.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtUml.LabelText = "UML ";
            this.txtUml.Location = new System.Drawing.Point(162, 67);
            this.txtUml.Multiline = true;
            this.txtUml.Name = "txtUml";
            this.txtUml.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtUml.ResponsiveProfiles"))));
            this.txtUml.Size = new System.Drawing.Size(310, 206);
            this.txtUml.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(162, 279);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnUpdate.ResponsiveProfiles"))));
            this.btnUpdate.Size = new System.Drawing.Size(310, 35);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUml);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cmbThemes);
            this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(320, 0);
            this.panel1.Name = "panel1";
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
            this.panel1.Size = new System.Drawing.Size(635, 323);
            this.panel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.sequence);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowLayoutPanel1.ResponsiveProfiles"))));
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1283, 331);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // Features
            // 
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Web.Ext.jSequence.Sequence sequence;
        private Web.ComboBox cmbThemes;
        private Web.TextBox txtUml;
        private Web.Button btnUpdate;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Panel panel1;
    }
}
