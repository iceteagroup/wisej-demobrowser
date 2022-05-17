namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class TreeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeTable));
            this.treeTable1 = new Wisej.Web.Ext.Webix.TreeTable();
            this.checkBoxEditable = new Wisej.Web.CheckBox();
            this.comboBoxEditaction = new Wisej.Web.ComboBox();
            this.checkBoxEnableMultiSelect = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/datatree__index.html";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#treetable";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://docs.webix.com/api__refs__ui.treetable.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.treeTable1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableMultiSelect);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEditable);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxEditaction);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 434);
            // 
            // treeTable1
            // 
            this.treeTable1.Dock = Wisej.Web.DockStyle.Fill;
            this.treeTable1.Location = new System.Drawing.Point(8, 8);
            this.treeTable1.Name = "treeTable1";
            this.treeTable1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeTable1.Options"))));
            this.treeTable1.Size = new System.Drawing.Size(1073, 542);
            this.treeTable1.TabIndex = 11;
            this.treeTable1.Text = "treeTable1";
            // 
            // checkBoxEditable
            // 
            this.checkBoxEditable.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEditable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEditable.AutoSize = false;
            this.checkBoxEditable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEditable.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEditable, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEditable, true);
            this.checkBoxEditable.Location = new System.Drawing.Point(3, 48);
            this.checkBoxEditable.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEditable.Name = "checkBoxEditable";
            this.checkBoxEditable.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEditable.TabIndex = 0;
            this.checkBoxEditable.Text = "Editable";
            this.checkBoxEditable.CheckedChanged += new System.EventHandler(this.checkBoxEditable_CheckedChanged);
            // 
            // comboBoxEditaction
            // 
            this.comboBoxEditaction.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxEditaction.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxEditaction, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxEditaction, true);
            this.comboBoxEditaction.Items.AddRange(new object[] {
            "click",
            "dblclick"});
            this.comboBoxEditaction.LabelText = "Edit Action";
            this.comboBoxEditaction.Location = new System.Drawing.Point(3, 93);
            this.comboBoxEditaction.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxEditaction.Name = "comboBoxEditaction";
            this.comboBoxEditaction.Size = new System.Drawing.Size(212, 57);
            this.comboBoxEditaction.TabIndex = 1;
            // 
            // checkBoxEnableMultiSelect
            // 
            this.checkBoxEnableMultiSelect.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableMultiSelect.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableMultiSelect.AutoSize = false;
            this.checkBoxEnableMultiSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEnableMultiSelect.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableMultiSelect, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableMultiSelect, true);
            this.checkBoxEnableMultiSelect.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEnableMultiSelect.Name = "checkBoxEnableMultiSelect";
            this.checkBoxEnableMultiSelect.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableMultiSelect.TabIndex = 2;
            this.checkBoxEnableMultiSelect.Text = "Enable Multi-Select";
            // 
            // TreeTable
            // 
            this.Name = "TreeTable";
            this.Load += new System.EventHandler(this.TreeTable_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.TreeTable treeTable1;
        private CheckBox checkBoxEditable;
        private ComboBox comboBoxEditaction;
        private CheckBox checkBoxEnableMultiSelect;
    }
}
