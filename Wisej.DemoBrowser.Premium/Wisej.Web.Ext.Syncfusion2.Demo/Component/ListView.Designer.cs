namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class ListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
            this.listView1 = new Wisej.Web.Ext.Syncfusion2.ListView();
            this.checkBoxShowCheckBox = new Wisej.Web.CheckBox();
            this.checkBoxHeader = new Wisej.Web.CheckBox();
            this.comboBoxPosition = new Wisej.Web.ComboBox();
            this.comboBoxSortOrder = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/listview/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/list-view/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSortOrder);
            this.groupBox1.Controls.Add(this.comboBoxPosition);
            this.groupBox1.Controls.Add(this.checkBoxHeader);
            this.groupBox1.Controls.Add(this.checkBoxShowCheckBox);
            this.groupBox1.Size = new System.Drawing.Size(250, 408);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxShowCheckBox, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxHeader, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxPosition, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxSortOrder, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 327);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.listView1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/listview/default.html";
            // 
            // listView1
            // 
            this.listView1.Dock = Wisej.Web.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(8, 8);
            this.listView1.Name = "listView1";
            this.listView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("listView1.Options"))));
            this.listView1.Size = new System.Drawing.Size(1073, 542);
            this.listView1.TabIndex = 0;
            this.listView1.Text = "listView1";
            // 
            // checkBoxShowCheckBox
            // 
            this.checkBoxShowCheckBox.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowCheckBox.Location = new System.Drawing.Point(25, 46);
            this.checkBoxShowCheckBox.Name = "checkBoxShowCheckBox";
            this.checkBoxShowCheckBox.Size = new System.Drawing.Size(164, 24);
            this.checkBoxShowCheckBox.TabIndex = 2;
            this.checkBoxShowCheckBox.Text = "Show checkbox";
            this.checkBoxShowCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxShowCheckBox_CheckedChanged);
            // 
            // checkBoxHeader
            // 
            this.checkBoxHeader.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxHeader.Location = new System.Drawing.Point(25, 83);
            this.checkBoxHeader.Name = "checkBoxHeader";
            this.checkBoxHeader.Size = new System.Drawing.Size(147, 24);
            this.checkBoxHeader.TabIndex = 3;
            this.checkBoxHeader.Text = "Show header";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Enabled = false;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.comboBoxPosition.LabelText = "CheckBox position";
            this.comboBoxPosition.Location = new System.Drawing.Point(23, 119);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(200, 46);
            this.comboBoxPosition.TabIndex = 4;
            // 
            // comboBoxSortOrder
            // 
            this.comboBoxSortOrder.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxSortOrder.Items.AddRange(new object[] {
            "None",
            "Ascending",
            "Descending"});
            this.comboBoxSortOrder.LabelText = "Sort order";
            this.comboBoxSortOrder.Location = new System.Drawing.Point(23, 183);
            this.comboBoxSortOrder.Name = "comboBoxSortOrder";
            this.comboBoxSortOrder.Size = new System.Drawing.Size(200, 46);
            this.comboBoxSortOrder.TabIndex = 5;
            // 
            // ListView
            // 
            this.Name = "ListView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.ListView listView1;
        private ComboBox comboBoxSortOrder;
        private ComboBox comboBoxPosition;
        private CheckBox checkBoxHeader;
        private CheckBox checkBoxShowCheckBox;
    }
}
