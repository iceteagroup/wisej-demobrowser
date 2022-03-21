namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Gantt
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
            this.gantt1 = new Wisej.Web.Ext.Syncfusion2.Gantt();
            this.checkBoxReording = new Wisej.Web.CheckBox();
            this.checkBoxUnscheduleTask = new Wisej.Web.CheckBox();
            this.checkBoxSorting = new Wisej.Web.CheckBox();
            this.checkBoxSelection = new Wisej.Web.CheckBox();
            this.checkBoxResizing = new Wisej.Web.CheckBox();
            this.comboBoxDuration = new Wisej.Web.ComboBox();
            this.checkBoxShowColumn = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/gantt/es5-getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/gantt/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxShowColumn);
            this.groupBox1.Controls.Add(this.comboBoxDuration);
            this.groupBox1.Controls.Add(this.checkBoxResizing);
            this.groupBox1.Controls.Add(this.checkBoxSelection);
            this.groupBox1.Controls.Add(this.checkBoxSorting);
            this.groupBox1.Controls.Add(this.checkBoxUnscheduleTask);
            this.groupBox1.Controls.Add(this.checkBoxReording);
            this.groupBox1.Size = new System.Drawing.Size(250, 459);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxReording, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxUnscheduleTask, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxSorting, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxSelection, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxResizing, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxDuration, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxShowColumn, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 378);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.gantt1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/gantt/default.html";
            // 
            // gantt1
            // 
            this.gantt1.Dock = Wisej.Web.DockStyle.Fill;
            this.gantt1.Location = new System.Drawing.Point(8, 8);
            this.gantt1.Name = "gantt1";
            this.gantt1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"dataSource\":[]}")));
            this.gantt1.Size = new System.Drawing.Size(1073, 542);
            this.gantt1.TabIndex = 0;
            this.gantt1.Text = "gantt1";
            // 
            // checkBoxReording
            // 
            this.checkBoxReording.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxReording.Location = new System.Drawing.Point(16, 24);
            this.checkBoxReording.Name = "checkBoxReording";
            this.checkBoxReording.Size = new System.Drawing.Size(154, 24);
            this.checkBoxReording.TabIndex = 1;
            this.checkBoxReording.Text = "Allow reording";
            // 
            // checkBoxUnscheduleTask
            // 
            this.checkBoxUnscheduleTask.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxUnscheduleTask.Location = new System.Drawing.Point(16, 177);
            this.checkBoxUnscheduleTask.Name = "checkBoxUnscheduleTask";
            this.checkBoxUnscheduleTask.Size = new System.Drawing.Size(220, 24);
            this.checkBoxUnscheduleTask.TabIndex = 2;
            this.checkBoxUnscheduleTask.Text = "Allow unscheduled task";
            // 
            // checkBoxSorting
            // 
            this.checkBoxSorting.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxSorting.Location = new System.Drawing.Point(16, 140);
            this.checkBoxSorting.Name = "checkBoxSorting";
            this.checkBoxSorting.Size = new System.Drawing.Size(143, 24);
            this.checkBoxSorting.TabIndex = 3;
            this.checkBoxSorting.Text = "Allow sorting";
            // 
            // checkBoxSelection
            // 
            this.checkBoxSelection.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxSelection.Location = new System.Drawing.Point(16, 101);
            this.checkBoxSelection.Name = "checkBoxSelection";
            this.checkBoxSelection.Size = new System.Drawing.Size(159, 24);
            this.checkBoxSelection.TabIndex = 4;
            this.checkBoxSelection.Text = "Allow selection";
            // 
            // checkBoxResizing
            // 
            this.checkBoxResizing.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxResizing.Location = new System.Drawing.Point(16, 63);
            this.checkBoxResizing.Name = "checkBoxResizing";
            this.checkBoxResizing.Size = new System.Drawing.Size(150, 24);
            this.checkBoxResizing.TabIndex = 5;
            this.checkBoxResizing.Text = "Allow resizing";
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxDuration.Items.AddRange(new object[] {
            "day",
            "hour",
            "minute"});
            this.comboBoxDuration.LabelText = "Duration unit";
            this.comboBoxDuration.Location = new System.Drawing.Point(16, 255);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(213, 46);
            this.comboBoxDuration.TabIndex = 6;
            // 
            // checkBoxShowColumn
            // 
            this.checkBoxShowColumn.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowColumn.Location = new System.Drawing.Point(15, 215);
            this.checkBoxShowColumn.Name = "checkBoxShowColumn";
            this.checkBoxShowColumn.Size = new System.Drawing.Size(193, 24);
            this.checkBoxShowColumn.TabIndex = 7;
            this.checkBoxShowColumn.Text = "Show column menu ";
            // 
            // Gantt
            // 
            this.Name = "Gantt";
            this.Load += new System.EventHandler(this.Gantt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Gantt gantt1;
        private CheckBox checkBoxShowColumn;
        private ComboBox comboBoxDuration;
        private CheckBox checkBoxResizing;
        private CheckBox checkBoxSelection;
        private CheckBox checkBoxSorting;
        private CheckBox checkBoxUnscheduleTask;
        private CheckBox checkBoxReording;
    }
}
