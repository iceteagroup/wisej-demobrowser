namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoTimePicker
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
            this.kendoTimePicker1 = new Wisej.Web.Ext.Kendo.kendoTimePicker();
            this.comboBoxFillMode = new Wisej.Web.ComboBox();
            this.maskedTextBoxMin = new Wisej.Web.MaskedTextBox();
            this.maskedTextBoxMax = new Wisej.Web.MaskedTextBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoTimePicker1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/timepicker/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/timepicker";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/timepicker/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxFillMode);
            this.flowLayoutPanelProperties.Controls.Add(this.maskedTextBoxMin);
            this.flowLayoutPanelProperties.Controls.Add(this.maskedTextBoxMax);
            // 
            // kendoTimePicker1
            // 
            this.kendoTimePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoTimePicker1.Location = new System.Drawing.Point(394, 259);
            this.kendoTimePicker1.Name = "kendoTimePicker1";
            this.kendoTimePicker1.Size = new System.Drawing.Size(300, 40);
            this.kendoTimePicker1.TabIndex = 0;
            this.kendoTimePicker1.Text = "kendoTimePicker1";
            // 
            // comboBoxFillMode
            // 
            this.comboBoxFillMode.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxFillMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxFillMode.Items.AddRange(new object[] {
            "null",
            "solid",
            "flat",
            "outline"});
            this.comboBoxFillMode.LabelText = "Fill mode";
            this.comboBoxFillMode.Location = new System.Drawing.Point(3, 3);
            this.comboBoxFillMode.Name = "comboBoxFillMode";
            this.comboBoxFillMode.Size = new System.Drawing.Size(212, 57);
            this.comboBoxFillMode.TabIndex = 0;
            // 
            // maskedTextBoxMin
            // 
            this.maskedTextBoxMin.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.maskedTextBoxMin.LabelText = "Min";
            this.maskedTextBoxMin.Location = new System.Drawing.Point(3, 66);
            this.maskedTextBoxMin.Mask = "00:00";
            this.maskedTextBoxMin.Name = "maskedTextBoxMin";
            this.maskedTextBoxMin.Size = new System.Drawing.Size(212, 57);
            this.maskedTextBoxMin.TabIndex = 1;
            // 
            // maskedTextBoxMax
            // 
            this.maskedTextBoxMax.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.maskedTextBoxMax.LabelText = "Max";
            this.maskedTextBoxMax.Location = new System.Drawing.Point(3, 129);
            this.maskedTextBoxMax.Mask = "00:00";
            this.maskedTextBoxMax.Name = "maskedTextBoxMax";
            this.maskedTextBoxMax.Size = new System.Drawing.Size(212, 57);
            this.maskedTextBoxMax.TabIndex = 2;
            // 
            // kendoTimePicker
            // 
            this.MinimumSize = new System.Drawing.Size(935, 509);
            this.Name = "kendoTimePicker";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoTimePicker kendoTimePicker1;
        private ComboBox comboBoxFillMode;
        private MaskedTextBox maskedTextBoxMin;
        private MaskedTextBox maskedTextBoxMax;
    }
}
