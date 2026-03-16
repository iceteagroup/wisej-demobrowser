namespace Wisej.DemoBrowser.Mermaid { 
	partial class Features
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
            this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
            this.mermaid1 = new Wisej.Web.Ext.Mermaid.Mermaid();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.txtDiagram = new Wisej.Web.TextBox();
            this.cmbLook = new Wisej.Web.ComboBox();
            this.cmbTheme = new Wisej.Web.ComboBox();
            this.chkPanZoom = new Wisej.Web.CheckBox();
            this.flexLayoutPanel2 = new Wisej.Web.FlexLayoutPanel();
            this.btnValidate = new Wisej.Web.Button();
            this.btnDownloadSvg = new Wisej.Web.Button();
            this.btnExportImage = new Wisej.Web.Button();
            this.btnDownloadPdf = new Wisej.Web.Button();
            this.numZoom = new Wisej.Web.NumericUpDown();
            this.btnApplyConfig = new Wisej.Web.Button();
            this.flexLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flexLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // flexLayoutPanel1
            // 
            this.flexLayoutPanel1.Controls.Add(this.flexLayoutPanel2);
            this.flexLayoutPanel1.Controls.Add(this.mermaid1);
            this.flexLayoutPanel1.Controls.Add(this.groupBox1);
            this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.flexLayoutPanel1.Name = "flexLayoutPanel1";
            this.flexLayoutPanel1.Size = new System.Drawing.Size(1390, 442);
            this.flexLayoutPanel1.TabIndex = 0;
            // 
            // mermaid1
            // 
            this.flexLayoutPanel1.SetFillWeight(this.mermaid1, 80);
            this.mermaid1.Location = new System.Drawing.Point(189, 3);
            this.mermaid1.Name = "mermaid1";
            this.mermaid1.Size = new System.Drawing.Size(946, 436);
            this.mermaid1.TabIndex = 0;
            this.mermaid1.Text = "mermaid1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.flexLayoutPanel1.SetFillWeight(this.groupBox1, 20);
            this.groupBox1.Location = new System.Drawing.Point(1151, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 436);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtDiagram);
            this.flowLayoutPanel1.Controls.Add(this.cmbLook);
            this.flowLayoutPanel1.Controls.Add(this.cmbTheme);
            this.flowLayoutPanel1.Controls.Add(this.numZoom);
            this.flowLayoutPanel1.Controls.Add(this.chkPanZoom);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 412);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtDiagram
            // 
            this.flowLayoutPanel1.SetFillWeight(this.txtDiagram, 60);
            this.flowLayoutPanel1.SetFlowBreak(this.txtDiagram, true);
            this.txtDiagram.LabelText = "Diagram";
            this.txtDiagram.Location = new System.Drawing.Point(3, 3);
            this.txtDiagram.Multiline = true;
            this.txtDiagram.Name = "txtDiagram";
            this.txtDiagram.Size = new System.Drawing.Size(224, 180);
            this.txtDiagram.TabIndex = 60;
            // 
            // cmbLook
            // 
            this.cmbLook.Dock = Wisej.Web.DockStyle.Fill;
            this.cmbLook.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.cmbLook, 10);
            this.flowLayoutPanel1.SetFlowBreak(this.cmbLook, true);
            this.cmbLook.LabelText = "Look";
            this.cmbLook.Location = new System.Drawing.Point(3, 189);
            this.cmbLook.Name = "cmbLook";
            this.cmbLook.Size = new System.Drawing.Size(224, 53);
            this.cmbLook.TabIndex = 6;
            // 
            // cmbTheme
            // 
            this.cmbTheme.Dock = Wisej.Web.DockStyle.Fill;
            this.cmbTheme.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.cmbTheme, 10);
            this.flowLayoutPanel1.SetFlowBreak(this.cmbTheme, true);
            this.cmbTheme.LabelText = "Theme";
            this.cmbTheme.Location = new System.Drawing.Point(3, 248);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(224, 53);
            this.cmbTheme.TabIndex = 7;
            // 
            // chkPanZoom
            // 
            this.flowLayoutPanel1.SetFillWeight(this.chkPanZoom, 10);
            this.flowLayoutPanel1.SetFlowBreak(this.chkPanZoom, true);
            this.chkPanZoom.Location = new System.Drawing.Point(3, 366);
            this.chkPanZoom.Name = "chkPanZoom";
            this.chkPanZoom.Size = new System.Drawing.Size(224, 23);
            this.chkPanZoom.TabIndex = 8;
            this.chkPanZoom.Text = "Enable Pan/Zoom";
            // 
            // flexLayoutPanel2
            // 
            this.flexLayoutPanel2.Controls.Add(this.btnValidate);
            this.flexLayoutPanel2.Controls.Add(this.btnDownloadSvg);
            this.flexLayoutPanel2.Controls.Add(this.btnExportImage);
            this.flexLayoutPanel2.Controls.Add(this.btnDownloadPdf);
            this.flexLayoutPanel2.Controls.Add(this.btnApplyConfig);
            this.flexLayoutPanel2.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.flexLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flexLayoutPanel2.Name = "flexLayoutPanel2";
            this.flexLayoutPanel2.Size = new System.Drawing.Size(170, 436);
            this.flexLayoutPanel2.TabIndex = 2;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(3, 3);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(164, 30);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Validate";
            // 
            // btnDownloadSvg
            // 
            this.btnDownloadSvg.Location = new System.Drawing.Point(3, 49);
            this.btnDownloadSvg.Name = "btnDownloadSvg";
            this.btnDownloadSvg.Size = new System.Drawing.Size(164, 30);
            this.btnDownloadSvg.TabIndex = 5;
            this.btnDownloadSvg.Text = "Download SVG";
            // 
            // btnExportImage
            // 
            this.btnExportImage.Location = new System.Drawing.Point(3, 95);
            this.btnExportImage.Name = "btnExportImage";
            this.btnExportImage.Size = new System.Drawing.Size(164, 30);
            this.btnExportImage.TabIndex = 6;
            this.btnExportImage.Text = "Export Image";
            // 
            // btnDownloadPdf
            // 
            this.btnDownloadPdf.Location = new System.Drawing.Point(3, 141);
            this.btnDownloadPdf.Name = "btnDownloadPdf";
            this.btnDownloadPdf.Size = new System.Drawing.Size(164, 30);
            this.btnDownloadPdf.TabIndex = 7;
            this.btnDownloadPdf.Text = "Download PDF";
            // 
            // numZoom
            // 
            this.numZoom.DecimalPlaces = 2;
            this.flowLayoutPanel1.SetFillWeight(this.numZoom, 10);
            this.flowLayoutPanel1.SetFlowBreak(this.numZoom, true);
            this.numZoom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numZoom.LabelText = "Zoom";
            this.numZoom.Location = new System.Drawing.Point(3, 307);
            this.numZoom.Maximum = new decimal(3);
            this.numZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(224, 53);
            this.numZoom.TabIndex = 9;
            this.numZoom.Value = new decimal(1);
            // 
            // btnApplyConfig
            // 
            this.btnApplyConfig.AppearanceKey = "button-ok";
            this.btnApplyConfig.Dock = Wisej.Web.DockStyle.Left;
            this.btnApplyConfig.Location = new System.Drawing.Point(3, 187);
            this.btnApplyConfig.Name = "btnApplyConfig";
            this.btnApplyConfig.Size = new System.Drawing.Size(164, 30);
            this.btnApplyConfig.TabIndex = 14;
            this.btnApplyConfig.Text = "Apply Config";
            // 
            // Features
            // 
            this.Controls.Add(this.flexLayoutPanel1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(16);
            this.Load += new System.EventHandler(this.Features_Load);
            this.flexLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flexLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private Web.FlexLayoutPanel flexLayoutPanel1;
        private Web.Ext.Mermaid.Mermaid mermaid1;
        private Web.GroupBox groupBox1;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.TextBox txtDiagram;
        private Web.FlexLayoutPanel flexLayoutPanel2;
        private Web.ComboBox cmbLook;
        private Web.ComboBox cmbTheme;
        private Web.CheckBox chkPanZoom;
        private Web.Button btnValidate;
        private Web.Button btnDownloadSvg;
        private Web.Button btnExportImage;
        private Web.Button btnDownloadPdf;
        private Web.NumericUpDown numZoom;
        private Web.Button btnApplyConfig;
    }
}
