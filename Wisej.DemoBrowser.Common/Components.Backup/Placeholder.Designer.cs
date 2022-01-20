
namespace Wisej.DemoBrowser.Common.Components
{
    partial class Placeholder
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
            this.label1 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Wisej.Web.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("default", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1086, 761);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coming soon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Placeholder
            // 
            this.Controls.Add(this.label1);
            this.Name = "Placeholder";
            this.Size = new System.Drawing.Size(1086, 761);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Label label1;
    }
}
