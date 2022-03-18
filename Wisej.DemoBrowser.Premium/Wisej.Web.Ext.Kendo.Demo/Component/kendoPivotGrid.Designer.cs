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
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.buttonExport = new Wisej.Web.Button();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.kendoPivotGrid1 = new Wisej.Web.Ext.Kendo.kendoPivotGrid();
            this.buttonPDF = new Wisej.Web.Button();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoPivotGrid1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPDF);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 394);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonPDF, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 313);
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
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(28, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Reorderable";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(28, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Filterable";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(28, 117);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 38);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Sortable";
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/microsoft-excel-logo.svg";
            this.buttonExport.Location = new System.Drawing.Point(28, 265);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(42, 42);
            this.buttonExport.TabIndex = 8;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = false;
            this.numericUpDown1.Label.Size = 50;
            this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown1.LabelText = "Column Width";
            this.numericUpDown1.Location = new System.Drawing.Point(28, 167);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
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
            this.buttonPDF.Location = new System.Drawing.Point(76, 265);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(42, 42);
            this.buttonPDF.TabIndex = 10;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // kendoPivotGrid
            // 
            this.Name = "kendoPivotGrid";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoPivotGrid kendoPivotGrid1;
		private CheckBox checkBox1;
		private Button buttonExport;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private NumericUpDown numericUpDown1;
		private Button buttonPDF;
	}
}
