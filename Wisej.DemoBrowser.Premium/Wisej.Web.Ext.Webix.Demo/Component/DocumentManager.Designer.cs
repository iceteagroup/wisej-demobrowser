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
            this.comboBoxMode = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__docmanager.html#overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery/docmanager";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.docmanager.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.documentManager1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBoxMode);
            // 
            // documentManager1
            // 
            this.documentManager1.Dock = Wisej.Web.DockStyle.Fill;
            this.documentManager1.Location = new System.Drawing.Point(8, 8);
            this.documentManager1.Name = "documentManager1";
            this.documentManager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"url\":\"https://docs.webix.com/docmanager-backend/\",\"mode\":\"cards\"}")));
            this.documentManager1.Size = new System.Drawing.Size(1073, 542);
            this.documentManager1.TabIndex = 0;
            this.documentManager1.Text = "documentManager1";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxMode.Items.AddRange(new object[] {
            "list",
            "cards",
            "double"});
            this.comboBoxMode.LabelText = "Mode";
            this.comboBoxMode.Location = new System.Drawing.Point(3, 3);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(212, 46);
            this.comboBoxMode.TabIndex = 0;
            // 
            // DocumentManager
            // 
            this.Name = "DocumentManager";
            this.Load += new System.EventHandler(this.DocumentManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.DocumentManager documentManager1;
        private ComboBox comboBoxMode;
    }
}
