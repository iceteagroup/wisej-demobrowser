﻿namespace Wisej.DemoBrowser.TinyMCE
{
	partial class Features
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            this.tinyMCE1 = new Wisej.Web.Ext.TinyMCE.TinyMCE();
            this.SuspendLayout();
            // 
            // tinyMCE1
            // 
            this.tinyMCE1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tinyMCE1.CssClass = "shadow";
            this.tinyMCE1.Location = new System.Drawing.Point(211, 12);
            this.tinyMCE1.Name = "tinyMCE1";
            this.tinyMCE1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("tinyMCE1.ResponsiveProfiles"))));
            this.tinyMCE1.Size = new System.Drawing.Size(1000, 450);
            this.tinyMCE1.TabIndex = 0;
            // 
            // Features
            // 
            this.Controls.Add(this.tinyMCE1);
            this.MinimumSize = new System.Drawing.Size(700, 0);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.TinyMCE.TinyMCE tinyMCE1;
	}
}
