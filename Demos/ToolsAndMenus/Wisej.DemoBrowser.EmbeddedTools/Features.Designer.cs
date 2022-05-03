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
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool4 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool5 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool6 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool7 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool8 = new Wisej.Web.ComponentTool();
            this.textBox1 = new Wisej.Web.TextBox();
            this.textBox2 = new Wisej.Web.TextBox();
            this.textBox3 = new Wisej.Web.TextBox();
            this.textBox4 = new Wisej.Web.TextBox();
            this.checkedListBox1 = new Wisej.Web.CheckedListBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox1.LabelText = "Tool Position Right";
            this.textBox1.Location = new System.Drawing.Point(231, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 53);
            this.textBox1.TabIndex = 9;
            componentTool1.ImageSource = "node-opened";
            this.textBox1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            this.textBox1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.Tool_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox2.LabelText = "Tool Position Left";
            this.textBox2.Location = new System.Drawing.Point(231, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 53);
            this.textBox2.TabIndex = 10;
            componentTool2.ImageSource = "icon-settings";
            componentTool2.Position = Wisej.Web.LeftRightAlignment.Left;
            this.textBox2.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
            this.textBox2.ToolClick += new Wisej.Web.ToolClickEventHandler(this.Tool_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox3.LabelText = "Tool AutoHide";
            this.textBox3.Location = new System.Drawing.Point(607, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 53);
            this.textBox3.TabIndex = 11;
            componentTool3.AutoHide = true;
            componentTool3.ImageSource = "icon-print?color=activeCaption";
            this.textBox3.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool3});
            this.textBox3.ToolClick += new Wisej.Web.ToolClickEventHandler(this.Tool_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox4.LabelText = "Multiple Tools";
            this.textBox4.Location = new System.Drawing.Point(607, 261);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(247, 53);
            this.textBox4.TabIndex = 12;
            componentTool4.Enabled = false;
            componentTool4.ImageSource = "icon-save?color=windowText";
            componentTool5.ImageSource = "icon-search";
            componentTool6.ImageSource = "menu-overflow";
            this.textBox4.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool4,
            componentTool5,
            componentTool6});
            this.textBox4.ToolClick += new Wisej.Web.ToolClickEventHandler(this.Tool_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.checkedListBox1.Location = new System.Drawing.Point(945, 170);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(247, 88);
            this.checkedListBox1.TabIndex = 13;
            componentTool7.ImageSource = "checkbox";
            componentTool7.Position = Wisej.Web.LeftRightAlignment.Left;
            componentTool7.ToolTipText = "Check All";
            this.checkedListBox1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool7});
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
            this.comboBox1.Location = new System.Drawing.Point(945, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 30);
            this.comboBox1.TabIndex = 14;
            componentTool8.ImageSource = "icon-info";
            this.comboBox1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool8});
            this.comboBox1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.comboBox1_ToolClick);
            // 
            // Features
            // 
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(978, 340);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.TextBox textBox1;
        private Web.TextBox textBox2;
        private Web.TextBox textBox3;
        private Web.TextBox textBox4;
        private Web.CheckedListBox checkedListBox1;
        private Web.ComboBox comboBox1;
    }
}
