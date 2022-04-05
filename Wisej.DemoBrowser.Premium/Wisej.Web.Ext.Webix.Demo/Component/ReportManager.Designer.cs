namespace Wisej.Web.Ext.Webix.Demo.Component
{
    partial class ReportManager
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
            this.reportManager1 = new Wisej.Web.Ext.Webix.ReportManager();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery/reports";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.reports.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.reportManager1);
            // 
            // reportManager1
            // 
            this.reportManager1.Dock = Wisej.Web.DockStyle.Fill;
            this.reportManager1.Location = new System.Drawing.Point(8, 8);
            this.reportManager1.Name = "reportManager1";
            this.reportManager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"url\":\"https://docs.webix.com/reports-backend/\"}")));
            this.reportManager1.Size = new System.Drawing.Size(1073, 542);
            this.reportManager1.TabIndex = 0;
            this.reportManager1.Text = "reportManager1";
            // 
            // ReportManager
            // 
            this.Name = "ReportManager";
            this.Load += new System.EventHandler(this.ReportManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.ReportManager reportManager1;
    }
}
