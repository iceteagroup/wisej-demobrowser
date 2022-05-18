namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoPivotGridV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoPivotGridV2));
            this.kendoPivotGridV21 = new Wisej.Web.Ext.Kendo.kendoPivotGridV2();
            this.numericUpDownColumnWidth = new Wisej.Web.NumericUpDown();
            this.buttonPDF = new Wisej.Web.Button();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoPivotGridV21);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/pivotgridv2/index";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/pivotgridv2";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/data-management/pivotgridv2/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDownColumnWidth);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonPDF);
            // 
            // kendoPivotGridV21
            // 
            this.kendoPivotGridV21.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoPivotGridV21.Location = new System.Drawing.Point(8, 8);
            this.kendoPivotGridV21.Name = "kendoPivotGridV21";
            this.kendoPivotGridV21.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoPivotGridV21.Options"))));
            this.kendoPivotGridV21.Size = new System.Drawing.Size(1073, 542);
            this.kendoPivotGridV21.TabIndex = 0;
            this.kendoPivotGridV21.Text = "kendoPivotGridV21";
            // 
            // numericUpDownColumnWidth
            // 
            this.numericUpDownColumnWidth.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDownColumnWidth, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDownColumnWidth, true);
            this.numericUpDownColumnWidth.Label.Size = 50;
            this.numericUpDownColumnWidth.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDownColumnWidth.LabelText = "Column Width";
            this.numericUpDownColumnWidth.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownColumnWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownColumnWidth.Name = "numericUpDownColumnWidth";
            this.numericUpDownColumnWidth.Size = new System.Drawing.Size(212, 60);
            this.numericUpDownColumnWidth.TabIndex = 11;
            this.numericUpDownColumnWidth.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // buttonPDF
            // 
            this.buttonPDF.Display = Wisej.Web.Display.Icon;
            this.buttonPDF.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
            this.buttonPDF.Location = new System.Drawing.Point(3, 82);
            this.buttonPDF.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(42, 42);
            this.buttonPDF.TabIndex = 12;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // kendoPivotGridV2
            // 
            this.Name = "kendoPivotGridV2";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoPivotGridV2 kendoPivotGridV21;
        private NumericUpDown numericUpDownColumnWidth;
        private Button buttonPDF;
    }
}
