namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejDigitalGauge
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
            this.ejDigitalGauge1 = new Wisej.Web.Ext.Syncfusion.ejDigitalGauge();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label4 = new Wisej.Web.Label();
            this.trackBarSegmentSpacing = new Wisej.Web.TrackBar();
            this.label5 = new Wisej.Web.Label();
            this.trackBarCharSpacing = new Wisej.Web.TrackBar();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSegmentSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCharSpacing)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/digitalgauge/overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/digitalgauge/DefaultFunctionalit" +
    "ies";
            // 
            // linkAPI
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "https://help.syncfusion.com/api/js/ejdigitalgauge";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejDigitalGauge1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.textBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.panel1);
            this.flowLayoutPanelProperties.Controls.Add(this.panel2);
            this.flowLayoutPanelProperties.Location = new System.Drawing.Point(16, 31);
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(218, 441);
            // 
            // ejDigitalGauge1
            // 
            this.ejDigitalGauge1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejDigitalGauge1.Location = new System.Drawing.Point(8, 8);
            this.ejDigitalGauge1.Name = "ejDigitalGauge1";
            this.ejDigitalGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"isResponsive\":true,\"items\":[{\"segmentSettings\":{\"width\":1,\"spacing\":0,\"color\":\"" +
        "#8c8c8c\"},\"characterSettings\":{\"opacity\":0.8,\"spacing\":2},\"value\":\"123456789\",\"p" +
        "osition\":{\"x\":52,\"y\":52}}]}")));
            this.ejDigitalGauge1.Size = new System.Drawing.Size(1073, 542);
            this.ejDigitalGauge1.TabIndex = 0;
            this.ejDigitalGauge1.Text = "ejDigitalGauge1";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.textBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.textBox1, true);
            this.textBox1.Label.Size = 50;
            this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox1.LabelText = "Text";
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 60);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "123456789";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Segment Spacing";
            // 
            // trackBarSegmentSpacing
            // 
            this.trackBarSegmentSpacing.Location = new System.Drawing.Point(3, 25);
            this.trackBarSegmentSpacing.Maximum = 1;
            this.trackBarSegmentSpacing.Minimum = -2;
            this.trackBarSegmentSpacing.Name = "trackBarSegmentSpacing";
            this.trackBarSegmentSpacing.Size = new System.Drawing.Size(195, 34);
            this.trackBarSegmentSpacing.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Character Spacing";
            // 
            // trackBarCharSpacing
            // 
            this.trackBarCharSpacing.Location = new System.Drawing.Point(3, 25);
            this.trackBarCharSpacing.Maximum = 4;
            this.trackBarCharSpacing.Minimum = 1;
            this.trackBarCharSpacing.Name = "trackBarCharSpacing";
            this.trackBarCharSpacing.Size = new System.Drawing.Size(195, 34);
            this.trackBarCharSpacing.TabIndex = 1;
            this.trackBarCharSpacing.Value = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.trackBarSegmentSpacing);
            this.flowLayoutPanelProperties.SetFillWeight(this.panel1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.panel1, true);
            this.panel1.Location = new System.Drawing.Point(3, 82);
            this.panel1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 64);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.trackBarCharSpacing);
            this.flowLayoutPanelProperties.SetFillWeight(this.panel2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.panel2, true);
            this.panel2.Location = new System.Drawing.Point(3, 165);
            this.panel2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 64);
            this.panel2.TabIndex = 2;
            this.panel2.TabStop = true;
            // 
            // ejDigitalGauge
            // 
            this.Name = "ejDigitalGauge";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSegmentSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCharSpacing)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDigitalGauge ejDigitalGauge1;
		private TextBox textBox1;
		private Label label4;
		private TrackBar trackBarSegmentSpacing;
		private Label label5;
		private TrackBar trackBarCharSpacing;
		private Panel panel2;
		private Panel panel1;
	}
}
