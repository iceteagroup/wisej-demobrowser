namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igColorPicker
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
			this.label4 = new Wisej.Web.Label();
			this.igColorPicker1 = new Wisej.Web.Ext.Ignite.igColorPicker();
			this.buttonGetSelectedColor = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.TabIndex = 3;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.igColorPicker1);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "https://www.igniteui.com/help/api/2019.2/ui.igcolorpicker";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.buttonGetSelectedColor);
			// 
			// label4
			// 
			this.label4.Anchor = Wisej.Web.AnchorStyles.None;
			this.label4.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.label4.Location = new System.Drawing.Point(344, 359);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(201, 33);
			this.label4.TabIndex = 1;
			this.label4.Text = "Selected Color";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// igColorPicker1
			// 
			this.igColorPicker1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igColorPicker1.Location = new System.Drawing.Point(344, 184);
			this.igColorPicker1.Name = "igColorPicker1";
			this.igColorPicker1.Size = new System.Drawing.Size(201, 159);
			this.igColorPicker1.TabIndex = 0;
			this.igColorPicker1.Text = "igColorPicker1";
			// 
			// buttonGetSelectedColor
			// 
			this.buttonGetSelectedColor.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.buttonGetSelectedColor.Location = new System.Drawing.Point(3, 3);
			this.buttonGetSelectedColor.Name = "buttonGetSelectedColor";
			this.buttonGetSelectedColor.Size = new System.Drawing.Size(212, 35);
			this.buttonGetSelectedColor.TabIndex = 4;
			this.buttonGetSelectedColor.Text = "Get Selected Color";
			this.buttonGetSelectedColor.Click += new System.EventHandler(this.buttonGetSelectedColor_Click);
			// 
			// igColorPicker
			// 
			this.Name = "igColorPicker";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igColorPicker igColorPicker1;
		private Label label4;
        private Button buttonGetSelectedColor;
    }
}
