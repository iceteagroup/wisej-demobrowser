namespace Wisej.DemoBrowser.ScrollBars
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
			this.hScrollBar1 = new Wisej.Web.HScrollBar();
			this.vScrollBar1 = new Wisej.Web.VScrollBar();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.label3 = new Wisej.Web.Label();
			this.hScrollBar2 = new Wisej.Web.HScrollBar();
			this.SuspendLayout();
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Anchor = Wisej.Web.AnchorStyles.None;
			this.hScrollBar1.Location = new System.Drawing.Point(675, 141);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(220, 20);
			this.hScrollBar1.TabIndex = 0;
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Anchor = Wisej.Web.AnchorStyles.None;
			this.vScrollBar1.Location = new System.Drawing.Point(547, 141);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(20, 220);
			this.vScrollBar1.TabIndex = 1;
			this.vScrollBar1.Scroll += new Wisej.Web.ScrollEventHandler(this.ScrollBar_Scroll);
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(527, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Vertical";
			// 
			// label2
			// 
			this.label2.Anchor = Wisej.Web.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(675, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "Horizontal";
			// 
			// label3
			// 
			this.label3.Anchor = Wisej.Web.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(675, 313);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Large Change";
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Anchor = Wisej.Web.AnchorStyles.None;
			this.hScrollBar2.LargeChange = 20;
			this.hScrollBar2.Location = new System.Drawing.Point(675, 341);
			this.hScrollBar2.Maximum = 40;
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(220, 20);
			this.hScrollBar2.SmallChange = 2;
			this.hScrollBar2.TabIndex = 4;
			// 
			// Features
			// 
			this.Controls.Add(this.label3);
			this.Controls.Add(this.hScrollBar2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.hScrollBar1);
			this.MinimumSize = new System.Drawing.Size(403, 337);
			this.Name = "Features";
			this.Load += new System.EventHandler(this.Features_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.HScrollBar hScrollBar1;
		private Web.VScrollBar vScrollBar1;
		private Web.Label label1;
		private Web.Label label2;
		private Web.Label label3;
		private Web.HScrollBar hScrollBar2;
	}
}
