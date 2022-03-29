namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoTreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoTreeView));
            this.kendoTreeView1 = new Wisej.Web.Ext.Kendo.kendoTreeView();
            this.checkBoxAllowDragAndDrop = new Wisej.Web.CheckBox();
            this.checkBoxShowcheckboxes = new Wisej.Web.CheckBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoTreeView1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/treeview/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/treeview";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/treeview/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxAllowDragAndDrop);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxShowcheckboxes);
            // 
            // kendoTreeView1
            // 
            this.kendoTreeView1.Location = new System.Drawing.Point(51, 31);
            this.kendoTreeView1.Name = "kendoTreeView1";
            this.kendoTreeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoTreeView1.Options"))));
            this.kendoTreeView1.Size = new System.Drawing.Size(350, 250);
            this.kendoTreeView1.TabIndex = 0;
            this.kendoTreeView1.Text = "kendoTreeView1";
            // 
            // checkBoxAllowDragAndDrop
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxAllowDragAndDrop, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxAllowDragAndDrop, true);
            this.checkBoxAllowDragAndDrop.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAllowDragAndDrop.Name = "checkBoxAllowDragAndDrop";
            this.checkBoxAllowDragAndDrop.Size = new System.Drawing.Size(212, 27);
            this.checkBoxAllowDragAndDrop.TabIndex = 1;
            this.checkBoxAllowDragAndDrop.Text = "Allow drag-and-drop";
            // 
            // checkBoxShowcheckboxes
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxShowcheckboxes, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxShowcheckboxes, true);
            this.checkBoxShowcheckboxes.Location = new System.Drawing.Point(3, 49);
            this.checkBoxShowcheckboxes.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxShowcheckboxes.Name = "checkBoxShowcheckboxes";
            this.checkBoxShowcheckboxes.Size = new System.Drawing.Size(212, 27);
            this.checkBoxShowcheckboxes.TabIndex = 2;
            this.checkBoxShowcheckboxes.Text = "Show checkbox";
            // 
            // kendoTreeView
            // 
            this.Name = "kendoTreeView";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoTreeView kendoTreeView1;
        private CheckBox checkBoxAllowDragAndDrop;
        private CheckBox checkBoxShowcheckboxes;
    }
}
