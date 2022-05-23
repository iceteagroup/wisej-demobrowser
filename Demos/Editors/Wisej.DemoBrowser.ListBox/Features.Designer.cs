namespace Wisej.DemoBrowser.ListBox
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
            this.listBoxDefaultCities = new Wisej.Web.ListBox();
            this.listBoxHtml = new Wisej.Web.ListBox();
            this.listBoxSpacing = new Wisej.Web.ListBox();
            this.checkBoxReadOnly = new Wisej.Web.CheckBox();
            this.SuspendLayout();
            // 
            // listBoxDefaultCities
            // 
            this.listBoxDefaultCities.Anchor = Wisej.Web.AnchorStyles.None;
            this.listBoxDefaultCities.Items.AddRange(new object[] {
            "Aberdeen",
            "Abilene",
            "Akron",
            "Albany",
            "Albuquerque",
            "Alexandria",
            "Allentown",
            "Amarillo",
            "Anaheim",
            "Anchorage",
            "Ann Arbor",
            "Antioch",
            "Apple Valley",
            "Appleton",
            "Arlington",
            "Arvada",
            "Asheville",
            "Athens",
            "Atlanta",
            "Atlantic City",
            "Augusta",
            "Aurora",
            "Austin",
            "Bakersfield",
            "Baltimore",
            "Barnstable",
            "Baton Rouge",
            "Beaumont",
            "Bel Air",
            "Bellevue",
            "Berkeley",
            "Bethlehem",
            "Billings",
            "Birmingham",
            "Bloomington",
            "Boise",
            "Boise City"});
            this.listBoxDefaultCities.LabelText = "Default ListBox";
            this.listBoxDefaultCities.Location = new System.Drawing.Point(132, 4);
            this.listBoxDefaultCities.Name = "listBoxDefaultCities";
            this.listBoxDefaultCities.Size = new System.Drawing.Size(248, 275);
            this.listBoxDefaultCities.TabIndex = 0;
            this.listBoxDefaultCities.SelectedIndexChanged += new System.EventHandler(this.listBoxDefaultCities_SelectedIndexChanged);
            // 
            // listBoxHtml
            // 
            this.listBoxHtml.AllowHtml = true;
            this.listBoxHtml.Anchor = Wisej.Web.AnchorStyles.None;
            this.listBoxHtml.Items.AddRange(new object[] {
            "<b>Aberdeen</b>",
            "<i>Abilene</i>",
            "<b>Akron</b>",
            "Albany",
            "Albuquerque",
            "<b style=\'color:red\'>Alexandria</b>",
            "Allentown",
            "<b>Amarillo</b>",
            "Anaheim",
            "Anchorage",
            "Ann Arbor",
            "Antioch",
            "Apple Valley",
            "Appleton",
            "Arlington",
            "Arvada",
            "Asheville",
            "Athens",
            "Atlanta",
            "Atlantic City",
            "Augusta",
            "Aurora",
            "Austin",
            "Bakersfield",
            "Baltimore",
            "Barnstable",
            "Baton Rouge",
            "Beaumont",
            "Bel Air",
            "Bellevue",
            "Berkeley",
            "Bethlehem",
            "Billings",
            "Birmingham",
            "Bloomington",
            "Boise",
            "Boise City"});
            this.listBoxHtml.LabelText = "ListBox with HTML";
            this.listBoxHtml.Location = new System.Drawing.Point(396, 4);
            this.listBoxHtml.Name = "listBoxHtml";
            this.listBoxHtml.Size = new System.Drawing.Size(248, 275);
            this.listBoxHtml.TabIndex = 1;
            // 
            // listBoxSpacing
            // 
            this.listBoxSpacing.Anchor = Wisej.Web.AnchorStyles.None;
            this.listBoxSpacing.ItemHeight = 45;
            this.listBoxSpacing.Items.AddRange(new object[] {
            "Aberdeen",
            "Abilene",
            "Akron",
            "Albany",
            "Albuquerque",
            "Alexandria",
            "Allentown",
            "Amarillo",
            "Anaheim",
            "Anchorage",
            "Ann Arbor",
            "Antioch",
            "Apple Valley",
            "Appleton",
            "Arlington",
            "Arvada",
            "Asheville",
            "Athens",
            "Atlanta",
            "Atlantic City",
            "Augusta",
            "Aurora",
            "Austin",
            "Bakersfield",
            "Baltimore",
            "Barnstable",
            "Baton Rouge",
            "Beaumont",
            "Bel Air",
            "Bellevue",
            "Berkeley",
            "Bethlehem",
            "Billings",
            "Birmingham",
            "Bloomington",
            "Boise",
            "Boise City"});
            this.listBoxSpacing.LabelText = "Increased Spacing";
            this.listBoxSpacing.Location = new System.Drawing.Point(660, 4);
            this.listBoxSpacing.Name = "listBoxSpacing";
            this.listBoxSpacing.Size = new System.Drawing.Size(248, 275);
            this.listBoxSpacing.TabIndex = 3;
            // 
            // checkBoxReadOnly
            // 
            this.checkBoxReadOnly.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBoxReadOnly.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxReadOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxReadOnly.Location = new System.Drawing.Point(4, 132);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(112, 24);
            this.checkBoxReadOnly.TabIndex = 4;
            this.checkBoxReadOnly.Text = "Read Only";
            this.checkBoxReadOnly.CheckedChanged += new System.EventHandler(this.checkBoxReadOnly_CheckedChanged);
            // 
            // Features
            // 
            this.Controls.Add(this.checkBoxReadOnly);
            this.Controls.Add(this.listBoxSpacing);
            this.Controls.Add(this.listBoxHtml);
            this.Controls.Add(this.listBoxDefaultCities);
            this.MinimumSize = new System.Drawing.Size(912, 283);
            this.Name = "Features";
            this.Size = new System.Drawing.Size(912, 283);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.ListBox listBoxDefaultCities;
		private Web.ListBox listBoxHtml;
		private Web.ListBox listBoxSpacing;
        private Web.CheckBox checkBoxReadOnly;
    }
}
