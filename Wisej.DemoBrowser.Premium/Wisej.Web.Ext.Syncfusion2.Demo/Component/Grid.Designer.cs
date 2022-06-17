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
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/grid/getting-started/";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/grid/";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.grid1);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBoxGrouping);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxReordering);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxResizing);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxFiltering);
			this.flowLayoutPanel1.Controls.Add(this.comboBoxGridLine);
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
			this.grid1.Size = new System.Drawing.Size(872, 560);
			this.grid1.TabIndex = 0;
			this.grid1.Text = "grid1";
			// 
			// checkBoxGrouping
			// 
			this.checkBoxGrouping.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxGrouping.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxGrouping, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxGrouping, true);
			this.checkBoxGrouping.Location = new System.Drawing.Point(3, 3);
			this.checkBoxGrouping.Name = "checkBoxGrouping";
			this.checkBoxGrouping.Size = new System.Drawing.Size(212, 24);
			this.checkBoxGrouping.TabIndex = 1;
			this.checkBoxGrouping.Text = "Allow Grouping";
			// 
			// checkBoxReordering
			// 
			this.checkBoxReordering.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxReordering.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxReordering, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxReordering, true);
			this.checkBoxReordering.Location = new System.Drawing.Point(3, 46);
			this.checkBoxReordering.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxReordering.Name = "checkBoxReordering";
			this.checkBoxReordering.Size = new System.Drawing.Size(212, 24);
			this.checkBoxReordering.TabIndex = 2;
			this.checkBoxReordering.Text = "Allow Reordering";
			// 
			// checkBoxResizing
			// 
			this.checkBoxResizing.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxResizing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxResizing, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxResizing, true);
			this.checkBoxResizing.Location = new System.Drawing.Point(3, 89);
			this.checkBoxResizing.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxResizing.Name = "checkBoxResizing";
			this.checkBoxResizing.Size = new System.Drawing.Size(212, 24);
			this.checkBoxResizing.TabIndex = 3;
			this.checkBoxResizing.Text = "Allow Resizing";
			// 
			// checkBoxFiltering
			// 
			this.checkBoxFiltering.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxFiltering.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxFiltering, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxFiltering, true);
			this.checkBoxFiltering.Location = new System.Drawing.Point(3, 132);
			this.checkBoxFiltering.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxFiltering.Name = "checkBoxFiltering";
			this.checkBoxFiltering.Size = new System.Drawing.Size(212, 24);
			this.checkBoxFiltering.TabIndex = 4;
			this.checkBoxFiltering.Text = "Allow Filtering";
			// 
			// comboBoxGridLine
			// 
			this.comboBoxGridLine.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanel1.SetFillWeight(this.comboBoxGridLine, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.comboBoxGridLine, true);
			this.comboBoxGridLine.Items.AddRange(new object[] {
            "Default",
            "Both",
            "None",
            "Horizontal",
            "Vertical"});
			this.comboBoxGridLine.LabelText = "Grid Line Type";
			this.comboBoxGridLine.Location = new System.Drawing.Point(3, 175);
			this.comboBoxGridLine.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBoxGridLine.Name = "comboBoxGridLine";
			this.comboBoxGridLine.Size = new System.Drawing.Size(212, 51);
			this.comboBoxGridLine.TabIndex = 5;
			this.comboBoxGridLine.Text = "Default";
			// 
			// Grid
			// 
			this.Name = "Grid";
			this.Load += new System.EventHandler(this.Grid_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

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
