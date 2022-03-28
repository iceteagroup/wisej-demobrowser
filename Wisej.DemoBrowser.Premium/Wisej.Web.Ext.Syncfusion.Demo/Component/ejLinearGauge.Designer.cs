namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejLinearGauge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejLinearGauge));
            this.ejLinearGauge1 = new Wisej.Web.Ext.Syncfusion.ejLinearGauge();
            this.numericUpDownVal = new Wisej.Web.NumericUpDown();
            this.comboBoxOrientation = new Wisej.Web.ComboBox();
            this.comboBoxLabelPosition = new Wisej.Web.ComboBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.buttonSave = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVal)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/lineargauge/overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(600, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/lineargauge/DefaultFunctionaliti" +
    "es";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejlineargauge";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejLinearGauge1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDownVal);
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxOrientation);
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxLabelPosition);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonSave);
            // 
            // ejLinearGauge1
            // 
            this.ejLinearGauge1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.ejLinearGauge1.Location = new System.Drawing.Point(69, 17);
            this.ejLinearGauge1.Name = "ejLinearGauge1";
            this.ejLinearGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejLinearGauge1.Options"))));
            this.ejLinearGauge1.Size = new System.Drawing.Size(950, 523);
            this.ejLinearGauge1.TabIndex = 0;
            this.ejLinearGauge1.Text = "ejLinearGauge1";
            // 
            // numericUpDownVal
            // 
            this.numericUpDownVal.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDownVal, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDownVal, true);
            this.numericUpDownVal.Label.Size = 50;
            this.numericUpDownVal.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDownVal.LabelText = "Value";
            this.numericUpDownVal.Location = new System.Drawing.Point(3, 72);
            this.numericUpDownVal.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownVal.Name = "numericUpDownVal";
            this.numericUpDownVal.Size = new System.Drawing.Size(212, 60);
            this.numericUpDownVal.TabIndex = 1;
            this.numericUpDownVal.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // comboBoxOrientation
            // 
            this.comboBoxOrientation.AutoSize = false;
            this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanelProperties.SetFillWeight(this.comboBoxOrientation, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.comboBoxOrientation, true);
            this.comboBoxOrientation.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.comboBoxOrientation.Label.Size = 50;
            this.comboBoxOrientation.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBoxOrientation.LabelText = "Orientation";
            this.comboBoxOrientation.Location = new System.Drawing.Point(3, 151);
            this.comboBoxOrientation.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxOrientation.Name = "comboBoxOrientation";
            this.comboBoxOrientation.Size = new System.Drawing.Size(212, 60);
            this.comboBoxOrientation.TabIndex = 2;
            this.comboBoxOrientation.Text = "Vertical";
            // 
            // comboBoxLabelPosition
            // 
            this.comboBoxLabelPosition.AutoSize = false;
            this.comboBoxLabelPosition.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanelProperties.SetFillWeight(this.comboBoxLabelPosition, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.comboBoxLabelPosition, true);
            this.comboBoxLabelPosition.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom"});
            this.comboBoxLabelPosition.Label.Size = 60;
            this.comboBoxLabelPosition.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBoxLabelPosition.LabelText = "Outer Custom Label Position";
            this.comboBoxLabelPosition.Location = new System.Drawing.Point(3, 230);
            this.comboBoxLabelPosition.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxLabelPosition.Name = "comboBoxLabelPosition";
            this.comboBoxLabelPosition.Size = new System.Drawing.Size(212, 84);
            this.comboBoxLabelPosition.TabIndex = 3;
            this.comboBoxLabelPosition.Text = "Bottom";
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
            this.checkBox1.Size = new System.Drawing.Size(212, 50);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Marker Point Animation";
            // 
            // buttonSave
            // 
            this.buttonSave.Display = Wisej.Web.Display.Icon;
            this.buttonSave.ImageSource = "icon-save";
            this.buttonSave.Location = new System.Drawing.Point(3, 333);
            this.buttonSave.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(42, 42);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ejLinearGauge
            // 
            this.Name = "ejLinearGauge";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejLinearGauge ejLinearGauge1;
		private NumericUpDown numericUpDownVal;
		private ComboBox comboBoxOrientation;
		private ComboBox comboBoxLabelPosition;
		private CheckBox checkBox1;
		private Button buttonSave;
	}
}
