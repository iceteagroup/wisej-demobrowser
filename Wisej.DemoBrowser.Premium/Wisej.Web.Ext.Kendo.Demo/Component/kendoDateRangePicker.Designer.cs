namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDateRangePicker
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
			this.kendoDateRangePicker1 = new Wisej.Web.Ext.Kendo.kendoDateRangePicker();
			this.dateTimePickerMin = new Wisej.Web.DateTimePicker();
			this.dateTimePickerMax = new Wisej.Web.DateTimePicker();
			this.comboBoxDepth = new Wisej.Web.ComboBox();
			this.checkBoxWeekNumber = new Wisej.Web.CheckBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoDateRangePicker1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/daterangepicker/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/daterangepicker";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/daterangepicker/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBoxWeekNumber);
			this.flowLayoutPanelProperties.Controls.Add(this.comboBoxDepth);
			this.flowLayoutPanelProperties.Controls.Add(this.dateTimePickerMin);
			this.flowLayoutPanelProperties.Controls.Add(this.dateTimePickerMax);
			// 
			// kendoDateRangePicker1
			// 
			this.kendoDateRangePicker1.Anchor = Wisej.Web.AnchorStyles.None;
			this.kendoDateRangePicker1.Location = new System.Drawing.Point(268, 259);
			this.kendoDateRangePicker1.Name = "kendoDateRangePicker1";
			this.kendoDateRangePicker1.Size = new System.Drawing.Size(353, 59);
			this.kendoDateRangePicker1.TabIndex = 0;
			// 
			// dateTimePickerMin
			// 
			this.dateTimePickerMin.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dateTimePickerMin.LabelText = "Min";
			this.dateTimePickerMin.Location = new System.Drawing.Point(3, 122);
			this.dateTimePickerMin.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.dateTimePickerMin.Name = "dateTimePickerMin";
			this.dateTimePickerMin.Size = new System.Drawing.Size(212, 57);
			this.dateTimePickerMin.TabIndex = 2;
			this.dateTimePickerMin.Value = new System.DateTime(2022, 4, 11, 20, 18, 35, 660);
			// 
			// dateTimePickerMax
			// 
			this.dateTimePickerMax.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dateTimePickerMax.LabelText = "Max";
			this.dateTimePickerMax.Location = new System.Drawing.Point(3, 198);
			this.dateTimePickerMax.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.dateTimePickerMax.Name = "dateTimePickerMax";
			this.dateTimePickerMax.Size = new System.Drawing.Size(212, 57);
			this.dateTimePickerMax.TabIndex = 3;
			this.dateTimePickerMax.Value = new System.DateTime(2022, 4, 11, 20, 18, 35, 660);
			// 
			// comboBoxDepth
			// 
			this.comboBoxDepth.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxDepth.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxDepth.Items.AddRange(new object[] {
            "month",
            "year",
            "decade",
            "century"});
			this.comboBoxDepth.LabelText = "Depth";
			this.comboBoxDepth.Location = new System.Drawing.Point(3, 46);
			this.comboBoxDepth.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBoxDepth.Name = "comboBoxDepth";
			this.comboBoxDepth.Size = new System.Drawing.Size(212, 57);
			this.comboBoxDepth.TabIndex = 4;
			// 
			// checkBoxWeekNumber
			// 
			this.checkBoxWeekNumber.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxWeekNumber.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxWeekNumber, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxWeekNumber, true);
			this.checkBoxWeekNumber.Location = new System.Drawing.Point(3, 3);
			this.checkBoxWeekNumber.Name = "checkBoxWeekNumber";
			this.checkBoxWeekNumber.Size = new System.Drawing.Size(212, 24);
			this.checkBoxWeekNumber.TabIndex = 5;
			this.checkBoxWeekNumber.Text = "Week Number";
			// 
			// kendoDateRangePicker
			// 
			this.Name = "kendoDateRangePicker";
			this.Load += new System.EventHandler(this.kendoDateRangePicker_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.flowLayoutPanelProperties.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoDateRangePicker kendoDateRangePicker1;
        private DateTimePicker dateTimePickerMin;
        private DateTimePicker dateTimePickerMax;
        private ComboBox comboBoxDepth;
        private CheckBox checkBoxWeekNumber;
    }
}
