namespace Wisej.DemoBrowser.ProgressBar
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
            this.progressBar1 = new Wisej.Web.ProgressBar();
            this.progressBar2 = new Wisej.Web.ProgressBar();
            this.progressBarSteps = new Wisej.Web.ProgressBar();
            this.buttonTask = new Wisej.Web.Button();
            this.progressBar3 = new Wisej.Web.ProgressBar();
            this.progressBar4 = new Wisej.Web.ProgressBar();
            this.progressBar5 = new Wisej.Web.ProgressBar();
            this.progressBar6 = new Wisej.Web.ProgressBar();
            this.progressBar7 = new Wisej.Web.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(362, 93);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 35);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Text = "Default";
            this.progressBar1.Value = 10;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBar2.BarColor = System.Drawing.Color.FromName("@success");
            this.progressBar2.Location = new System.Drawing.Point(362, 179);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(200, 35);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 1;
            this.progressBar2.Text = "Bar Color";
            this.progressBar2.Value = 10;
            // 
            // progressBarSteps
            // 
            this.progressBarSteps.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBarSteps.Location = new System.Drawing.Point(362, 347);
            this.progressBarSteps.Name = "progressBarSteps";
            this.progressBarSteps.Size = new System.Drawing.Size(200, 35);
            this.progressBarSteps.Step = 1;
            this.progressBarSteps.TabIndex = 2;
            this.progressBarSteps.Text = "0%";
            this.progressBarSteps.Value = 10;
            // 
            // buttonTask
            // 
            this.buttonTask.Anchor = Wisej.Web.AnchorStyles.None;
            this.buttonTask.Location = new System.Drawing.Point(96, 219);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(137, 37);
            this.buttonTask.TabIndex = 3;
            this.buttonTask.Text = "Start Task";
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBar3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.progressBar3.Location = new System.Drawing.Point(860, 92);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(200, 35);
            this.progressBar3.Step = 1;
            this.progressBar3.TabIndex = 4;
            this.progressBar3.Text = "Solid";
            this.progressBar3.Value = 10;
            // 
            // progressBar4
            // 
            this.progressBar4.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBar4.BorderStyle = Wisej.Web.BorderStyle.Dotted;
            this.progressBar4.Location = new System.Drawing.Point(860, 177);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(200, 35);
            this.progressBar4.Step = 1;
            this.progressBar4.TabIndex = 5;
            this.progressBar4.Text = "Dotted";
            this.progressBar4.Value = 10;
            // 
            // progressBar5
            // 
            this.progressBar5.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBar5.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.progressBar5.Location = new System.Drawing.Point(860, 262);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(200, 35);
            this.progressBar5.Step = 1;
            this.progressBar5.TabIndex = 6;
            this.progressBar5.Text = "Dashed";
            this.progressBar5.Value = 10;
            // 
            // progressBar6
            // 
            this.progressBar6.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBar6.BorderStyle = Wisej.Web.BorderStyle.Double;
            this.progressBar6.Location = new System.Drawing.Point(860, 347);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(200, 35);
            this.progressBar6.Step = 1;
            this.progressBar6.TabIndex = 7;
            this.progressBar6.Text = "Double";
            this.progressBar6.Value = 10;
            // 
            // progressBar7
            // 
            this.progressBar7.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBar7.CssStyle = "border-radius: 20px;";
            this.progressBar7.Location = new System.Drawing.Point(362, 264);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(200, 35);
            this.progressBar7.Step = 1;
            this.progressBar7.TabIndex = 8;
            this.progressBar7.Text = "Custom CSS";
            this.progressBar7.Value = 10;
            // 
            // Features
            // 
            this.Controls.Add(this.progressBar7);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.progressBarSteps);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.MinimumSize = new System.Drawing.Size(723, 322);
            this.Name = "Features";
            this.ResumeLayout(false);

		}

		#endregion

		private Web.ProgressBar progressBar1;
		private Web.ProgressBar progressBar2;
		private Web.ProgressBar progressBarSteps;
		private Web.Button buttonTask;
		private Web.ProgressBar progressBar3;
		private Web.ProgressBar progressBar4;
		private Web.ProgressBar progressBar5;
		private Web.ProgressBar progressBar6;
		private Web.ProgressBar progressBar7;
	}
}
