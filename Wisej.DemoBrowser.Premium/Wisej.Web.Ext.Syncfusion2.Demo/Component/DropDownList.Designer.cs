namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class DropDownList
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
            this.tagTextBoxDataSource = new Wisej.Web.TagTextBox();
            this.checkBoxSearchable = new Wisej.Web.CheckBox();
            this.comboBoxSortOrder = new Wisej.Web.ComboBox();
            this.dropDownList1 = new Wisej.Web.Ext.Syncfusion2.DropDownList();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/drop-down-list/es5-getting-st" +
    "arted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/drop-down-list/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSortOrder);
            this.groupBox1.Controls.Add(this.checkBoxSearchable);
            this.groupBox1.Controls.Add(this.tagTextBoxDataSource);
            this.groupBox1.Size = new System.Drawing.Size(250, 429);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.tagTextBoxDataSource, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxSearchable, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxSortOrder, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 346);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dropDownList1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/drop-down-list/default.html";
            // 
            // tagTextBoxDataSource
            // 
            this.tagTextBoxDataSource.LabelText = "Data source";
            this.tagTextBoxDataSource.Location = new System.Drawing.Point(15, 181);
            this.tagTextBoxDataSource.MaxTagCount = 10;
            this.tagTextBoxDataSource.Multiline = true;
            this.tagTextBoxDataSource.Name = "tagTextBoxDataSource";
            this.tagTextBoxDataSource.Size = new System.Drawing.Size(216, 141);
            this.tagTextBoxDataSource.TabIndex = 1;
            this.tagTextBoxDataSource.Text = "data1,data2\r\n";
            // 
            // checkBoxSearchable
            // 
            this.checkBoxSearchable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxSearchable.Location = new System.Drawing.Point(15, 29);
            this.checkBoxSearchable.Name = "checkBoxSearchable";
            this.checkBoxSearchable.Size = new System.Drawing.Size(134, 24);
            this.checkBoxSearchable.TabIndex = 2;
            this.checkBoxSearchable.Text = "Searchable";
            // 
            // comboBoxSortOrder
            // 
            this.comboBoxSortOrder.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxSortOrder.Items.AddRange(new object[] {
            "None",
            "Ascending",
            "Descending"});
            this.comboBoxSortOrder.LabelText = "Sort order";
            this.comboBoxSortOrder.Location = new System.Drawing.Point(15, 90);
            this.comboBoxSortOrder.Name = "comboBoxSortOrder";
            this.comboBoxSortOrder.Size = new System.Drawing.Size(216, 46);
            this.comboBoxSortOrder.TabIndex = 3;
            // 
            // dropDownList1
            // 
            this.dropDownList1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dropDownList1.Location = new System.Drawing.Point(369, 262);
            this.dropDownList1.Name = "dropDownList1";
            this.dropDownList1.Size = new System.Drawing.Size(350, 35);
            this.dropDownList1.TabIndex = 0;
            this.dropDownList1.Text = "dropDownList1";
            // 
            // DropDownList
            // 
            this.Name = "DropDownList";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.DropDownList dropDownList1;
        private TagTextBox tagTextBoxDataSource;
        private ComboBox comboBoxSortOrder;
        private CheckBox checkBoxSearchable;
    }
}
