namespace Wisej.DemoBrowser.UserControl
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
            this.userControl1 = new Wisej.Web.UserControl();
            this.SuspendLayout();
            // 
            // userControl1
            // 
            this.userControl1.BackColor = System.Drawing.Color.FromName("@window");
            this.userControl1.Dock = Wisej.Web.DockStyle.Fill;
            this.userControl1.Location = new System.Drawing.Point(10, 10);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(1402, 454);
            this.userControl1.TabIndex = 0;
            this.userControl1.TabStop = true;
            // 
            // Features
            // 
            this.BackColor = System.Drawing.Color.FromName("@controlDark");
            this.Controls.Add(this.userControl1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(10);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.UserControl userControl1;
    }
}
