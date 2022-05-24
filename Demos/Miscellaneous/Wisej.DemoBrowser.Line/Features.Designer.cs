namespace Wisej.DemoBrowser.Line
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
            this.line1 = new Wisej.Web.Line();
            this.line2 = new Wisej.Web.Line();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.line3 = new Wisej.Web.Line();
            this.label4 = new Wisej.Web.Label();
            this.line4 = new Wisej.Web.Line();
            this.line5 = new Wisej.Web.Line();
            this.line6 = new Wisej.Web.Line();
            this.line7 = new Wisej.Web.Line();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.Anchor = Wisej.Web.AnchorStyles.None;
            this.line1.Location = new System.Drawing.Point(384, 249);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(200, 10);
            // 
            // line2
            // 
            this.line2.Anchor = Wisej.Web.AnchorStyles.None;
            this.line2.Location = new System.Drawing.Point(308, 184);
            this.line2.Name = "line2";
            this.line2.Orientation = Wisej.Web.Orientation.Vertical;
            this.line2.Size = new System.Drawing.Size(10, 142);
            // 
            // label1
            // 
            this.label1.Anchor = Wisej.Web.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vertical";
            // 
            // label2
            // 
            this.label2.Anchor = Wisej.Web.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horizontal";
            // 
            // label3
            // 
            this.label3.Anchor = Wisej.Web.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thick Line";
            // 
            // line3
            // 
            this.line3.Anchor = Wisej.Web.AnchorStyles.None;
            this.line3.LineSize = 3;
            this.line3.Location = new System.Drawing.Point(650, 249);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(200, 10);
            // 
            // label4
            // 
            this.label4.Anchor = Wisej.Web.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(916, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Line Styles";
            // 
            // line4
            // 
            this.line4.Anchor = Wisej.Web.AnchorStyles.None;
            this.line4.LineSize = 3;
            this.line4.Location = new System.Drawing.Point(916, 184);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(200, 10);
            // 
            // line5
            // 
            this.line5.Anchor = Wisej.Web.AnchorStyles.None;
            this.line5.LineSize = 3;
            this.line5.LineStyle = Wisej.Web.LineStyle.Dotted;
            this.line5.Location = new System.Drawing.Point(916, 226);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(200, 10);
            // 
            // line6
            // 
            this.line6.Anchor = Wisej.Web.AnchorStyles.None;
            this.line6.LineSize = 3;
            this.line6.LineStyle = Wisej.Web.LineStyle.Dashed;
            this.line6.Location = new System.Drawing.Point(916, 271);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(200, 10);
            // 
            // line7
            // 
            this.line7.Anchor = Wisej.Web.AnchorStyles.None;
            this.line7.LineSize = 3;
            this.line7.LineStyle = Wisej.Web.LineStyle.Double;
            this.line7.Location = new System.Drawing.Point(916, 316);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(200, 10);
            // 
            // Features
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.line7);
            this.Controls.Add(this.line6);
            this.Controls.Add(this.line5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.MinimumSize = new System.Drawing.Size(833, 194);
            this.Name = "Features";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Line line1;
		private Web.Line line2;
		private Web.Label label1;
		private Web.Label label2;
		private Web.Label label3;
		private Web.Line line3;
		private Web.Label label4;
		private Web.Line line4;
		private Web.Line line5;
		private Web.Line line6;
		private Web.Line line7;
	}
}
