namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
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
            this.treeMap1 = new Wisej.Web.Ext.Syncfusion2.TreeMap();
            this.checkBoxGroupingSeparator = new Wisej.Web.CheckBox();
            this.comboBoxRenderDirection = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/treemap/es5-getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/treemap/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxRenderDirection);
            this.groupBox1.Controls.Add(this.checkBoxGroupingSeparator);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxGroupingSeparator, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxRenderDirection, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.treeMap1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/treemap/default.html";
            // 
            // treeMap1
            // 
            this.treeMap1.Dock = Wisej.Web.DockStyle.Fill;
            this.treeMap1.Location = new System.Drawing.Point(8, 8);
            this.treeMap1.Name = "treeMap1";
            this.treeMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeMap1.Options"))));
            this.treeMap1.Size = new System.Drawing.Size(1073, 542);
            this.treeMap1.TabIndex = 0;
            this.treeMap1.Text = "treeMap1";
            // 
            // checkBoxGroupingSeparator
            // 
            this.checkBoxGroupingSeparator.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxGroupingSeparator.Location = new System.Drawing.Point(13, 36);
            this.checkBoxGroupingSeparator.Name = "checkBoxGroupingSeparator";
            this.checkBoxGroupingSeparator.Size = new System.Drawing.Size(226, 24);
            this.checkBoxGroupingSeparator.TabIndex = 1;
            this.checkBoxGroupingSeparator.Text = "Use Grouping Separator";
            // 
            // comboBoxRenderDirection
            // 
            this.comboBoxRenderDirection.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxRenderDirection.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxRenderDirection.Items.AddRange(new object[] {
            "TopLeftBottomRight",
            "TopRightBottomLeft",
            "BottomRightTopLeft",
            "BottomLeftTopRight"});
            this.comboBoxRenderDirection.LabelText = "Render direction";
            this.comboBoxRenderDirection.Location = new System.Drawing.Point(11, 75);
            this.comboBoxRenderDirection.Name = "comboBoxRenderDirection";
            this.comboBoxRenderDirection.Size = new System.Drawing.Size(226, 46);
            this.comboBoxRenderDirection.TabIndex = 2;
            // 
            // TreeMap
            // 
            this.Name = "TreeMap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.TreeMap treeMap1;
        private ComboBox comboBoxRenderDirection;
        private CheckBox checkBoxGroupingSeparator;
    }
}
