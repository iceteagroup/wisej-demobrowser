namespace Wisej.DemoBrowser.FluentUIThemes
{
    partial class AppointmentPlanner
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
            Wisej.Resources.ComponentResourceManager resources = new Wisej.Resources.ComponentResourceManager(typeof(AppointmentPlanner));
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.label1 = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageSource = "resource.wx/Wisej.Ext.FluentUIOutlinedIcons/globe.svg?color=#0027FF";
            this.pictureBox1.Location = new System.Drawing.Point(233, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 148);
            // 
            // label1
            // 
            this.label1.AllowHtml = true;
            this.label1.Location = new System.Drawing.Point(384, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 148);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // AppointmentPlanner
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AppointmentPlanner";
            this.Load += new System.EventHandler(this.Ignite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.PictureBox pictureBox1;
        private Web.Label label1;
    }
}
