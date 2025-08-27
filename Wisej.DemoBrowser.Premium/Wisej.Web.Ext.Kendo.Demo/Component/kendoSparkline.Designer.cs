namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoSparkline
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoSparkline));
			this.kendoSparkline1 = new Wisej.Web.Ext.Kendo.kendoSparkline();
			this.buttonImage = new Wisej.Web.Button();
			this.buttonPDF = new Wisej.Web.Button();
			this.label4 = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.panelClimate = new Wisej.Web.Panel();
			this.label9 = new Wisej.Web.Label();
			this.kendoSparkline4 = new Wisej.Web.Ext.Kendo.kendoSparkline();
			this.label8 = new Wisej.Web.Label();
			this.kendoSparkline3 = new Wisej.Web.Ext.Kendo.kendoSparkline();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.panelTemperature = new Wisej.Web.Panel();
			this.label7 = new Wisej.Web.Label();
			this.kendoSparkline2 = new Wisej.Web.Ext.Kendo.kendoSparkline();
			this.comboBoxTheme = new Wisej.Web.ComboBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.panelClimate.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panelTemperature.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.flowLayoutPanel1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/sparklines/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/sparkline";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/charts/sparkline/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.comboBoxTheme);
			this.flowLayoutPanelProperties.Controls.Add(this.buttonImage);
			this.flowLayoutPanelProperties.Controls.Add(this.buttonPDF);
			// 
			// kendoSparkline1
			// 
			this.kendoSparkline1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoSparkline1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.kendoSparkline1.Location = new System.Drawing.Point(37, 51);
			this.kendoSparkline1.Name = "kendoSparkline1";
			this.kendoSparkline1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"data\":[936,968,1025,999,998,1014,1017,1010,1010,1007,1004,988,990,988,987,995,9" +
        "46,954,991,984,974,956,986,936,955,1021,1013,1005,958,953,952,940,937,980,966,96" +
        "5,928,916,910,980]}")));
			this.kendoSparkline1.Size = new System.Drawing.Size(377, 38);
			this.kendoSparkline1.TabIndex = 0;
			this.kendoSparkline1.Text = "kendoSparkline1";
			// 
			// buttonImage
			// 
			this.buttonImage.Display = Wisej.Web.Display.Icon;
			this.buttonImage.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
			this.buttonImage.Location = new System.Drawing.Point(3, 79);
			this.buttonImage.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonImage.Name = "buttonImage";
			this.buttonImage.Size = new System.Drawing.Size(42, 42);
			this.buttonImage.TabIndex = 12;
			this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
			// 
			// buttonPDF
			// 
			this.buttonPDF.Display = Wisej.Web.Display.Icon;
			this.buttonPDF.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
			this.buttonPDF.Location = new System.Drawing.Point(51, 79);
			this.buttonPDF.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonPDF.Name = "buttonPDF";
			this.buttonPDF.Size = new System.Drawing.Size(42, 42);
			this.buttonPDF.TabIndex = 15;
			this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("@defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label4.Location = new System.Drawing.Point(37, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(189, 22);
			this.label4.TabIndex = 1;
			this.label4.Text = "Climate control history";
			// 
			// label5
			// 
			this.label5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(454, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 22);
			this.label5.TabIndex = 2;
			this.label5.Text = "980mb";
			// 
			// panelClimate
			// 
			this.panelClimate.BorderStyle = Wisej.Web.BorderStyle.Dashed;
			this.panelClimate.Controls.Add(this.label9);
			this.panelClimate.Controls.Add(this.kendoSparkline4);
			this.panelClimate.Controls.Add(this.label8);
			this.panelClimate.Controls.Add(this.kendoSparkline3);
			this.panelClimate.Controls.Add(this.label5);
			this.panelClimate.Controls.Add(this.label4);
			this.panelClimate.Controls.Add(this.kendoSparkline1);
			this.flowLayoutPanel1.SetFillWeight(this.panelClimate, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.panelClimate, true);
			this.panelClimate.Location = new System.Drawing.Point(3, 3);
			this.panelClimate.Name = "panelClimate";
			this.panelClimate.Size = new System.Drawing.Size(555, 201);
			this.panelClimate.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(454, 147);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 22);
			this.label9.TabIndex = 6;
			this.label9.Text = "32%";
			// 
			// kendoSparkline4
			// 
			this.kendoSparkline4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoSparkline4.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.kendoSparkline4.Location = new System.Drawing.Point(37, 139);
			this.kendoSparkline4.Name = "kendoSparkline4";
			this.kendoSparkline4.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"type\":\"area\",\"data\":[71,70,69,68,65,60,55,55,50,52,73,72,72,71,68,63,57,58,53,5" +
        "5,63,59,61,64,58,53,48,48,45,45,63,64,63,67,58,56,53,59,51,54],\"tooltip\":{\"forma" +
        "t\":\"{0} %\"}}")));
			this.kendoSparkline4.Size = new System.Drawing.Size(377, 38);
			this.kendoSparkline4.TabIndex = 5;
			this.kendoSparkline4.Text = "kendoSparkline4";
			// 
			// label8
			// 
			this.label8.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(454, 111);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 22);
			this.label8.TabIndex = 4;
			this.label8.Text = "21°C";
			// 
			// kendoSparkline3
			// 
			this.kendoSparkline3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoSparkline3.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.kendoSparkline3.Location = new System.Drawing.Point(37, 95);
			this.kendoSparkline3.Name = "kendoSparkline3";
			this.kendoSparkline3.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"type\":\"column\",\"data\":[16,17,18,19,20,21,21,22,23,22,20,18,17,17,16,16,17,18,19" +
        ",20,21,22,23,25,24,24,22,22,23,22,22,21,16,15,15,16,19,20,20,21],\"tooltip\":{\"for" +
        "mat\":\"{0} &deg;C\"}}")));
			this.kendoSparkline3.Size = new System.Drawing.Size(377, 38);
			this.kendoSparkline3.TabIndex = 3;
			this.kendoSparkline3.Text = "kendoSparkline3";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = Wisej.Web.AnchorStyles.None;
			this.flowLayoutPanel1.Controls.Add(this.panelClimate);
			this.flowLayoutPanel1.Controls.Add(this.panelTemperature);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(164, 126);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 324);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// panelTemperature
			// 
			this.panelTemperature.BorderStyle = Wisej.Web.BorderStyle.Dashed;
			this.panelTemperature.Controls.Add(this.label7);
			this.panelTemperature.Controls.Add(this.kendoSparkline2);
			this.flowLayoutPanel1.SetFillWeight(this.panelTemperature, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.panelTemperature, true);
			this.panelTemperature.Location = new System.Drawing.Point(3, 210);
			this.panelTemperature.Name = "panelTemperature";
			this.panelTemperature.Size = new System.Drawing.Size(555, 110);
			this.panelTemperature.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("@defaultBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label7.Location = new System.Drawing.Point(37, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(171, 22);
			this.label7.TabIndex = 1;
			this.label7.Text = "Temperature control";
			// 
			// kendoSparkline2
			// 
			this.kendoSparkline2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.kendoSparkline2.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.kendoSparkline2.Location = new System.Drawing.Point(37, 45);
			this.kendoSparkline2.Name = "kendoSparkline2";
			this.kendoSparkline2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoSparkline2.Options"))));
			this.kendoSparkline2.Size = new System.Drawing.Size(480, 34);
			this.kendoSparkline2.TabIndex = 0;
			this.kendoSparkline2.Text = "kendoSparkline2";
			// 
			// comboBoxTheme
			// 
			this.comboBoxTheme.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanelProperties.SetFillWeight(this.comboBoxTheme, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.comboBoxTheme, true);
			this.comboBoxTheme.Items.AddRange(new object[] {
            "black",
            "blueopal",
            "bootstrap",
            "default",
            "hightcontrast",
            "metro",
            "metroblack",
            "moonlight",
            "silver",
            "uniform"});
			this.comboBoxTheme.LabelText = "Theme";
			this.comboBoxTheme.Location = new System.Drawing.Point(3, 3);
			this.comboBoxTheme.Name = "comboBoxTheme";
			this.comboBoxTheme.Size = new System.Drawing.Size(212, 57);
			this.comboBoxTheme.TabIndex = 0;
			this.comboBoxTheme.Text = "default";
			// 
			// kendoSparkline
			// 
			this.Name = "kendoSparkline";
			this.Load += new System.EventHandler(this.kendoSparkline_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.flowLayoutPanelProperties.PerformLayout();
			this.panelClimate.ResumeLayout(false);
			this.panelClimate.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panelTemperature.ResumeLayout(false);
			this.panelTemperature.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoSparkline kendoSparkline1;
        private Button buttonImage;
        private Button buttonPDF;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelClimate;
        private Label label9;
        private Kendo.kendoSparkline kendoSparkline4;
        private Label label8;
        private Kendo.kendoSparkline kendoSparkline3;
        private Label label5;
        private Label label4;
        private Panel panelTemperature;
        private Label label7;
        private Kendo.kendoSparkline kendoSparkline2;
        private ComboBox comboBoxTheme;
    }
}
