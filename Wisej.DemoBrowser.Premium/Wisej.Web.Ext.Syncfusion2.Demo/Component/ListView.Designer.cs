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
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/listview/getting-started/";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/list-view/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.listView1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxHeader);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxPosition);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxSortOrder);
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
            this.checkBoxShowCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxShowCheckBox, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxShowCheckBox, true);
            this.checkBoxShowCheckBox.Location = new System.Drawing.Point(3, 3);
            this.checkBoxShowCheckBox.Name = "checkBoxShowCheckBox";
            this.checkBoxShowCheckBox.Size = new System.Drawing.Size(212, 24);
            this.checkBoxShowCheckBox.TabIndex = 2;
            this.checkBoxShowCheckBox.Text = "Show Checkbox";
            this.checkBoxShowCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxShowCheckBox_CheckedChanged);
            // 
            // checkBoxHeader
            // 
            this.checkBoxHeader.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxHeader.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxHeader, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxHeader, true);
            this.checkBoxHeader.Location = new System.Drawing.Point(3, 46);
            this.checkBoxHeader.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxHeader.Name = "checkBoxHeader";
            this.checkBoxHeader.Size = new System.Drawing.Size(212, 24);
            this.checkBoxHeader.TabIndex = 3;
            this.checkBoxHeader.Text = "Show Header";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Enabled = false;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxPosition, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxPosition, true);
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.comboBoxPosition.LabelText = "CheckBox Position";
            this.comboBoxPosition.Location = new System.Drawing.Point(3, 89);
            this.comboBoxPosition.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(212, 46);
            this.comboBoxPosition.TabIndex = 4;
            // 
            // comboBoxSortOrder
            // 
            this.comboBoxSortOrder.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxSortOrder, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxSortOrder, true);
            this.comboBoxSortOrder.Items.AddRange(new object[] {
            "None",
            "Ascending",
            "Descending"});
            this.comboBoxSortOrder.LabelText = "Sort Order";
            this.comboBoxSortOrder.Location = new System.Drawing.Point(3, 154);
            this.comboBoxSortOrder.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxSortOrder.Name = "comboBoxSortOrder";
            this.comboBoxSortOrder.Size = new System.Drawing.Size(212, 46);
            this.comboBoxSortOrder.TabIndex = 5;
            // 
            // ListView
            // 
            this.Name = "ListView";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
