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
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction4 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction3 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igBulletGraph));
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            this.igBulletGraph1 = new Wisej.Web.Ext.Ignite.igBulletGraph();
            this.igBulletGraph2 = new Wisej.Web.Ext.Ignite.igBulletGraph();
            this.igBulletGraph3 = new Wisej.Web.Ext.Ignite.igBulletGraph();
            this.igBulletGraph4 = new Wisej.Web.Ext.Ignite.igBulletGraph();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.label7 = new Wisej.Web.Label();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.label8 = new Wisej.Web.Label();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.numericUpDown3 = new Wisej.Web.NumericUpDown();
            this.numericUpDown4 = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Size = new System.Drawing.Size(250, 433);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label8, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown3, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown4, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 350);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.igBulletGraph4);
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
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://www.igniteui.com/help/api/2019.2/ui.igBulletGraph";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igbulletgraph-overview";
            // 
            // igBulletGraph1
            // 
            this.igBulletGraph1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.igBulletGraph1.Location = new System.Drawing.Point(26, 97);
            this.igBulletGraph1.MaximumValue = 10000D;
            this.igBulletGraph1.Name = "igBulletGraph1";
            this.igBulletGraph1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igBulletGraph1.Options"))));
            this.igBulletGraph1.Size = new System.Drawing.Size(1037, 72);
            this.igBulletGraph1.TabIndex = 1;
            this.igBulletGraph1.Value = 6500;
            this.igBulletGraph1.ValueInnerExtent = 0.5D;
            this.igBulletGraph1.ValueOuterExtent = 0.65D;
            widgetFunction4.Name = "formatLabel";
            widgetFunction4.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"K\";";
            this.igBulletGraph1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction4};
            // 
            // igBulletGraph2
            // 
            this.igBulletGraph2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.igBulletGraph2.Location = new System.Drawing.Point(26, 202);
            this.igBulletGraph2.MaximumValue = 10000D;
            this.igBulletGraph2.Name = "igBulletGraph2";
            this.igBulletGraph2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igBulletGraph2.Options"))));
            this.igBulletGraph2.Size = new System.Drawing.Size(1037, 72);
            this.igBulletGraph2.TabIndex = 3;
            this.igBulletGraph2.Value = 5000;
            this.igBulletGraph2.ValueInnerExtent = 0.5D;
            this.igBulletGraph2.ValueOuterExtent = 0.65D;
            widgetFunction3.Name = "formatLabel";
            widgetFunction3.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"K\";";
            this.igBulletGraph2.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction3};
            // 
            // igBulletGraph3
            // 
            this.igBulletGraph3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.igBulletGraph3.Location = new System.Drawing.Point(26, 307);
            this.igBulletGraph3.MaximumValue = 500D;
            this.igBulletGraph3.Name = "igBulletGraph3";
            this.igBulletGraph3.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igBulletGraph3.Options"))));
            this.igBulletGraph3.Size = new System.Drawing.Size(1037, 72);
            this.igBulletGraph3.TabIndex = 5;
            this.igBulletGraph3.Value = 350;
            this.igBulletGraph3.ValueInnerExtent = 0.35D;
            this.igBulletGraph3.ValueOuterExtent = 0.8D;
            widgetFunction2.Name = "formatLabel";
            widgetFunction2.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"K\";";
            this.igBulletGraph3.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction2};
            // 
            // igBulletGraph4
            // 
            this.igBulletGraph4.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.igBulletGraph4.Location = new System.Drawing.Point(26, 412);
            this.igBulletGraph4.MaximumValue = 100D;
            this.igBulletGraph4.Name = "igBulletGraph4";
            this.igBulletGraph4.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igBulletGraph4.Options"))));
            this.igBulletGraph4.Size = new System.Drawing.Size(1037, 72);
            this.igBulletGraph4.TabIndex = 7;
            this.igBulletGraph4.Value = 55;
            widgetFunction1.Name = "formatLabel";
            widgetFunction1.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"K\";";
            this.igBulletGraph4.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
            // 
            // label4
            // 
            this.label4.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "YTD Revenue";
            // 
            // label5
            // 
            this.label5.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Profit";
            // 
            // label6
            // 
            this.label6.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Avg Order";
            // 
            // label7
            // 
            this.label7.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "New Customers";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.LabelText = "Minimum Value";
            this.numericUpDown1.Location = new System.Drawing.Point(28, 78);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 57);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Note: Changes only affect top widget";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.LabelText = "Maximum Value";
            this.numericUpDown2.Location = new System.Drawing.Point(28, 146);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(195, 57);
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
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.LabelText = "Value Inner Extent";
            this.numericUpDown3.Location = new System.Drawing.Point(28, 214);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(195, 57);
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
            this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown4.LabelText = "Value Outer Extent";
            this.numericUpDown4.Location = new System.Drawing.Point(28, 282);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(195, 57);
            this.numericUpDown4.TabIndex = 4;
            this.numericUpDown4.Value = new decimal(new int[] {
            65,
            0,
            0,
            131072});
            // 
            // igBulletGraph
            // 
            this.Name = "igBulletGraph";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Ignite.igBulletGraph igBulletGraph1;
		private Ignite.igBulletGraph igBulletGraph4;
		private Ignite.igBulletGraph igBulletGraph3;
		private Ignite.igBulletGraph igBulletGraph2;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private NumericUpDown numericUpDown4;
		private NumericUpDown numericUpDown3;
		private NumericUpDown numericUpDown2;
		private Label label8;
		private NumericUpDown numericUpDown1;
	}
}
