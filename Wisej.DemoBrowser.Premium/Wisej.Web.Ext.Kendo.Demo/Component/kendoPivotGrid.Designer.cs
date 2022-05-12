namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoPivotGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoPivotGrid));
            this.checkBoxReorderable = new Wisej.Web.CheckBox();
            this.checkBoxFilterable = new Wisej.Web.CheckBox();
            this.checkBoxSortable = new Wisej.Web.CheckBox();
            this.buttonExport = new Wisej.Web.Button();
            this.kendoPivotGrid1 = new Wisej.Web.Ext.Kendo.kendoPivotGrid();
            this.buttonPDF = new Wisej.Web.Button();
            this.numericUpDownColumnWidth = new Wisej.Web.NumericUpDown();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoPivotGrid1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/pivotgrid/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/pivotgrid";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/data-management/pivotgrid/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxReorderable);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxFilterable);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxSortable);
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDownColumnWidth);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonExport);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonPDF);
            // 
            // checkBoxReorderable
            // 
            this.checkBoxReorderable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxReorderable.AutoSize = false;
            this.checkBoxReorderable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxReorderable.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxReorderable, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxReorderable, true);
            this.checkBoxReorderable.Location = new System.Drawing.Point(3, 3);
            this.checkBoxReorderable.Name = "checkBoxReorderable";
            this.checkBoxReorderable.Size = new System.Drawing.Size(212, 38);
            this.checkBoxReorderable.TabIndex = 5;
            this.checkBoxReorderable.Text = "Reorderable";
            // 
            // checkBoxFilterable
            // 
            this.checkBoxFilterable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFilterable.AutoSize = false;
            this.checkBoxFilterable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxFilterable.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxFilterable, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxFilterable, true);
            this.checkBoxFilterable.Location = new System.Drawing.Point(3, 60);
            this.checkBoxFilterable.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxFilterable.Name = "checkBoxFilterable";
            this.checkBoxFilterable.Size = new System.Drawing.Size(212, 38);
            this.checkBoxFilterable.TabIndex = 6;
            this.checkBoxFilterable.Text = "Filterable";
            // 
            // checkBoxSortable
            // 
            this.checkBoxSortable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxSortable.AutoSize = false;
            this.checkBoxSortable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSortable.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxSortable, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxSortable, true);
            this.checkBoxSortable.Location = new System.Drawing.Point(3, 117);
            this.checkBoxSortable.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxSortable.Name = "checkBoxSortable";
            this.checkBoxSortable.Size = new System.Drawing.Size(212, 38);
            this.checkBoxSortable.TabIndex = 7;
            this.checkBoxSortable.Text = "Sortable";
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/microsoft-excel-logo.svg";
            this.buttonExport.Location = new System.Drawing.Point(3, 253);
            this.buttonExport.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(42, 42);
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // kendoPivotGrid1
            // 
            this.kendoPivotGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.kendoPivotGrid1.Location = new System.Drawing.Point(31, 23);
            this.kendoPivotGrid1.Name = "kendoPivotGrid1";
            this.kendoPivotGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoPivotGrid1.Options"))));
            this.kendoPivotGrid1.Size = new System.Drawing.Size(1027, 511);
            this.kendoPivotGrid1.TabIndex = 0;
            this.kendoPivotGrid1.Text = "kendoPivotGrid1";
            this.kendoPivotGrid1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoPivotGrid1_WebRequest);
            // 
            // buttonPDF
            // 
            this.buttonPDF.Display = Wisej.Web.Display.Icon;
            this.buttonPDF.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
            this.buttonPDF.Location = new System.Drawing.Point(51, 253);
            this.buttonPDF.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(42, 42);
            this.buttonPDF.TabIndex = 10;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // numericUpDownColumnWidth
            // 
            this.numericUpDownColumnWidth.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDownColumnWidth, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDownColumnWidth, true);
            this.numericUpDownColumnWidth.Label.Size = 50;
            this.numericUpDownColumnWidth.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDownColumnWidth.LabelText = "Column Width";
            this.numericUpDownColumnWidth.Location = new System.Drawing.Point(3, 174);
            this.numericUpDownColumnWidth.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownColumnWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownColumnWidth.Name = "numericUpDownColumnWidth";
            this.numericUpDownColumnWidth.Size = new System.Drawing.Size(212, 60);
            this.numericUpDownColumnWidth.TabIndex = 9;
            this.numericUpDownColumnWidth.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // kendoPivotGrid
            // 
            this.MinimumSize = new System.Drawing.Size(887, 615);
            this.Name = "kendoPivotGrid";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoPivotGrid kendoPivotGrid1;
		private CheckBox checkBoxReorderable;
		private Button buttonExport;
		private CheckBox checkBoxSortable;
		private CheckBox checkBoxFilterable;
		private Button buttonPDF;
        private NumericUpDown numericUpDownColumnWidth;
    }
}
