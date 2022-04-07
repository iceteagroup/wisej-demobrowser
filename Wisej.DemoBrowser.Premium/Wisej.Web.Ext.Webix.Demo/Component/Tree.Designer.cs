namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Tree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tree));
            this.tree1 = new Wisej.Web.Ext.Webix.Tree();
            this.checkBoxDragScroll = new Wisej.Web.CheckBox();
            this.checkBoxMultiSelect = new Wisej.Web.CheckBox();
            this.checkBoxEnableSelect = new Wisej.Web.CheckBox();
            this.checkBoxEnableThreeState = new Wisej.Web.CheckBox();
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
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#tree";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.tree.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tree1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxDragScroll);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxMultiSelect);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableSelect);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableThreeState);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 434);
            // 
            // tree1
            // 
            this.tree1.Anchor = Wisej.Web.AnchorStyles.None;
            this.tree1.Location = new System.Drawing.Point(418, 162);
            this.tree1.Name = "tree1";
            this.tree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("tree1.Options"))));
            this.tree1.Size = new System.Drawing.Size(253, 235);
            this.tree1.TabIndex = 0;
            this.tree1.Text = "tree1";
            // 
            // checkBoxDragScroll
            // 
            this.checkBoxDragScroll.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxDragScroll.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDragScroll.AutoSize = false;
            this.checkBoxDragScroll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDragScroll.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxDragScroll, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxDragScroll, true);
            this.checkBoxDragScroll.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDragScroll.Name = "checkBoxDragScroll";
            this.checkBoxDragScroll.Size = new System.Drawing.Size(212, 26);
            this.checkBoxDragScroll.TabIndex = 4;
            this.checkBoxDragScroll.Text = "Enable Drag Scroll";
            // 
            // checkBoxMultiSelect
            // 
            this.checkBoxMultiSelect.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxMultiSelect.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxMultiSelect.AutoSize = false;
            this.checkBoxMultiSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxMultiSelect, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxMultiSelect, true);
            this.checkBoxMultiSelect.Location = new System.Drawing.Point(3, 48);
            this.checkBoxMultiSelect.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxMultiSelect.Name = "checkBoxMultiSelect";
            this.checkBoxMultiSelect.Size = new System.Drawing.Size(212, 26);
            this.checkBoxMultiSelect.TabIndex = 5;
            this.checkBoxMultiSelect.Text = "Enable Multi-Select";
            // 
            // checkBoxEnableSelect
            // 
            this.checkBoxEnableSelect.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableSelect.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableSelect.AutoSize = false;
            this.checkBoxEnableSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableSelect, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableSelect, true);
            this.checkBoxEnableSelect.Location = new System.Drawing.Point(3, 93);
            this.checkBoxEnableSelect.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEnableSelect.Name = "checkBoxEnableSelect";
            this.checkBoxEnableSelect.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableSelect.TabIndex = 6;
            this.checkBoxEnableSelect.Text = "Enable Select";
            // 
            // checkBoxEnableThreeState
            // 
            this.checkBoxEnableThreeState.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableThreeState.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableThreeState.AutoSize = false;
            this.checkBoxEnableThreeState.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableThreeState, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableThreeState, true);
            this.checkBoxEnableThreeState.Location = new System.Drawing.Point(3, 138);
            this.checkBoxEnableThreeState.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEnableThreeState.Name = "checkBoxEnableThreeState";
            this.checkBoxEnableThreeState.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableThreeState.TabIndex = 7;
            this.checkBoxEnableThreeState.Text = "Enable Three-State";
            // 
            // Tree
            // 
            this.Name = "Tree";
            this.Load += new System.EventHandler(this.Tree_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Tree tree1;
        private CheckBox checkBoxDragScroll;
        private CheckBox checkBoxMultiSelect;
        private CheckBox checkBoxEnableSelect;
        private CheckBox checkBoxEnableThreeState;
    }
}
