namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class TreeMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeMap));
            this.treeMap1 = new Wisej.Web.Ext.Webix.TreeMap();
            this.checkBoxEnableSelect = new Wisej.Web.CheckBox();
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
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#treemap";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.treemap.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.treeMap1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableSelect);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableMultiSelect);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 434);
            // 
            // treeMap1
            // 
            this.treeMap1.Anchor = Wisej.Web.AnchorStyles.None;
            this.treeMap1.Location = new System.Drawing.Point(294, 79);
            this.treeMap1.Name = "treeMap1";
            this.treeMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeMap1.Options"))));
            this.treeMap1.Size = new System.Drawing.Size(500, 400);
            this.treeMap1.TabIndex = 11;
            this.treeMap1.Text = "treeMap1";
            // 
            // checkBoxEnableSelect
            // 
            this.checkBoxEnableSelect.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableSelect.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableSelect.AutoSize = false;
            this.checkBoxEnableSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEnableSelect.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableSelect, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableSelect, true);
            this.checkBoxEnableSelect.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEnableSelect.Name = "checkBoxEnableSelect";
            this.checkBoxEnableSelect.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableSelect.TabIndex = 3;
            this.checkBoxEnableSelect.Text = "Enable Select";
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
            this.checkBoxEnableMultiSelect.Location = new System.Drawing.Point(3, 48);
            this.checkBoxEnableMultiSelect.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEnableMultiSelect.Name = "checkBoxEnableMultiSelect";
            this.checkBoxEnableMultiSelect.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableMultiSelect.TabIndex = 4;
            this.checkBoxEnableMultiSelect.Text = "Enable Multi-Select";
            // 
            // TreeMap
            // 
            this.Name = "TreeMap";
            this.Load += new System.EventHandler(this.TreeMap_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.TreeMap treeMap1;
        private CheckBox checkBoxEnableSelect;
        private CheckBox checkBoxEnableMultiSelect;
    }
}
