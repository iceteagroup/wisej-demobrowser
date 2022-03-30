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
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.scheduler1);
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
            // Scheduler
            // 
            this.Name = "Scheduler";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.Scheduler scheduler1;
    }
}
