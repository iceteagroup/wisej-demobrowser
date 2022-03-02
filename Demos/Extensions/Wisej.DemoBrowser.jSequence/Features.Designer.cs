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
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.btnExample1 = new Wisej.Web.Button();
            this.btnExample2 = new Wisej.Web.Button();
            this.btnExample3 = new Wisej.Web.Button();
            this.btnExample4 = new Wisej.Web.Button();
            this.cmbThemes = new Wisej.Web.ComboBox();
            this.txtUml = new Wisej.Web.TextBox();
            this.btnUpdate = new Wisej.Web.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sequence
            // 
            this.sequence.Dock = Wisej.Web.DockStyle.Left;
            this.sequence.Name = "sequence";
            this.sequence.Size = new System.Drawing.Size(982, 474);
            this.sequence.TabIndex = 3;
            this.sequence.Text = "sequence4";
            this.sequence.UML = "Andrew->Alex: Says Hello\r\nNote right of Alex: China thinks\\nabout it\r\nAlex-->Andr" +
    "ew: How are you?\r\nAndrew->>Alex: I am good thanks!";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExample1);
            this.flowLayoutPanel1.Controls.Add(this.btnExample2);
            this.flowLayoutPanel1.Controls.Add(this.btnExample3);
            this.flowLayoutPanel1.Controls.Add(this.btnExample4);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(982, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 41);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(3, 3);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(100, 32);
            this.btnExample1.TabIndex = 0;
            this.btnExample1.Text = "Example 1";
            this.btnExample1.Click += new System.EventHandler(this.btnExample1_Click);
            // 
            // btnExample2
            // 
            this.btnExample2.Location = new System.Drawing.Point(109, 3);
            this.btnExample2.Name = "btnExample2";
            this.btnExample2.Size = new System.Drawing.Size(100, 32);
            this.btnExample2.TabIndex = 1;
            this.btnExample2.Text = "Example 2";
            this.btnExample2.Click += new System.EventHandler(this.btnExample2_Click);
            // 
            // btnExample3
            // 
            this.btnExample3.Location = new System.Drawing.Point(215, 3);
            this.btnExample3.Name = "btnExample3";
            this.btnExample3.Size = new System.Drawing.Size(100, 32);
            this.btnExample3.TabIndex = 2;
            this.btnExample3.Text = "Example 3";
            this.btnExample3.Click += new System.EventHandler(this.btnExample3_Click);
            // 
            // btnExample4
            // 
            this.btnExample4.Location = new System.Drawing.Point(321, 3);
            this.btnExample4.Name = "btnExample4";
            this.btnExample4.Size = new System.Drawing.Size(100, 32);
            this.btnExample4.TabIndex = 3;
            this.btnExample4.Text = "Example 4";
            this.btnExample4.Click += new System.EventHandler(this.btnExample4_Click);
            // 
            // cmbThemes
            // 
            this.cmbThemes.Dock = Wisej.Web.DockStyle.Top;
            this.cmbThemes.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbThemes.Items.AddRange(new object[] {
            "Simple",
            "Hand"});
            this.cmbThemes.LabelText = "Themes";
            this.cmbThemes.Location = new System.Drawing.Point(982, 41);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(440, 42);
            this.cmbThemes.TabIndex = 5;
            this.cmbThemes.SelectedIndexChanged += new System.EventHandler(this.cmbThemes_SelectedIndexChanged);
            // 
            // txtUml
            // 
            this.txtUml.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtUml.LabelText = "UML ";
            this.txtUml.Location = new System.Drawing.Point(993, 110);
            this.txtUml.Multiline = true;
            this.txtUml.Name = "txtUml";
            this.txtUml.Size = new System.Drawing.Size(410, 323);
            this.txtUml.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(1121, 439);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 24);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUml);
            this.Controls.Add(this.cmbThemes);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sequence);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Web.Ext.jSequence.Sequence sequence;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Button btnExample1;
        private Web.Button btnExample2;
        private Web.Button btnExample3;
        private Web.Button btnExample4;
        private Web.ComboBox cmbThemes;
        private Web.TextBox txtUml;
        private Web.Button btnUpdate;
    }
}
