namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDropDownTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoDropDownTree));
            this.kendoDropDownTree1 = new Wisej.Web.Ext.Kendo.kendoDropDownTree();
            this.checkBoxCheckBoxes = new Wisej.Web.CheckBox();
            this.checkBoxCheckAll = new Wisej.Web.CheckBox();
            this.comboBoxTagMode = new Wisej.Web.ComboBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoDropDownTree1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/dropdowntree/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/dropdowntree";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/dropdowntree/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxTagMode);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxCheckBoxes);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxCheckAll);
            this.flowLayoutPanelProperties.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(218, 437);
            // 
            // kendoDropDownTree1
            // 
            this.kendoDropDownTree1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoDropDownTree1.Location = new System.Drawing.Point(394, 259);
            this.kendoDropDownTree1.Name = "kendoDropDownTree1";
            this.kendoDropDownTree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoDropDownTree1.Options"))));
            this.kendoDropDownTree1.Size = new System.Drawing.Size(300, 40);
            this.kendoDropDownTree1.TabIndex = 0;
            this.kendoDropDownTree1.Text = "kendoDropDownTree1";
            // 
            // checkBoxCheckBoxes
            // 
            this.checkBoxCheckBoxes.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxCheckBoxes.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxCheckBoxes.AutoSize = false;
            this.checkBoxCheckBoxes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCheckBoxes.Location = new System.Drawing.Point(3, 55);
            this.checkBoxCheckBoxes.Name = "checkBoxCheckBoxes";
            this.checkBoxCheckBoxes.Size = new System.Drawing.Size(212, 26);
            this.checkBoxCheckBoxes.TabIndex = 0;
            this.checkBoxCheckBoxes.Text = "CheckBoxes";
            this.checkBoxCheckBoxes.CheckedChanged += new System.EventHandler(this.checkBoxCheckBoxes_CheckedChanged);
            // 
            // checkBoxCheckAll
            // 
            this.checkBoxCheckAll.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxCheckAll.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxCheckAll.AutoSize = false;
            this.checkBoxCheckAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCheckAll.Enabled = false;
            this.checkBoxCheckAll.Location = new System.Drawing.Point(3, 87);
            this.checkBoxCheckAll.Name = "checkBoxCheckAll";
            this.checkBoxCheckAll.Size = new System.Drawing.Size(212, 26);
            this.checkBoxCheckAll.TabIndex = 1;
            this.checkBoxCheckAll.Text = "Check all";
            // 
            // comboBoxTagMode
            // 
            this.comboBoxTagMode.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxTagMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxTagMode.Items.AddRange(new object[] {
            "Multiple",
            "Single"});
            this.comboBoxTagMode.LabelText = "Tag mode";
            this.comboBoxTagMode.Location = new System.Drawing.Point(3, 3);
            this.comboBoxTagMode.Name = "comboBoxTagMode";
            this.comboBoxTagMode.Size = new System.Drawing.Size(212, 46);
            this.comboBoxTagMode.TabIndex = 2;
            // 
            // kendoDropDownTree
            // 
            this.Name = "kendoDropDownTree";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDropDownTree kendoDropDownTree1;
        private CheckBox checkBoxCheckBoxes;
        private CheckBox checkBoxCheckAll;
        private ComboBox comboBoxTagMode;
    }
}
