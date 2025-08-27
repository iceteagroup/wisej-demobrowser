
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
			this.buttonValidate = new Wisej.Web.Button();
			this.buttonReset = new Wisej.Web.Button();
			this.kendoCaptcha1 = new Wisej.Web.Ext.Kendo.kendoCaptcha();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoCaptcha1);
			this.panel.Text = "z";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.buttonValidate);
			this.flowLayoutPanelProperties.Controls.Add(this.buttonReset);
			// 
			// buttonValidate
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.buttonValidate, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.buttonValidate, true);
			this.buttonValidate.Location = new System.Drawing.Point(3, 3);
			this.buttonValidate.Name = "buttonValidate";
			this.buttonValidate.Size = new System.Drawing.Size(212, 35);
			this.buttonValidate.TabIndex = 1;
			this.buttonValidate.Text = "Validate";
			this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
			// 
			// buttonReset
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.buttonReset, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.buttonReset, true);
			this.buttonReset.Location = new System.Drawing.Point(3, 57);
			this.buttonReset.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(212, 40);
			this.buttonReset.TabIndex = 2;
			this.buttonReset.Text = "Reset";
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// kendoCaptcha1
			// 
			this.kendoCaptcha1.Anchor = Wisej.Web.AnchorStyles.None;
			this.kendoCaptcha1.Location = new System.Drawing.Point(258, 188);
			this.kendoCaptcha1.Name = "kendoCaptcha1";
			this.kendoCaptcha1.Size = new System.Drawing.Size(373, 201);
			this.kendoCaptcha1.TabIndex = 0;
			this.kendoCaptcha1.Text = "kendoCaptcha1";
			this.kendoCaptcha1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoCaptcha1_WebRequest);
			// 
			// kendoCaptcha
			// 
			this.Name = "kendoCaptcha";
			this.Load += new System.EventHandler(this.kendoCaptcha_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoCaptcha kendoCaptcha1;
		private Button buttonReset;
		private Button buttonValidate;
	}
}
