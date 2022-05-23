namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class DropDownTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropDownTree));
            this.dropDownTree1 = new Wisej.Web.Ext.Syncfusion2.DropDownTree();
            this.checkBoxFiltering = new Wisej.Web.CheckBox();
            this.checkBoxMultiSelection = new Wisej.Web.CheckBox();
            this.textBoxPlaceholder = new Wisej.Web.TextBox();
            this.checkBoxReadOnly = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/drop-down-tree/es5-getting-st" +
    "arted/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/drop-down-tree/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dropDownTree1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxFiltering);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxMultiSelection);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxReadOnly);
            this.flowLayoutPanel1.Controls.Add(this.textBoxPlaceholder);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/drop-down-tree/default.html";
            // 
            // dropDownTree1
            // 
            this.dropDownTree1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dropDownTree1.Location = new System.Drawing.Point(269, 268);
            this.dropDownTree1.Name = "dropDownTree1";
            this.dropDownTree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dropDownTree1.Options"))));
            this.dropDownTree1.Size = new System.Drawing.Size(350, 40);
            this.dropDownTree1.TabIndex = 0;
            this.dropDownTree1.Text = "dropDownTree1";
            // 
            // checkBoxFiltering
            // 
            this.checkBoxFiltering.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFiltering.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxFiltering, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxFiltering, true);
            this.checkBoxFiltering.Location = new System.Drawing.Point(3, 3);
            this.checkBoxFiltering.Name = "checkBoxFiltering";
            this.checkBoxFiltering.Size = new System.Drawing.Size(212, 24);
            this.checkBoxFiltering.TabIndex = 0;
            this.checkBoxFiltering.Text = "Filtering";
            // 
            // checkBoxMultiSelection
            // 
            this.checkBoxMultiSelection.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxMultiSelection.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxMultiSelection, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxMultiSelection, true);
            this.checkBoxMultiSelection.Location = new System.Drawing.Point(3, 46);
            this.checkBoxMultiSelection.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxMultiSelection.Name = "checkBoxMultiSelection";
            this.checkBoxMultiSelection.Size = new System.Drawing.Size(212, 24);
            this.checkBoxMultiSelection.TabIndex = 1;
            this.checkBoxMultiSelection.Text = "Multi Selection";
            // 
            // textBoxPlaceholder
            // 
            this.flowLayoutPanel1.SetFillWeight(this.textBoxPlaceholder, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxPlaceholder, true);
            this.textBoxPlaceholder.LabelText = "Placeholder";
            this.textBoxPlaceholder.Location = new System.Drawing.Point(3, 132);
            this.textBoxPlaceholder.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.textBoxPlaceholder.Name = "textBoxPlaceholder";
            this.textBoxPlaceholder.Size = new System.Drawing.Size(212, 57);
            this.textBoxPlaceholder.TabIndex = 2;
            this.textBoxPlaceholder.Text = "Select a folder or file";
            // 
            // checkBoxReadOnly
            // 
            this.checkBoxReadOnly.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxReadOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxReadOnly, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxReadOnly, true);
            this.checkBoxReadOnly.Location = new System.Drawing.Point(3, 89);
            this.checkBoxReadOnly.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(212, 24);
            this.checkBoxReadOnly.TabIndex = 3;
            this.checkBoxReadOnly.Text = "Read Only";
            // 
            // DropDownTree
            // 
            this.Name = "DropDownTree";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.DropDownTree dropDownTree1;
        private CheckBox checkBoxFiltering;
        private CheckBox checkBoxMultiSelection;
        private TextBox textBoxPlaceholder;
        private CheckBox checkBoxReadOnly;
    }
}
