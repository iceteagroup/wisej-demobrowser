namespace Wisej.DemoBrowser.ChartJS4
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
            Wisej.Resources.ComponentResourceManager resources = new Wisej.Resources.ComponentResourceManager(typeof(Features));
            this.htmlPanel1 = new Wisej.Web.HtmlPanel();
            this.SuspendLayout();
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.htmlPanel1.Focusable = false;
            this.htmlPanel1.Html = resources.GetString("htmlPanel1.Html");
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(1422, 474);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.TabStop = false;
            // 
            // Features
            // 
            this.Controls.Add(this.htmlPanel1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Ignite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.HtmlPanel htmlPanel1;
    }
}
