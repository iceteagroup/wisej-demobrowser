namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class ColorPicker
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
			this.colorPicker1 = new Wisej.Web.Ext.Webix.ColorPicker();
			this.SuspendLayout();
			// 
			// colorPicker1
			// 
			this.colorPicker1.Anchor = Wisej.Web.AnchorStyles.None;
			this.colorPicker1.Location = new System.Drawing.Point(615, 218);
			this.colorPicker1.Name = "colorPicker1";
			this.colorPicker1.Size = new System.Drawing.Size(300, 40);
			this.colorPicker1.TabIndex = 11;
			this.colorPicker1.Text = "colorPicker1";
			// 
			// ColorPicker
			// 
			this.Controls.Add(this.colorPicker1);
			this.Name = "ColorPicker";
			this.Controls.SetChildIndex(this.colorPicker1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.ColorPicker colorPicker1;
	}
}
