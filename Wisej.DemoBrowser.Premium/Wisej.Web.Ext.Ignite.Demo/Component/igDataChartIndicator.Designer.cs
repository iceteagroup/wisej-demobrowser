namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igDataChartIndicator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igDataChartIndicator));
			this.igDataChart1 = new Wisej.Web.Ext.Ignite.igDataChart();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonExportImage = new Wisej.Web.Button();
			this.button1 = new Wisej.Web.Button();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExportImage);
			this.groupBox1.Size = new System.Drawing.Size(250, 481);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExportImage, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 397);
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igDataChart1);
			this.panel.Size = new System.Drawing.Size(455, 481);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/data-chart/charts-financial-indicators";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igDataChart";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igdatachart-landing-page";
			// 
			// igDataChart1
			// 
			this.igDataChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igDataChart1.Location = new System.Drawing.Point(19, 27);
			this.igDataChart1.Name = "igDataChart1";
			this.igDataChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igDataChart1.Options"))));
			this.igDataChart1.Size = new System.Drawing.Size(415, 425);
			this.igDataChart1.TabIndex = 0;
			this.igDataChart1.Text = "igDataChart1";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 320);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 4;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonExportImage
			// 
			this.buttonExportImage.Display = Wisej.Web.Display.Icon;
			this.buttonExportImage.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
			this.buttonExportImage.Location = new System.Drawing.Point(76, 320);
			this.buttonExportImage.Name = "buttonExportImage";
			this.buttonExportImage.Size = new System.Drawing.Size(42, 42);
			this.buttonExportImage.TabIndex = 5;
			this.buttonExportImage.Click += new System.EventHandler(this.buttonExportImage_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 258);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 3;
			this.button1.Text = "Add Item";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Is Square";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 109);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Horizontal Zoom";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Highlighting Transition Duration";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 182);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// igDataChartIndicator
			// 
			this.Name = "igDataChartIndicator";
			this.Size = new System.Drawing.Size(864, 671);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igDataChart igDataChart1;
		private Upload buttonLoad;
		private Button buttonExportImage;
		private Button button1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private NumericUpDown numericUpDown1;
	}
}
