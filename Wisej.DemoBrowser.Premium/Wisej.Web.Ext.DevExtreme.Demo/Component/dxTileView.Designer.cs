namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxTileView
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
            Wisej.Web.Ext.DevExtreme.dxBase.WidgetEventHandler widgetEventHandler1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetEventHandler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxTileView));
            this.dxTileView1 = new Wisej.Web.Ext.DevExtreme.dxTileView();
            this.numericUpDownItemMargin = new Wisej.Web.NumericUpDown();
            this.numericUpDownBaseItemHeight = new Wisej.Web.NumericUpDown();
            this.numericUpDownBaseItemWidth = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaseItemHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaseItemWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/TileView/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/TileView/Basics/jQuery/Light/" +
    "";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTileView/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxTileView1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownItemMargin);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownBaseItemHeight);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownBaseItemWidth);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 470);
            // 
            // dxTileView1
            // 
            this.dxTileView1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dxTileView1.CssStyle = ".img { width: 500px; }";
            this.dxTileView1.Location = new System.Drawing.Point(120, 128);
            this.dxTileView1.Name = "dxTileView1";
            this.dxTileView1.Size = new System.Drawing.Size(649, 320);
            this.dxTileView1.TabIndex = 0;
            widgetEventHandler1.Name = "itemTemplate";
            widgetEventHandler1.Source = resources.GetString("widgetEventHandler1.Source");
            this.dxTileView1.WidgetEvents = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetEventHandler[] {
        widgetEventHandler1};
            // 
            // numericUpDownItemMargin
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownItemMargin, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownItemMargin, true);
            this.numericUpDownItemMargin.LabelText = "Item Margin";
            this.numericUpDownItemMargin.Location = new System.Drawing.Point(3, 16);
            this.numericUpDownItemMargin.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownItemMargin.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownItemMargin.Name = "numericUpDownItemMargin";
            this.numericUpDownItemMargin.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownItemMargin.TabIndex = 30;
            this.numericUpDownItemMargin.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDownBaseItemHeight
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownBaseItemHeight, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownBaseItemHeight, true);
            this.numericUpDownBaseItemHeight.LabelText = "Base Item Height";
            this.numericUpDownBaseItemHeight.Location = new System.Drawing.Point(3, 81);
            this.numericUpDownBaseItemHeight.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownBaseItemHeight.Name = "numericUpDownBaseItemHeight";
            this.numericUpDownBaseItemHeight.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownBaseItemHeight.TabIndex = 32;
            this.numericUpDownBaseItemHeight.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // numericUpDownBaseItemWidth
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownBaseItemWidth, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownBaseItemWidth, true);
            this.numericUpDownBaseItemWidth.LabelText = "Base Item Width";
            this.numericUpDownBaseItemWidth.Location = new System.Drawing.Point(3, 146);
            this.numericUpDownBaseItemWidth.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownBaseItemWidth.Name = "numericUpDownBaseItemWidth";
            this.numericUpDownBaseItemWidth.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownBaseItemWidth.TabIndex = 33;
            this.numericUpDownBaseItemWidth.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // dxTileView
            // 
            this.Name = "dxTileView";
            this.Size = new System.Drawing.Size(1299, 726);
            this.Load += new System.EventHandler(this.dxTileView_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaseItemHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaseItemWidth)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxTileView dxTileView1;
		private NumericUpDown numericUpDownItemMargin;
		private NumericUpDown numericUpDownBaseItemWidth;
		private NumericUpDown numericUpDownBaseItemHeight;
	}
}
