namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igDataChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igDataChart));
            this.igDataChart1 = new Wisej.Web.Ext.Ignite.igDataChart();
            this.textBoxTitle = new Wisej.Web.TextBox();
            this.buttonLoad = new Wisej.Web.Upload();
            this.buttonExportImage = new Wisej.Web.Button();
            this.buttonAdd = new Wisej.Web.Button();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.textBoxCountry = new Wisej.Web.TextBox();
            this.textBoxSubtitle = new Wisej.Web.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igDataChart1);
            this.panel.Padding = new Wisej.Web.Padding(8);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/data-chart/overview";
            // 
            // linkApi
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igDataChart";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igdatachart-landing-page";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBoxTitle);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSubtitle);
            this.flowLayoutPanel1.Controls.Add(this.comboBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.buttonLoad);
            this.flowLayoutPanel1.Controls.Add(this.buttonExportImage);
            // 
            // igDataChart1
            // 
            this.igDataChart1.Dock = Wisej.Web.DockStyle.Fill;
            this.igDataChart1.Location = new System.Drawing.Point(8, 8);
            this.igDataChart1.Name = "igDataChart1";
            this.igDataChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igDataChart1.Options"))));
            this.igDataChart1.Size = new System.Drawing.Size(872, 560);
            this.igDataChart1.TabIndex = 0;
            this.igDataChart1.Text = "igDataChart1";
            // 
            // textBoxTitle
            // 
            this.flowLayoutPanel1.SetFillWeight(this.textBoxTitle, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxTitle, true);
            this.textBoxTitle.LabelText = "Title";
            this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(212, 57);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Text = "Population per Country";
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(3, 388);
            this.buttonLoad.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
            // 
            // buttonExportImage
            // 
            this.buttonExportImage.Display = Wisej.Web.Display.Icon;
            this.buttonExportImage.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
            this.buttonExportImage.Location = new System.Drawing.Point(51, 388);
            this.buttonExportImage.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonExportImage.Name = "buttonExportImage";
            this.buttonExportImage.Size = new System.Drawing.Size(42, 42);
            this.buttonExportImage.TabIndex = 3;
            this.buttonExportImage.Click += new System.EventHandler(this.buttonExportImage_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(7, 93);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(199, 35);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox2, true);
            this.comboBox2.Items.AddRange(new object[] {
            "Pop1995",
            "Pop2005",
            "Pop2015",
            "Pop2025"});
            this.comboBox2.LabelText = "Population Year";
            this.comboBox2.Location = new System.Drawing.Point(3, 155);
            this.comboBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 57);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "Pop2015";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCountry);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel1.SetFillWeight(this.groupBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.groupBox2, true);
            this.groupBox2.Location = new System.Drawing.Point(3, 231);
            this.groupBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "Add Country";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.LabelText = "Name";
            this.textBoxCountry.Location = new System.Drawing.Point(7, 28);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(199, 57);
            this.textBoxCountry.TabIndex = 4;
            this.textBoxCountry.Text = "Disneyland";
            // 
            // textBoxSubtitle
            // 
            this.flowLayoutPanel1.SetFillWeight(this.textBoxSubtitle, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxSubtitle, true);
            this.textBoxSubtitle.LabelText = "Subtitle";
            this.textBoxSubtitle.Location = new System.Drawing.Point(3, 79);
            this.textBoxSubtitle.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.textBoxSubtitle.Name = "textBoxSubtitle";
            this.textBoxSubtitle.Size = new System.Drawing.Size(212, 57);
            this.textBoxSubtitle.TabIndex = 1;
            this.textBoxSubtitle.Text = "Largest projected populations for 2015";
            // 
            // igDataChart
            // 
            this.Name = "igDataChart";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igDataChart igDataChart1;
		private TextBox textBoxTitle;
		private Upload buttonLoad;
		private Button buttonExportImage;
		private Button buttonAdd;
		private ComboBox comboBox2;
		private GroupBox groupBox2;
        private TextBox textBoxSubtitle;
        private TextBox textBoxCountry;
    }
}
