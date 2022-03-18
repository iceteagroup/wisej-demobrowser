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
			this.SuspendLayout();
			// 
			// barcode1
			// 
			this.barcode1.Anchor = Wisej.Web.AnchorStyles.None;
			this.barcode1.Location = new System.Drawing.Point(515, 38);
			this.barcode1.Name = "barcode1";
			this.barcode1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"id\":\"barcode\",\"type\":\"ean13\",\"value\":\"123456789012\"}")));
			this.barcode1.Size = new System.Drawing.Size(500, 400);
			this.barcode1.TabIndex = 0;
			this.barcode1.Text = "barcode1";
			// 
			// Barcode
			// 
			this.Controls.Add(this.barcode1);
			this.Name = "Barcode";
			this.Controls.SetChildIndex(this.barcode1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.Barcode barcode1;
	}
}
