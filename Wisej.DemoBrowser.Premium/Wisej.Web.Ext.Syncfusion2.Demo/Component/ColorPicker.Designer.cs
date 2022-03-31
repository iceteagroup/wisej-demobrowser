namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class ColorPicker
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
            this.colorPicker1 = new Wisej.Web.Ext.Syncfusion2.ColorPicker();
            this.comboBoxMode = new Wisej.Web.ComboBox();
            this.checkBoxShowButton = new Wisej.Web.CheckBox();
            this.checkBoxInline = new Wisej.Web.CheckBox();
            this.panelColorValue = new Wisej.Web.Panel();
            this.label4 = new Wisej.Web.Label();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/color-picker/es5-getting-star" +
    "ted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/color-picker/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.colorPicker1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBoxMode);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowButton);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxInline);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.panelColorValue);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/color-picker/default.html";
            // 
            // colorPicker1
            // 
            this.colorPicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.colorPicker1.Location = new System.Drawing.Point(514, 256);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"#345876\"}")));
            this.colorPicker1.Size = new System.Drawing.Size(60, 47);
            this.colorPicker1.TabIndex = 0;
            this.colorPicker1.Text = "colorPicker1";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxMode, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxMode, true);
            this.comboBoxMode.Items.AddRange(new object[] {
            "Picker",
            "Palette"});
            this.comboBoxMode.LabelText = "Mode";
            this.comboBoxMode.Location = new System.Drawing.Point(3, 3);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(212, 46);
            this.comboBoxMode.TabIndex = 2;
            // 
            // checkBoxShowButton
            // 
            this.checkBoxShowButton.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxShowButton, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxShowButton, true);
            this.checkBoxShowButton.Location = new System.Drawing.Point(3, 68);
            this.checkBoxShowButton.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxShowButton.Name = "checkBoxShowButton";
            this.checkBoxShowButton.Size = new System.Drawing.Size(212, 24);
            this.checkBoxShowButton.TabIndex = 3;
            this.checkBoxShowButton.Text = "Show Button";
            // 
            // checkBoxInline
            // 
            this.checkBoxInline.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxInline.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxInline, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxInline, true);
            this.checkBoxInline.Location = new System.Drawing.Point(3, 111);
            this.checkBoxInline.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxInline.Name = "checkBoxInline";
            this.checkBoxInline.Size = new System.Drawing.Size(212, 24);
            this.checkBoxInline.TabIndex = 4;
            this.checkBoxInline.Text = "Inline";
            // 
            // panelColorValue
            // 
            this.panelColorValue.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanel1.SetFillWeight(this.panelColorValue, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.panelColorValue, true);
            this.panelColorValue.Location = new System.Drawing.Point(3, 179);
            this.panelColorValue.Name = "panelColorValue";
            this.panelColorValue.Size = new System.Drawing.Size(212, 27);
            this.panelColorValue.TabIndex = 5;
            this.panelColorValue.TabStop = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.flowLayoutPanel1.SetFillWeight(this.label4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.label4, true);
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selected Color";
            // 
            // ColorPicker
            // 
            this.Name = "ColorPicker";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.ColorPicker colorPicker1;
        private ComboBox comboBoxMode;
        private CheckBox checkBoxInline;
        private CheckBox checkBoxShowButton;
        private Label label4;
        private Panel panelColorValue;
    }
}
