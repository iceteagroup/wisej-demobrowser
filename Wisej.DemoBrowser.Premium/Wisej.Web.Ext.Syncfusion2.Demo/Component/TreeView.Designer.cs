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
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/treeview/es5-getting-started/" +
    "";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/treeview/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEditing);
            this.groupBox1.Controls.Add(this.checkBoxShowCheckbox);
            this.groupBox1.Controls.Add(this.checkBoxDragAndDrop);
            this.groupBox1.Controls.Add(this.comboBoxExpandOn);
            this.groupBox1.Size = new System.Drawing.Size(250, 295);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxExpandOn, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxDragAndDrop, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxShowCheckbox, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxEditing, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 214);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.treeView1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/treeview/default.html";
            // 
            // treeView1
            // 
            this.treeView1.Dock = Wisej.Web.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(8, 8);
            this.treeView1.Name = "treeView1";
            this.treeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeView1.Options"))));
            this.treeView1.Size = new System.Drawing.Size(1073, 542);
            this.treeView1.TabIndex = 0;
            this.treeView1.Text = "treeView1";
            // 
            // comboBoxExpandOn
            // 
            this.comboBoxExpandOn.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxExpandOn.Items.AddRange(new object[] {
            "Auto",
            "Click",
            "DblClick",
            "None"});
            this.comboBoxExpandOn.LabelText = "Expand on";
            this.comboBoxExpandOn.Location = new System.Drawing.Point(18, 112);
            this.comboBoxExpandOn.Name = "comboBoxExpandOn";
            this.comboBoxExpandOn.Size = new System.Drawing.Size(214, 42);
            this.comboBoxExpandOn.TabIndex = 1;
            // 
            // checkBoxDragAndDrop
            // 
            this.checkBoxDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDragAndDrop.Location = new System.Drawing.Point(18, 25);
            this.checkBoxDragAndDrop.Name = "checkBoxDragAndDrop";
            this.checkBoxDragAndDrop.Size = new System.Drawing.Size(168, 24);
            this.checkBoxDragAndDrop.TabIndex = 2;
            this.checkBoxDragAndDrop.Text = "Allow drag and drop";
            // 
            // checkBoxShowCheckbox
            // 
            this.checkBoxShowCheckbox.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowCheckbox.Location = new System.Drawing.Point(18, 83);
            this.checkBoxShowCheckbox.Name = "checkBoxShowCheckbox";
            this.checkBoxShowCheckbox.Size = new System.Drawing.Size(144, 24);
            this.checkBoxShowCheckbox.TabIndex = 3;
            this.checkBoxShowCheckbox.Text = "Show checkbox";
            // 
            // checkBoxEditing
            // 
            this.checkBoxEditing.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEditing.Location = new System.Drawing.Point(18, 54);
            this.checkBoxEditing.Name = "checkBoxEditing";
            this.checkBoxEditing.Size = new System.Drawing.Size(123, 24);
            this.checkBoxEditing.TabIndex = 4;
            this.checkBoxEditing.Text = "Allow edting";
            // 
            // TreeView
            // 
            this.Name = "TreeView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.TreeView treeView1;
        private CheckBox checkBoxEditing;
        private CheckBox checkBoxShowCheckbox;
        private CheckBox checkBoxDragAndDrop;
        private ComboBox comboBoxExpandOn;
    }
}
