namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoSlider
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
            this.kendoSlider1 = new Wisej.Web.Ext.Kendo.kendoSlider();
            this.kendoSlider2 = new Wisej.Web.Ext.Kendo.kendoSlider();
            this.checkBoxShowButtons = new Wisej.Web.CheckBox();
            this.comboBoxTickPlacement = new Wisej.Web.ComboBox();
            this.numericUpDownValue = new Wisej.Web.NumericUpDown();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoSlider2);
            this.panel.Controls.Add(this.kendoSlider1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/slider/index";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/slider";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/slider/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxShowButtons);
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxTickPlacement);
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDownValue);
            // 
            // kendoSlider1
            // 
            this.kendoSlider1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoSlider1.Location = new System.Drawing.Point(274, 94);
            this.kendoSlider1.Name = "kendoSlider1";
            this.kendoSlider1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"showButtons\":true,\"increaseButtonTitle\":\"Right\",\"decreaseButtonTitle\":\"Left\",\"m" +
        "in\":-20,\"max\":20,\"smallStep\":2,\"largeStep\":1,\"orientation\":\"horizontal\"}")));
            this.kendoSlider1.Size = new System.Drawing.Size(340, 26);
            this.kendoSlider1.TabIndex = 0;
            this.kendoSlider1.Text = "kendoSlider1";
            // 
            // kendoSlider2
            // 
            this.kendoSlider2.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoSlider2.Location = new System.Drawing.Point(428, 142);
            this.kendoSlider2.Name = "kendoSlider2";
            this.kendoSlider2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"orientation\":\"vertical\",\"min\":-20,\"max\":20,\"smallStep\":1,\"largeStep\":20,\"showBu" +
        "ttons\":true}")));
            this.kendoSlider2.Size = new System.Drawing.Size(33, 340);
            this.kendoSlider2.TabIndex = 1;
            this.kendoSlider2.Text = "kendoSlider2";
            // 
            // checkBoxShowButtons
            // 
            this.checkBoxShowButtons.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxShowButtons.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowButtons.AutoSize = false;
            this.checkBoxShowButtons.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowButtons.Checked = true;
            this.checkBoxShowButtons.Location = new System.Drawing.Point(3, 3);
            this.checkBoxShowButtons.Name = "checkBoxShowButtons";
            this.checkBoxShowButtons.Size = new System.Drawing.Size(212, 26);
            this.checkBoxShowButtons.TabIndex = 0;
            this.checkBoxShowButtons.Text = "Show Buttons";
            // 
            // comboBoxTickPlacement
            // 
            this.comboBoxTickPlacement.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxTickPlacement.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxTickPlacement.Items.AddRange(new object[] {
            "TopLeft",
            "BottomRight",
            "Both",
            "None"});
            this.comboBoxTickPlacement.LabelText = "Tick Placement";
            this.comboBoxTickPlacement.Location = new System.Drawing.Point(3, 48);
            this.comboBoxTickPlacement.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxTickPlacement.Name = "comboBoxTickPlacement";
            this.comboBoxTickPlacement.Size = new System.Drawing.Size(212, 57);
            this.comboBoxTickPlacement.TabIndex = 1;
            this.comboBoxTickPlacement.Text = "Both";
            // 
            // numericUpDownValue
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDownValue, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDownValue, true);
            this.numericUpDownValue.LabelText = "Value";
            this.numericUpDownValue.Location = new System.Drawing.Point(3, 124);
            this.numericUpDownValue.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownValue.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(212, 57);
            this.numericUpDownValue.TabIndex = 2;
            this.numericUpDownValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            // 
            // kendoSlider
            // 
            this.Name = "kendoSlider";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoSlider kendoSlider1;
		private Kendo.kendoSlider kendoSlider2;
        private CheckBox checkBoxShowButtons;
        private ComboBox comboBoxTickPlacement;
        private NumericUpDown numericUpDownValue;
    }
}
