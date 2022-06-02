namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejBulletGraph
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejBulletGraph));
			this.ejBulletGraph1 = new Wisej.Web.Ext.Syncfusion.ejBulletGraph();
			this.ejBulletGraph2 = new Wisej.Web.Ext.Syncfusion.ejBulletGraph();
			this.numericUpDownVal = new Wisej.Web.NumericUpDown();
			this.numericUpDownCompMeasureVal = new Wisej.Web.NumericUpDown();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompMeasureVal)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://help.syncfusion.com/js/bulletgraph/overview";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 4;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(516, 24);
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/bulletgraph/DefaultFunctionaliti" +
    "es";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "https://help.syncfusion.com/api/js/ejbulletgraph";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejBulletGraph2);
			this.panel.Controls.Add(this.ejBulletGraph1);
			this.panel.TabIndex = 7;
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDownVal);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDownCompMeasureVal);
			this.flowLayoutPanelProperties.Controls.Add(this.comboBox1);
			// 
			// ejBulletGraph1
			// 
			this.ejBulletGraph1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejBulletGraph1.Location = new System.Drawing.Point(141, 180);
			this.ejBulletGraph1.Name = "ejBulletGraph1";
			this.ejBulletGraph1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejBulletGraph1.Options"))));
			this.ejBulletGraph1.Size = new System.Drawing.Size(607, 83);
			this.ejBulletGraph1.TabIndex = 0;
			this.ejBulletGraph1.Text = "ejBulletGraph1";
			// 
			// ejBulletGraph2
			// 
			this.ejBulletGraph2.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejBulletGraph2.Location = new System.Drawing.Point(141, 314);
			this.ejBulletGraph2.Name = "ejBulletGraph2";
			this.ejBulletGraph2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejBulletGraph2.Options"))));
			this.ejBulletGraph2.Size = new System.Drawing.Size(607, 83);
			this.ejBulletGraph2.TabIndex = 1;
			this.ejBulletGraph2.Text = "ejBulletGraph2";
			// 
			// numericUpDownVal
			// 
			this.numericUpDownVal.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDownVal, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDownVal, true);
			this.numericUpDownVal.Label.Size = 50;
			this.numericUpDownVal.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDownVal.LabelText = "Revenue Value";
			this.numericUpDownVal.Location = new System.Drawing.Point(3, 48);
			this.numericUpDownVal.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDownVal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownVal.Name = "numericUpDownVal";
			this.numericUpDownVal.Size = new System.Drawing.Size(212, 60);
			this.numericUpDownVal.TabIndex = 1;
			this.numericUpDownVal.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// numericUpDownCompMeasureVal
			// 
			this.numericUpDownCompMeasureVal.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDownCompMeasureVal, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDownCompMeasureVal, true);
			this.numericUpDownCompMeasureVal.Label.Size = 60;
			this.numericUpDownCompMeasureVal.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDownCompMeasureVal.LabelText = "Revenue Comparative Value";
			this.numericUpDownCompMeasureVal.Location = new System.Drawing.Point(3, 127);
			this.numericUpDownCompMeasureVal.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDownCompMeasureVal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownCompMeasureVal.Name = "numericUpDownCompMeasureVal";
			this.numericUpDownCompMeasureVal.Size = new System.Drawing.Size(212, 92);
			this.numericUpDownCompMeasureVal.TabIndex = 2;
			this.numericUpDownCompMeasureVal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanelProperties.SetFillWeight(this.comboBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.comboBox1, true);
			this.comboBox1.Items.AddRange(new object[] {
            "Forward",
            "Backward"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Flow Direction";
			this.comboBox1.Location = new System.Drawing.Point(3, 238);
			this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(212, 60);
			this.comboBox1.TabIndex = 3;
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
			this.checkBox1.Size = new System.Drawing.Size(212, 26);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Apply Range Stroke";
			// 
			// ejBulletGraph
			// 
			this.Name = "ejBulletGraph";
			this.Load += new System.EventHandler(this.ejBulletGraph_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCompMeasureVal)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejBulletGraph ejBulletGraph1;
		private Syncfusion.ejBulletGraph ejBulletGraph2;
		private NumericUpDown numericUpDownVal;
		private NumericUpDown numericUpDownCompMeasureVal;
		private ComboBox comboBox1;
		private CheckBox checkBox1;
	}
}
