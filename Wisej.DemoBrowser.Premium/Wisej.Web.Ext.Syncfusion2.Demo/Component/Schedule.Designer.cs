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
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/schedule/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/schedule";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAdaptativeUI);
            this.groupBox1.Controls.Add(this.comboBoxCurrentView);
            this.groupBox1.Controls.Add(this.checkBoxResizing);
            this.groupBox1.Controls.Add(this.checkBoxInline);
            this.groupBox1.Controls.Add(this.checkBoxDragAndDrop);
            this.groupBox1.Controls.Add(this.comboBoxCalendarMode);
            this.groupBox1.Size = new System.Drawing.Size(285, 477);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxCalendarMode, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxDragAndDrop, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxInline, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxResizing, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxCurrentView, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxAdaptativeUI, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 396);
            this.buttonUpdate.Size = new System.Drawing.Size(230, 52);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.schedule1);
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
            this.comboBoxCalendarMode.Items.AddRange(new object[] {
            "Gregorian",
            "Islamic"});
            this.comboBoxCalendarMode.LabelText = "Calendar mode";
            this.comboBoxCalendarMode.Location = new System.Drawing.Point(21, 31);
            this.comboBoxCalendarMode.Name = "comboBoxCalendarMode";
            this.comboBoxCalendarMode.Size = new System.Drawing.Size(211, 46);
            this.comboBoxCalendarMode.TabIndex = 1;
            // 
            // checkBoxDragAndDrop
            // 
            this.checkBoxDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDragAndDrop.AutoSize = false;
            this.checkBoxDragAndDrop.Location = new System.Drawing.Point(21, 96);
            this.checkBoxDragAndDrop.Name = "checkBoxDragAndDrop";
            this.checkBoxDragAndDrop.Size = new System.Drawing.Size(245, 35);
            this.checkBoxDragAndDrop.TabIndex = 2;
            this.checkBoxDragAndDrop.Text = "Allow drag and drop";
            // 
            // checkBoxInline
            // 
            this.checkBoxInline.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxInline.Location = new System.Drawing.Point(21, 139);
            this.checkBoxInline.Name = "checkBoxInline";
            this.checkBoxInline.Size = new System.Drawing.Size(133, 24);
            this.checkBoxInline.TabIndex = 3;
            this.checkBoxInline.Text = "Allow inline";
            // 
            // checkBoxResizing
            // 
            this.checkBoxResizing.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxResizing.Location = new System.Drawing.Point(21, 174);
            this.checkBoxResizing.Name = "checkBoxResizing";
            this.checkBoxResizing.Size = new System.Drawing.Size(150, 24);
            this.checkBoxResizing.TabIndex = 4;
            this.checkBoxResizing.Text = "Allow resizing";
            // 
            // comboBoxCurrentView
            // 
            this.comboBoxCurrentView.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
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
            this.comboBoxCurrentView.LabelText = "Current view";
            this.comboBoxCurrentView.Location = new System.Drawing.Point(20, 243);
            this.comboBoxCurrentView.Name = "comboBoxCurrentView";
            this.comboBoxCurrentView.Size = new System.Drawing.Size(211, 46);
            this.comboBoxCurrentView.TabIndex = 5;
            // 
            // checkBoxAdaptativeUI
            // 
            this.checkBoxAdaptativeUI.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAdaptativeUI.Location = new System.Drawing.Point(21, 208);
            this.checkBoxAdaptativeUI.Name = "checkBoxAdaptativeUI";
            this.checkBoxAdaptativeUI.Size = new System.Drawing.Size(201, 24);
            this.checkBoxAdaptativeUI.TabIndex = 6;
            this.checkBoxAdaptativeUI.Text = "Enable adaptative UI";
            // 
            // Schedule
            // 
            this.Name = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
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
