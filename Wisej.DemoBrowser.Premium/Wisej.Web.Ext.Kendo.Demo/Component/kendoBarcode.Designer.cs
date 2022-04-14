namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoBarcode
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
            this.kendoBarcode1 = new Wisej.Web.Ext.Kendo.kendoBarcode();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.textBox1 = new Wisej.Web.TextBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.comboBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.textBox1);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoBarcode1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/barcode/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/barcode";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/barcodes/barcode/overview";
            // 
            // kendoBarcode1
            // 
            this.kendoBarcode1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoBarcode1.Location = new System.Drawing.Point(311, 134);
            this.kendoBarcode1.Name = "kendoBarcode1";
            this.kendoBarcode1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"WWW.WISEJ.COM/\",\"type\":\"code39\"}")));
            this.kendoBarcode1.Size = new System.Drawing.Size(466, 290);
            this.kendoBarcode1.TabIndex = 0;
            this.kendoBarcode1.Text = "kendoBarcode1";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 38);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Checksum";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.textBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.textBox1, true);
            this.textBox1.Label.Size = 50;
            this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox1.LabelText = "Value";
            this.textBox1.Location = new System.Drawing.Point(3, 139);
            this.textBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 60);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "WWW.WISEJ.COM/";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanelProperties.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "ean8",
            "ean13",
            "upce",
            "upca",
            "code11",
            "code39",
            "code39extended",
            "code93",
            "code93extended",
            "code128",
            "code128a",
            "code128b",
            "code128c",
            "gs1-128",
            "msimod10",
            "msimod11",
            "msimod1010",
            "msimod1110",
            "postnet"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Type";
            this.comboBox1.Location = new System.Drawing.Point(3, 60);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "code39";
            // 
            // kendoBarcode
            // 
            this.MinimumSize = new System.Drawing.Size(902, 526);
            this.Name = "kendoBarcode";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoBarcode kendoBarcode1;
		private CheckBox checkBox1;
		private TextBox textBox1;
		private ComboBox comboBox1;
	}
}
