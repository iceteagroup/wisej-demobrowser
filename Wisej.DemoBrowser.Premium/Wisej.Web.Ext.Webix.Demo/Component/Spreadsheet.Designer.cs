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
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.spreadsheet1);
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
            // Spreadsheet
            // 
            this.Name = "Spreadsheet";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.Spreadsheet spreadsheet1;
    }
}
