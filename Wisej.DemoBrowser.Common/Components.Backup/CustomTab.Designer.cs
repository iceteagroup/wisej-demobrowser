
namespace Wisej.DemoBrowser.Common.Components
{
    partial class CustomTab
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
            this.label1.BackColor = System.Drawing.Color.FromName("@tabText");
            this.label1.CssStyle = "writing-mode: vertical-rl;";
            this.label1.Dock = Wisej.Web.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new Wisej.Web.Padding(3);
            this.label1.Size = new System.Drawing.Size(25, 279);
            this.label1.TabIndex = 0;
            this.label1.Text = "Properties";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomTab
            // 
            this.Controls.Add(this.label1);
            this.CssStyle = "border-radius:8px;";
            this.Name = "CustomTab";
            this.Size = new System.Drawing.Size(25, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Label label1;
    }
}
