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
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoSpreadsheet1);
            this.panel.Size = new System.Drawing.Size(682, 380);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.buttonPDF);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Size = new System.Drawing.Size(250, 380);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonPDF, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 299);
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
            // buttonPDF
            // 
            this.buttonPDF.Display = Wisej.Web.Display.Icon;
            this.buttonPDF.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
            this.buttonPDF.Location = new System.Drawing.Point(76, 251);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(42, 42);
            this.buttonPDF.TabIndex = 14;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/microsoft-excel-logo.svg";
            this.buttonExport.Location = new System.Drawing.Point(28, 251);
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
            this.kendoSpreadsheet1.Size = new System.Drawing.Size(643, 342);
            this.kendoSpreadsheet1.TabIndex = 0;
            this.kendoSpreadsheet1.Text = "kendoSpreadsheet1";
            this.kendoSpreadsheet1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoSpreadsheet1_WebRequest);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = false;
            this.numericUpDown1.Label.Size = 50;
            this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown1.LabelText = "Header Height";
            this.numericUpDown1.Location = new System.Drawing.Point(28, 93);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
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
            this.numericUpDown2.Label.Size = 50;
            this.numericUpDown2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown2.LabelText = "Header Width";
            this.numericUpDown2.Location = new System.Drawing.Point(28, 183);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(195, 60);
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
            this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(28, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 31);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Sheetsbar";
            // 
            // kendoSpreadsheet
            // 
            this.Name = "kendoSpreadsheet";
            this.Size = new System.Drawing.Size(1091, 570);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
	}
}
