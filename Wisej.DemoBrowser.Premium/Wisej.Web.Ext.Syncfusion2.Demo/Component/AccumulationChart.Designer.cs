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
            this.numericUpDownExplodeOffset = new Wisej.Web.NumericUpDown();
            this.trackBarExplodeIndex = new Wisej.Web.TrackBar();
            this.label5 = new Wisej.Web.Label();
            this.numericUpDownRadius = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPieAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExplodeOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExplodeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Size = new System.Drawing.Size(836, 24);
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/accumulation-chart/es5-gettin" +
    "g-started/";
            // 
            // linkApi
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
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownExplodeOffset);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownRadius);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.trackBarExplodeIndex);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 45);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 470);
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
            this.accumulationChart1.Size = new System.Drawing.Size(872, 560);
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
            this.textBoxTitle.Size = new System.Drawing.Size(212, 57);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxSubTitle
            // 
            this.textBoxSubTitle.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.SetFillWeight(this.textBoxSubTitle, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxSubTitle, true);
            this.textBoxSubTitle.LabelText = "SubTitle";
            this.textBoxSubTitle.Location = new System.Drawing.Point(3, 79);
            this.textBoxSubTitle.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.textBoxSubTitle.Name = "textBoxSubTitle";
            this.textBoxSubTitle.Size = new System.Drawing.Size(212, 57);
            this.textBoxSubTitle.TabIndex = 2;
            // 
            // trackBarPieAngle
            // 
            this.trackBarPieAngle.AutoSize = false;
            this.trackBarPieAngle.Dock = Wisej.Web.DockStyle.Top;
            this.trackBarPieAngle.Location = new System.Drawing.Point(3, 183);
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
            this.label4.Location = new System.Drawing.Point(3, 155);
            this.label4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pie Angle";
            // 
            // numericUpDownExplodeOffset
            // 
            this.numericUpDownExplodeOffset.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownExplodeOffset, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownExplodeOffset, true);
            this.numericUpDownExplodeOffset.Label.AutoEllipsis = true;
            this.numericUpDownExplodeOffset.LabelText = "Explode Offset (%)";
            this.numericUpDownExplodeOffset.Location = new System.Drawing.Point(3, 242);
            this.numericUpDownExplodeOffset.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownExplodeOffset.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownExplodeOffset.Name = "numericUpDownExplodeOffset";
            this.numericUpDownExplodeOffset.Size = new System.Drawing.Size(212, 57);
            this.numericUpDownExplodeOffset.TabIndex = 11;
            this.numericUpDownExplodeOffset.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // trackBarExplodeIndex
            // 
            this.trackBarExplodeIndex.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.SetFillWeight(this.trackBarExplodeIndex, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.trackBarExplodeIndex, true);
            this.trackBarExplodeIndex.Location = new System.Drawing.Point(3, 422);
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
            this.label5.Location = new System.Drawing.Point(3, 394);
            this.label5.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Explosion Index";
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownRadius, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownRadius, true);
            this.numericUpDownRadius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownRadius.Label.AutoEllipsis = true;
            this.numericUpDownRadius.LabelText = "Radius (%)";
            this.numericUpDownRadius.Location = new System.Drawing.Point(3, 318);
            this.numericUpDownRadius.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(212, 57);
            this.numericUpDownRadius.TabIndex = 15;
            this.numericUpDownRadius.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // AccumulationChart
            // 
            this.Name = "AccumulationChart";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPieAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExplodeOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarExplodeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.AccumulationChart accumulationChart1;
		private TextBox textBoxTitle;
        private TextBox textBoxSubTitle;
        private TrackBar trackBarPieAngle;
        private Label label4;
        private NumericUpDown numericUpDownExplodeOffset;
        private Label label5;
        private TrackBar trackBarExplodeIndex;
        private NumericUpDown numericUpDownRadius;
    }
}
