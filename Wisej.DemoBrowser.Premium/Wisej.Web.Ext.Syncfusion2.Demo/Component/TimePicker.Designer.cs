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
			this.checkBoxOpenOnFocus = new Wisej.Web.CheckBox();
			this.textBoxMinimum = new Wisej.Web.TextBox();
			this.contextMenu1 = new Wisej.Web.ContextMenu();
			this.contextMenu2 = new Wisej.Web.ContextMenu();
			this.contextMenu3 = new Wisej.Web.ContextMenu();
			this.textBoxMaximum = new Wisej.Web.TextBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/timepicker/es5-getting-starte" +
    "d/";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/timepicker/";
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
			this.flowLayoutPanel1.Controls.Add(this.textBoxMinimum);
			this.flowLayoutPanel1.Controls.Add(this.textBoxMaximum);
			this.flowLayoutPanel1.Controls.Add(this.comboBoxHourFormat);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/timepicker/default.html";
			// 
			// timePicker1
			// 
			this.timePicker1.Anchor = Wisej.Web.AnchorStyles.None;
			this.timePicker1.Location = new System.Drawing.Point(269, 268);
			this.timePicker1.Name = "timePicker1";
			this.timePicker1.Size = new System.Drawing.Size(350, 40);
			this.timePicker1.TabIndex = 0;
			this.timePicker1.Text = "";
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
			this.comboBoxHourFormat.Location = new System.Drawing.Point(3, 186);
			this.comboBoxHourFormat.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBoxHourFormat.Name = "comboBoxHourFormat";
			this.comboBoxHourFormat.Size = new System.Drawing.Size(212, 51);
			this.comboBoxHourFormat.TabIndex = 14;
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
			this.checkBoxOpenOnFocus.Text = "Open on Focus";
			// 
			// textBoxMinimum
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxMinimum, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.textBoxMinimum, true);
			this.textBoxMinimum.InputType.Type = Wisej.Web.TextBoxType.Time;
			this.textBoxMinimum.LabelText = "Minimum (Hours)";
			this.textBoxMinimum.Location = new System.Drawing.Point(3, 46);
			this.textBoxMinimum.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBoxMinimum.Name = "textBoxMinimum";
			this.textBoxMinimum.Size = new System.Drawing.Size(212, 51);
			this.textBoxMinimum.TabIndex = 19;
			// 
			// contextMenu1
			// 
			this.contextMenu1.Name = "contextMenu1";
			// 
			// contextMenu2
			// 
			this.contextMenu2.Name = "contextMenu2";
			// 
			// contextMenu3
			// 
			this.contextMenu3.Name = "contextMenu3";
			// 
			// textBoxMaximum
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxMaximum, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.textBoxMaximum, true);
			this.textBoxMaximum.InputType.Type = Wisej.Web.TextBoxType.Time;
			this.textBoxMaximum.LabelText = "Maximum (Hours)";
			this.textBoxMaximum.Location = new System.Drawing.Point(3, 116);
			this.textBoxMaximum.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBoxMaximum.Name = "textBoxMaximum";
			this.textBoxMaximum.Size = new System.Drawing.Size(212, 51);
			this.textBoxMaximum.TabIndex = 20;
			// 
			// TimePicker
			// 
			this.Name = "TimePicker";
			this.Load += new System.EventHandler(this.TimePicker_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.TimePicker timePicker1;
        private ComboBox comboBoxHourFormat;
        private CheckBox checkBoxOpenOnFocus;
        private TextBox textBoxMinimum;
        private TextBox textBoxMaximum;
        private ContextMenu contextMenu1;
        private ContextMenu contextMenu2;
        private ContextMenu contextMenu3;
    }
}
