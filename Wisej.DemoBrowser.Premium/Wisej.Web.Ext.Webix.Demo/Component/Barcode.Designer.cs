namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Barcode
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
            this.barcode1 = new Wisej.Web.Ext.Webix.Barcode();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.barcode1);
            // 
            // barcode1
            // 
            this.barcode1.Anchor = Wisej.Web.AnchorStyles.None;
            this.barcode1.Location = new System.Drawing.Point(294, 79);
            this.barcode1.Name = "barcode1";
            this.barcode1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"type\":\"ean13\",\"value\":\"123456789012\"}")));
            this.barcode1.Size = new System.Drawing.Size(500, 400);
            this.barcode1.TabIndex = 0;
            this.barcode1.Text = "barcode1";
            // 
            // Barcode
            // 
            this.Name = "Barcode";
            this.Load += new System.EventHandler(this.Barcode_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Barcode barcode1;
	}
}
