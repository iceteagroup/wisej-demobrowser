namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxGallery
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
            this.dxGallery1 = new Wisej.Web.Ext.DevExtreme.dxGallery();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.checkBox6 = new Wisej.Web.CheckBox();
            this.checkBox7 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Gallery/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Gallery/Overview/jQuery/Light" +
    "/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxGallery/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxGallery1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox5);
            this.flowLayoutPanel1.Controls.Add(this.checkBox6);
            this.flowLayoutPanel1.Controls.Add(this.checkBox7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 470);
            // 
            // dxGallery1
            // 
            this.dxGallery1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dxGallery1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.dxGallery1.Location = new System.Drawing.Point(166, 103);
            this.dxGallery1.Name = "dxGallery1";
            this.dxGallery1.Size = new System.Drawing.Size(556, 371);
            this.dxGallery1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 38);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Loop";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox5, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox5, true);
            this.checkBox5.Location = new System.Drawing.Point(3, 52);
            this.checkBox5.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(212, 38);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "Show Indicator";
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox6.AutoSize = false;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox6.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox6, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox6, true);
            this.checkBox6.Location = new System.Drawing.Point(3, 101);
            this.checkBox6.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(212, 38);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Show Nav Buttons";
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox7.AutoSize = false;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox7, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox7, true);
            this.checkBox7.Location = new System.Drawing.Point(3, 150);
            this.checkBox7.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(212, 38);
            this.checkBox7.TabIndex = 15;
            this.checkBox7.Text = "Swipe Enabled";
            // 
            // dxGallery
            // 
            this.Name = "dxGallery";
            this.Size = new System.Drawing.Size(1299, 722);
            this.Load += new System.EventHandler(this.dxGallery_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxGallery dxGallery1;
        private CheckBox checkBox1;
		private CheckBox checkBox7;
		private CheckBox checkBox6;
		private CheckBox checkBox5;
	}
}
