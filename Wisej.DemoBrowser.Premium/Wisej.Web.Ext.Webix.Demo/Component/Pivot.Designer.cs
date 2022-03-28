namespace Wisej.Web.Ext.Webix.Demo.Component
{
    partial class Pivot
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
            this.pivot1 = new Wisej.Web.Ext.Webix.Pivot();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pivot1);
            // 
            // pivot1
            // 
            this.pivot1.Dock = Wisej.Web.DockStyle.Fill;
            this.pivot1.Location = new System.Drawing.Point(8, 8);
            this.pivot1.Name = "pivot1";
            this.pivot1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"structure\":{\"rows\":[\"form\",\"name\"],\"columns\":[\"year\"],\"values\":[{\"name\":\"oil\",\"" +
        "operation\":[\"min\",\"sum\"]}]},\"url\":\"https://cdn.webix.com/demodata/pivot.json\"}")));
            this.pivot1.Size = new System.Drawing.Size(1073, 542);
            this.pivot1.TabIndex = 0;
            this.pivot1.Text = "pivot1";
            // 
            // Pivot
            // 
            this.Name = "Pivot";
            this.Load += new System.EventHandler(this.Pivot_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.Pivot pivot1;
    }
}
