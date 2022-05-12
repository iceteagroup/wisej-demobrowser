namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxNavBar
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
            this.dxNavBar1 = new Wisej.Web.Ext.DevExtreme.dxNavBar();
            this.dataRepeater1 = new Wisej.Web.DataRepeater();
            this.linkLabelEmail = new Wisej.Web.LinkLabel();
            this.labelCategory = new Wisej.Web.Label();
            this.labelName = new Wisej.Web.Label();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.buttonChangeSelectedIndex = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).BeginInit();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/NavBar/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/NavBar/Overview/jQuery/Light/" +
    "";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxNavBar/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dataRepeater1);
            this.panel.Controls.Add(this.dxNavBar1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.buttonChangeSelectedIndex);
            // 
            // dxNavBar1
            // 
            this.dxNavBar1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dxNavBar1.Location = new System.Drawing.Point(8, 504);
            this.dxNavBar1.Name = "dxNavBar1";
            this.dxNavBar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"dataSource\":[{\"text\":\"Contacts\",\"icon\":\"user\"},{\"text\":\"Missed\",\"icon\":\"clock\"," +
        "\"badge\":3},{\"text\":\"Favorites\",\"icon\":\"favorites\"}]}")));
            this.dxNavBar1.Size = new System.Drawing.Size(872, 64);
            this.dxNavBar1.TabIndex = 2;
            this.dxNavBar1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[0];
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataRepeater1.ItemHeaderVisible = false;
            this.dataRepeater1.ItemSize = new System.Drawing.Size(200, 100);
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.linkLabelEmail);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.labelCategory);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.labelName);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.pictureBox1);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(870, 100);
            this.dataRepeater1.Location = new System.Drawing.Point(8, 8);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(872, 496);
            this.dataRepeater1.TabIndex = 3;
            this.dataRepeater1.Text = "dataRepeater1";
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.Location = new System.Drawing.Point(105, 75);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(45, 22);
            this.linkLabelEmail.TabIndex = 3;
            this.linkLabelEmail.Text = "Email";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(105, 43);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(73, 22);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Outgoing";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelName.Location = new System.Drawing.Point(105, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 28);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "John Doe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 82);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
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
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Hover State Enabled";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "multiple",
            "single"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Selection Mode";
            this.comboBox1.Location = new System.Drawing.Point(3, 60);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "single";
            // 
            // buttonChangeSelectedIndex
            // 
            this.buttonChangeSelectedIndex.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonChangeSelectedIndex.Location = new System.Drawing.Point(3, 139);
            this.buttonChangeSelectedIndex.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonChangeSelectedIndex.Name = "buttonChangeSelectedIndex";
            this.buttonChangeSelectedIndex.Size = new System.Drawing.Size(212, 42);
            this.buttonChangeSelectedIndex.TabIndex = 18;
            this.buttonChangeSelectedIndex.Text = "Change selected index";
            this.buttonChangeSelectedIndex.Click += new System.EventHandler(this.buttonChangeSelectedIndex_Click);
            // 
            // dxNavBar
            // 
            this.Name = "dxNavBar";
            this.Load += new System.EventHandler(this.dxNavBar_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).EndInit();
            this.dataRepeater1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxNavBar dxNavBar1;
		private DataRepeater dataRepeater1;
		private LinkLabel linkLabelEmail;
		private Label labelCategory;
		private Label labelName;
		private PictureBox pictureBox1;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
        private Button buttonChangeSelectedIndex;
    }
}
