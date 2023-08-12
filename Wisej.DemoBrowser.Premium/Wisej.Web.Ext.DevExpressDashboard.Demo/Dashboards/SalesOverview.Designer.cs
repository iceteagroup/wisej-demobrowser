namespace Wisej.Web.Ext.DevExpressDashboard.Demo.Dashboards
{
	partial class SalesOverview
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
			this.dxDashboard1 = new Wisej.Web.Ext.DxDashboard.DxDashboard();
			this.SuspendLayout();
			// 
			// dxDashboard1
			// 
			this.dxDashboard1.Dock = Wisej.Web.DockStyle.Fill;
			this.dxDashboard1.Name = "dxDashboard1";
			this.dxDashboard1.Size = new System.Drawing.Size(744, 591);
			this.dxDashboard1.TabIndex = 0;
			this.dxDashboard1.Text = "dxDashboard1";
			this.dxDashboard1.WebRequest += new Wisej.Web.WebRequestHandler(this.dxDashboard1_WebRequest);
			// 
			// SalesOverview
			// 
			this.Controls.Add(this.dxDashboard1);
			this.Name = "SalesOverview";
			this.Size = new System.Drawing.Size(744, 591);
			this.Load += new System.EventHandler(this.SalesOverview_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private DxDashboard.DxDashboard dxDashboard1;
	}
}
