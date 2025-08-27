﻿namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejPivotTreeMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejPivotTreeMap));
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate1 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			this.ejPivotTreeMap1 = new Wisej.Web.Ext.Syncfusion.ejPivotTreeMap();
			this.buttonSave = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://help.syncfusion.com/js/pivottreemap/overview";
			// 
			// groupBox1
			// 
			this.groupBox1.TabIndex = 6;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 1;
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(545, 24);
			this.linkDemo.TabIndex = 4;
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/pivottreemap/DefaultFunctionalit" +
    "ies";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 2;
			this.linkApi.Text = "https://help.syncfusion.com/api/js/ejpivottreemap";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPivotTreeMap1);
			this.panel.TabIndex = 8;
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.buttonSave);
			// 
			// ejPivotTreeMap1
			// 
			this.ejPivotTreeMap1.Dock = Wisej.Web.DockStyle.Fill;
			this.ejPivotTreeMap1.Location = new System.Drawing.Point(8, 8);
			this.ejPivotTreeMap1.Name = "ejPivotTreeMap1";
			this.ejPivotTreeMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejPivotTreeMap1.Options"))));
			this.ejPivotTreeMap1.Size = new System.Drawing.Size(872, 560);
			this.ejPivotTreeMap1.TabIndex = 0;
			this.ejPivotTreeMap1.Text = "ejPivotTreeMap1";
			widgetTemplate1.Id = "tooltipTemplate";
			widgetTemplate1.Template = resources.GetString("widgetTemplate1.Template");
			widgetTemplate1.Type = "application/jsrender";
			this.ejPivotTreeMap1.WidgetTemplates = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate[] {
        widgetTemplate1};
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(3, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// ejPivotTreeMap
			// 
			this.Name = "ejPivotTreeMap";
			this.Load += new System.EventHandler(this.ejPivotTreeMap_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejPivotTreeMap ejPivotTreeMap1;
		private Button buttonSave;
	}
}
