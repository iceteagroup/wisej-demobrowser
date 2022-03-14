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
            this.textBox1 = new Wisej.Web.TextBox();
            this.textBox2 = new Wisej.Web.TextBox();
            this.textBox3 = new Wisej.Web.TextBox();
            this.textBox4 = new Wisej.Web.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox1.LabelText = "Tool Position Right With ToolTip";
            this.textBox1.Location = new System.Drawing.Point(400, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 57);
            this.textBox1.TabIndex = 9;
            componentTool1.ImageSource = "node-opened";
            componentTool1.ToolTipText = "This is a Tool component";
            this.textBox1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            this.textBox1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.Tool_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox2.LabelText = "Tool Position Right";
            this.textBox2.Location = new System.Drawing.Point(400, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 57);
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
            this.textBox3.Location = new System.Drawing.Point(776, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 57);
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
            this.textBox4.LabelText = "Tool Disabled";
            this.textBox4.Location = new System.Drawing.Point(776, 259);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(247, 57);
            this.textBox4.TabIndex = 12;
            componentTool4.Enabled = false;
            componentTool4.ImageSource = "icon-save?color=windowText";
            this.textBox4.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool4});
            this.textBox4.ToolClick += new Wisej.Web.ToolClickEventHandler(this.Tool_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(978, 340);
            this.Name = "Features";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.TextBox textBox1;
        private Web.TextBox textBox2;
        private Web.TextBox textBox3;
        private Web.TextBox textBox4;
    }
}
