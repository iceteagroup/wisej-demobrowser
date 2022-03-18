namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class SideMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideMenu));
			this.sideMenu1 = new Wisej.Web.Ext.Webix.SideMenu();
			this.SuspendLayout();
			// 
			// sideMenu1
			// 
			this.sideMenu1.Anchor = Wisej.Web.AnchorStyles.None;
			this.sideMenu1.Location = new System.Drawing.Point(515, 38);
			this.sideMenu1.Name = "sideMenu1";
			this.sideMenu1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("sideMenu1.Options"))));
			this.sideMenu1.Size = new System.Drawing.Size(500, 400);
			this.sideMenu1.TabIndex = 0;
			this.sideMenu1.Text = "sideMenu1";
			// 
			// SideMenu
			// 
			this.Controls.Add(this.sideMenu1);
			this.Name = "SideMenu";
			this.Controls.SetChildIndex(this.sideMenu1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.SideMenu sideMenu1;
	}
}
