namespace Wisej.DemoBrowser.Pannellum
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
            this.pannellum = new Wisej.Web.Ext.Pannellum.Pannellum();
            this.SuspendLayout();
            // 
            // pannellum
            // 
            this.pannellum.Dock = Wisej.Web.DockStyle.Fill;
            this.pannellum.Name = "pannellum";
            this.pannellum.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"type\":\"equirectangular\",\"autoLoad\":true,\"panorama\":\"https://pannellum.org/image" +
        "s/alma.jpg\"}")));
            this.pannellum.Size = new System.Drawing.Size(1422, 474);
            this.pannellum.TabIndex = 10;
            this.pannellum.Text = "pannellum1";
            this.pannellum.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.pannellum_WidgetEvent);
            // 
            // Features
            // 
            this.Controls.Add(this.pannellum);
            this.Name = "Features";
            this.ResumeLayout(false);

        }

        #endregion
        private Web.Ext.Pannellum.Pannellum pannellum;
    }
}
