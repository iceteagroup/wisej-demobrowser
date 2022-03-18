namespace Wisej.Web.Ext.Ignite.Demo
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
			this.panel3 = new Wisej.Web.Panel();
			this.comboBoxCulture = new Wisej.Web.ComboBox();
			this.comboBoxTheme = new Wisej.Web.ComboBox();
			this.label1 = new Wisej.Web.Label();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.panel1 = new Wisej.Web.Panel();
			this.listBox1 = new Wisej.Web.ListBox();
			this.panel2 = new Wisej.Web.Panel();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			this.panel3.Size = new System.Drawing.Size(2051, 100);
			this.panel3.TabIndex = 1;
			this.panel3.TabStop = true;
			// 
			// comboBoxCulture
			// 
			this.comboBoxCulture.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxCulture.AutoSize = false;
			this.comboBoxCulture.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxCulture.Items.AddRange(new object[] {
            "bg",
            "de",
            "en",
            "es",
            "fr",
            "ja",
            "ru"});
			this.comboBoxCulture.Location = new System.Drawing.Point(1598, 49);
			this.comboBoxCulture.Name = "comboBoxCulture";
			this.comboBoxCulture.Size = new System.Drawing.Size(193, 35);
			this.comboBoxCulture.TabIndex = 5;
			this.comboBoxCulture.Text = "en";
			this.comboBoxCulture.SelectedIndexChanged += new System.EventHandler(this.comboBoxCulture_SelectedIndexChanged);
			// 
			// comboBoxTheme
			// 
			this.comboBoxTheme.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxTheme.AutoSize = false;
			this.comboBoxTheme.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxTheme.Items.AddRange(new object[] {
            "ios",
            "metro",
            "infragistics",
            "infragistics2012",
            "bootstrap3/yeti",
            "bootstrap3/flatly",
            "bootstrap3/default",
            "bootstrap3/superhero",
            "bootstrap4/default"});
			this.comboBoxTheme.Location = new System.Drawing.Point(1827, 49);
			this.comboBoxTheme.Name = "comboBoxTheme";
			this.comboBoxTheme.Size = new System.Drawing.Size(193, 35);
			this.comboBoxTheme.TabIndex = 3;
			this.comboBoxTheme.Text = "infragistics";
			this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("default, Verdana", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(43, 53, 124);
			this.label1.Location = new System.Drawing.Point(129, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(575, 48);
			this.label1.TabIndex = 1;
			this.label1.Text = "IgniteUI Integration Tests";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageSource = "Images\\ignite.png";
			this.pictureBox1.Location = new System.Drawing.Point(21, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(71, 69);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Dock = Wisej.Web.DockStyle.Left;
			this.panel1.HeaderBackColor = System.Drawing.Color.FromArgb(43, 53, 124);
			this.panel1.HeaderSize = 40;
			this.panel1.Location = new System.Drawing.Point(0, 100);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Wisej.Web.Padding(20);
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(250, 735);
			this.panel1.TabIndex = 2;
			this.panel1.TabStop = true;
			this.panel1.Text = "Component";
			// 
			// listBox1
			// 
			this.listBox1.BorderStyle = Wisej.Web.BorderStyle.None;
			this.listBox1.DisplayMember = "Name";
			this.listBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.listBox1.IconMember = "Icon";
			this.listBox1.Location = new System.Drawing.Point(20, 20);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(208, 653);
			this.listBox1.TabIndex = 0;
			this.listBox1.ValueMember = "Name";
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.Dock = Wisej.Web.DockStyle.Fill;
			this.panel2.HeaderBackColor = System.Drawing.Color.FromArgb(245, 146, 30);
			this.panel2.HeaderSize = 40;
			this.panel2.Location = new System.Drawing.Point(250, 100);
			this.panel2.Name = "panel2";
			this.panel2.ShowCloseButton = false;
			this.panel2.ShowHeader = true;
			this.panel2.Size = new System.Drawing.Size(1801, 735);
			this.panel2.TabIndex = 3;
			this.panel2.TabStop = true;
			this.panel2.Text = "Test";
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "MainView";
			this.Size = new System.Drawing.Size(2051, 835);
			this.Text = "IgniteUI Integration Tests";
			this.Load += new System.EventHandler(this.MainView_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel3;
		private ComboBox comboBoxTheme;
		private Label label1;
		private PictureBox pictureBox1;
		private Panel panel1;
		private Panel panel2;
		private ListBox listBox1;
		private ComboBox comboBoxCulture;
	}
}

