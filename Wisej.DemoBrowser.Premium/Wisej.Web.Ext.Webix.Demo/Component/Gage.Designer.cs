namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Gage
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
			this.gage1 = new Wisej.Web.Ext.Webix.Gage();
			this.SuspendLayout();
			// 
			// gage1
			// 
			this.gage1.Anchor = Wisej.Web.AnchorStyles.None;
			this.gage1.Location = new System.Drawing.Point(515, 38);
			this.gage1.Name = "gage1";
			this.gage1.Size = new System.Drawing.Size(500, 400);
			this.gage1.TabIndex = 0;
			this.gage1.Text = "gage1";
			// 
			// Gage
			// 
			this.Controls.Add(this.gage1);
			this.Name = "Gage";
			this.Controls.SetChildIndex(this.gage1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.Gage gage1;
	}
}
