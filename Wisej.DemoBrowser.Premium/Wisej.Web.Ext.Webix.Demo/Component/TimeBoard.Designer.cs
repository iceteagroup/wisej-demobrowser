﻿namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class TimeBoard
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
            this.timeBoard1 = new Wisej.Web.Ext.Webix.TimeBoard();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.timeBoard1);
            // 
            // timeBoard1
            // 
            this.timeBoard1.Anchor = Wisej.Web.AnchorStyles.None;
            this.timeBoard1.Location = new System.Drawing.Point(294, 188);
            this.timeBoard1.Name = "timeBoard1";
            this.timeBoard1.Size = new System.Drawing.Size(500, 183);
            this.timeBoard1.TabIndex = 11;
            this.timeBoard1.Text = "timeBoard1";
            // 
            // TimeBoard
            // 
            this.Name = "TimeBoard";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.TimeBoard timeBoard1;
	}
}