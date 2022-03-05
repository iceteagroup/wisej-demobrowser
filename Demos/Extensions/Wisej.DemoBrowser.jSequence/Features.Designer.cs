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
            this.navigationBar = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            this.navItem1 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navItem2 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navItem3 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navItem4 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.SuspendLayout();
            // 
            // sequence
            // 
            this.sequence.Anchor = Wisej.Web.AnchorStyles.None;
            this.sequence.Location = new System.Drawing.Point(680, 44);
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
            this.cmbThemes.Location = new System.Drawing.Point(192, 56);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(437, 49);
            this.cmbThemes.TabIndex = 5;
            this.cmbThemes.SelectedIndexChanged += new System.EventHandler(this.cmbThemes_SelectedIndexChanged);
            // 
            // txtUml
            // 
            this.txtUml.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtUml.LabelText = "UML ";
            this.txtUml.Location = new System.Drawing.Point(192, 134);
            this.txtUml.Multiline = true;
            this.txtUml.Name = "txtUml";
            this.txtUml.Size = new System.Drawing.Size(437, 207);
            this.txtUml.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(335, 362);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 35);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.Color.FromName("@controlLight");
            this.navigationBar.CompactView = true;
            this.navigationBar.Dock = Wisej.Web.DockStyle.Left;
            this.navigationBar.ItemHeight = 50;
            this.navigationBar.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navItem1,
            this.navItem2,
            this.navItem3,
            this.navItem4});
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.ShowUser = false;
            this.navigationBar.Size = new System.Drawing.Size(70, 474);
            this.navigationBar.TabIndex = 8;
            // 
            // navItem1
            // 
            this.navItem1.BackColor = System.Drawing.Color.Transparent;
            this.navItem1.Icon = "resource.wx/Wisej.DemoBrowser.jSequence/1.png";
            this.navItem1.Name = "NavigationBarItem";
            this.navItem1.Text = "Example 1";
            this.navItem1.Click += new System.EventHandler(this.navItem1_Click);
            // 
            // navItem2
            // 
            this.navItem2.BackColor = System.Drawing.Color.Transparent;
            this.navItem2.Icon = "resource.wx/Wisej.DemoBrowser.jSequence/2.png";
            this.navItem2.Name = "NavigationBarItem";
            this.navItem2.Text = "Example 2";
            this.navItem2.Click += new System.EventHandler(this.navItem2_Click);
            // 
            // navItem3
            // 
            this.navItem3.BackColor = System.Drawing.Color.Transparent;
            this.navItem3.Icon = "resource.wx/Wisej.DemoBrowser.jSequence/3.png";
            this.navItem3.Name = "NavigationBarItem";
            this.navItem3.Text = "Example 3";
            this.navItem3.Click += new System.EventHandler(this.navItem3_Click);
            // 
            // navItem4
            // 
            this.navItem4.BackColor = System.Drawing.Color.Transparent;
            this.navItem4.Icon = "resource.wx/Wisej.DemoBrowser.jSequence/4.png";
            this.navItem4.Name = "NavigationBarItem";
            this.navItem4.Text = "Example 4";
            this.navItem4.Click += new System.EventHandler(this.navItem4_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUml);
            this.Controls.Add(this.cmbThemes);
            this.Controls.Add(this.sequence);
            this.MinimumSize = new System.Drawing.Size(978, 340);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Web.Ext.jSequence.Sequence sequence;
        private Web.ComboBox cmbThemes;
        private Web.TextBox txtUml;
        private Web.Button btnUpdate;
        private Web.Ext.NavigationBar.NavigationBar navigationBar;
        private Web.Ext.NavigationBar.NavigationBarItem navItem1;
        private Web.Ext.NavigationBar.NavigationBarItem navItem2;
        private Web.Ext.NavigationBar.NavigationBarItem navItem3;
        private Web.Ext.NavigationBar.NavigationBarItem navItem4;
    }
}
