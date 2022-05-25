namespace Wisej.DemoBrowser.TabControl
{
    partial class Layout
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
            this.tabControl = new Wisej.Web.TabControl();
            this.tabPage1 = new Wisej.Web.TabPage();
            this.labelPage1Text = new Wisej.Web.Label();
            this.tabPage2 = new Wisej.Web.TabPage();
            this.labelPage2Text = new Wisej.Web.Label();
            this.comboBoxOrientation = new Wisej.Web.ComboBox();
            this.comboBoxAlignment = new Wisej.Web.ComboBox();
            this.panel1 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = Wisej.Web.TabAlignment.Bottom;
            this.tabControl.Anchor = Wisej.Web.AnchorStyles.None;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.flowLayoutPanel1.SetFillWeight(this.tabControl, 2);
            this.tabControl.Location = new System.Drawing.Point(408, 3);
            this.tabControl.MinimumSize = new System.Drawing.Size(300, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Orientation = Wisej.Web.Orientation.Vertical;
            this.tabControl.PageInsets = new Wisej.Web.Padding(1, 1, 1, 77);
            this.tabControl.Size = new System.Drawing.Size(798, 332);
            this.tabControl.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelPage1Text);
            this.tabPage1.Location = new System.Drawing.Point(1, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(796, 254);
            this.tabPage1.Text = "Tab Page 1";
            // 
            // labelText
            // 
            this.labelPage1Text.AutoSize = true;
            this.labelPage1Text.Dock = Wisej.Web.DockStyle.Fill;
            this.labelPage1Text.Location = new System.Drawing.Point(0, 0);
            this.labelPage1Text.Name = "labelText";
            this.labelPage1Text.Size = new System.Drawing.Size(796, 254);
            this.labelPage1Text.TabIndex = 4;
            this.labelPage1Text.Text = "TabPage aligned to the Bottom and oriented Vertically";
            this.labelPage1Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelPage2Text);
            this.tabPage2.Location = new System.Drawing.Point(1, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(796, 254);
            this.tabPage2.Text = "Tab Page 2";
            // 
            // label15
            // 
            this.labelPage2Text.AutoSize = true;
            this.labelPage2Text.Dock = Wisej.Web.DockStyle.Fill;
            this.labelPage2Text.Location = new System.Drawing.Point(0, 0);
            this.labelPage2Text.Name = "label15";
            this.labelPage2Text.Size = new System.Drawing.Size(796, 254);
            this.labelPage2Text.TabIndex = 5;
            this.labelPage2Text.Text = "Tabs bottom aligned & oriented vertically";
            this.labelPage2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxOrientation
            // 
            this.comboBoxOrientation.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxOrientation.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.comboBoxOrientation.LabelText = "Tab Orientation";
            this.comboBoxOrientation.Location = new System.Drawing.Point(102, 88);
            this.comboBoxOrientation.Name = "comboBoxOrientation";
            this.comboBoxOrientation.Size = new System.Drawing.Size(195, 53);
            this.comboBoxOrientation.TabIndex = 9;
            this.comboBoxOrientation.Text = "Vertical";
            this.comboBoxOrientation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrientation_SelectedIndexChanged);
            // 
            // comboBoxAlignment
            // 
            this.comboBoxAlignment.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxAlignment.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxAlignment.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Left",
            "Right"});
            this.comboBoxAlignment.LabelText = "Tab Alignment";
            this.comboBoxAlignment.Location = new System.Drawing.Point(102, 191);
            this.comboBoxAlignment.Name = "comboBoxAlignment";
            this.comboBoxAlignment.Size = new System.Drawing.Size(195, 53);
            this.comboBoxAlignment.TabIndex = 10;
            this.comboBoxAlignment.Text = "Bottom";
            this.comboBoxAlignment.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlignment_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxAlignment);
            this.panel1.Controls.Add(this.comboBoxOrientation);
            this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(275, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 332);
            this.panel1.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.tabControl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1209, 340);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // Layout
            // 
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Layout";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.TabControl tabControl;
        private Web.TabPage tabPage1;
        private Web.Label labelPage1Text;
        private Web.TabPage tabPage2;
        private Web.Label labelPage2Text;
        private Web.ComboBox comboBoxOrientation;
        private Web.ComboBox comboBoxAlignment;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Panel panel1;
    }
}
