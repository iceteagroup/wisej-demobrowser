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
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 233);
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
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igQrCodeBarcode";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://www.igniteui.com/help/igqrcodebarcode-overview";
			// 
			// textBox1
			// 
			this.textBox1.Label.Text = "Value to Encode";
			this.textBox1.Location = new System.Drawing.Point(28, 135);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 41);
			this.textBox1.TabIndex = 1;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "undefined",
            "numeric",
            "alphanumeric",
            "byte",
            "kanji"});
			this.comboBox1.Label.Text = "Encoding Mode";
			this.comboBox1.Location = new System.Drawing.Point(28, 37);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 41);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "undefined";
			// 
			// igQRCodeBarcode1
			// 
			this.igQRCodeBarcode1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igQRCodeBarcode1.Data = "http://www.infragistics.com/products/jquery/";
			this.igQRCodeBarcode1.Location = new System.Drawing.Point(115, 46);
			this.igQRCodeBarcode1.Name = "igQRCodeBarcode1";
			this.igQRCodeBarcode1.Size = new System.Drawing.Size(223, 221);
			this.igQRCodeBarcode1.TabIndex = 0;
			// 
			// igQRCodeBarcode
			// 
			this.Name = "igQRCodeBarcode";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igQRCodeBarcode igQRCodeBarcode1;
		private TextBox textBox1;
		private ComboBox comboBox1;
	}
}
