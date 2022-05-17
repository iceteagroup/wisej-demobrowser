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
            this.comboBoxEditMode = new Wisej.Web.ComboBox();
            this.checkBoxFiltrable = new Wisej.Web.CheckBox();
            this.checkBoxColumnMenu = new Wisej.Web.CheckBox();
            this.checkBoxResizable = new Wisej.Web.CheckBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoTreeList1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/treelist/index";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/treelist";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/data-management/treelist/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxFiltrable);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxColumnMenu);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxResizable);
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxEditMode);
            // 
            // kendoTreeList1
            // 
            this.kendoTreeList1.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoTreeList1.Location = new System.Drawing.Point(8, 8);
            this.kendoTreeList1.Name = "kendoTreeList1";
            this.kendoTreeList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoTreeList1.Options"))));
            this.kendoTreeList1.Size = new System.Drawing.Size(872, 560);
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
            // comboBoxEditMode
            // 
            this.comboBoxEditMode.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxEditMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxEditMode.Items.AddRange(new object[] {
            "inline",
            "popup",
            "incell"});
            this.comboBoxEditMode.LabelText = "Edit Mode";
            this.comboBoxEditMode.Location = new System.Drawing.Point(3, 151);
            this.comboBoxEditMode.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxEditMode.Name = "comboBoxEditMode";
            this.comboBoxEditMode.Size = new System.Drawing.Size(212, 57);
            this.comboBoxEditMode.TabIndex = 0;
            this.comboBoxEditMode.Text = "inline";
            // 
            // checkBoxFiltrable
            // 
            this.checkBoxFiltrable.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxFiltrable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFiltrable.AutoSize = false;
            this.checkBoxFiltrable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxFiltrable.Location = new System.Drawing.Point(3, 16);
            this.checkBoxFiltrable.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxFiltrable.Name = "checkBoxFiltrable";
            this.checkBoxFiltrable.Size = new System.Drawing.Size(212, 26);
            this.checkBoxFiltrable.TabIndex = 1;
            this.checkBoxFiltrable.Text = "Enable Filter";
            // 
            // checkBoxColumnMenu
            // 
            this.checkBoxColumnMenu.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxColumnMenu.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxColumnMenu.AutoSize = false;
            this.checkBoxColumnMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxColumnMenu.Location = new System.Drawing.Point(3, 61);
            this.checkBoxColumnMenu.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxColumnMenu.Name = "checkBoxColumnMenu";
            this.checkBoxColumnMenu.Size = new System.Drawing.Size(212, 26);
            this.checkBoxColumnMenu.TabIndex = 2;
            this.checkBoxColumnMenu.Text = "Column Menu";
            // 
            // checkBoxResizable
            // 
            this.checkBoxResizable.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxResizable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxResizable.AutoSize = false;
            this.checkBoxResizable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxResizable.Location = new System.Drawing.Point(3, 106);
            this.checkBoxResizable.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxResizable.Name = "checkBoxResizable";
            this.checkBoxResizable.Size = new System.Drawing.Size(212, 26);
            this.checkBoxResizable.TabIndex = 3;
            this.checkBoxResizable.Text = "Resizable";
            // 
            // kendoTreeList
            // 
            this.Name = "kendoTreeList";
            this.Load += new System.EventHandler(this.kendoTreeList_Load);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoTreeList kendoTreeList1;
        private ComboBox comboBoxEditMode;
        private CheckBox checkBoxFiltrable;
        private CheckBox checkBoxColumnMenu;
        private CheckBox checkBoxResizable;
    }
}
