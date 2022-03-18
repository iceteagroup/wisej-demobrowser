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
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoFileManager1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/filemanager/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/filemanager";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/data-management/filemanager/overview";
            // 
            // kendoFileManager1
            // 
            this.kendoFileManager1.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoFileManager1.Location = new System.Drawing.Point(8, 8);
            this.kendoFileManager1.Name = "kendoFileManager1";
            this.kendoFileManager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoFileManager1.Options"))));
            this.kendoFileManager1.Size = new System.Drawing.Size(1073, 542);
            this.kendoFileManager1.TabIndex = 0;
            this.kendoFileManager1.Text = "kendoFileManager1";
            // 
            // kendoFileManager
            // 
            this.Name = "kendoFileManager";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoFileManager kendoFileManager1;
	}
}
