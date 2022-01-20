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
			this.listBox2 = new Wisej.Web.ListBox();
			this.listBox3 = new Wisej.Web.ListBox();
			this.listBox4 = new Wisej.Web.ListBox();
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
			this.listBoxDefaultCities.Location = new System.Drawing.Point(133, 100);
			this.listBoxDefaultCities.Name = "listBoxDefaultCities";
			this.listBoxDefaultCities.Size = new System.Drawing.Size(248, 275);
			this.listBoxDefaultCities.TabIndex = 0;
			this.listBoxDefaultCities.SelectedIndexChanged += new System.EventHandler(this.listBoxDefaultCities_SelectedIndexChanged);
			// 
			// listBox2
			// 
			this.listBox2.AllowHtml = true;
			this.listBox2.Anchor = Wisej.Web.AnchorStyles.None;
			this.listBox2.Items.AddRange(new object[] {
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
			this.listBox2.LabelText = "ListBox with HTML";
			this.listBox2.Location = new System.Drawing.Point(439, 100);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(248, 275);
			this.listBox2.TabIndex = 1;
			// 
			// listBox3
			// 
			this.listBox3.Anchor = Wisej.Web.AnchorStyles.None;
			this.listBox3.Items.AddRange(new object[] {
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
			this.listBox3.LabelText = "Read Only";
			this.listBox3.Location = new System.Drawing.Point(734, 100);
			this.listBox3.Name = "listBox3";
			this.listBox3.ReadOnly = true;
			this.listBox3.Size = new System.Drawing.Size(248, 275);
			this.listBox3.TabIndex = 2;
			// 
			// listBox4
			// 
			this.listBox4.Anchor = Wisej.Web.AnchorStyles.None;
			this.listBox4.ItemHeight = 45;
			this.listBox4.Items.AddRange(new object[] {
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
			this.listBox4.LabelText = "Increased Spacing";
			this.listBox4.Location = new System.Drawing.Point(1041, 100);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(248, 275);
			this.listBox4.TabIndex = 3;
			// 
			// Features
			// 
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBoxDefaultCities);
			this.MinimumSize = new System.Drawing.Size(1220, 300);
			this.Name = "Features";
			this.ResumeLayout(false);

		}

		#endregion

		private Web.ListBox listBoxDefaultCities;
		private Web.ListBox listBox2;
		private Web.ListBox listBox3;
		private Web.ListBox listBox4;
	}
}
