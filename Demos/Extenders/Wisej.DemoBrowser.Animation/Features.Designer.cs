namespace Wisej.DemoBrowser.Animation
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new Wisej.Web.Panel();
			this.label1 = new Wisej.Web.Label();
			this.panel2 = new Wisej.Web.Panel();
			this.label2 = new Wisej.Web.Label();
			this.panel3 = new Wisej.Web.Panel();
			this.label3 = new Wisej.Web.Label();
			this.panel4 = new Wisej.Web.Panel();
			this.label4 = new Wisej.Web.Label();
			this.animation1 = new Wisej.Web.Animation(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
			this.animation1.GetAnimation(this.panel1).Duration = 2500;
			this.animation1.GetAnimation(this.panel1).Event = "appear";
			this.animation1.GetAnimation(this.panel1).Name = "slideRightIn";
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1014, 146);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(255, 196);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(86, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Slide in Right";
			// 
			// panel2
			// 
			this.panel2.Anchor = Wisej.Web.AnchorStyles.None;
			this.animation1.GetAnimation(this.panel2).Duration = 2500;
			this.animation1.GetAnimation(this.panel2).Event = "appear";
			this.animation1.GetAnimation(this.panel2).Name = "slideLeftIn";
			this.panel2.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(154, 146);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(255, 196);
			this.panel2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = Wisej.Web.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(91, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Slide in Left";
			// 
			// panel3
			// 
			this.panel3.Anchor = Wisej.Web.AnchorStyles.None;
			this.animation1.GetAnimation(this.panel3).Duration = 2500;
			this.animation1.GetAnimation(this.panel3).Event = "appear";
			this.animation1.GetAnimation(this.panel3).Name = "popIn";
			this.panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(585, 254);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(255, 196);
			this.panel3.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Anchor = Wisej.Web.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(106, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "Pop In";
			// 
			// panel4
			// 
			this.panel4.Anchor = Wisej.Web.AnchorStyles.None;
			this.animation1.GetAnimation(this.panel4).Duration = 2500;
			this.animation1.GetAnimation(this.panel4).Event = "appear";
			this.animation1.GetAnimation(this.panel4).Name = "growHeight";
			this.panel4.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(584, 24);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(255, 196);
			this.panel4.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Anchor = Wisej.Web.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(88, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Grow Height";
			// 
			// Features
			// 
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(1132, 431);
			this.Name = "Features";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Panel panel1;
		private Web.Animation animation1;
		private Web.Label label1;
		private Web.Panel panel2;
		private Web.Label label2;
		private Web.Panel panel3;
		private Web.Label label3;
		private Web.Panel panel4;
		private Web.Label label4;
	}
}
