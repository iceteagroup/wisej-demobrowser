namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igBulletGraph
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
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction3 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igBulletGraph));
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            this.igBulletGraph1 = new Wisej.Web.Ext.Ignite.igBulletGraph();
            this.igBulletGraph2 = new Wisej.Web.Ext.Ignite.igBulletGraph();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.label8 = new Wisej.Web.Label();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.numericUpDown3 = new Wisej.Web.NumericUpDown();
            this.numericUpDown4 = new Wisej.Web.NumericUpDown();
            this.igBulletGraph3 = new Wisej.Web.Ext.Ignite.igBulletGraph();
            this.label6 = new Wisej.Web.Label();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.igBulletGraph3);
            this.panel.Controls.Add(this.igBulletGraph2);
            this.panel.Controls.Add(this.igBulletGraph1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/bullet-graph/overview";
            // 
            // linkApi
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "https://www.igniteui.com/help/api/2019.2/ui.igBulletGraph";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igbulletgraph-overview";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown2);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown3);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown4);
            // 
            // igBulletGraph1
            // 
            this.igBulletGraph1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.igBulletGraph1.Location = new System.Drawing.Point(26, 158);
            this.igBulletGraph1.Name = "igBulletGraph1";
            this.igBulletGraph1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igBulletGraph1.Options"))));
            this.igBulletGraph1.Size = new System.Drawing.Size(836, 72);
            this.igBulletGraph1.TabIndex = 1;
            widgetFunction3.Name = "formatLabel";
            widgetFunction3.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"K\";";
            this.igBulletGraph1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction3};
            // 
            // igBulletGraph2
            // 
            this.igBulletGraph2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.igBulletGraph2.Location = new System.Drawing.Point(26, 263);
            this.igBulletGraph2.Name = "igBulletGraph2";
            this.igBulletGraph2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igBulletGraph2.Options"))));
            this.igBulletGraph2.Size = new System.Drawing.Size(836, 72);
            this.igBulletGraph2.TabIndex = 3;
            widgetFunction2.Name = "formatLabel";
            widgetFunction2.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"K\";";
            this.igBulletGraph2.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction2};
            // 
            // label4
            // 
            this.label4.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "YTD Revenue";
            // 
            // label5
            // 
            this.label5.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Profit";
            // 
            // numericUpDown1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
            this.numericUpDown1.LabelText = "Minimum Value";
            this.numericUpDown1.Location = new System.Drawing.Point(3, 66);
            this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.flowLayoutPanel1.SetFillWeight(this.label8, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.label8, true);
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 44);
            this.label8.TabIndex = 0;
            this.label8.Text = "Note: Changes only affect top widget";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown2, true);
            this.numericUpDown2.LabelText = "Maximum Value";
            this.numericUpDown2.Location = new System.Drawing.Point(3, 142);
            this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown3, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown3, true);
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.LabelText = "Value Inner Extent";
            this.numericUpDown3.Location = new System.Drawing.Point(3, 218);
            this.numericUpDown3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown3.TabIndex = 3;
            this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown4, true);
            this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown4.LabelText = "Value Outer Extent";
            this.numericUpDown4.Location = new System.Drawing.Point(3, 294);
            this.numericUpDown4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown4.TabIndex = 4;
            this.numericUpDown4.Value = new decimal(new int[] {
            65,
            0,
            0,
            131072});
            // 
            // igBulletGraph3
            // 
            this.igBulletGraph3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.igBulletGraph3.Location = new System.Drawing.Point(26, 368);
            this.igBulletGraph3.Name = "igBulletGraph3";
            this.igBulletGraph3.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igBulletGraph3.Options"))));
            this.igBulletGraph3.Size = new System.Drawing.Size(836, 72);
            this.igBulletGraph3.TabIndex = 5;
            widgetFunction1.Name = "formatLabel";
            widgetFunction1.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"K\";";
            this.igBulletGraph3.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
            // 
            // label6
            // 
            this.label6.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Avg Order";
            // 
            // igBulletGraph
            // 
            this.Name = "igBulletGraph";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igBulletGraph igBulletGraph1;
		private Ignite.igBulletGraph igBulletGraph2;
		private Label label5;
		private Label label4;
		private NumericUpDown numericUpDown4;
		private NumericUpDown numericUpDown3;
		private NumericUpDown numericUpDown2;
		private Label label8;
		private NumericUpDown numericUpDown1;
        private Label label6;
        private Ignite.igBulletGraph igBulletGraph3;
    }
}
