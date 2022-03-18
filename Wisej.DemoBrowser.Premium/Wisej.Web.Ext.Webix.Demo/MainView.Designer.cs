namespace Wisej.Web.Ext.Webix.Demo
{
	partial class MainView
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
			this.panelDemo = new Wisej.Web.Panel();
			this.panel3 = new Wisej.Web.Panel();
			this.comboBoxCulture = new Wisej.Web.ComboBox();
			this.comboBoxTheme = new Wisej.Web.ComboBox();
			this.label1 = new Wisej.Web.Label();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.panel1 = new Wisej.Web.Panel();
			this.listBoxComponents = new Wisej.Web.ListBox();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelDemo
			// 
			this.panelDemo.CssStyle = "border-radius: 0px;";
			this.panelDemo.Dock = Wisej.Web.DockStyle.Fill;
			this.panelDemo.HeaderBackColor = System.Drawing.Color.FromName("@webixPurple");
			this.panelDemo.HeaderSize = 40;
			this.panelDemo.Location = new System.Drawing.Point(250, 100);
			this.panelDemo.Name = "panelDemo";
			this.panelDemo.ShowCloseButton = false;
			this.panelDemo.ShowHeader = true;
			this.panelDemo.Size = new System.Drawing.Size(1328, 692);
			this.panelDemo.TabIndex = 6;
			this.panelDemo.TabStop = true;
			this.panelDemo.Text = "Test";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.comboBoxCulture);
			this.panel3.Controls.Add(this.comboBoxTheme);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Dock = Wisej.Web.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1578, 100);
			this.panel3.TabIndex = 4;
			this.panel3.TabStop = true;
			// 
			// comboBoxCulture
			// 
			this.comboBoxCulture.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxCulture.AutoSize = false;
			this.comboBoxCulture.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxCulture.Items.AddRange(new object[] {
            "de-DE",
            "it-IT",
            "pt-BR",
            "en-US"});
			this.comboBoxCulture.Location = new System.Drawing.Point(1155, 33);
			this.comboBoxCulture.Name = "comboBoxCulture";
			this.comboBoxCulture.Size = new System.Drawing.Size(193, 35);
			this.comboBoxCulture.TabIndex = 7;
			this.comboBoxCulture.Text = "en-US";
			this.comboBoxCulture.SelectedIndexChanged += new System.EventHandler(this.comboBoxCulture_SelectedIndexChanged);
			// 
			// comboBoxTheme
			// 
			this.comboBoxTheme.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxTheme.AutoSize = false;
			this.comboBoxTheme.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxTheme.Items.AddRange(new object[] {
            "material",
            "mini",
            "flat",
            "compact",
            "contrast"});
			this.comboBoxTheme.Location = new System.Drawing.Point(1354, 33);
			this.comboBoxTheme.Name = "comboBoxTheme";
			this.comboBoxTheme.Size = new System.Drawing.Size(193, 35);
			this.comboBoxTheme.TabIndex = 3;
			this.comboBoxTheme.Text = "material";
			this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("@windowTitle", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(43, 53, 124);
			this.label1.Location = new System.Drawing.Point(129, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(575, 48);
			this.label1.TabIndex = 1;
			this.label1.Text = "Webix Integration Tests";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageSource = "Images\\Webix.png";
			this.pictureBox1.Location = new System.Drawing.Point(21, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(71, 69);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.panel1.Controls.Add(this.listBoxComponents);
			this.panel1.CssStyle = "border-radius: 0px;";
			this.panel1.Dock = Wisej.Web.DockStyle.Left;
			this.panel1.HeaderBackColor = System.Drawing.Color.FromName("@webixPurple");
			this.panel1.HeaderSize = 40;
			this.panel1.Location = new System.Drawing.Point(0, 100);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Wisej.Web.Padding(20);
			this.panel1.ShowCloseButton = false;
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(250, 692);
			this.panel1.TabIndex = 5;
			this.panel1.TabStop = true;
			this.panel1.Text = "Components";
			// 
			// listBoxComponents
			// 
			this.listBoxComponents.BorderStyle = Wisej.Web.BorderStyle.None;
			this.listBoxComponents.DisplayMember = "Name";
			this.listBoxComponents.Dock = Wisej.Web.DockStyle.Fill;
			this.listBoxComponents.Focusable = false;
			this.listBoxComponents.IconMember = "Icon";
			this.listBoxComponents.Location = new System.Drawing.Point(20, 20);
			this.listBoxComponents.Name = "listBoxComponents";
			this.listBoxComponents.Size = new System.Drawing.Size(208, 610);
			this.listBoxComponents.TabIndex = 0;
			this.listBoxComponents.ValueMember = "Name";
			this.listBoxComponents.SelectedIndexChanged += new System.EventHandler(this.listBoxComponents_SelectedIndexChanged);
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panelDemo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "MainView";
			this.Size = new System.Drawing.Size(1578, 792);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.MainView_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Panel panel3;
		private ComboBox comboBoxCulture;
		private ComboBox comboBoxTheme;
		private Label label1;
		private PictureBox pictureBox1;
		private Panel panel1;
		private ListBox listBoxComponents;
		public Panel panelDemo;
	}
}

