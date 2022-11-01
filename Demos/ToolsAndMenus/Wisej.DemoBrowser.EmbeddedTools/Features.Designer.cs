namespace Wisej.DemoBrowser.EmbeddedTools
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
            Wisej.Web.ComponentTool componentTool9 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool10 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool11 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool12 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool13 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool14 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool15 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool16 = new Wisej.Web.ComponentTool();
            this.textBox1 = new Wisej.Web.TextBox();
            this.textBox2 = new Wisej.Web.TextBox();
            this.textBox3 = new Wisej.Web.TextBox();
            this.textBox4 = new Wisej.Web.TextBox();
            this.checkedListBox1 = new Wisej.Web.CheckedListBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox1.LabelText = "Tool Position Right";
            this.textBox1.Location = new System.Drawing.Point(25, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textBox1.ResponsiveProfiles"))));
            this.textBox1.Size = new System.Drawing.Size(247, 53);
            this.textBox1.TabIndex = 9;
            componentTool9.ImageSource = "node-opened";
            this.textBox1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool9});
            this.textBox1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.Tool_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox2.LabelText = "Tool Position Left";
            this.textBox2.Location = new System.Drawing.Point(25, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textBox2.ResponsiveProfiles"))));
            this.textBox2.Size = new System.Drawing.Size(247, 53);
            this.textBox2.TabIndex = 10;
            componentTool10.ImageSource = "icon-settings";
            componentTool10.Position = Wisej.Web.LeftRightAlignment.Left;
            this.textBox2.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool10});
            this.textBox2.ToolClick += new Wisej.Web.ToolClickEventHandler(this.Tool_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox3.LabelText = "Tool AutoHide";
            this.textBox3.Location = new System.Drawing.Point(25, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textBox3.ResponsiveProfiles"))));
            this.textBox3.Size = new System.Drawing.Size(247, 53);
            this.textBox3.TabIndex = 11;
            componentTool11.AutoHide = true;
            componentTool11.ImageSource = "icon-print?color=activeCaption";
            this.textBox3.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool11});
            this.textBox3.ToolClick += new Wisej.Web.ToolClickEventHandler(this.Tool_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox4.LabelText = "Multiple Tools";
            this.textBox4.Location = new System.Drawing.Point(25, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textBox4.ResponsiveProfiles"))));
            this.textBox4.Size = new System.Drawing.Size(247, 53);
            this.textBox4.TabIndex = 12;
            componentTool12.Enabled = false;
            componentTool12.ImageSource = "icon-save?color=windowText";
            componentTool13.ImageSource = "icon-search";
            componentTool14.ImageSource = "menu-overflow";
            this.textBox4.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool12,
            componentTool13,
            componentTool14});
            this.textBox4.ToolClick += new Wisej.Web.ToolClickEventHandler(this.Tool_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.checkedListBox1.LabelText = "CheckedListBox with Tool";
            this.checkedListBox1.Location = new System.Drawing.Point(25, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("checkedListBox1.ResponsiveProfiles"))));
            this.checkedListBox1.Size = new System.Drawing.Size(247, 225);
            this.checkedListBox1.TabIndex = 13;
            componentTool15.ImageSource = "checkbox";
            componentTool15.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool15.ToolTipText = "Check All";
            this.checkedListBox1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool15});
            this.checkedListBox1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.checkedListBox1_ToolClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBox1.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4"});
            this.comboBox1.LabelText = "ComboBox with Tool";
            this.comboBox1.Location = new System.Drawing.Point(25, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("comboBox1.ResponsiveProfiles"))));
            this.comboBox1.Size = new System.Drawing.Size(247, 53);
            this.comboBox1.TabIndex = 14;
            componentTool16.ImageSource = "icon-info";
            this.comboBox1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool16});
            this.comboBox1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.comboBox1_ToolClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
            this.panel1.Size = new System.Drawing.Size(296, 263);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox3);
            this.flowLayoutPanel1.SetFillWeight(this.panel2, 1);
            this.panel2.Location = new System.Drawing.Point(607, 3);
            this.panel2.Name = "panel2";
            this.panel2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel2.ResponsiveProfiles"))));
            this.panel2.Size = new System.Drawing.Size(296, 263);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkedListBox1);
            this.flowLayoutPanel1.SetFillWeight(this.panel3, 1);
            this.panel3.Location = new System.Drawing.Point(305, 3);
            this.panel3.Name = "panel3";
            this.panel3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel3.ResponsiveProfiles"))));
            this.panel3.Size = new System.Drawing.Size(296, 263);
            this.panel3.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = Wisej.Web.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(258, 103);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowLayoutPanel1.ResponsiveProfiles"))));
            this.flowLayoutPanel1.Size = new System.Drawing.Size(906, 269);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // Features
            // 
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.TextBox textBox1;
        private Web.TextBox textBox2;
        private Web.TextBox textBox3;
        private Web.TextBox textBox4;
        private Web.CheckedListBox checkedListBox1;
        private Web.ComboBox comboBox1;
        private Web.Panel panel1;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Panel panel3;
        private Web.Panel panel2;
    }
}
