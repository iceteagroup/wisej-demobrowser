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
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.colorBoard1);
            // 
            // colorBoard1
            // 
            this.colorBoard1.Anchor = Wisej.Web.AnchorStyles.None;
            this.colorBoard1.Location = new System.Drawing.Point(294, 79);
            this.colorBoard1.Name = "colorBoard1";
            this.colorBoard1.Size = new System.Drawing.Size(500, 400);
            this.colorBoard1.TabIndex = 0;
            this.colorBoard1.Text = "colorBoard1";
            // 
            // ColorBoard
            // 
            this.Name = "ColorBoard";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.ColorBoard colorBoard1;
	}
}
