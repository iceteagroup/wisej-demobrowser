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
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = Wisej.Web.AnchorStyles.None;
			this.button1.Location = new System.Drawing.Point(116, 220);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 35);
			this.button1.TabIndex = 0;
			this.button1.Text = "Default";
			this.button1.Click += new System.EventHandler(this.buttonDefault_Click);
			// 
			// buttonAlignments
			// 
			this.buttonAlignments.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonAlignments.Location = new System.Drawing.Point(532, 220);
			this.buttonAlignments.Name = "buttonAlignments";
			this.buttonAlignments.Size = new System.Drawing.Size(150, 35);
			this.buttonAlignments.TabIndex = 1;
			this.buttonAlignments.Text = "Alignments";
			this.buttonAlignments.Click += new System.EventHandler(this.buttonAlignments_Click);
			// 
			// buttonAutoCloseDelay
			// 
			this.buttonAutoCloseDelay.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonAutoCloseDelay.Location = new System.Drawing.Point(740, 220);
			this.buttonAutoCloseDelay.Name = "buttonAutoCloseDelay";
			this.buttonAutoCloseDelay.Size = new System.Drawing.Size(150, 35);
			this.buttonAutoCloseDelay.TabIndex = 2;
			this.buttonAutoCloseDelay.Text = "Auto Close Delay";
			this.buttonAutoCloseDelay.Click += new System.EventHandler(this.buttonAutoCloseDelay_Click);
			// 
			// buttonHtml
			// 
			this.buttonHtml.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonHtml.Location = new System.Drawing.Point(948, 220);
			this.buttonHtml.Name = "buttonHtml";
			this.buttonHtml.Size = new System.Drawing.Size(150, 35);
			this.buttonHtml.TabIndex = 3;
			this.buttonHtml.Text = "HTML";
			this.buttonHtml.Click += new System.EventHandler(this.buttonHtml_Click);
			// 
			// buttonBackColor
			// 
			this.buttonBackColor.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonBackColor.Location = new System.Drawing.Point(1156, 220);
			this.buttonBackColor.Name = "buttonBackColor";
			this.buttonBackColor.Size = new System.Drawing.Size(150, 35);
			this.buttonBackColor.TabIndex = 4;
			this.buttonBackColor.Text = "Back Color";
			this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
			// 
			// button2
			// 
			this.button2.Anchor = Wisej.Web.AnchorStyles.None;
			this.button2.Location = new System.Drawing.Point(324, 220);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(150, 35);
			this.button2.TabIndex = 5;
			this.button2.Text = "Icon";
			this.button2.Click += new System.EventHandler(this.buttonIcon_Click);
			// 
			// Features
			// 
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonBackColor);
			this.Controls.Add(this.buttonHtml);
			this.Controls.Add(this.buttonAutoCloseDelay);
			this.Controls.Add(this.buttonAlignments);
			this.Controls.Add(this.button1);
			this.MinimumSize = new System.Drawing.Size(1217, 65);
			this.Name = "Features";
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button button1;
		private Web.Button buttonAlignments;
		private Web.Button buttonAutoCloseDelay;
		private Web.Button buttonHtml;
		private Web.Button buttonBackColor;
		private Web.Button button2;
	}
}
