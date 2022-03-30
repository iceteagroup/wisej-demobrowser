namespace Wisej.DemoBrowser.GroupBox
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
            this.grpCollapsible = new Wisej.Web.GroupBox();
            this.button3 = new Wisej.Web.Button();
            this.grpRegular = new Wisej.Web.GroupBox();
            this.button2 = new Wisej.Web.Button();
            this.grpCheckBox = new Wisej.Web.GroupBox();
            this.button1 = new Wisej.Web.Button();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.button4 = new Wisej.Web.Button();
            this.grpCollapsible.SuspendLayout();
            this.grpRegular.SuspendLayout();
            this.grpCheckBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCollapsible
            // 
            this.grpCollapsible.Anchor = Wisej.Web.AnchorStyles.None;
            this.grpCollapsible.Controls.Add(this.button3);
            this.grpCollapsible.Location = new System.Drawing.Point(728, 30);
            this.grpCollapsible.Name = "grpCollapsible";
            this.grpCollapsible.ShowCloseButton = true;
            this.grpCollapsible.Size = new System.Drawing.Size(256, 195);
            this.grpCollapsible.TabIndex = 0;
            this.grpCollapsible.Text = "Collapsible GroupBox";
            // 
            // button3
            // 
            this.button3.Anchor = Wisej.Web.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(78, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            // 
            // grpRegular
            // 
            this.grpRegular.Anchor = Wisej.Web.AnchorStyles.None;
            this.grpRegular.Controls.Add(this.button2);
            this.grpRegular.Location = new System.Drawing.Point(439, 249);
            this.grpRegular.Name = "grpRegular";
            this.grpRegular.Size = new System.Drawing.Size(256, 195);
            this.grpRegular.TabIndex = 1;
            this.grpRegular.Text = "Regular GroupBox";
            // 
            // button2
            // 
            this.button2.Anchor = Wisej.Web.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(78, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            // 
            // grpCheckBox
            // 
            this.grpCheckBox.Anchor = Wisej.Web.AnchorStyles.None;
            this.grpCheckBox.Controls.Add(this.button1);
            this.grpCheckBox.Location = new System.Drawing.Point(439, 30);
            this.grpCheckBox.Name = "grpCheckBox";
            this.grpCheckBox.ShowCheckBox = true;
            this.grpCheckBox.Size = new System.Drawing.Size(256, 195);
            this.grpCheckBox.TabIndex = 2;
            this.grpCheckBox.Text = "Enable GroupBox";
            this.grpCheckBox.CheckedChanged += new System.EventHandler(this.grpCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(78, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(728, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.ShowCloseButton = true;
            this.groupBox1.Size = new System.Drawing.Size(256, 195);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "Disabled GroupBox";
            // 
            // button4
            // 
            this.button4.Anchor = Wisej.Web.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(78, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 27);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            // 
            // Features
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCheckBox);
            this.Controls.Add(this.grpRegular);
            this.Controls.Add(this.grpCollapsible);
            this.MinimumSize = new System.Drawing.Size(940, 400);
            this.Name = "Features";
            this.grpCollapsible.ResumeLayout(false);
            this.grpRegular.ResumeLayout(false);
            this.grpCheckBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.GroupBox grpCollapsible;
        private Web.Button button3;
        private Web.GroupBox grpRegular;
        private Web.Button button2;
        private Web.GroupBox grpCheckBox;
        private Web.Button button1;
        private Web.GroupBox groupBox1;
        private Web.Button button4;
    }
}
