namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoFileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoFileManager));
            this.kendoFileManager1 = new Wisej.Web.Ext.Kendo.kendoFileManager();
            this.checkBoxContextMenu = new Wisej.Web.CheckBox();
            this.checkBoxBreadcrumb = new Wisej.Web.CheckBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoFileManager1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/filemanager/index";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/filemanager";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/data-management/filemanager/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxContextMenu);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxBreadcrumb);
            // 
            // kendoFileManager1
            // 
            this.kendoFileManager1.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoFileManager1.Location = new System.Drawing.Point(8, 8);
            this.kendoFileManager1.Name = "kendoFileManager1";
            this.kendoFileManager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoFileManager1.Options"))));
            this.kendoFileManager1.Size = new System.Drawing.Size(872, 560);
            this.kendoFileManager1.TabIndex = 0;
            this.kendoFileManager1.Text = "kendoFileManager1";
            this.kendoFileManager1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoFileManager1_WebRequest);
            // 
            // checkBoxContextMenu
            // 
            this.checkBoxContextMenu.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxContextMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxContextMenu, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxContextMenu, true);
            this.checkBoxContextMenu.Location = new System.Drawing.Point(3, 3);
            this.checkBoxContextMenu.Name = "checkBoxContextMenu";
            this.checkBoxContextMenu.Size = new System.Drawing.Size(212, 24);
            this.checkBoxContextMenu.TabIndex = 0;
            this.checkBoxContextMenu.Text = "Context Menu";
            // 
            // checkBoxBreadcrumb
            // 
            this.checkBoxBreadcrumb.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxBreadcrumb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxBreadcrumb, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxBreadcrumb, true);
            this.checkBoxBreadcrumb.Location = new System.Drawing.Point(3, 46);
            this.checkBoxBreadcrumb.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxBreadcrumb.Name = "checkBoxBreadcrumb";
            this.checkBoxBreadcrumb.Size = new System.Drawing.Size(212, 24);
            this.checkBoxBreadcrumb.TabIndex = 1;
            this.checkBoxBreadcrumb.Text = "Breadcrumb";
            // 
            // kendoFileManager
            // 
            this.Name = "kendoFileManager";
            this.Load += new System.EventHandler(this.kendoFileManager_Load);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoFileManager kendoFileManager1;
        private CheckBox checkBoxContextMenu;
        private CheckBox checkBoxBreadcrumb;
    }
}
