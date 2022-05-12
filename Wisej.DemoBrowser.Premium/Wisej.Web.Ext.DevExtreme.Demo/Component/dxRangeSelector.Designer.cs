namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxRangeSelector
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
            this.dxRangeSelector1 = new Wisej.Web.Ext.DevExtreme.dxRangeSelector();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.buttonExport = new Wisej.Web.Button();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/RangeSelector/Visual_Elemen" +
    "ts/";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/RangeSelector/NumericScaleLig" +
    "htweight/jQuery/Light/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/d" +
    "xRangeSelector/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxRangeSelector1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox5);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown2);
            this.flowLayoutPanel1.Controls.Add(this.buttonExport);
            // 
            // dxRangeSelector1
            // 
            this.dxRangeSelector1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.dxRangeSelector1.Location = new System.Drawing.Point(15, 211);
            this.dxRangeSelector1.Name = "dxRangeSelector1";
            this.dxRangeSelector1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":{\"startValue\":\"40000\",\"endValue\":\"80000\",\"length\":\"day\"},\"title\":\"Select" +
        " House Price Range\"}")));
            this.dxRangeSelector1.Size = new System.Drawing.Size(859, 121);
            this.dxRangeSelector1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 38);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Allow Sliders Swap";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox5, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox5, true);
            this.checkBox5.Location = new System.Drawing.Point(3, 56);
            this.checkBox5.Margin = new Wisej.Web.Padding(3, 12, 3, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(212, 38);
            this.checkBox5.TabIndex = 28;
            this.checkBox5.Text = "Snap to Ticks";
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
            this.buttonExport.Location = new System.Drawing.Point(3, 328);
            this.buttonExport.Margin = new Wisej.Web.Padding(3, 12, 3, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(42, 42);
            this.buttonExport.TabIndex = 29;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // numericUpDown1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
            this.numericUpDown1.LabelText = "Start Value";
            this.numericUpDown1.Location = new System.Drawing.Point(3, 184);
            this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 12, 3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown1.TabIndex = 30;
            this.numericUpDown1.Value = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown2, true);
            this.numericUpDown2.LabelText = "End Value";
            this.numericUpDown2.Location = new System.Drawing.Point(3, 256);
            this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 12, 3, 3);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown2.TabIndex = 31;
            this.numericUpDown2.Value = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "day",
            "hour",
            "millisecond",
            "minute",
            "month",
            "quarter",
            "second",
            "week",
            "year"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Value Length";
            this.comboBox1.Location = new System.Drawing.Point(3, 109);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 12, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 32;
            // 
            // dxRangeSelector
            // 
            this.AutoScroll = true;
            this.Name = "dxRangeSelector";
            this.Load += new System.EventHandler(this.dxRangeSelector_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxRangeSelector dxRangeSelector1;
		private CheckBox checkBox5;
		private CheckBox checkBox1;
		private Button buttonExport;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
		private ComboBox comboBox1;
    }
}
