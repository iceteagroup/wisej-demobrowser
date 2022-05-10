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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxTileView));
            Wisej.Web.Ext.DevExtreme.dxBase.WidgetEventHandler widgetEventHandler1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetEventHandler();
            this.dxTileView1 = new Wisej.Web.Ext.DevExtreme.dxTileView();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.numericUpDownItemMargin = new Wisej.Web.NumericUpDown();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.numericUpDownBaseItemHeight = new Wisej.Web.NumericUpDown();
            this.numericUpDownBaseItemWidth = new Wisej.Web.NumericUpDown();
            this.button1 = new Wisej.Web.Button();
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
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTileView/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxTileView1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownItemMargin);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownBaseItemHeight);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownBaseItemWidth);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 441);
            // 
            // dxTileView1
            // 
            this.dxTileView1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dxTileView1.CssStyle = ".img { width: 500px; }";
            this.dxTileView1.Location = new System.Drawing.Point(179, 31);
            this.dxTileView1.Name = "dxTileView1";
            this.dxTileView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxTileView1.Options"))));
            this.dxTileView1.Size = new System.Drawing.Size(731, 495);
            this.dxTileView1.TabIndex = 0;
            widgetEventHandler1.Name = "itemTemplate";
            widgetEventHandler1.Source = resources.GetString("widgetEventHandler1.Source");
            this.dxTileView1.WidgetEvents = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetEventHandler[] {
        widgetEventHandler1};
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "horizontal",
            "vertical"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Direction";
            this.comboBox1.Location = new System.Drawing.Point(3, 255);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "horizontal";
            // 
            // numericUpDownItemMargin
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownItemMargin, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownItemMargin, true);
            this.numericUpDownItemMargin.LabelText = "Item Margin";
            this.numericUpDownItemMargin.Location = new System.Drawing.Point(3, 60);
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
            20,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 38);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Show Scrollbar";
            // 
            // numericUpDownBaseItemHeight
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownBaseItemHeight, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownBaseItemHeight, true);
            this.numericUpDownBaseItemHeight.LabelText = "Base Item Height";
            this.numericUpDownBaseItemHeight.Location = new System.Drawing.Point(3, 125);
            this.numericUpDownBaseItemHeight.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownBaseItemHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownBaseItemHeight.Name = "numericUpDownBaseItemHeight";
            this.numericUpDownBaseItemHeight.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownBaseItemHeight.TabIndex = 32;
            this.numericUpDownBaseItemHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownBaseItemWidth
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownBaseItemWidth, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownBaseItemWidth, true);
            this.numericUpDownBaseItemWidth.LabelText = "Base Item Width";
            this.numericUpDownBaseItemWidth.Location = new System.Drawing.Point(3, 190);
            this.numericUpDownBaseItemWidth.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownBaseItemWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownBaseItemWidth.Name = "numericUpDownBaseItemWidth";
            this.numericUpDownBaseItemWidth.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownBaseItemWidth.TabIndex = 33;
            this.numericUpDownBaseItemWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.button1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.button1, true);
            this.button1.Location = new System.Drawing.Point(3, 334);
            this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 40);
            this.button1.TabIndex = 34;
            this.button1.Text = "Get Scroll Position";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dxTileView
            // 
            this.MinimumSize = new System.Drawing.Size(1181, 726);
            this.Name = "dxTileView";
            this.Load += new System.EventHandler(this.dxTileView_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaseItemHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaseItemWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxTileView dxTileView1;
		private ComboBox comboBox1;
		private NumericUpDown numericUpDownItemMargin;
		private Button button1;
		private NumericUpDown numericUpDownBaseItemWidth;
		private NumericUpDown numericUpDownBaseItemHeight;
		private CheckBox checkBox1;
	}
}
