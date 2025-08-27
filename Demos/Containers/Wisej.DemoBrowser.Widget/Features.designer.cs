namespace Wisej.DemoBrowser.Widget
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
            this.widget1 = new Wisej.Web.Widget();
            this.SuspendLayout();
            // 
            // widget1
            // 
            this.widget1.BackColor = System.Drawing.Color.FromName("@window");
            this.widget1.Dock = Wisej.Web.DockStyle.Fill;
            this.widget1.Location = new System.Drawing.Point(10, 10);
            this.widget1.Name = "widget1";
            this.widget1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.widget1.Size = new System.Drawing.Size(1402, 454);
            this.widget1.TabIndex = 0;
            this.widget1.Text = "widget1";
            // 
            // Features
            // 
            this.BackColor = System.Drawing.Color.FromName("@controlDark");
            this.Controls.Add(this.widget1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(10);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Widget widget1;
    }
}
