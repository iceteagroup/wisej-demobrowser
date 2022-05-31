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
            this.propertyGrid1 = new Wisej.Web.PropertyGrid();
            this.personCard1 = new Wisej.DemoBrowser.PropertyGrid.PersonCard();
            this.panel1 = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = Wisej.Web.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(1098, 5);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.NameFillWeight = 25F;
            this.propertyGrid1.RowHeadersVisible = false;
            this.propertyGrid1.SelectedObject = this.personCard1;
            this.propertyGrid1.Size = new System.Drawing.Size(319, 464);
            this.propertyGrid1.TabIndex = 0;
            // 
            // 
            // 
            this.propertyGrid1.ToolBar.Enabled = true;
            // 
            // personCard1
            // 
            this.personCard1.Anchor = Wisej.Web.AnchorStyles.None;
            this.personCard1.Location = new System.Drawing.Point(305, 83);
            this.personCard1.MaximumSize = new System.Drawing.Size(700, 0);
            this.personCard1.MinimumSize = new System.Drawing.Size(400, 0);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(482, 298);
            this.personCard1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.personCard1);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 464);
            this.panel1.TabIndex = 2;
            // 
            // Features
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid1);
            this.MinimumSize = new System.Drawing.Size(811, 312);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(5);
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
