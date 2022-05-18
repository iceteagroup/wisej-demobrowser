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
            this.trackBarExplodeIndex = new Wisej.Web.TrackBar();
            this.label5 = new Wisej.Web.Label();
            this.numericUpDownOuterRadius = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPieAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExplodeRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExplodeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOuterRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Size = new System.Drawing.Size(836, 24);
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/accumulation-chart/es5-gettin" +
    "g-started/";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/accumulation-chart/overvi" +
    "ew/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.accumulationChart1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBoxTitle);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSubTitle);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.trackBarPieAngle);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownExplodeRadius);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownOuterRadius);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.trackBarExplodeIndex);
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
            this.accumulationChart1.Size = new System.Drawing.Size(1073, 542);
            this.accumulationChart1.TabIndex = 0;
            this.accumulationChart1.Text = "accumulationChart1";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.SetFillWeight(this.textBoxTitle, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxTitle, true);
            this.textBoxTitle.LabelText = "Title";
            this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(212, 46);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxSubTitle
            // 
            this.textBoxSubTitle.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.SetFillWeight(this.textBoxSubTitle, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxSubTitle, true);
            this.textBoxSubTitle.LabelText = "SubTitle";
            this.textBoxSubTitle.Location = new System.Drawing.Point(3, 68);
            this.textBoxSubTitle.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.textBoxSubTitle.Name = "textBoxSubTitle";
            this.textBoxSubTitle.Size = new System.Drawing.Size(212, 46);
            this.textBoxSubTitle.TabIndex = 2;
            // 
            // trackBarPieAngle
            // 
            this.trackBarPieAngle.AutoSize = false;
            this.trackBarPieAngle.Dock = Wisej.Web.DockStyle.Top;
            this.trackBarPieAngle.Location = new System.Drawing.Point(3, 158);
            this.trackBarPieAngle.Maximum = 360;
            this.trackBarPieAngle.Name = "trackBarPieAngle";
            this.trackBarPieAngle.Size = new System.Drawing.Size(212, 40);
            this.trackBarPieAngle.TabIndex = 3;
            this.trackBarPieAngle.TickStyle = Wisej.Web.TickStyle.None;
            // 
            // label4
            // 
            this.label4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.flowLayoutPanel1.SetFillWeight(this.label4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.label4, true);
            this.label4.Location = new System.Drawing.Point(3, 133);
            this.label4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pie Angle";
            // 
            // numericUpDownExplodeRadius
            // 
            this.numericUpDownExplodeRadius.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownExplodeRadius, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownExplodeRadius, true);
            this.numericUpDownExplodeRadius.Label.AutoEllipsis = true;
            this.numericUpDownExplodeRadius.LabelText = "Explode Radius";
            this.numericUpDownExplodeRadius.Location = new System.Drawing.Point(3, 217);
            this.numericUpDownExplodeRadius.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownExplodeRadius.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownExplodeRadius.Name = "numericUpDownExplodeRadius";
            this.numericUpDownExplodeRadius.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownExplodeRadius.TabIndex = 11;
            // 
            // trackBarExplodeIndex
            // 
            this.trackBarExplodeIndex.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.SetFillWeight(this.trackBarExplodeIndex, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.trackBarExplodeIndex, true);
            this.trackBarExplodeIndex.Location = new System.Drawing.Point(3, 372);
            this.trackBarExplodeIndex.Maximum = 11;
            this.trackBarExplodeIndex.Name = "trackBarExplodeIndex";
            this.trackBarExplodeIndex.Size = new System.Drawing.Size(212, 34);
            this.trackBarExplodeIndex.TabIndex = 13;
            this.trackBarExplodeIndex.TickStyle = Wisej.Web.TickStyle.None;
            this.trackBarExplodeIndex.Value = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.flowLayoutPanel1.SetFillWeight(this.label5, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.label5, true);
            this.label5.Location = new System.Drawing.Point(3, 347);
            this.label5.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Explosion Index";
            // 
            // numericUpDownOuterRadius
            // 
            this.numericUpDownOuterRadius.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownOuterRadius, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownOuterRadius, true);
            this.numericUpDownOuterRadius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownOuterRadius.Label.AutoEllipsis = true;
            this.numericUpDownOuterRadius.LabelText = "Outer radius (%)";
            this.numericUpDownOuterRadius.Location = new System.Drawing.Point(3, 282);
            this.numericUpDownOuterRadius.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownOuterRadius.Name = "numericUpDownOuterRadius";
            this.numericUpDownOuterRadius.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownOuterRadius.TabIndex = 15;
            // 
            // AccumulationChart
            // 
            this.Name = "AccumulationChart";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPieAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExplodeRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExplodeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOuterRadius)).EndInit();
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
        private Label label5;
        private TrackBar trackBarExplodeIndex;
        private NumericUpDown numericUpDownOuterRadius;
    }
}
