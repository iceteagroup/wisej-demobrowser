namespace Wisej.DemoBrowser.iFramePanel
{
    partial class Features
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
            this.iFramePanel1 = new Wisej.Web.IFramePanel();
            this.SuspendLayout();
            // 
            // iFramePanel1
            // 
            this.iFramePanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.iFramePanel1.Location = new System.Drawing.Point(8, 8);
            this.iFramePanel1.Name = "iFramePanel1";
            this.iFramePanel1.Size = new System.Drawing.Size(1406, 458);
            this.iFramePanel1.TabIndex = 0;
            this.iFramePanel1.Text = "iFramePanel1";
            this.iFramePanel1.Url = "http://wisej.com";
            // 
            // Features
            // 
            this.Controls.Add(this.iFramePanel1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(8);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.IFramePanel iFramePanel1;
    }
}
