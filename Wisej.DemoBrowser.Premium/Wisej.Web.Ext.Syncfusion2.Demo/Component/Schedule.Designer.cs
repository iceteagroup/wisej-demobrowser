namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Schedule
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
            this.schedule1 = new Wisej.Web.Ext.Syncfusion2.Schedule();
            this.comboBoxCalendarMode = new Wisej.Web.ComboBox();
            this.checkBoxDragAndDrop = new Wisej.Web.CheckBox();
            this.checkBoxInline = new Wisej.Web.CheckBox();
            this.checkBoxResizing = new Wisej.Web.CheckBox();
            this.comboBoxCurrentView = new Wisej.Web.ComboBox();
            this.checkBoxAdaptativeUI = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/schedule/getting-started/";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/schedule";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.schedule1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxDragAndDrop);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxInline);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxResizing);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAdaptativeUI);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxCalendarMode);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxCurrentView);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/schedule/overview.html";
            // 
            // schedule1
            // 
            this.schedule1.Dock = Wisej.Web.DockStyle.Fill;
            this.schedule1.Location = new System.Drawing.Point(8, 8);
            this.schedule1.Name = "schedule1";
            this.schedule1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"selectedDate\":\"2021-01-15\",\"eventSettings\":{\"dataSource\":[]}}")));
            this.schedule1.Size = new System.Drawing.Size(1073, 542);
            this.schedule1.TabIndex = 0;
            this.schedule1.Text = "schedule1";
            // 
            // comboBoxCalendarMode
            // 
            this.comboBoxCalendarMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxCalendarMode, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxCalendarMode, true);
            this.comboBoxCalendarMode.Items.AddRange(new object[] {
            "Gregorian",
            "Islamic"});
            this.comboBoxCalendarMode.LabelText = "Calendar Mode";
            this.comboBoxCalendarMode.Location = new System.Drawing.Point(3, 175);
            this.comboBoxCalendarMode.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxCalendarMode.Name = "comboBoxCalendarMode";
            this.comboBoxCalendarMode.Size = new System.Drawing.Size(212, 46);
            this.comboBoxCalendarMode.TabIndex = 1;
            // 
            // checkBoxDragAndDrop
            // 
            this.checkBoxDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDragAndDrop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxDragAndDrop, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxDragAndDrop, true);
            this.checkBoxDragAndDrop.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDragAndDrop.Name = "checkBoxDragAndDrop";
            this.checkBoxDragAndDrop.Size = new System.Drawing.Size(212, 24);
            this.checkBoxDragAndDrop.TabIndex = 2;
            this.checkBoxDragAndDrop.Text = "Allow Drag-and-Drop";
            // 
            // checkBoxInline
            // 
            this.checkBoxInline.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxInline.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxInline, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxInline, true);
            this.checkBoxInline.Location = new System.Drawing.Point(3, 46);
            this.checkBoxInline.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxInline.Name = "checkBoxInline";
            this.checkBoxInline.Size = new System.Drawing.Size(212, 24);
            this.checkBoxInline.TabIndex = 3;
            this.checkBoxInline.Text = "Allow Inline";
            // 
            // checkBoxResizing
            // 
            this.checkBoxResizing.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxResizing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxResizing, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxResizing, true);
            this.checkBoxResizing.Location = new System.Drawing.Point(3, 89);
            this.checkBoxResizing.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxResizing.Name = "checkBoxResizing";
            this.checkBoxResizing.Size = new System.Drawing.Size(212, 24);
            this.checkBoxResizing.TabIndex = 4;
            this.checkBoxResizing.Text = "Allow Resizing";
            // 
            // comboBoxCurrentView
            // 
            this.comboBoxCurrentView.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxCurrentView, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxCurrentView, true);
            this.comboBoxCurrentView.Items.AddRange(new object[] {
            "Day",
            "Week",
            "WorkWeek",
            "Month",
            "Year",
            "Agenda",
            "MonthAgenda",
            "TimelineDay",
            "TimelineWeek",
            "TimelineWorkWeek",
            "TimelineMonth",
            "TimelineYear"});
            this.comboBoxCurrentView.LabelText = "Current View";
            this.comboBoxCurrentView.Location = new System.Drawing.Point(3, 240);
            this.comboBoxCurrentView.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxCurrentView.Name = "comboBoxCurrentView";
            this.comboBoxCurrentView.Size = new System.Drawing.Size(212, 46);
            this.comboBoxCurrentView.TabIndex = 5;
            // 
            // checkBoxAdaptativeUI
            // 
            this.checkBoxAdaptativeUI.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAdaptativeUI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxAdaptativeUI, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxAdaptativeUI, true);
            this.checkBoxAdaptativeUI.Location = new System.Drawing.Point(3, 132);
            this.checkBoxAdaptativeUI.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxAdaptativeUI.Name = "checkBoxAdaptativeUI";
            this.checkBoxAdaptativeUI.Size = new System.Drawing.Size(212, 24);
            this.checkBoxAdaptativeUI.TabIndex = 6;
            this.checkBoxAdaptativeUI.Text = "Enable Adaptative UI";
            // 
            // Schedule
            // 
            this.Name = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Schedule schedule1;
        private ComboBox comboBoxCalendarMode;
        private CheckBox checkBoxDragAndDrop;
        private CheckBox checkBoxInline;
        private ComboBox comboBoxCurrentView;
        private CheckBox checkBoxResizing;
        private CheckBox checkBoxAdaptativeUI;
    }
}
