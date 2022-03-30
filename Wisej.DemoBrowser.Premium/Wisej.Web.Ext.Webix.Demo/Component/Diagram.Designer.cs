namespace Wisej.Web.Ext.Webix.Demo.Component
{
    partial class Diagram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagram));
            this.diagram1 = new Wisej.Web.Ext.Webix.Diagram();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.diagram1);
            // 
            // diagram1
            // 
            this.diagram1.Dock = Wisej.Web.DockStyle.Fill;
            this.diagram1.Location = new System.Drawing.Point(8, 8);
            this.diagram1.Name = "diagram1";
            this.diagram1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("diagram1.Options"))));
            this.diagram1.Size = new System.Drawing.Size(1073, 542);
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // Diagram
            // 
            this.Name = "Diagram";
            this.Load += new System.EventHandler(this.Diagram_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.Diagram diagram1;
    }
}
