namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejSymbolPalette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejSymbolPalette));
            Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate1 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
            this.ejSymbolPalette1 = new Wisej.Web.Ext.Syncfusion.ejSymbolPalette();
            this.ejDiagram1 = new Wisej.Web.Ext.Syncfusion.ejDiagram();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/slider/overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(586, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/diagram/GettingStarted/SymbolPal" +
    "ette";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejslider";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejDiagram1);
            this.panel.Controls.Add(this.ejSymbolPalette1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown2);
            // 
            // ejSymbolPalette1
            // 
            this.ejSymbolPalette1.Dock = Wisej.Web.DockStyle.Left;
            this.ejSymbolPalette1.Location = new System.Drawing.Point(8, 8);
            this.ejSymbolPalette1.Name = "ejSymbolPalette1";
            this.ejSymbolPalette1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejSymbolPalette1.Options"))));
            this.ejSymbolPalette1.ResizableEdges = Wisej.Web.AnchorStyles.Right;
            this.ejSymbolPalette1.Size = new System.Drawing.Size(250, 542);
            this.ejSymbolPalette1.TabIndex = 0;
            this.ejSymbolPalette1.Text = "ejSymbolPalette1";
            widgetTemplate1.Id = "svgTemplate";
            widgetTemplate1.Template = resources.GetString("widgetTemplate1.Template");
            this.ejSymbolPalette1.WidgetTemplates = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate[] {
        widgetTemplate1};
            // 
            // ejDiagram1
            // 
            this.ejDiagram1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejDiagram1.Location = new System.Drawing.Point(258, 8);
            this.ejDiagram1.Name = "ejDiagram1";
            this.ejDiagram1.Size = new System.Drawing.Size(823, 542);
            this.ejDiagram1.TabIndex = 1;
            this.ejDiagram1.Text = "ejDiagram1";
            this.ejDiagram1.Appear += new System.EventHandler(this.ejDiagram1_Appear);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 54);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Palette Item Text";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 76);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Allow Drag";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown1, true);
            this.numericUpDown1.Label.Size = 50;
            this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown1.LabelText = "Preview Height";
            this.numericUpDown1.Location = new System.Drawing.Point(3, 133);
            this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 60);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown2, true);
            this.numericUpDown2.Label.Size = 50;
            this.numericUpDown2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown2.LabelText = "Header Height";
            this.numericUpDown2.Location = new System.Drawing.Point(3, 212);
            this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(212, 60);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ejSymbolPalette
            // 
            this.Name = "ejSymbolPalette";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSymbolPalette ejSymbolPalette1;
		private Syncfusion.ejDiagram ejDiagram1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
	}
}
