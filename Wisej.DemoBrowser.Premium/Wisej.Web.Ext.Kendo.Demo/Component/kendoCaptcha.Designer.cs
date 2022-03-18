
namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoCaptcha
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
            this.button2 = new Wisej.Web.Button();
            this.kendoCaptcha1 = new Wisej.Web.Ext.Kendo.kendoCaptcha();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoCaptcha1);
            this.panel.Text = "z";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.button2, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Validate";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kendoCaptcha1
            // 
            this.kendoCaptcha1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoCaptcha1.Location = new System.Drawing.Point(270, 90);
            this.kendoCaptcha1.Name = "kendoCaptcha1";
            this.kendoCaptcha1.Size = new System.Drawing.Size(548, 378);
            this.kendoCaptcha1.TabIndex = 0;
            this.kendoCaptcha1.Text = "kendoCaptcha1";
            this.kendoCaptcha1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoCaptcha1_WebRequest);
            // 
            // kendoCaptcha
            // 
            this.Name = "kendoCaptcha";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoCaptcha kendoCaptcha1;
		private Button button2;
		private Button button1;
	}
}
