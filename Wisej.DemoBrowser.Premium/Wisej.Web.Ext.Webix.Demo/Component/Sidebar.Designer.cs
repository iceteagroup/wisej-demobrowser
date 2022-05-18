namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Sidebar
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
            this.sidebar1 = new Wisej.Web.Ext.Webix.Sidebar();
            this.checkBoxCollapsed = new Wisej.Web.CheckBox();
            this.checkBoxEnableMultiOpen = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__sidebar.html";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#sidebar";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://docs.webix.com/api__refs__ui.sidebar.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.sidebar1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxCollapsed);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableMultiOpen);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 434);
            // 
            // sidebar1
            // 
            this.sidebar1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.sidebar1.Location = new System.Drawing.Point(437, 79);
            this.sidebar1.Name = "sidebar1";
            this.sidebar1.Size = new System.Drawing.Size(215, 400);
            this.sidebar1.TabIndex = 0;
            this.sidebar1.Text = "sidebar1";
            // 
            // checkBoxCollapsed
            // 
            this.checkBoxCollapsed.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxCollapsed.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxCollapsed.AutoSize = false;
            this.checkBoxCollapsed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxCollapsed, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxCollapsed, true);
            this.checkBoxCollapsed.Location = new System.Drawing.Point(3, 3);
            this.checkBoxCollapsed.Name = "checkBoxCollapsed";
            this.checkBoxCollapsed.Size = new System.Drawing.Size(212, 26);
            this.checkBoxCollapsed.TabIndex = 1;
            this.checkBoxCollapsed.Text = "Collapsed";
            // 
            // checkBoxEnableMultiOpen
            // 
            this.checkBoxEnableMultiOpen.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableMultiOpen.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableMultiOpen.AutoSize = false;
            this.checkBoxEnableMultiOpen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableMultiOpen, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableMultiOpen, true);
            this.checkBoxEnableMultiOpen.Location = new System.Drawing.Point(3, 48);
            this.checkBoxEnableMultiOpen.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEnableMultiOpen.Name = "checkBoxEnableMultiOpen";
            this.checkBoxEnableMultiOpen.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableMultiOpen.TabIndex = 2;
            this.checkBoxEnableMultiOpen.Text = "Enable Multi-Open";
            // 
            // Sidebar
            // 
            this.Name = "Sidebar";
            this.Load += new System.EventHandler(this.Sidebar_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Sidebar sidebar1;
        private CheckBox checkBoxCollapsed;
        private CheckBox checkBoxEnableMultiOpen;
    }
}
