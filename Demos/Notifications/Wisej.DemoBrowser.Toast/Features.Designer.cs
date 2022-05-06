namespace Wisej.DemoBrowser.Toast
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
			this.button1 = new Wisej.Web.Button();
			this.buttonAlignments = new Wisej.Web.Button();
			this.buttonAutoCloseDelay = new Wisej.Web.Button();
			this.buttonHtml = new Wisej.Web.Button();
			this.buttonBackColor = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = Wisej.Web.AnchorStyles.None;
			this.button1.AppearanceKey = "button-ok";
			this.button1.Location = new System.Drawing.Point(20, 20);
			this.button1.Margin = new Wisej.Web.Padding(20);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 35);
			this.button1.TabIndex = 0;
			this.button1.Text = "Default";
			this.button1.Click += new System.EventHandler(this.buttonDefault_Click);
			// 
			// buttonAlignments
			// 
			this.buttonAlignments.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonAlignments.AppearanceKey = "button-ok";
			this.buttonAlignments.Location = new System.Drawing.Point(970, 20);
			this.buttonAlignments.Margin = new Wisej.Web.Padding(20);
			this.buttonAlignments.Name = "buttonAlignments";
			this.buttonAlignments.Size = new System.Drawing.Size(150, 35);
			this.buttonAlignments.TabIndex = 1;
			this.buttonAlignments.Text = "Alignments";
			this.buttonAlignments.Click += new System.EventHandler(this.buttonAlignments_Click);
			// 
			// buttonAutoCloseDelay
			// 
			this.buttonAutoCloseDelay.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonAutoCloseDelay.AppearanceKey = "button-ok";
			this.buttonAutoCloseDelay.Location = new System.Drawing.Point(780, 20);
			this.buttonAutoCloseDelay.Margin = new Wisej.Web.Padding(20);
			this.buttonAutoCloseDelay.Name = "buttonAutoCloseDelay";
			this.buttonAutoCloseDelay.Size = new System.Drawing.Size(150, 35);
			this.buttonAutoCloseDelay.TabIndex = 2;
			this.buttonAutoCloseDelay.Text = "Auto Close Delay";
			this.buttonAutoCloseDelay.Click += new System.EventHandler(this.buttonAutoCloseDelay_Click);
			// 
			// buttonHtml
			// 
			this.buttonHtml.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonHtml.AppearanceKey = "button-ok";
			this.buttonHtml.Location = new System.Drawing.Point(590, 20);
			this.buttonHtml.Margin = new Wisej.Web.Padding(20);
			this.buttonHtml.Name = "buttonHtml";
			this.buttonHtml.Size = new System.Drawing.Size(150, 35);
			this.buttonHtml.TabIndex = 3;
			this.buttonHtml.Text = "HTML";
			this.buttonHtml.Click += new System.EventHandler(this.buttonHtml_Click);
			// 
			// buttonBackColor
			// 
			this.buttonBackColor.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonBackColor.AppearanceKey = "button-ok";
			this.buttonBackColor.Location = new System.Drawing.Point(400, 20);
			this.buttonBackColor.Margin = new Wisej.Web.Padding(20);
			this.buttonBackColor.Name = "buttonBackColor";
			this.buttonBackColor.Size = new System.Drawing.Size(150, 35);
			this.buttonBackColor.TabIndex = 4;
			this.buttonBackColor.Text = "Back Color";
			this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
			// 
			// button2
			// 
			this.button2.Anchor = Wisej.Web.AnchorStyles.None;
			this.button2.AppearanceKey = "button-ok";
			this.button2.Location = new System.Drawing.Point(210, 20);
			this.button2.Margin = new Wisej.Web.Padding(20);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(150, 35);
			this.button2.TabIndex = 5;
			this.button2.Text = "Icon";
			this.button2.Click += new System.EventHandler(this.buttonIcon_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Controls.Add(this.buttonBackColor);
			this.flowLayoutPanel1.Controls.Add(this.buttonHtml);
			this.flowLayoutPanel1.Controls.Add(this.buttonAutoCloseDelay);
			this.flowLayoutPanel1.Controls.Add(this.buttonAlignments);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(59, 55);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1146, 75);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// Features
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Features";
			this.Size = new System.Drawing.Size(1245, 170);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button button1;
		private Web.Button buttonAlignments;
		private Web.Button buttonAutoCloseDelay;
		private Web.Button buttonHtml;
		private Web.Button buttonBackColor;
		private Web.Button button2;
		private Web.FlowLayoutPanel flowLayoutPanel1;
	}
}
