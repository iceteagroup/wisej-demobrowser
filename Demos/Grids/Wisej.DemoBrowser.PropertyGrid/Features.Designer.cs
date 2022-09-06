namespace Wisej.DemoBrowser.PropertyGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            this.panel1 = new Wisej.Web.Panel();
            this.personCard1 = new Wisej.DemoBrowser.PropertyGrid.PersonCard();
            this.propertyGrid1 = new Wisej.Web.PropertyGrid();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.personCard1);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(325, 5);
            this.panel1.Name = "panel1";
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles1"))));
            this.panel1.Size = new System.Drawing.Size(864, 464);
            this.panel1.TabIndex = 2;
            // 
            // personCard1
            // 
            this.personCard1.Name = "personCard1";
            this.personCard1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("personCard1.ResponsiveProfiles"))));
            this.personCard1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("personCard1.ResponsiveProfiles1"))));
            this.personCard1.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = Wisej.Web.DockStyle.Left;
            this.propertyGrid1.Location = new System.Drawing.Point(5, 5);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.NameFillWeight = 25F;
            this.propertyGrid1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("propertyGrid1.ResponsiveProfiles"))));
            this.propertyGrid1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("propertyGrid1.ResponsiveProfiles1"))));
            this.propertyGrid1.RowHeadersVisible = false;
            this.propertyGrid1.SelectedObject = this.personCard1;
            this.propertyGrid1.Size = new System.Drawing.Size(320, 464);
            this.propertyGrid1.TabIndex = 0;
            // 
            // 
            // 
            this.propertyGrid1.ToolBar.Enabled = true;
            // 
            // Features
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid1);
            this.MinimumSize = new System.Drawing.Size(811, 312);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(5);
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles1"))));
            this.Size = new System.Drawing.Size(1194, 474);
            this.Load += new System.EventHandler(this.Features_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Web.PropertyGrid propertyGrid1;
        private PersonCard personCard1;
        private Web.Panel panel1;
    }
}
