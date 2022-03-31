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
            this.flowLayoutPanel1.SuspendLayout();
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
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.timePicker1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxOpenOnFocus);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownFrom);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownTo);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxHourFormat);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/timepicker/default.html";
            // 
            // timePicker1
            // 
            this.timePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.timePicker1.Location = new System.Drawing.Point(369, 259);
            this.timePicker1.Name = "timePicker1";
            this.timePicker1.Size = new System.Drawing.Size(350, 40);
            this.timePicker1.TabIndex = 0;
            this.timePicker1.Text = "timePicker1";
            // 
            // comboBoxHourFormat
            // 
            this.comboBoxHourFormat.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxHourFormat, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxHourFormat, true);
            this.comboBoxHourFormat.Items.AddRange(new object[] {
            "hh:mm a",
            "HH:mm"});
            this.comboBoxHourFormat.LabelText = "Hour Format";
            this.comboBoxHourFormat.Location = new System.Drawing.Point(3, 176);
            this.comboBoxHourFormat.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxHourFormat.Name = "comboBoxHourFormat";
            this.comboBoxHourFormat.Size = new System.Drawing.Size(212, 46);
            this.comboBoxHourFormat.TabIndex = 14;
            // 
            // numericUpDownFrom
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownFrom, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownFrom, true);
            this.numericUpDownFrom.LabelText = "From (Hours)";
            this.numericUpDownFrom.Location = new System.Drawing.Point(3, 46);
            this.numericUpDownFrom.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownFrom.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownFrom.TabIndex = 15;
            this.numericUpDownFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownTo
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownTo, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownTo, true);
            this.numericUpDownTo.LabelText = "To";
            this.numericUpDownTo.Location = new System.Drawing.Point(3, 111);
            this.numericUpDownTo.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownTo.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownTo.Name = "numericUpDownTo";
            this.numericUpDownTo.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownTo.TabIndex = 17;
            // 
            // checkBoxOpenOnFocus
            // 
            this.checkBoxOpenOnFocus.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxOpenOnFocus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxOpenOnFocus, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxOpenOnFocus, true);
            this.checkBoxOpenOnFocus.Location = new System.Drawing.Point(3, 3);
            this.checkBoxOpenOnFocus.Name = "checkBoxOpenOnFocus";
            this.checkBoxOpenOnFocus.Size = new System.Drawing.Size(212, 24);
            this.checkBoxOpenOnFocus.TabIndex = 18;
            this.checkBoxOpenOnFocus.Text = "Open on focus";
            // 
            // TimePicker
            // 
            this.Name = "TimePicker";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
