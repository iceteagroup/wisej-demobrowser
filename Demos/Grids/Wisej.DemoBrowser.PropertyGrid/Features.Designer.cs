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
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = Wisej.Web.AnchorStyles.None;
            this.propertyGrid1.Location = new System.Drawing.Point(221, 16);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(374, 443);
            this.propertyGrid1.TabIndex = 0;
            // 
            // 
            // 
            this.propertyGrid1.ToolBar.Enabled = true;
            // 
            // personCard1
            // 
            this.personCard1.Anchor = Wisej.Web.AnchorStyles.None;
            this.personCard1.Location = new System.Drawing.Point(613, 81);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(588, 312);
            this.personCard1.TabIndex = 1;
            // 
            // Features
            // 
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.personCard1);
            this.MinimumSize = new System.Drawing.Size(978, 340);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(5);
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Web.PropertyGrid propertyGrid1;
        private PersonCard personCard1;
    }
}
