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
            this.comboBoxNode = new Wisej.Web.ComboBox();
            this.tagTextBoxSubNodeDataSource = new Wisej.Web.TagTextBox();
            this.dropDownTree1 = new Wisej.Web.Ext.Syncfusion2.DropDownTree();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/drop-down-tree/es5-getting-st" +
    "arted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/drop-down-tree/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tagTextBoxSubNodeDataSource);
            this.groupBox1.Controls.Add(this.comboBoxNode);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxNode, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.tagTextBoxSubNodeDataSource, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 224);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dropDownTree1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/drop-down-tree/default.html";
            // 
            // comboBoxNode
            // 
            this.comboBoxNode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxNode.Items.AddRange(new object[] {
            "Boot",
            "FileManager",
            "System32"});
            this.comboBoxNode.LabelText = "Node";
            this.comboBoxNode.Location = new System.Drawing.Point(28, 38);
            this.comboBoxNode.Name = "comboBoxNode";
            this.comboBoxNode.Size = new System.Drawing.Size(196, 53);
            this.comboBoxNode.TabIndex = 2;
            // 
            // tagTextBoxSubNodeDataSource
            // 
            this.tagTextBoxSubNodeDataSource.LabelText = "Sub node data source";
            this.tagTextBoxSubNodeDataSource.Location = new System.Drawing.Point(28, 109);
            this.tagTextBoxSubNodeDataSource.MaxLength = 10;
            this.tagTextBoxSubNodeDataSource.MaxTagCount = 10;
            this.tagTextBoxSubNodeDataSource.Multiline = true;
            this.tagTextBoxSubNodeDataSource.Name = "tagTextBoxSubNodeDataSource";
            this.tagTextBoxSubNodeDataSource.Size = new System.Drawing.Size(196, 212);
            this.tagTextBoxSubNodeDataSource.TabIndex = 3;
            // 
            // dropDownTree1
            // 
            this.dropDownTree1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dropDownTree1.Location = new System.Drawing.Point(369, 262);
            this.dropDownTree1.Name = "dropDownTree1";
            this.dropDownTree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"fields\":{\"dataSource\":[{\"id\":\"1\",\"name\":\"Boot\"},{\"id\":\"2\",\"name\":\"FileManager\"}" +
        ",{\"id\":\"3\",\"name\":\"System32\"}],\"value\":\"id\",\"text\":\"name\",\"child\":\"subChild\",\"ex" +
        "panded\":\"expanded\"}}")));
            this.dropDownTree1.Size = new System.Drawing.Size(350, 35);
            this.dropDownTree1.TabIndex = 0;
            this.dropDownTree1.Text = "dropDownTree1";
            // 
            // DropDownTree
            // 
            this.Name = "DropDownTree";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.DropDownTree dropDownTree1;
        private ComboBox comboBoxNode;
        private TagTextBox tagTextBoxSubNodeDataSource;
    }
}
