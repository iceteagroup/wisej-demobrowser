namespace Wisej.Web.Ext.Webix.Demo.Component
{
    partial class DocumentManager
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
            this.documentManager1 = new Wisej.Web.Ext.Webix.DocumentManager();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.documentManager1);
            // 
            // documentManager1
            // 
            this.documentManager1.Dock = Wisej.Web.DockStyle.Fill;
            this.documentManager1.Location = new System.Drawing.Point(8, 8);
            this.documentManager1.Name = "documentManager1";
            this.documentManager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"url\":\"https://docs.webix.com/docmanager-backend/\"}")));
            this.documentManager1.Size = new System.Drawing.Size(1073, 542);
            this.documentManager1.TabIndex = 0;
            this.documentManager1.Text = "documentManager1";
            // 
            // DocumentManager
            // 
            this.Name = "DocumentManager";
            this.Load += new System.EventHandler(this.DocumentManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.DocumentManager documentManager1;
    }
}
