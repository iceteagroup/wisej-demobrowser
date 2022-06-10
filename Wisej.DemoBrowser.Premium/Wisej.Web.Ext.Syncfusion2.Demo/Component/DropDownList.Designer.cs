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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropDownList));
			this.tagTextBoxDataSource = new Wisej.Web.TagTextBox();
			this.checkBoxSearchable = new Wisej.Web.CheckBox();
			this.comboBoxSortOrder = new Wisej.Web.ComboBox();
			this.dropDownList1 = new Wisej.Web.Ext.Syncfusion2.DropDownList();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/drop-down-list/es5-getting-st" +
    "arted/";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/drop-down-list/";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dropDownList1);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBoxSearchable);
			this.flowLayoutPanel1.Controls.Add(this.comboBoxSortOrder);
			this.flowLayoutPanel1.Controls.Add(this.tagTextBoxDataSource);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/drop-down-list/default.html";
			// 
			// tagTextBoxDataSource
			// 
			this.tagTextBoxDataSource.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.tagTextBoxDataSource, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.tagTextBoxDataSource, true);
			this.tagTextBoxDataSource.LabelText = "Data Source";
			this.tagTextBoxDataSource.Location = new System.Drawing.Point(3, 116);
			this.tagTextBoxDataSource.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.tagTextBoxDataSource.MaxTagCount = 10;
			this.tagTextBoxDataSource.Multiline = true;
			this.tagTextBoxDataSource.Name = "tagTextBoxDataSource";
			this.tagTextBoxDataSource.Size = new System.Drawing.Size(212, 239);
			this.tagTextBoxDataSource.TabIndex = 1;
			this.tagTextBoxDataSource.Text = resources.GetString("tagTextBoxDataSource.Text");
			// 
			// checkBoxSearchable
			// 
			this.checkBoxSearchable.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxSearchable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxSearchable, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxSearchable, true);
			this.checkBoxSearchable.Location = new System.Drawing.Point(3, 3);
			this.checkBoxSearchable.Name = "checkBoxSearchable";
			this.checkBoxSearchable.Size = new System.Drawing.Size(212, 24);
			this.checkBoxSearchable.TabIndex = 2;
			this.checkBoxSearchable.Text = "Searchable";
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
			this.comboBoxSortOrder.Location = new System.Drawing.Point(3, 46);
			this.comboBoxSortOrder.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBoxSortOrder.Name = "comboBoxSortOrder";
			this.comboBoxSortOrder.Size = new System.Drawing.Size(212, 51);
			this.comboBoxSortOrder.TabIndex = 3;
			// 
			// dropDownList1
			// 
			this.dropDownList1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dropDownList1.Location = new System.Drawing.Point(269, 268);
			this.dropDownList1.Name = "dropDownList1";
			this.dropDownList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dropDownList1.Options"))));
			this.dropDownList1.Size = new System.Drawing.Size(350, 40);
			this.dropDownList1.TabIndex = 0;
			this.dropDownList1.Text = "dropDownList1";
			// 
			// DropDownList
			// 
			this.Name = "DropDownList";
			this.Load += new System.EventHandler(this.DropDownList_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.DropDownList dropDownList1;
        private TagTextBox tagTextBoxDataSource;
        private ComboBox comboBoxSortOrder;
        private CheckBox checkBoxSearchable;
    }
}
