namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class ColorSelect
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
			this.colorSelect1 = new Wisej.Web.Ext.Webix.ColorSelect();
			this.SuspendLayout();
			// 
			// colorSelect1
			// 
			this.colorSelect1.Anchor = Wisej.Web.AnchorStyles.None;
			this.colorSelect1.Location = new System.Drawing.Point(515, 38);
			this.colorSelect1.Name = "colorSelect1";
			this.colorSelect1.Size = new System.Drawing.Size(500, 400);
			this.colorSelect1.TabIndex = 0;
			this.colorSelect1.Text = "colorSelect1";
			// 
			// ColorSelect
			// 
			this.Controls.Add(this.colorSelect1);
			this.Name = "ColorSelect";
			this.Controls.SetChildIndex(this.colorSelect1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.ColorSelect colorSelect1;
	}
}
