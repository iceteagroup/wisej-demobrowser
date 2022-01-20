namespace Wisej.DemoBrowser.CheckBox
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
			this.checkBoxDefault = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.checkBox5 = new Wisej.Web.CheckBox();
			this.checkBox6 = new Wisej.Web.CheckBox();
			this.checkBox7 = new Wisej.Web.CheckBox();
			this.checkBox8 = new Wisej.Web.CheckBox();
			this.checkBox9 = new Wisej.Web.CheckBox();
			this.SuspendLayout();
			// 
			// checkBoxDefault
			// 
			this.checkBoxDefault.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxDefault.AutoSize = false;
			this.checkBoxDefault.Location = new System.Drawing.Point(32, 21);
			this.checkBoxDefault.Name = "checkBoxDefault";
			this.checkBoxDefault.Size = new System.Drawing.Size(200, 27);
			this.checkBoxDefault.TabIndex = 0;
			this.checkBoxDefault.Text = "Default";
			this.checkBoxDefault.CheckedChanged += new System.EventHandler(this.checkBoxDefault_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBox2.AutoCheck = false;
			this.checkBox2.AutoSize = false;
			this.checkBox2.Location = new System.Drawing.Point(32, 312);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(200, 27);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "AutoCheck False";
			// 
			// checkBox3
			// 
			this.checkBox3.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(401, 21);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(200, 27);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Aligned Right";
			this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox4
			// 
			this.checkBox4.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBox4.AutoSize = false;
			this.checkBox4.Location = new System.Drawing.Point(401, 112);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(200, 27);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Aligned Left";
			this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox5
			// 
			this.checkBox5.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBox5.AutoSize = false;
			this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
			this.checkBox5.Location = new System.Drawing.Point(401, 203);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(200, 45);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "Aligned Top";
			this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox6
			// 
			this.checkBox6.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBox6.AutoSize = false;
			this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
			this.checkBox6.Location = new System.Drawing.Point(401, 312);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(200, 45);
			this.checkBox6.TabIndex = 5;
			this.checkBox6.Text = "Aligned Bottom";
			this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox7
			// 
			this.checkBox7.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBox7.AutoSize = false;
			this.checkBox7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox7.ImageSource = "icon-help";
			this.checkBox7.Location = new System.Drawing.Point(770, 21);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(107, 27);
			this.checkBox7.TabIndex = 6;
			this.checkBox7.Text = "Image";
			// 
			// checkBox8
			// 
			this.checkBox8.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBox8.AutoSize = false;
			this.checkBox8.Checked = true;
			this.checkBox8.CheckedForeColor = System.Drawing.Color.FromArgb(0, 110, 255);
			this.checkBox8.Location = new System.Drawing.Point(32, 203);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(200, 27);
			this.checkBox8.TabIndex = 7;
			this.checkBox8.Text = "Checked Color";
			// 
			// checkBox9
			// 
			this.checkBox9.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBox9.AutoSize = false;
			this.checkBox9.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox9.Location = new System.Drawing.Point(32, 112);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(200, 27);
			this.checkBox9.TabIndex = 8;
			this.checkBox9.Text = "Three-State";
			this.checkBox9.ThreeState = true;
			// 
			// Features
			// 
			this.Controls.Add(this.checkBox9);
			this.Controls.Add(this.checkBox8);
			this.Controls.Add(this.checkBox7);
			this.Controls.Add(this.checkBox6);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBoxDefault);
			this.MinimumSize = new System.Drawing.Size(909, 379);
			this.Name = "Features";
			this.Size = new System.Drawing.Size(909, 379);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.CheckBox checkBoxDefault;
		private Web.CheckBox checkBox2;
		private Web.CheckBox checkBox3;
		private Web.CheckBox checkBox4;
		private Web.CheckBox checkBox5;
		private Web.CheckBox checkBox6;
		private Web.CheckBox checkBox7;
		private Web.CheckBox checkBox8;
		private Web.CheckBox checkBox9;
	}
}
