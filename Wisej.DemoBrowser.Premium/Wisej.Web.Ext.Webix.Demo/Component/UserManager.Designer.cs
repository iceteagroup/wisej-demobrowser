namespace Wisej.Web.Ext.Webix.Demo.Component
{
    partial class UserManager
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
            this.userManager1 = new Wisej.Web.Ext.Webix.UserManager();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__unitlist.html";
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery/usermanager";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://docs.webix.com/api__refs__ui.usermanager.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.userManager1);
            // 
            // userManager1
            // 
            this.userManager1.Dock = Wisej.Web.DockStyle.Fill;
            this.userManager1.Location = new System.Drawing.Point(8, 8);
            this.userManager1.Name = "userManager1";
            this.userManager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"url\":\"https://docs.webix.com/usermanager-backend/\"}")));
            this.userManager1.Size = new System.Drawing.Size(1073, 542);
            this.userManager1.TabIndex = 0;
            this.userManager1.Text = "userManager1";
            // 
            // UserManager
            // 
            this.Name = "UserManager";
            this.Load += new System.EventHandler(this.UserManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.UserManager userManager1;
    }
}
