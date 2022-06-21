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
			this.textBoxAppend = new Wisej.Web.TextBox();
			this.buttonAppend = new Wisej.Web.Button();
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
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/treeview";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/treeview/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBoxAllowDragAndDrop);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBoxShowcheckboxes);
			this.flowLayoutPanelProperties.Controls.Add(this.textBoxAppend);
			this.flowLayoutPanelProperties.Controls.Add(this.buttonAppend);
			// 
			// kendoTreeView1
			// 
			this.kendoTreeView1.Dock = Wisej.Web.DockStyle.Fill;
			this.kendoTreeView1.Location = new System.Drawing.Point(8, 8);
			this.kendoTreeView1.Name = "kendoTreeView1";
			this.kendoTreeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoTreeView1.Options"))));
			this.kendoTreeView1.Size = new System.Drawing.Size(872, 560);
			this.kendoTreeView1.TabIndex = 0;
			this.kendoTreeView1.Text = "kendoTreeView1";
			// 
			// checkBoxAllowDragAndDrop
			// 
			this.checkBoxAllowDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAllowDragAndDrop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAllowDragAndDrop.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxAllowDragAndDrop, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxAllowDragAndDrop, true);
			this.checkBoxAllowDragAndDrop.Location = new System.Drawing.Point(3, 3);
			this.checkBoxAllowDragAndDrop.Name = "checkBoxAllowDragAndDrop";
			this.checkBoxAllowDragAndDrop.Size = new System.Drawing.Size(212, 24);
			this.checkBoxAllowDragAndDrop.TabIndex = 1;
			this.checkBoxAllowDragAndDrop.Text = "Allow Drag-and-Drop";
			// 
			// checkBoxShowcheckboxes
			// 
			this.checkBoxShowcheckboxes.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowcheckboxes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowcheckboxes.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxShowcheckboxes, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxShowcheckboxes, true);
			this.checkBoxShowcheckboxes.Location = new System.Drawing.Point(3, 46);
			this.checkBoxShowcheckboxes.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxShowcheckboxes.Name = "checkBoxShowcheckboxes";
			this.checkBoxShowcheckboxes.Size = new System.Drawing.Size(212, 24);
			this.checkBoxShowcheckboxes.TabIndex = 2;
			this.checkBoxShowcheckboxes.Text = "Show Checkboxes";
			// 
			// textBoxAppend
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.textBoxAppend, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.textBoxAppend, true);
			this.textBoxAppend.LabelText = "Append";
			this.textBoxAppend.Location = new System.Drawing.Point(3, 89);
			this.textBoxAppend.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBoxAppend.Name = "textBoxAppend";
			this.textBoxAppend.Size = new System.Drawing.Size(212, 51);
			this.textBoxAppend.TabIndex = 3;
			this.textBoxAppend.Text = "Photos";
			// 
			// buttonAppend
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.buttonAppend, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.buttonAppend, true);
			this.buttonAppend.Location = new System.Drawing.Point(3, 146);
			this.buttonAppend.Name = "buttonAppend";
			this.buttonAppend.Size = new System.Drawing.Size(212, 37);
			this.buttonAppend.TabIndex = 4;
			this.buttonAppend.Text = "Append";
			this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
			// 
			// kendoTreeView
			// 
			this.Name = "kendoTreeView";
			this.Load += new System.EventHandler(this.kendoTreeView_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.flowLayoutPanelProperties.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoTreeView kendoTreeView1;
        private CheckBox checkBoxAllowDragAndDrop;
        private CheckBox checkBoxShowcheckboxes;
        private TextBox textBoxAppend;
        private Button buttonAppend;
    }
}
