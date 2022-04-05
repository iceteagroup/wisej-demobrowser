namespace Wisej.Web.Ext.Webix.Demo.Component
{
    partial class Kanban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kanban));
            this.kanban1 = new Wisej.Web.Ext.Webix.Kanban();
            this.comboBoxType = new Wisej.Web.ComboBox();
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
            this.linkDemo.Text = "https://snippet.webix.com/gallery/kanban";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.kanban.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kanban1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBoxType);
            // 
            // kanban1
            // 
            this.kanban1.Dock = Wisej.Web.DockStyle.Fill;
            this.kanban1.Location = new System.Drawing.Point(8, 8);
            this.kanban1.Name = "kanban1";
            this.kanban1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kanban1.Options"))));
            this.kanban1.Size = new System.Drawing.Size(1073, 542);
            this.kanban1.TabIndex = 0;
            this.kanban1.Text = "kanban1";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxType.LabelText = "Type";
            this.comboBoxType.Location = new System.Drawing.Point(3, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(212, 46);
            this.comboBoxType.TabIndex = 0;
            // 
            // Kanban
            // 
            this.Name = "Kanban";
            this.Load += new System.EventHandler(this.Kanban_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.Kanban kanban1;
        private ComboBox comboBoxType;
    }
}
