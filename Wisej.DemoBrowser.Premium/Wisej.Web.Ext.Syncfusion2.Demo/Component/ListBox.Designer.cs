namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class ListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBox));
            this.listBox1 = new Wisej.Web.Ext.Syncfusion2.ListBox();
            this.checkBoxDragAndDrop = new Wisej.Web.CheckBox();
            this.checkBoxFiltering = new Wisej.Web.CheckBox();
            this.comboBoxFilterType = new Wisej.Web.ComboBox();
            this.comboBoxSortOrder = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/list-box/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/list-box/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSortOrder);
            this.groupBox1.Controls.Add(this.comboBoxFilterType);
            this.groupBox1.Controls.Add(this.checkBoxFiltering);
            this.groupBox1.Controls.Add(this.checkBoxDragAndDrop);
            this.groupBox1.Size = new System.Drawing.Size(250, 351);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxDragAndDrop, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxFiltering, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxFilterType, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxSortOrder, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 270);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.listBox1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/list-box/default.html";
            // 
            // listBox1
            // 
            this.listBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.listBox1.Location = new System.Drawing.Point(8, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("listBox1.Options"))));
            this.listBox1.Size = new System.Drawing.Size(1073, 542);
            this.listBox1.TabIndex = 0;
            this.listBox1.Text = "listBox1";
            // 
            // checkBoxDragAndDrop
            // 
            this.checkBoxDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDragAndDrop.Location = new System.Drawing.Point(17, 30);
            this.checkBoxDragAndDrop.Name = "checkBoxDragAndDrop";
            this.checkBoxDragAndDrop.Size = new System.Drawing.Size(197, 24);
            this.checkBoxDragAndDrop.TabIndex = 1;
            this.checkBoxDragAndDrop.Text = "Allow drag-and-drop";
            // 
            // checkBoxFiltering
            // 
            this.checkBoxFiltering.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFiltering.Location = new System.Drawing.Point(17, 74);
            this.checkBoxFiltering.Name = "checkBoxFiltering";
            this.checkBoxFiltering.Size = new System.Drawing.Size(147, 24);
            this.checkBoxFiltering.TabIndex = 2;
            this.checkBoxFiltering.Text = "Allow filtering";
            this.checkBoxFiltering.CheckedChanged += new System.EventHandler(this.checkBoxFiltering_CheckedChanged);
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxFilterType.Enabled = false;
            this.comboBoxFilterType.Items.AddRange(new object[] {
            "StartsWith",
            "EndsWith",
            "Contains"});
            this.comboBoxFilterType.LabelText = "Filter type";
            this.comboBoxFilterType.Location = new System.Drawing.Point(20, 112);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(203, 46);
            this.comboBoxFilterType.TabIndex = 3;
            // 
            // comboBoxSortOrder
            // 
            this.comboBoxSortOrder.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxSortOrder.Items.AddRange(new object[] {
            "None",
            "Ascending",
            "Descending"});
            this.comboBoxSortOrder.LabelText = "Sort order";
            this.comboBoxSortOrder.Location = new System.Drawing.Point(20, 179);
            this.comboBoxSortOrder.Name = "comboBoxSortOrder";
            this.comboBoxSortOrder.Size = new System.Drawing.Size(203, 46);
            this.comboBoxSortOrder.TabIndex = 4;
            // 
            // ListBox
            // 
            this.Name = "ListBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.ListBox listBox1;
        private ComboBox comboBoxSortOrder;
        private ComboBox comboBoxFilterType;
        private CheckBox checkBoxFiltering;
        private CheckBox checkBoxDragAndDrop;
    }
}
