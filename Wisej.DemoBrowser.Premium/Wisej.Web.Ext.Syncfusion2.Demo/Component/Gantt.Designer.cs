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
            this.flowLayoutPanel1.SuspendLayout();
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
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.gantt1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxReording);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxResizing);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxSelection);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxSorting);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxUnscheduleTask);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowColumn);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxDuration);
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
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxReording, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxReording, true);
            this.checkBoxReording.Location = new System.Drawing.Point(3, 3);
            this.checkBoxReording.Name = "checkBoxReording";
            this.checkBoxReording.Size = new System.Drawing.Size(212, 24);
            this.checkBoxReording.TabIndex = 1;
            this.checkBoxReording.Text = "Allow Reordering";
            // 
            // checkBoxUnscheduleTask
            // 
            this.checkBoxUnscheduleTask.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxUnscheduleTask, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxUnscheduleTask, true);
            this.checkBoxUnscheduleTask.Location = new System.Drawing.Point(3, 175);
            this.checkBoxUnscheduleTask.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxUnscheduleTask.Name = "checkBoxUnscheduleTask";
            this.checkBoxUnscheduleTask.Size = new System.Drawing.Size(212, 24);
            this.checkBoxUnscheduleTask.TabIndex = 2;
            this.checkBoxUnscheduleTask.Text = "Unscheduled Tasks";
            // 
            // checkBoxSorting
            // 
            this.checkBoxSorting.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxSorting, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxSorting, true);
            this.checkBoxSorting.Location = new System.Drawing.Point(3, 132);
            this.checkBoxSorting.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxSorting.Name = "checkBoxSorting";
            this.checkBoxSorting.Size = new System.Drawing.Size(212, 24);
            this.checkBoxSorting.TabIndex = 3;
            this.checkBoxSorting.Text = "Allow Sorting";
            // 
            // checkBoxSelection
            // 
            this.checkBoxSelection.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxSelection, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxSelection, true);
            this.checkBoxSelection.Location = new System.Drawing.Point(3, 89);
            this.checkBoxSelection.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxSelection.Name = "checkBoxSelection";
            this.checkBoxSelection.Size = new System.Drawing.Size(212, 24);
            this.checkBoxSelection.TabIndex = 4;
            this.checkBoxSelection.Text = "Allow Selection";
            // 
            // checkBoxResizing
            // 
            this.checkBoxResizing.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxResizing, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxResizing, true);
            this.checkBoxResizing.Location = new System.Drawing.Point(3, 46);
            this.checkBoxResizing.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxResizing.Name = "checkBoxResizing";
            this.checkBoxResizing.Size = new System.Drawing.Size(212, 24);
            this.checkBoxResizing.TabIndex = 5;
            this.checkBoxResizing.Text = "Allow Resizing";
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxDuration, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxDuration, true);
            this.comboBoxDuration.Items.AddRange(new object[] {
            "day",
            "hour",
            "minute"});
            this.comboBoxDuration.LabelText = "Duration unit";
            this.comboBoxDuration.Location = new System.Drawing.Point(3, 261);
            this.comboBoxDuration.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(212, 57);
            this.comboBoxDuration.TabIndex = 6;
            // 
            // checkBoxShowColumn
            // 
            this.checkBoxShowColumn.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxShowColumn, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxShowColumn, true);
            this.checkBoxShowColumn.Location = new System.Drawing.Point(3, 218);
            this.checkBoxShowColumn.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxShowColumn.Name = "checkBoxShowColumn";
            this.checkBoxShowColumn.Size = new System.Drawing.Size(212, 24);
            this.checkBoxShowColumn.TabIndex = 7;
            this.checkBoxShowColumn.Text = "Show Column Menu ";
            // 
            // Gantt
            // 
            this.Name = "Gantt";
            this.Load += new System.EventHandler(this.Gantt_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
