
namespace Wisej.DemoBrowser.Common.Components
{
    partial class DashboardItemView
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
            this.button1 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = Wisej.Web.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(743, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "More Details";
            // 
            // DashboardItemView
            // 
            this.Controls.Add(this.button1);
            this.Name = "DashboardItemView";
            this.Size = new System.Drawing.Size(743, 348);
            this.ResumeLayout(false);

        }

        #endregion
        public Web.Button button1;
    }
}
