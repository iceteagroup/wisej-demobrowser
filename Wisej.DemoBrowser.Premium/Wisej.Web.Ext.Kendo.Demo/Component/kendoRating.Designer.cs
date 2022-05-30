namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoRating
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
			this.kendoRating1 = new Wisej.Web.Ext.Kendo.kendoRating();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.numericUpDown3 = new Wisej.Web.NumericUpDown();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoRating1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/rating/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/rating";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/rating/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.comboBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown1);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown2);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown3);
			// 
			// kendoRating1
			// 
			this.kendoRating1.Anchor = Wisej.Web.AnchorStyles.None;
			this.kendoRating1.Location = new System.Drawing.Point(101, 261);
			this.kendoRating1.Name = "kendoRating1";
			this.kendoRating1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":3}")));
			this.kendoRating1.Size = new System.Drawing.Size(687, 37);
			this.kendoRating1.TabIndex = 0;
			this.kendoRating1.Text = "kendoRating1";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.numericUpDown1.DecimalPlaces = 1;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown1, true);
			this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.LabelText = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(3, 139);
			this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            3,
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
			this.numericUpDown2.LabelText = "Min";
			this.numericUpDown2.Location = new System.Drawing.Point(3, 218);
			this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown2.TabIndex = 4;
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown3, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown3, true);
			this.numericUpDown3.Label.Size = 50;
			this.numericUpDown3.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown3.LabelText = "Max";
			this.numericUpDown3.Location = new System.Drawing.Point(3, 297);
			this.numericUpDown3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown3.TabIndex = 5;
			this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
			this.checkBox1.Location = new System.Drawing.Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(212, 38);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Select Value on Focus";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanelProperties.SetFillWeight(this.comboBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.comboBox1, true);
			this.comboBox1.Items.AddRange(new object[] {
            "item",
            "half"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Type";
			this.comboBox1.Location = new System.Drawing.Point(3, 60);
			this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(212, 60);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.Text = "item";
			// 
			// kendoRating
			// 
			this.Name = "kendoRating";
			this.Load += new System.EventHandler(this.kendoRating_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoRating kendoRating1;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown3;
		private NumericUpDown numericUpDown2;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
	}
}
