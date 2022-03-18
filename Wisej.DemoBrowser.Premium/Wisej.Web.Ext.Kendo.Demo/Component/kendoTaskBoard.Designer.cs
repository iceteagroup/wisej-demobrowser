
namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoTaskBoard
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
			this.kendoTaskBoard1 = new Wisej.Web.Ext.Kendo.kendoTaskBoard();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoTaskBoard1);
			// 
			// kendoTaskBoard1
			// 
			this.kendoTaskBoard1.Dock = Wisej.Web.DockStyle.Fill;
			this.kendoTaskBoard1.Location = new System.Drawing.Point(8, 8);
			this.kendoTaskBoard1.Name = "kendoTaskBoard1";
			this.kendoTaskBoard1.Size = new System.Drawing.Size(437, 297);
			this.kendoTaskBoard1.TabIndex = 0;
			this.kendoTaskBoard1.Text = "kendoTaskBoard1";
			this.kendoTaskBoard1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.kendoTaskBoard1_WidgetEvent);
			// 
			// kendoTaskBoard
			// 
			this.Name = "kendoTaskBoard";
			this.Load += new System.EventHandler(this.kendoTaskBoard_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoTaskBoard kendoTaskBoard1;
	}
}
