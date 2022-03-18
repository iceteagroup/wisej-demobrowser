namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class ColorBoard
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
			this.colorBoard1 = new Wisej.Web.Ext.Webix.ColorBoard();
			this.SuspendLayout();
			// 
			// colorBoard1
			// 
			this.colorBoard1.Anchor = Wisej.Web.AnchorStyles.None;
			this.colorBoard1.Location = new System.Drawing.Point(515, 38);
			this.colorBoard1.Name = "colorBoard1";
			this.colorBoard1.Size = new System.Drawing.Size(500, 400);
			this.colorBoard1.TabIndex = 0;
			this.colorBoard1.Text = "colorBoard1";
			// 
			// ColorBoard
			// 
			this.Controls.Add(this.colorBoard1);
			this.Name = "ColorBoard";
			this.Controls.SetChildIndex(this.colorBoard1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.ColorBoard colorBoard1;
	}
}
