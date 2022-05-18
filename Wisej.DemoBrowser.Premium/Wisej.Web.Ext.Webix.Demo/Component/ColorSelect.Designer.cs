namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class ColorSelect
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
            this.colorSelect1 = new Wisej.Web.Ext.Webix.ColorSelect();
            this.checkBoxBorderless = new Wisej.Web.CheckBox();
            this.buttonGetSelectedColor = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__colorselector.html";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#colorselector";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://docs.webix.com/api__refs__ui.colorselect.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.colorSelect1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxBorderless);
            this.flowLayoutPanel1.Controls.Add(this.buttonGetSelectedColor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 437);
            // 
            // colorSelect1
            // 
            this.colorSelect1.Anchor = Wisej.Web.AnchorStyles.None;
            this.colorSelect1.Location = new System.Drawing.Point(294, 79);
            this.colorSelect1.Name = "colorSelect1";
            this.colorSelect1.Size = new System.Drawing.Size(500, 400);
            this.colorSelect1.TabIndex = 0;
            this.colorSelect1.Text = "colorSelect1";
            // 
            // checkBoxBorderless
            // 
            this.checkBoxBorderless.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxBorderless.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxBorderless.AutoSize = false;
            this.checkBoxBorderless.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxBorderless.Location = new System.Drawing.Point(3, 3);
            this.checkBoxBorderless.Name = "checkBoxBorderless";
            this.checkBoxBorderless.Size = new System.Drawing.Size(212, 26);
            this.checkBoxBorderless.TabIndex = 0;
            this.checkBoxBorderless.Text = "Borderless";
            // 
            // buttonGetSelectedColor
            // 
            this.buttonGetSelectedColor.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonGetSelectedColor.Location = new System.Drawing.Point(3, 48);
            this.buttonGetSelectedColor.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonGetSelectedColor.Name = "buttonGetSelectedColor";
            this.buttonGetSelectedColor.Size = new System.Drawing.Size(212, 34);
            this.buttonGetSelectedColor.TabIndex = 1;
            this.buttonGetSelectedColor.Text = "Get selcted color";
            this.buttonGetSelectedColor.Click += new System.EventHandler(this.buttonGetSelectedColor_Click);
            // 
            // ColorSelect
            // 
            this.MinimumSize = new System.Drawing.Size(927, 606);
            this.Name = "ColorSelect";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.ColorSelect colorSelect1;
        private CheckBox checkBoxBorderless;
        private Button buttonGetSelectedColor;
    }
}
