namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class TreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeView));
            this.treeView1 = new Wisej.Web.Ext.Syncfusion2.TreeView();
            this.comboBoxExpandOn = new Wisej.Web.ComboBox();
            this.checkBoxDragAndDrop = new Wisej.Web.CheckBox();
            this.checkBoxShowCheckbox = new Wisej.Web.CheckBox();
            this.checkBoxEditing = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/treeview/es5-getting-started/" +
    "";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/treeview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.treeView1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxDragAndDrop);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowCheckbox);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEditing);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxExpandOn);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/treeview/default.html";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = Wisej.Web.AnchorStyles.None;
            this.treeView1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.treeView1.Location = new System.Drawing.Point(294, 143);
            this.treeView1.Name = "treeView1";
            this.treeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeView1.Options"))));
            this.treeView1.Size = new System.Drawing.Size(300, 290);
            this.treeView1.TabIndex = 0;
            this.treeView1.Text = "treeView1";
            // 
            // comboBoxExpandOn
            // 
            this.comboBoxExpandOn.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxExpandOn, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxExpandOn, true);
            this.comboBoxExpandOn.Items.AddRange(new object[] {
            "Auto",
            "Click",
            "DblClick",
            "None"});
            this.comboBoxExpandOn.LabelText = "Expand on";
            this.comboBoxExpandOn.Location = new System.Drawing.Point(3, 132);
            this.comboBoxExpandOn.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxExpandOn.Name = "comboBoxExpandOn";
            this.comboBoxExpandOn.Size = new System.Drawing.Size(212, 57);
            this.comboBoxExpandOn.TabIndex = 1;
            // 
            // checkBoxDragAndDrop
            // 
            this.checkBoxDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDragAndDrop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxDragAndDrop, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxDragAndDrop, true);
            this.checkBoxDragAndDrop.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDragAndDrop.Name = "checkBoxDragAndDrop";
            this.checkBoxDragAndDrop.Size = new System.Drawing.Size(212, 24);
            this.checkBoxDragAndDrop.TabIndex = 2;
            this.checkBoxDragAndDrop.Text = "Allow Drag-and-Drop";
            // 
            // checkBoxShowCheckbox
            // 
            this.checkBoxShowCheckbox.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxShowCheckbox, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxShowCheckbox, true);
            this.checkBoxShowCheckbox.Location = new System.Drawing.Point(3, 46);
            this.checkBoxShowCheckbox.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxShowCheckbox.Name = "checkBoxShowCheckbox";
            this.checkBoxShowCheckbox.Size = new System.Drawing.Size(212, 24);
            this.checkBoxShowCheckbox.TabIndex = 3;
            this.checkBoxShowCheckbox.Text = "Show Checkbox";
            // 
            // checkBoxEditing
            // 
            this.checkBoxEditing.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEditing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEditing, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEditing, true);
            this.checkBoxEditing.Location = new System.Drawing.Point(3, 89);
            this.checkBoxEditing.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEditing.Name = "checkBoxEditing";
            this.checkBoxEditing.Size = new System.Drawing.Size(212, 24);
            this.checkBoxEditing.TabIndex = 4;
            this.checkBoxEditing.Text = "Allow Editing";
            // 
            // TreeView
            // 
            this.Name = "TreeView";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.TreeView treeView1;
        private CheckBox checkBoxEditing;
        private CheckBox checkBoxShowCheckbox;
        private CheckBox checkBoxDragAndDrop;
        private ComboBox comboBoxExpandOn;
    }
}
