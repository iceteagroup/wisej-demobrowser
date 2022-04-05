namespace Wisej.Web.Ext.Webix.Demo.Component
{
    partial class Spreadsheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spreadsheet));
            this.spreadsheet1 = new Wisej.Web.Ext.Webix.Spreadsheet();
            this.checkBoxEnableFull = new Wisej.Web.CheckBox();
            this.checkBoxClipboard = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery/spreadsheet";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.spreadsheet.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.spreadsheet1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableFull);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxClipboard);
            // 
            // spreadsheet1
            // 
            this.spreadsheet1.Dock = Wisej.Web.DockStyle.Fill;
            this.spreadsheet1.Location = new System.Drawing.Point(8, 8);
            this.spreadsheet1.Name = "spreadsheet1";
            this.spreadsheet1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("spreadsheet1.Options"))));
            this.spreadsheet1.Size = new System.Drawing.Size(1073, 542);
            this.spreadsheet1.TabIndex = 0;
            this.spreadsheet1.Text = "spreadsheet1";
            // 
            // checkBoxEnableFull
            // 
            this.checkBoxEnableFull.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableFull.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableFull.AutoSize = false;
            this.checkBoxEnableFull.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEnableFull.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEnableFull.Name = "checkBoxEnableFull";
            this.checkBoxEnableFull.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableFull.TabIndex = 0;
            this.checkBoxEnableFull.Text = "Enable full";
            // 
            // checkBoxClipboard
            // 
            this.checkBoxClipboard.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxClipboard.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxClipboard.AutoSize = false;
            this.checkBoxClipboard.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxClipboard.Location = new System.Drawing.Point(3, 35);
            this.checkBoxClipboard.Name = "checkBoxClipboard";
            this.checkBoxClipboard.Size = new System.Drawing.Size(212, 26);
            this.checkBoxClipboard.TabIndex = 1;
            this.checkBoxClipboard.Text = "Enable clipboard";
            // 
            // Spreadsheet
            // 
            this.Name = "Spreadsheet";
            this.Load += new System.EventHandler(this.Spreadsheet_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.Spreadsheet spreadsheet1;
        private CheckBox checkBoxEnableFull;
        private CheckBox checkBoxClipboard;
    }
}
