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
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.propertyGrid1, 1);
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.MinimumSize = new System.Drawing.Size(350, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(437, 298);
            this.propertyGrid1.TabIndex = 0;
            // 
            // 
            // 
            this.propertyGrid1.ToolBar.Enabled = true;
            // 
            // personCard1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.personCard1, 2);
            this.personCard1.Location = new System.Drawing.Point(446, 3);
            this.personCard1.MinimumSize = new System.Drawing.Size(700, 0);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(873, 298);
            this.personCard1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.propertyGrid1);
            this.flowLayoutPanel1.Controls.Add(this.personCard1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1322, 307);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Features
            // 
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(5);
            this.Load += new System.EventHandler(this.Features_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Web.PropertyGrid propertyGrid1;
        private PersonCard personCard1;
        private Web.FlowLayoutPanel flowLayoutPanel1;
    }
}
