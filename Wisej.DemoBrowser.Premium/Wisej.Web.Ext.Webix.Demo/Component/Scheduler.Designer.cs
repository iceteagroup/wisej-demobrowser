namespace Wisej.Web.Ext.Webix.Demo.Component
{
    partial class Scheduler
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
            this.scheduler1 = new Wisej.Web.Ext.Webix.Scheduler();
            this.comboBoxTimelineMode = new Wisej.Web.ComboBox();
            this.checkBoxAllowTimeline = new Wisej.Web.CheckBox();
            this.comboBoxMode = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery/scheduler";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.scheduler.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.scheduler1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowTimeline);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxMode);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxTimelineMode);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 434);
            // 
            // scheduler1
            // 
            this.scheduler1.Dock = Wisej.Web.DockStyle.Fill;
            this.scheduler1.Location = new System.Drawing.Point(8, 8);
            this.scheduler1.Name = "scheduler1";
            this.scheduler1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"date\":\"2020-08-31T20:00:00.001\",\"url\":\"https://docs.webix.com/calendar-backend/" +
        "\"}")));
            this.scheduler1.Size = new System.Drawing.Size(1073, 542);
            this.scheduler1.TabIndex = 0;
            this.scheduler1.Text = "scheduler1";
            // 
            // comboBoxTimelineMode
            // 
            this.comboBoxTimelineMode.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxTimelineMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxTimelineMode, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxTimelineMode, true);
            this.comboBoxTimelineMode.Items.AddRange(new object[] {
            "day",
            "week",
            "month"});
            this.comboBoxTimelineMode.LabelText = "Timeline Mode";
            this.comboBoxTimelineMode.Location = new System.Drawing.Point(3, 124);
            this.comboBoxTimelineMode.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxTimelineMode.Name = "comboBoxTimelineMode";
            this.comboBoxTimelineMode.Size = new System.Drawing.Size(212, 57);
            this.comboBoxTimelineMode.TabIndex = 0;
            // 
            // checkBoxAllowTimeline
            // 
            this.checkBoxAllowTimeline.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxAllowTimeline.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowTimeline.AutoSize = false;
            this.checkBoxAllowTimeline.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxAllowTimeline, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxAllowTimeline, true);
            this.checkBoxAllowTimeline.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAllowTimeline.Name = "checkBoxAllowTimeline";
            this.checkBoxAllowTimeline.Size = new System.Drawing.Size(212, 26);
            this.checkBoxAllowTimeline.TabIndex = 2;
            this.checkBoxAllowTimeline.Text = "Allow Timeline";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxMode, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxMode, true);
            this.comboBoxMode.Items.AddRange(new object[] {
            "day",
            "week",
            "month",
            "agenda",
            "timeline",
            "units"});
            this.comboBoxMode.LabelText = "Mode";
            this.comboBoxMode.Location = new System.Drawing.Point(3, 48);
            this.comboBoxMode.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(212, 57);
            this.comboBoxMode.TabIndex = 3;
            // 
            // Scheduler
            // 
            this.Name = "Scheduler";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.Scheduler scheduler1;
        private ComboBox comboBoxTimelineMode;
        private ComboBox comboBoxMode;
        private CheckBox checkBoxAllowTimeline;
    }
}
