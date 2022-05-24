namespace Wisej.DemoBrowser.Rotation
{
	partial class Features
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            this.rotation1 = new Wisej.Web.Rotation(this.components);
            this.htmlPanelDisplay = new Wisej.Web.HtmlPanel();
            this.numericUpDownXRotation = new Wisej.Web.NumericUpDown();
            this.numericUpDownYRotation = new Wisej.Web.NumericUpDown();
            this.numericUpDownZRotation = new Wisej.Web.NumericUpDown();
            this.numericUpDownZScale = new Wisej.Web.NumericUpDown();
            this.numericUpDownYScale = new Wisej.Web.NumericUpDown();
            this.numericUpDownXScale = new Wisej.Web.NumericUpDown();
            this.panelRight = new Wisej.Web.Panel();
            this.numericUpDownPerspective = new Wisej.Web.NumericUpDown();
            this.panelLeft = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXScale)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerspective)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlPanelDisplay
            // 
            this.htmlPanelDisplay.Dock = Wisej.Web.DockStyle.Fill;
            this.htmlPanelDisplay.Focusable = false;
            this.htmlPanelDisplay.Html = resources.GetString("htmlPanelDisplay.Html");
            this.htmlPanelDisplay.Location = new System.Drawing.Point(0, 0);
            this.htmlPanelDisplay.Name = "htmlPanelDisplay";
            this.rotation1.GetRotation(this.htmlPanelDisplay).Perspective = 100;
            this.rotation1.GetRotation(this.htmlPanelDisplay).RotateX = 13;
            this.rotation1.GetRotation(this.htmlPanelDisplay).ScaleX = 90;
            this.htmlPanelDisplay.Size = new System.Drawing.Size(632, 325);
            this.htmlPanelDisplay.TabIndex = 2;
            this.htmlPanelDisplay.TabStop = false;
            // 
            // numericUpDownXRotation
            // 
            this.numericUpDownXRotation.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDownXRotation.LabelText = "X-Axis Rotation";
            this.numericUpDownXRotation.Location = new System.Drawing.Point(18, 89);
            this.numericUpDownXRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownXRotation.Name = "numericUpDownXRotation";
            this.numericUpDownXRotation.Size = new System.Drawing.Size(190, 53);
            this.numericUpDownXRotation.TabIndex = 8;
            this.numericUpDownXRotation.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // numericUpDownYRotation
            // 
            this.numericUpDownYRotation.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDownYRotation.LabelText = "Y-Axis Rotation";
            this.numericUpDownYRotation.Location = new System.Drawing.Point(18, 166);
            this.numericUpDownYRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownYRotation.Name = "numericUpDownYRotation";
            this.numericUpDownYRotation.Size = new System.Drawing.Size(190, 53);
            this.numericUpDownYRotation.TabIndex = 9;
            // 
            // numericUpDownZRotation
            // 
            this.numericUpDownZRotation.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDownZRotation.LabelText = "Z-Axis Rotation";
            this.numericUpDownZRotation.Location = new System.Drawing.Point(18, 243);
            this.numericUpDownZRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownZRotation.Name = "numericUpDownZRotation";
            this.numericUpDownZRotation.Size = new System.Drawing.Size(190, 53);
            this.numericUpDownZRotation.TabIndex = 10;
            // 
            // numericUpDownZScale
            // 
            this.numericUpDownZScale.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDownZScale.LabelText = "Z-Axis Scale";
            this.numericUpDownZScale.Location = new System.Drawing.Point(242, 243);
            this.numericUpDownZScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownZScale.Name = "numericUpDownZScale";
            this.numericUpDownZScale.Size = new System.Drawing.Size(190, 53);
            this.numericUpDownZScale.TabIndex = 13;
            this.numericUpDownZScale.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownYScale
            // 
            this.numericUpDownYScale.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDownYScale.LabelText = "Y-Axis Scale";
            this.numericUpDownYScale.Location = new System.Drawing.Point(242, 166);
            this.numericUpDownYScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownYScale.Name = "numericUpDownYScale";
            this.numericUpDownYScale.Size = new System.Drawing.Size(190, 53);
            this.numericUpDownYScale.TabIndex = 12;
            this.numericUpDownYScale.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownXScale
            // 
            this.numericUpDownXScale.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDownXScale.LabelText = "X-Axis Scale";
            this.numericUpDownXScale.Location = new System.Drawing.Point(242, 89);
            this.numericUpDownXScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownXScale.Name = "numericUpDownXScale";
            this.numericUpDownXScale.Size = new System.Drawing.Size(190, 53);
            this.numericUpDownXScale.TabIndex = 11;
            this.numericUpDownXScale.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // panelRight
            // 
            this.panelRight.Anchor = Wisej.Web.AnchorStyles.None;
            this.panelRight.BackColor = System.Drawing.Color.Black;
            this.panelRight.Controls.Add(this.htmlPanelDisplay);
            this.flowLayoutPanel1.SetFillWeight(this.panelRight, 2);
            this.panelRight.Location = new System.Drawing.Point(491, 35);
            this.panelRight.MinimumSize = new System.Drawing.Size(400, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(632, 325);
            this.panelRight.TabIndex = 14;
            this.panelRight.TabStop = true;
            // 
            // numericUpDownPerspective
            // 
            this.numericUpDownPerspective.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDownPerspective.LabelText = "Perspective";
            this.numericUpDownPerspective.Location = new System.Drawing.Point(18, 18);
            this.numericUpDownPerspective.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownPerspective.Name = "numericUpDownPerspective";
            this.numericUpDownPerspective.Size = new System.Drawing.Size(190, 53);
            this.numericUpDownPerspective.TabIndex = 15;
            this.numericUpDownPerspective.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.numericUpDownPerspective);
            this.panelLeft.Controls.Add(this.numericUpDownZScale);
            this.panelLeft.Controls.Add(this.numericUpDownYScale);
            this.panelLeft.Controls.Add(this.numericUpDownXScale);
            this.panelLeft.Controls.Add(this.numericUpDownZRotation);
            this.panelLeft.Controls.Add(this.numericUpDownYRotation);
            this.panelLeft.Controls.Add(this.numericUpDownXRotation);
            this.flowLayoutPanel1.SetFillWeight(this.panelLeft, 1);
            this.panelLeft.Location = new System.Drawing.Point(35, 35);
            this.panelLeft.MinimumSize = new System.Drawing.Size(450, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(450, 325);
            this.panelLeft.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panelLeft);
            this.flowLayoutPanel1.Controls.Add(this.panelRight);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(132, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(32);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1158, 395);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // Features
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXScale)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerspective)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Rotation rotation1;
		private Web.NumericUpDown numericUpDownXRotation;
		private Web.NumericUpDown numericUpDownYRotation;
		private Web.NumericUpDown numericUpDownZRotation;
		private Web.NumericUpDown numericUpDownZScale;
		private Web.NumericUpDown numericUpDownYScale;
		private Web.NumericUpDown numericUpDownXScale;
		private Web.Panel panelRight;
        private Web.NumericUpDown numericUpDownPerspective;
        private Web.Panel panelLeft;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.HtmlPanel htmlPanelDisplay;
    }
}
