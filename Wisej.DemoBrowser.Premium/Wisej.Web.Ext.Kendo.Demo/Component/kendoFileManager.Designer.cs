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
            this.checkBoxResizable = new Wisej.Web.CheckBox();
            this.checkBoxDraggable = new Wisej.Web.CheckBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoFileManager1);
            this.panel.Size = new System.Drawing.Size(679, 283);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 283);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(16, 215);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxResizable);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxDraggable);
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(218, 157);
            // 
            // kendoFileManager1
            // 
            this.kendoFileManager1.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoFileManager1.Location = new System.Drawing.Point(8, 8);
            this.kendoFileManager1.Name = "kendoFileManager1";
            this.kendoFileManager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoFileManager1.Options"))));
            this.kendoFileManager1.Size = new System.Drawing.Size(661, 265);
            this.kendoFileManager1.TabIndex = 0;
            this.kendoFileManager1.Text = "kendoFileManager1";
            // 
            // checkBoxResizable
            // 
            this.checkBoxResizable.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxResizable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxResizable.AutoSize = false;
            this.checkBoxResizable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxResizable.Checked = true;
            this.checkBoxResizable.Location = new System.Drawing.Point(3, 3);
            this.checkBoxResizable.Name = "checkBoxResizable";
            this.checkBoxResizable.Size = new System.Drawing.Size(212, 26);
            this.checkBoxResizable.TabIndex = 0;
            this.checkBoxResizable.Text = "Resizable";
            // 
            // checkBoxDraggable
            // 
            this.checkBoxDraggable.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxDraggable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDraggable.AutoSize = false;
            this.checkBoxDraggable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDraggable.Checked = true;
            this.checkBoxDraggable.Location = new System.Drawing.Point(3, 35);
            this.checkBoxDraggable.Name = "checkBoxDraggable";
            this.checkBoxDraggable.Size = new System.Drawing.Size(212, 26);
            this.checkBoxDraggable.TabIndex = 1;
            this.checkBoxDraggable.Text = "Draggable";
            // 
            // kendoFileManager
            // 
            this.MinimumSize = new System.Drawing.Size(1088, 473);
            this.Name = "kendoFileManager";
            this.Size = new System.Drawing.Size(1088, 473);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoFileManager kendoFileManager1;
        private CheckBox checkBoxResizable;
        private CheckBox checkBoxDraggable;
    }
}
