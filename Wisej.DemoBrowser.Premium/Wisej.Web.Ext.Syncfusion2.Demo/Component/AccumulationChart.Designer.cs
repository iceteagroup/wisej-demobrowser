namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class AccumulationChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccumulationChart));
            this.accumulationChart1 = new Wisej.Web.Ext.Syncfusion2.AccumulationChart();
            this.textBoxTitle = new Wisej.Web.TextBox();
            this.textBoxSubTitle = new Wisej.Web.TextBox();
            this.trackBarPieAngle = new Wisej.Web.TrackBar();
            this.label4 = new Wisej.Web.Label();
            this.numericUpDownExplodeRadius = new Wisej.Web.NumericUpDown();
            this.textBoxNumOuterRadius = new Wisej.Web.TextBox();
            this.trackBarExplodeIndex = new Wisej.Web.TrackBar();
            this.label5 = new Wisej.Web.Label();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPieAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExplodeRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExplodeIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/accumulation-chart/es5-gettin" +
    "g-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/accumulation-chart/overvi" +
    "ew/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trackBarExplodeIndex);
            this.groupBox1.Controls.Add(this.textBoxNumOuterRadius);
            this.groupBox1.Controls.Add(this.numericUpDownExplodeRadius);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBarPieAngle);
            this.groupBox1.Controls.Add(this.textBoxSubTitle);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Size = new System.Drawing.Size(250, 542);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBoxTitle, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBoxSubTitle, 0);
            this.groupBox1.Controls.SetChildIndex(this.trackBarPieAngle, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownExplodeRadius, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBoxNumOuterRadius, 0);
            this.groupBox1.Controls.SetChildIndex(this.trackBarExplodeIndex, 0);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 458);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.accumulationChart1);
            this.panel.Size = new System.Drawing.Size(844, 542);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/chart/default-pie.html";
            // 
            // accumulationChart1
            // 
            this.accumulationChart1.Dock = Wisej.Web.DockStyle.Fill;
            this.accumulationChart1.Location = new System.Drawing.Point(8, 8);
            this.accumulationChart1.Name = "accumulationChart1";
            this.accumulationChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("accumulationChart1.Options"))));
            this.accumulationChart1.Size = new System.Drawing.Size(826, 524);
            this.accumulationChart1.TabIndex = 0;
            this.accumulationChart1.Text = "accumulationChart1";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.LabelText = "Title";
            this.textBoxTitle.Location = new System.Drawing.Point(6, 24);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(238, 46);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxSubTitle
            // 
            this.textBoxSubTitle.LabelText = "SubTitle";
            this.textBoxSubTitle.Location = new System.Drawing.Point(6, 88);
            this.textBoxSubTitle.Name = "textBoxSubTitle";
            this.textBoxSubTitle.Size = new System.Drawing.Size(238, 46);
            this.textBoxSubTitle.TabIndex = 2;
            // 
            // trackBarPieAngle
            // 
            this.trackBarPieAngle.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.trackBarPieAngle.AutoSize = false;
            this.trackBarPieAngle.Location = new System.Drawing.Point(6, 174);
            this.trackBarPieAngle.Maximum = 360;
            this.trackBarPieAngle.Name = "trackBarPieAngle";
            this.trackBarPieAngle.Size = new System.Drawing.Size(238, 40);
            this.trackBarPieAngle.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pie Angle";
            // 
            // numericUpDownExplodeRadius
            // 
            this.numericUpDownExplodeRadius.LabelText = "Explode Radius";
            this.numericUpDownExplodeRadius.Location = new System.Drawing.Point(133, 238);
            this.numericUpDownExplodeRadius.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownExplodeRadius.Name = "numericUpDownExplodeRadius";
            this.numericUpDownExplodeRadius.Size = new System.Drawing.Size(111, 64);
            this.numericUpDownExplodeRadius.TabIndex = 11;
            // 
            // textBoxNumOuterRadius
            // 
            this.textBoxNumOuterRadius.InputType.Max = "0,85";
            this.textBoxNumOuterRadius.InputType.Min = "0,10";
            this.textBoxNumOuterRadius.InputType.Mode = Wisej.Web.TextBoxMode.Decimal;
            this.textBoxNumOuterRadius.InputType.Step = 0.075D;
            this.textBoxNumOuterRadius.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.textBoxNumOuterRadius.LabelText = "Outer radius";
            this.textBoxNumOuterRadius.Location = new System.Drawing.Point(7, 238);
            this.textBoxNumOuterRadius.Name = "textBoxNumOuterRadius";
            this.textBoxNumOuterRadius.Size = new System.Drawing.Size(100, 46);
            this.textBoxNumOuterRadius.TabIndex = 12;
            // 
            // trackBarExplodeIndex
            // 
            this.trackBarExplodeIndex.Location = new System.Drawing.Point(7, 326);
            this.trackBarExplodeIndex.Maximum = 11;
            this.trackBarExplodeIndex.Name = "trackBarExplodeIndex";
            this.trackBarExplodeIndex.Size = new System.Drawing.Size(237, 34);
            this.trackBarExplodeIndex.TabIndex = 13;
            this.trackBarExplodeIndex.Value = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Explode index";
            // 
            // AccumulationChart
            // 
            this.Name = "AccumulationChart";
            this.Size = new System.Drawing.Size(1253, 732);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPieAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExplodeRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExplodeIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.AccumulationChart accumulationChart1;
		private TextBox textBoxTitle;
        private TextBox textBoxSubTitle;
        private TrackBar trackBarPieAngle;
        private Label label4;
        private NumericUpDown numericUpDownExplodeRadius;
        private TextBox textBoxNumOuterRadius;
        private Label label5;
        private TrackBar trackBarExplodeIndex;
    }
}
