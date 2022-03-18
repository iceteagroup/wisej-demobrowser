namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igDataChartFinancial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igDataChartFinancial));
            this.igDataChart1 = new Wisej.Web.Ext.Ignite.igDataChart();
            this.buttonLoad = new Wisej.Web.Upload();
            this.buttonExportImage = new Wisej.Web.Button();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.comboBox3 = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.buttonExportImage);
            this.groupBox1.Size = new System.Drawing.Size(250, 444);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonExportImage, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox3, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 361);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igDataChart1);
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
            this.igDataChart1.Location = new System.Drawing.Point(26, 26);
            this.igDataChart1.Name = "igDataChart1";
            this.igDataChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igDataChart1.Options"))));
            this.igDataChart1.Size = new System.Drawing.Size(1036, 504);
            this.igDataChart1.TabIndex = 0;
            this.igDataChart1.Text = "igDataChart1";
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(28, 279);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
            // 
            // buttonExportImage
            // 
            this.buttonExportImage.Display = Wisej.Web.Display.Icon;
            this.buttonExportImage.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
            this.buttonExportImage.Location = new System.Drawing.Point(76, 279);
            this.buttonExportImage.Name = "buttonExportImage";
            this.buttonExportImage.Size = new System.Drawing.Size(42, 42);
            this.buttonExportImage.TabIndex = 4;
            this.buttonExportImage.Click += new System.EventHandler(this.buttonExportImage_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "none",
            "dragZoom",
            "dragPan"});
            this.comboBox1.LabelText = "Default Interaction";
            this.comboBox1.Location = new System.Drawing.Point(28, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 57);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "dragZoom";
            // 
            // comboBox2
            // 
            this.comboBox2.Items.AddRange(new object[] {
            "none",
            "alt",
            "control",
            "shift"});
            this.comboBox2.LabelText = "Drag Modifier";
            this.comboBox2.Location = new System.Drawing.Point(28, 117);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 57);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "none";
            // 
            // comboBox3
            // 
            this.comboBox3.Items.AddRange(new object[] {
            "none",
            "beforeSeries",
            "behindSeries"});
            this.comboBox3.LabelText = "Grid Mode";
            this.comboBox3.Location = new System.Drawing.Point(28, 198);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(195, 57);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.Text = "behindSeries";
            // 
            // igDataChartFinancial
            // 
            this.Name = "igDataChartFinancial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Ignite.igDataChart igDataChart1;
		private Upload buttonLoad;
		private Button buttonExportImage;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private ComboBox comboBox3;
	}
}
