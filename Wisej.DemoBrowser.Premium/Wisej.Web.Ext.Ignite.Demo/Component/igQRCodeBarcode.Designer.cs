namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igQRCodeBarcode
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
            this.textBox1 = new Wisej.Web.TextBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.igQRCodeBarcode1 = new Wisej.Web.Ext.Ignite.igQRCodeBarcode();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igQRCodeBarcode1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/barcode/overview";
            // 
            // linkApi
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igQrCodeBarcode";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://www.igniteui.com/help/igqrcodebarcode-overview";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            // 
            // textBox1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.textBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBox1, true);
            this.textBox1.LabelText = "Value to Encode";
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 57);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1234567890";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "undefined",
            "numeric",
            "alphanumeric",
            "byte",
            "kanji"});
            this.comboBox1.LabelText = "Encoding Mode";
            this.comboBox1.Location = new System.Drawing.Point(3, 79);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 57);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "numeric";
            // 
            // igQRCodeBarcode1
            // 
            this.igQRCodeBarcode1.Anchor = Wisej.Web.AnchorStyles.None;
            this.igQRCodeBarcode1.Data = "1234567890";
            this.igQRCodeBarcode1.Location = new System.Drawing.Point(260, 117);
            this.igQRCodeBarcode1.Name = "igQRCodeBarcode1";
            this.igQRCodeBarcode1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"data\":\"1234567890\",\"encodingMode\":\"numeric\"}")));
            this.igQRCodeBarcode1.Size = new System.Drawing.Size(368, 342);
            this.igQRCodeBarcode1.TabIndex = 0;
            // 
            // igQRCodeBarcode
            // 
            this.Name = "igQRCodeBarcode";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igQRCodeBarcode igQRCodeBarcode1;
		private TextBox textBox1;
		private ComboBox comboBox1;
	}
}
