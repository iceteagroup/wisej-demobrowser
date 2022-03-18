namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class DatePicker
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
            this.datePicker1 = new Wisej.Web.Ext.Syncfusion2.DatePicker();
            this.dateTimePickerEnd = new Wisej.Web.DateTimePicker();
            this.dateTimePickerStart = new Wisej.Web.DateTimePicker();
            this.comboBoxFormat = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/datepicker/es5-getting-starte" +
    "d/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/datepicker/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFormat);
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Size = new System.Drawing.Size(250, 405);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTimePickerStart, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTimePickerEnd, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxFormat, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 323);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.datePicker1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/datepicker/default.html";
            // 
            // datePicker1
            // 
            this.datePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.datePicker1.Location = new System.Drawing.Point(369, 262);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"format\":\"dd-MMM-yy\"}")));
            this.datePicker1.Size = new System.Drawing.Size(350, 35);
            this.datePicker1.TabIndex = 0;
            this.datePicker1.Text = "datePicker1";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.LabelText = "End Date";
            this.dateTimePickerEnd.Location = new System.Drawing.Point(25, 129);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 53);
            this.dateTimePickerEnd.TabIndex = 4;
            this.dateTimePickerEnd.Value = new System.DateTime(2022, 1, 17, 20, 36, 40, 363);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.LabelText = "Start Date";
            this.dateTimePickerStart.Location = new System.Drawing.Point(25, 32);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 53);
            this.dateTimePickerStart.TabIndex = 3;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 1, 17, 20, 36, 40, 363);
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.Items.AddRange(new object[] {
            "dd-MMMM-yy",
            "yyyy-MM-dd",
            "dd-MMMM"});
            this.comboBoxFormat.LabelText = "Date Format";
            this.comboBoxFormat.Location = new System.Drawing.Point(26, 226);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(198, 53);
            this.comboBoxFormat.TabIndex = 5;
            // 
            // DatePicker
            // 
            this.Name = "DatePicker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.DatePicker datePicker1;
        private ComboBox comboBoxFormat;
        private Web.DateTimePicker dateTimePickerEnd;
        private Web.DateTimePicker dateTimePickerStart;
    }
}
