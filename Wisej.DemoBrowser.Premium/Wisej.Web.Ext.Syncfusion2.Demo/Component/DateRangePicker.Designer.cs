namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class DateRangePicker
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
            this.dateRangePicker1 = new Wisej.Web.Ext.Syncfusion2.DateRangePicker();
            this.comboBoxFormat = new Wisej.Web.ComboBox();
            this.dateTimePickerEnd = new Wisej.Web.DateTimePicker();
            this.dateTimePickerStart = new Wisej.Web.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/daterangepicker/es5-getting-s" +
    "tarted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/daterangepicker/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dateRangePicker1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dateTimePickerStart);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePickerEnd);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxFormat);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/daterangepicker/default.html";
            // 
            // dateRangePicker1
            // 
            this.dateRangePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dateRangePicker1.Location = new System.Drawing.Point(369, 259);
            this.dateRangePicker1.Name = "dateRangePicker1";
            this.dateRangePicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"format\":\"dd\'/\'MMM\'/\'yy hh:mm a\"}")));
            this.dateRangePicker1.Size = new System.Drawing.Size(350, 40);
            this.dateRangePicker1.TabIndex = 0;
            this.dateRangePicker1.Text = "dateRangePicker1";
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxFormat, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxFormat, true);
            this.comboBoxFormat.Items.AddRange(new object[] {
            "dd\\\'\\/\\\'MMM\\\'\\/\\\'yy hh:mm a",
            "yyyy\\\'\\/\\\'MM\\\'\\/\\\'dd HH:mm",
            "dd\\\'\\/\\\'MMMM\\\'\\/\\\'yyyy"});
            this.comboBoxFormat.LabelText = "Date Format";
            this.comboBoxFormat.Location = new System.Drawing.Point(3, 155);
            this.comboBoxFormat.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(212, 57);
            this.comboBoxFormat.TabIndex = 8;
            // 
            // dateTimePickerEnd
            // 
            this.flowLayoutPanel1.SetFillWeight(this.dateTimePickerEnd, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.dateTimePickerEnd, true);
            this.dateTimePickerEnd.LabelText = "End Date";
            this.dateTimePickerEnd.Location = new System.Drawing.Point(3, 79);
            this.dateTimePickerEnd.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(212, 57);
            this.dateTimePickerEnd.TabIndex = 7;
            this.dateTimePickerEnd.Value = new System.DateTime(2022, 1, 17, 20, 36, 40, 363);
            // 
            // dateTimePickerStart
            // 
            this.flowLayoutPanel1.SetFillWeight(this.dateTimePickerStart, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.dateTimePickerStart, true);
            this.dateTimePickerStart.LabelText = "Start Date";
            this.dateTimePickerStart.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(212, 57);
            this.dateTimePickerStart.TabIndex = 6;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 1, 17, 20, 36, 40, 363);
            // 
            // DateRangePicker
            // 
            this.Name = "DateRangePicker";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.DateRangePicker dateRangePicker1;
        private ComboBox comboBoxFormat;
        private Web.DateTimePicker dateTimePickerEnd;
        private Web.DateTimePicker dateTimePickerStart;
    }
}
