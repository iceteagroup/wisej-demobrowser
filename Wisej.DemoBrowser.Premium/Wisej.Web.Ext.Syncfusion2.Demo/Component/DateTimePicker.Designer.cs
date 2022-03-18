namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class DateTimePicker
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
            this.comboBoxFormat = new Wisej.Web.ComboBox();
            this.dateTimePickerEnd = new Wisej.Web.DateTimePicker();
            this.dateTimePickerStart = new Wisej.Web.DateTimePicker();
            this.dateTimePicker1 = new Wisej.Web.Ext.Syncfusion2.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/datetimepicker/es5-getting-st" +
    "arted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/datetimepicker/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFormat);
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Size = new System.Drawing.Size(250, 490);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTimePickerStart, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTimePickerEnd, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxFormat, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 407);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dateTimePicker1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/datetimepicker/default.html";
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.Items.AddRange(new object[] {
            "dd-MMM-yy hh:mm a",
            "yyyy-MM-dd HH:mm",
            "dd-MMMM HH:mm"});
            this.comboBoxFormat.LabelText = "Date Format";
            this.comboBoxFormat.Location = new System.Drawing.Point(26, 283);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(198, 53);
            this.comboBoxFormat.TabIndex = 11;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.LabelText = "End Date";
            this.dateTimePickerEnd.Location = new System.Drawing.Point(25, 159);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 53);
            this.dateTimePickerEnd.TabIndex = 10;
            this.dateTimePickerEnd.Value = new System.DateTime(2022, 1, 17, 20, 36, 40, 363);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.LabelText = "Start Date";
            this.dateTimePickerStart.Location = new System.Drawing.Point(25, 35);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 53);
            this.dateTimePickerStart.TabIndex = 9;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 1, 17, 20, 36, 40, 363);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 262);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"format\":\"dd-MMM-yy hh:mm a\"}")));
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 35);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Text = "dateTimePicker1";
            // 
            // DateTimePicker
            // 
            this.Name = "DateTimePicker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.DateTimePicker dateTimePicker1;
        private ComboBox comboBoxFormat;
        private Web.DateTimePicker dateTimePickerEnd;
        private Web.DateTimePicker dateTimePickerStart;
    }
}
