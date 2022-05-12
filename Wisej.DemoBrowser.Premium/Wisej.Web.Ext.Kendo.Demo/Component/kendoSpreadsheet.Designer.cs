namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoSpreadsheet
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
            this.buttonPDF = new Wisej.Web.Button();
            this.buttonExport = new Wisej.Web.Button();
            this.kendoSpreadsheet1 = new Wisej.Web.Ext.Kendo.kendoSpreadsheet();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.buttonAddSheet = new Wisej.Web.Button();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoSpreadsheet1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/spreadsheet/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/spreadsheet";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/data-management/spreadsheet/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown2);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonAddSheet);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonExport);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonPDF);
            // 
            // buttonPDF
            // 
            this.buttonPDF.Display = Wisej.Web.Display.Icon;
            this.buttonPDF.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
            this.buttonPDF.Location = new System.Drawing.Point(51, 265);
            this.buttonPDF.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(42, 42);
            this.buttonPDF.TabIndex = 14;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/microsoft-excel-logo.svg";
            this.buttonExport.Location = new System.Drawing.Point(3, 265);
            this.buttonExport.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(42, 42);
            this.buttonExport.TabIndex = 13;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // kendoSpreadsheet1
            // 
            this.kendoSpreadsheet1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.kendoSpreadsheet1.Location = new System.Drawing.Point(18, 18);
            this.kendoSpreadsheet1.Name = "kendoSpreadsheet1";
            this.kendoSpreadsheet1.Size = new System.Drawing.Size(1052, 522);
            this.kendoSpreadsheet1.TabIndex = 0;
            this.kendoSpreadsheet1.Text = "kendoSpreadsheet1";
            this.kendoSpreadsheet1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoSpreadsheet1_WebRequest);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown1, true);
            this.numericUpDown1.Label.Size = 50;
            this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown1.LabelText = "Header Height";
            this.numericUpDown1.Location = new System.Drawing.Point(3, 53);
            this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 60);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown2, true);
            this.numericUpDown2.Label.Size = 50;
            this.numericUpDown2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown2.LabelText = "Header Width";
            this.numericUpDown2.Location = new System.Drawing.Point(3, 132);
            this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(212, 60);
            this.numericUpDown2.TabIndex = 16;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 31);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Sheetsbar";
            // 
            // buttonAddSheet
            // 
            this.buttonAddSheet.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonAddSheet.Location = new System.Drawing.Point(3, 211);
            this.buttonAddSheet.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonAddSheet.Name = "buttonAddSheet";
            this.buttonAddSheet.Size = new System.Drawing.Size(212, 35);
            this.buttonAddSheet.TabIndex = 18;
            this.buttonAddSheet.Text = "Add Sheet";
            this.buttonAddSheet.Click += new System.EventHandler(this.buttonAddSheet_Click);
            // 
            // kendoSpreadsheet
            // 
            this.MinimumSize = new System.Drawing.Size(900, 610);
            this.Name = "kendoSpreadsheet";
            this.Load += new System.EventHandler(this.kendoSpreadsheet_Load);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoSpreadsheet kendoSpreadsheet1;
		private Button buttonPDF;
		private Button buttonExport;
		private CheckBox checkBox1;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
        private Button buttonAddSheet;
    }
}
