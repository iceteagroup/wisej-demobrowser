namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejTagCloud
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejTagCloud));
			this.ejTagCloud1 = new Wisej.Web.Ext.Syncfusion.ejTagCloud();
			this.numericUpDownMinimumFontSize = new Wisej.Web.NumericUpDown();
			this.numericUpDownMaximumFontSize = new Wisej.Web.NumericUpDown();
			this.comboBoxFormat = new Wisej.Web.ComboBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumFontSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximumFontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://help.syncfusion.com/js/tagcloud/overview";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 4;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(524, 24);
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/tagcloud/DefaultFunctionalities";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "https://help.syncfusion.com/api/js/ejtagcloud";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTagCloud1);
			this.panel.TabIndex = 7;
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDownMinimumFontSize);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDownMaximumFontSize);
			this.flowLayoutPanelProperties.Controls.Add(this.comboBoxFormat);
			// 
			// ejTagCloud1
			// 
			this.ejTagCloud1.Dock = Wisej.Web.DockStyle.Fill;
			this.ejTagCloud1.Location = new System.Drawing.Point(8, 8);
			this.ejTagCloud1.Name = "ejTagCloud1";
			this.ejTagCloud1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejTagCloud1.Options"))));
			this.ejTagCloud1.Size = new System.Drawing.Size(872, 560);
			this.ejTagCloud1.TabIndex = 0;
			this.ejTagCloud1.Text = "ejTagCloud1";
			// 
			// numericUpDownMinimumFontSize
			// 
			this.numericUpDownMinimumFontSize.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDownMinimumFontSize, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDownMinimumFontSize, true);
			this.numericUpDownMinimumFontSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownMinimumFontSize.Label.Size = 50;
			this.numericUpDownMinimumFontSize.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDownMinimumFontSize.LabelText = "Minimum Font Size";
			this.numericUpDownMinimumFontSize.Location = new System.Drawing.Point(3, 52);
			this.numericUpDownMinimumFontSize.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDownMinimumFontSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.numericUpDownMinimumFontSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownMinimumFontSize.Name = "numericUpDownMinimumFontSize";
			this.numericUpDownMinimumFontSize.Size = new System.Drawing.Size(212, 60);
			this.numericUpDownMinimumFontSize.TabIndex = 1;
			this.numericUpDownMinimumFontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// numericUpDownMaximumFontSize
			// 
			this.numericUpDownMaximumFontSize.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDownMaximumFontSize, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDownMaximumFontSize, true);
			this.numericUpDownMaximumFontSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownMaximumFontSize.Label.Size = 50;
			this.numericUpDownMaximumFontSize.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDownMaximumFontSize.LabelText = "Maximum Font Size";
			this.numericUpDownMaximumFontSize.Location = new System.Drawing.Point(3, 131);
			this.numericUpDownMaximumFontSize.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDownMaximumFontSize.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.numericUpDownMaximumFontSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownMaximumFontSize.Name = "numericUpDownMaximumFontSize";
			this.numericUpDownMaximumFontSize.Size = new System.Drawing.Size(212, 60);
			this.numericUpDownMaximumFontSize.TabIndex = 2;
			this.numericUpDownMaximumFontSize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// comboBoxFormat
			// 
			this.comboBoxFormat.AutoSize = false;
			this.comboBoxFormat.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanelProperties.SetFillWeight(this.comboBoxFormat, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.comboBoxFormat, true);
			this.comboBoxFormat.Items.AddRange(new object[] {
            "Cloud",
            "List"});
			this.comboBoxFormat.Label.Size = 50;
			this.comboBoxFormat.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxFormat.LabelText = "Format";
			this.comboBoxFormat.Location = new System.Drawing.Point(3, 210);
			this.comboBoxFormat.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBoxFormat.Name = "comboBoxFormat";
			this.comboBoxFormat.Size = new System.Drawing.Size(212, 60);
			this.comboBoxFormat.TabIndex = 3;
			this.comboBoxFormat.Text = "Cloud";
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
			this.checkBox1.Size = new System.Drawing.Size(212, 30);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Show Title";
			// 
			// ejTagCloud
			// 
			this.Name = "ejTagCloud";
			this.Load += new System.EventHandler(this.ejTagCloud_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimumFontSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaximumFontSize)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejTagCloud ejTagCloud1;
		private NumericUpDown numericUpDownMaximumFontSize;
		private NumericUpDown numericUpDownMinimumFontSize;
		private ComboBox comboBoxFormat;
		private CheckBox checkBox1;
	}
}
