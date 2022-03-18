namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Grid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grid));
            this.grid1 = new Wisej.Web.Ext.Syncfusion2.Grid();
            this.checkBoxGrouping = new Wisej.Web.CheckBox();
            this.checkBoxReordering = new Wisej.Web.CheckBox();
            this.checkBoxResizing = new Wisej.Web.CheckBox();
            this.checkBoxFiltering = new Wisej.Web.CheckBox();
            this.comboBoxGridLine = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/grid/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/grid/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxGridLine);
            this.groupBox1.Controls.Add(this.checkBoxFiltering);
            this.groupBox1.Controls.Add(this.checkBoxResizing);
            this.groupBox1.Controls.Add(this.checkBoxReordering);
            this.groupBox1.Controls.Add(this.checkBoxGrouping);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxGrouping, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxReordering, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxResizing, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxFiltering, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxGridLine, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.grid1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/grid/grid-overview.html";
            // 
            // grid1
            // 
            this.grid1.Dock = Wisej.Web.DockStyle.Fill;
            this.grid1.Location = new System.Drawing.Point(8, 8);
            this.grid1.Name = "grid1";
            this.grid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("grid1.Options"))));
            this.grid1.Size = new System.Drawing.Size(1073, 542);
            this.grid1.TabIndex = 0;
            this.grid1.Text = "grid1";
            // 
            // checkBoxGrouping
            // 
            this.checkBoxGrouping.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxGrouping.Location = new System.Drawing.Point(16, 22);
            this.checkBoxGrouping.Name = "checkBoxGrouping";
            this.checkBoxGrouping.Size = new System.Drawing.Size(138, 24);
            this.checkBoxGrouping.TabIndex = 1;
            this.checkBoxGrouping.Text = "Allow grouping";
            // 
            // checkBoxReordering
            // 
            this.checkBoxReordering.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxReordering.Location = new System.Drawing.Point(16, 50);
            this.checkBoxReordering.Name = "checkBoxReordering";
            this.checkBoxReordering.Size = new System.Drawing.Size(146, 24);
            this.checkBoxReordering.TabIndex = 2;
            this.checkBoxReordering.Text = "Allow reordering";
            // 
            // checkBoxResizing
            // 
            this.checkBoxResizing.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxResizing.Location = new System.Drawing.Point(16, 80);
            this.checkBoxResizing.Name = "checkBoxResizing";
            this.checkBoxResizing.Size = new System.Drawing.Size(132, 24);
            this.checkBoxResizing.TabIndex = 3;
            this.checkBoxResizing.Text = "Allow resizing";
            // 
            // checkBoxFiltering
            // 
            this.checkBoxFiltering.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFiltering.Location = new System.Drawing.Point(16, 109);
            this.checkBoxFiltering.Name = "checkBoxFiltering";
            this.checkBoxFiltering.Size = new System.Drawing.Size(129, 24);
            this.checkBoxFiltering.TabIndex = 4;
            this.checkBoxFiltering.Text = "Allow filtering";
            // 
            // comboBoxGridLine
            // 
            this.comboBoxGridLine.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxGridLine.Items.AddRange(new object[] {
            "Default",
            "Both",
            "None",
            "Horizontal",
            "Vertical"});
            this.comboBoxGridLine.LabelText = "Grid line type";
            this.comboBoxGridLine.Location = new System.Drawing.Point(20, 139);
            this.comboBoxGridLine.Name = "comboBoxGridLine";
            this.comboBoxGridLine.Size = new System.Drawing.Size(208, 42);
            this.comboBoxGridLine.TabIndex = 5;
            // 
            // Grid
            // 
            this.Name = "Grid";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Grid grid1;
        private CheckBox checkBoxFiltering;
        private CheckBox checkBoxResizing;
        private CheckBox checkBoxReordering;
        private CheckBox checkBoxGrouping;
        private ComboBox comboBoxGridLine;
    }
}
