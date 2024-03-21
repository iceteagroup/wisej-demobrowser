namespace Wisej.DemoBrowser.Barcode
{
	partial class Scanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            this.barcode1 = new Wisej.Web.Ext.Barcode.Barcode();
            this.checkBoxLabel = new Wisej.Web.CheckBox();
            this.comboBoxBarcodeType = new Wisej.Web.ComboBox();
            this.textBoxValue = new Wisej.Web.TextBox();
            this.panel1 = new Wisej.Web.Panel();
            this.flowLayoutPanelMain = new Wisej.Web.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // barcode1
            // 
            this.barcode1.Anchor = Wisej.Web.AnchorStyles.None;
            this.barcode1.BarcodeType = Wisej.Web.Ext.Barcode.BarcodeType.Code_128;
            this.flowLayoutPanelMain.SetFillWeight(this.barcode1, 1);
            this.barcode1.Location = new System.Drawing.Point(503, 3);
            this.barcode1.MinimumSize = new System.Drawing.Size(300, 0);
            this.barcode1.Name = "barcode1";
            this.barcode1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("barcode1.ResponsiveProfiles"))));
            this.barcode1.Size = new System.Drawing.Size(494, 318);
            this.barcode1.TabIndex = 4;
            this.barcode1.Text = "1234567890";
            // 
            // checkBoxLabel
            // 
            this.checkBoxLabel.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBoxLabel.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxLabel.AutoSize = false;
            this.checkBoxLabel.Checked = true;
            this.checkBoxLabel.Location = new System.Drawing.Point(160, 49);
            this.checkBoxLabel.Name = "checkBoxLabel";
            this.checkBoxLabel.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("checkBoxLabel.ResponsiveProfiles"))));
            this.checkBoxLabel.Size = new System.Drawing.Size(175, 35);
            this.checkBoxLabel.TabIndex = 3;
            this.checkBoxLabel.Text = "Show Label";
            this.checkBoxLabel.CheckedChanged += new System.EventHandler(this.checkBoxLabel_CheckedChanged);
            // 
            // comboBoxBarcodeType
            // 
            this.comboBoxBarcodeType.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxBarcodeType.AutoSize = false;
            this.comboBoxBarcodeType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxBarcodeType.Items.AddRange(new object[] {
            "Aztec",
            "Codabar",
            "Code_39",
            "Code_128",
            "DataMatrix",
            "EAN_8",
            "EAN_13",
            "ITF",
            "PDF_417",
            "QR",
            "UPC_A",
            "MSI",
            "Plessey"});
            this.comboBoxBarcodeType.LabelText = "Barcode Type";
            this.comboBoxBarcodeType.Location = new System.Drawing.Point(160, 120);
            this.comboBoxBarcodeType.Name = "comboBoxBarcodeType";
            this.comboBoxBarcodeType.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("comboBoxBarcodeType.ResponsiveProfiles"))));
            this.comboBoxBarcodeType.Size = new System.Drawing.Size(175, 60);
            this.comboBoxBarcodeType.TabIndex = 5;
            this.comboBoxBarcodeType.Text = "Code_128";
            this.comboBoxBarcodeType.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarcodeType_SelectedIndexChanged);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBoxValue.LabelText = "Value";
            this.textBoxValue.Location = new System.Drawing.Point(160, 216);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textBoxValue.ResponsiveProfiles"))));
            this.textBoxValue.Size = new System.Drawing.Size(175, 53);
            this.textBoxValue.TabIndex = 6;
            this.textBoxValue.Text = "1234567890";
            this.textBoxValue.KeyPress += new Wisej.Web.KeyPressEventHandler(this.textBoxValue_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxValue);
            this.panel1.Controls.Add(this.comboBoxBarcodeType);
            this.panel1.Controls.Add(this.checkBoxLabel);
            this.flowLayoutPanelMain.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
            this.panel1.Size = new System.Drawing.Size(494, 318);
            this.panel1.TabIndex = 7;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.AutoSize = true;
            this.flowLayoutPanelMain.Controls.Add(this.panel1);
            this.flowLayoutPanelMain.Controls.Add(this.barcode1);
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(211, 75);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowLayoutPanelMain.ResponsiveProfiles"))));
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(1000, 324);
            this.flowLayoutPanelMain.TabIndex = 8;
            // 
            // Features
            // 
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Name = "Features";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Ext.Barcode.Barcode barcode1;
		private Web.CheckBox checkBoxLabel;
		private Web.ComboBox comboBoxBarcodeType;
		private Web.TextBox textBoxValue;
        private Web.FlowLayoutPanel flowLayoutPanelMain;
        private Web.Panel panel1;
    }
}
