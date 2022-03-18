namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class TimePicker
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
            this.timePicker1 = new Wisej.Web.Ext.Syncfusion2.TimePicker();
            this.comboBoxHourFormat = new Wisej.Web.ComboBox();
            this.numericUpDownFrom = new Wisej.Web.NumericUpDown();
            this.numericUpDownTo = new Wisej.Web.NumericUpDown();
            this.checkBoxOpenOnFocus = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/timepicker/es5-getting-starte" +
    "d/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/timepicker/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxOpenOnFocus);
            this.groupBox1.Controls.Add(this.numericUpDownTo);
            this.groupBox1.Controls.Add(this.numericUpDownFrom);
            this.groupBox1.Controls.Add(this.comboBoxHourFormat);
            this.groupBox1.Size = new System.Drawing.Size(250, 348);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxHourFormat, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownFrom, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownTo, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxOpenOnFocus, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 267);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.timePicker1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/timepicker/default.html";
            // 
            // timePicker1
            // 
            this.timePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.timePicker1.Location = new System.Drawing.Point(51, 139);
            this.timePicker1.Name = "timePicker1";
            this.timePicker1.Size = new System.Drawing.Size(350, 35);
            this.timePicker1.TabIndex = 0;
            this.timePicker1.Text = "timePicker1";
            // 
            // comboBoxHourFormat
            // 
            this.comboBoxHourFormat.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxHourFormat.Items.AddRange(new object[] {
            "hh:mm a",
            "HH:mm"});
            this.comboBoxHourFormat.LabelText = "Hour Format";
            this.comboBoxHourFormat.Location = new System.Drawing.Point(26, 157);
            this.comboBoxHourFormat.Name = "comboBoxHourFormat";
            this.comboBoxHourFormat.Size = new System.Drawing.Size(198, 42);
            this.comboBoxHourFormat.TabIndex = 14;
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.LabelText = "From (Hours)";
            this.numericUpDownFrom.Location = new System.Drawing.Point(26, 27);
            this.numericUpDownFrom.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(197, 42);
            this.numericUpDownFrom.TabIndex = 15;
            this.numericUpDownFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownTo
            // 
            this.numericUpDownTo.LabelText = "To";
            this.numericUpDownTo.Location = new System.Drawing.Point(26, 93);
            this.numericUpDownTo.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownTo.Name = "numericUpDownTo";
            this.numericUpDownTo.Size = new System.Drawing.Size(197, 42);
            this.numericUpDownTo.TabIndex = 17;
            // 
            // checkBoxOpenOnFocus
            // 
            this.checkBoxOpenOnFocus.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxOpenOnFocus.Location = new System.Drawing.Point(28, 218);
            this.checkBoxOpenOnFocus.Name = "checkBoxOpenOnFocus";
            this.checkBoxOpenOnFocus.Size = new System.Drawing.Size(137, 24);
            this.checkBoxOpenOnFocus.TabIndex = 18;
            this.checkBoxOpenOnFocus.Text = "Open on focus";
            // 
            // TimePicker
            // 
            this.Name = "TimePicker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.TimePicker timePicker1;
        private NumericUpDown numericUpDownTo;
        private NumericUpDown numericUpDownFrom;
        private ComboBox comboBoxHourFormat;
        private CheckBox checkBoxOpenOnFocus;
    }
}
