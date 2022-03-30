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
            this.flowLayoutPanel1.SuspendLayout();
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
            this.flowLayoutPanel1.Controls.Add(this.comboBoxNode);
            this.flowLayoutPanel1.Controls.Add(this.tagTextBoxSubNodeDataSource);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/drop-down-tree/default.html";
            // 
            // comboBoxNode
            // 
            this.comboBoxNode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxNode, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxNode, true);
            this.comboBoxNode.Items.AddRange(new object[] {
            "Boot",
            "FileManager",
            "System32"});
            this.comboBoxNode.LabelText = "Node";
            this.comboBoxNode.Location = new System.Drawing.Point(3, 3);
            this.comboBoxNode.Name = "comboBoxNode";
            this.comboBoxNode.Size = new System.Drawing.Size(212, 57);
            this.comboBoxNode.TabIndex = 2;
            // 
            // tagTextBoxSubNodeDataSource
            // 
            this.tagTextBoxSubNodeDataSource.AutoSize = false;
            this.flowLayoutPanel1.SetFillWeight(this.tagTextBoxSubNodeDataSource, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.tagTextBoxSubNodeDataSource, true);
            this.tagTextBoxSubNodeDataSource.LabelText = "Sub-Node Items";
            this.tagTextBoxSubNodeDataSource.Location = new System.Drawing.Point(3, 79);
            this.tagTextBoxSubNodeDataSource.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.tagTextBoxSubNodeDataSource.MaxLength = 10;
            this.tagTextBoxSubNodeDataSource.MaxTagCount = 10;
            this.tagTextBoxSubNodeDataSource.Multiline = true;
            this.tagTextBoxSubNodeDataSource.Name = "tagTextBoxSubNodeDataSource";
            this.tagTextBoxSubNodeDataSource.Size = new System.Drawing.Size(212, 142);
            this.tagTextBoxSubNodeDataSource.TabIndex = 3;
            // 
            // dropDownTree1
            // 
            this.dropDownTree1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dropDownTree1.Location = new System.Drawing.Point(369, 259);
            this.dropDownTree1.Name = "dropDownTree1";
            this.dropDownTree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"fields\":{\"dataSource\":[{\"id\":\"1\",\"name\":\"Boot\"},{\"id\":\"2\",\"name\":\"FileManager\"}" +
        ",{\"id\":\"3\",\"name\":\"System32\"}],\"value\":\"id\",\"text\":\"name\",\"child\":\"subChild\",\"ex" +
        "panded\":\"expanded\"}}")));
            this.dropDownTree1.Size = new System.Drawing.Size(350, 40);
            this.dropDownTree1.TabIndex = 0;
            this.dropDownTree1.Text = "dropDownTree1";
            // 
            // DropDownTree
            // 
            this.Name = "DropDownTree";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.DropDownTree dropDownTree1;
        private ComboBox comboBoxNode;
        private TagTextBox tagTextBoxSubNodeDataSource;
    }
}
