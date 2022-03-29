namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoTreeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoTreeList));
            Wisej.Web.Ext.Kendo.kendoBase.WidgetTemplate widgetTemplate1 = new Wisej.Web.Ext.Kendo.kendoBase.WidgetTemplate();
            this.kendoTreeList1 = new Wisej.Web.Ext.Kendo.kendoTreeList();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoTreeList1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/treelist/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/treelist";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/data-management/treelist/overview";
            // 
            // kendoTreeList1
            // 
            this.kendoTreeList1.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoTreeList1.Location = new System.Drawing.Point(8, 8);
            this.kendoTreeList1.Name = "kendoTreeList1";
            this.kendoTreeList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoTreeList1.Options"))));
            this.kendoTreeList1.Size = new System.Drawing.Size(1073, 542);
            this.kendoTreeList1.TabIndex = 0;
            this.kendoTreeList1.Text = "kendoTreeList1";
            widgetTemplate1.Id = "photo-template";
            widgetTemplate1.Template = "<div class=\'employee-photo\'\r\n                style=\'background-image: url(./Image" +
    "s/TreeList/#:data.EmployeeID#.jpg);\'></div>\r\n           <div class=\'employee-nam" +
    "e\'>#: FirstName #</div>";
            widgetTemplate1.Type = "text/x-kendo-template";
            this.kendoTreeList1.WidgetTemplates = new Wisej.Web.Ext.Kendo.kendoBase.WidgetTemplate[] {
        widgetTemplate1};
            // 
            // kendoTreeList
            // 
            this.Name = "kendoTreeList";
            this.Load += new System.EventHandler(this.kendoTreeList_Load);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoTreeList kendoTreeList1;
	}
}
