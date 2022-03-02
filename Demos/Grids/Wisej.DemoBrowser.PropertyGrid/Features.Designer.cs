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
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.propertyGrid1 = new Wisej.Web.PropertyGrid();
            this.personCard1 = new Wisej.DemoBrowser.PropertyGrid.PersonCard();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromName("@desktop");
            this.groupBox1.Controls.Add(this.propertyGrid1);
            this.groupBox1.Dock = Wisej.Web.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "PropertyGrid Demo";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = Wisej.Web.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 18);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(374, 443);
            this.propertyGrid1.TabIndex = 0;
            // 
            // 
            // 
            this.propertyGrid1.ToolBar.Enabled = true;
            this.propertyGrid1.SelectedGridItemBeginEdit += new Wisej.Web.SelectedGridItemBeginEditEventHandler(this.propertyGrid1_SelectedGridItemBeginEdit);
            // 
            // personCard1
            // 
            this.personCard1.Anchor = Wisej.Web.AnchorStyles.None;
            this.personCard1.Location = new System.Drawing.Point(873, 100);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(541, 274);
            this.personCard1.TabIndex = 1;
            // 
            // Features
            // 
            this.Controls.Add(this.personCard1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(5);
            this.Load += new System.EventHandler(this.Features_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.GroupBox groupBox1;
        private Web.PropertyGrid propertyGrid1;
        private PersonCard personCard1;
    }
}
