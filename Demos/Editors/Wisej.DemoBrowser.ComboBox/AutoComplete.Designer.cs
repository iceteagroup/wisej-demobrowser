namespace Wisej.DemoBrowser.ComboBox
{
    partial class AutoComplete
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
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBoxAutoCompleteMode = new Wisej.Web.ComboBox();
			this.comboBoxDropDownStyle = new Wisej.Web.ComboBox();
			this.panel1 = new Wisej.Web.Panel();
			this.label1 = new Wisej.Web.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBox1.Items.AddRange(new object[] {
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
            "Boise City",
            "Bonita Springs",
            "Boston",
            "Boulder",
            "Bradenton",
            "Bremerton",
            "Bridgeport",
            "Brighton",
            "Brownsville",
            "Bryan",
            "Buffalo",
            "Burbank",
            "Burlington",
            "Cambridge",
            "Canton",
            "Cape Coral",
            "Carrollton",
            "Cary",
            "Cathedral City",
            "Cedar Rapids",
            "Champaign",
            "Chandler",
            "Charleston",
            "Charlotte",
            "Chattanooga",
            "Chesapeake",
            "Chicago",
            "Chula Vista",
            "Cincinnati",
            "Clarke County",
            "Clarksville",
            "Clearwater",
            "Cleveland",
            "College Station",
            "Colorado Springs",
            "Columbia",
            "Columbus"});
			this.comboBox1.LabelText = "Select City";
			this.comboBox1.Location = new System.Drawing.Point(384, 158);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(229, 42);
			this.comboBox1.TabIndex = 0;
			// 
			// comboBoxAutoCompleteMode
			// 
			this.comboBoxAutoCompleteMode.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBoxAutoCompleteMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxAutoCompleteMode.LabelText = "Auto Complete Mode";
			this.comboBoxAutoCompleteMode.Location = new System.Drawing.Point(24, 22);
			this.comboBoxAutoCompleteMode.Name = "comboBoxAutoCompleteMode";
			this.comboBoxAutoCompleteMode.Size = new System.Drawing.Size(180, 42);
			this.comboBoxAutoCompleteMode.TabIndex = 1;
			this.comboBoxAutoCompleteMode.Text = "None";
			this.comboBoxAutoCompleteMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutoCompleteMode_SelectedIndexChanged);
			// 
			// comboBoxDropDownStyle
			// 
			this.comboBoxDropDownStyle.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBoxDropDownStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxDropDownStyle.Items.AddRange(new object[] {
            "DropDown",
            "DropDownList"});
			this.comboBoxDropDownStyle.LabelText = "Drop Down Style";
			this.comboBoxDropDownStyle.Location = new System.Drawing.Point(24, 111);
			this.comboBoxDropDownStyle.Name = "comboBoxDropDownStyle";
			this.comboBoxDropDownStyle.Size = new System.Drawing.Size(180, 42);
			this.comboBoxDropDownStyle.TabIndex = 2;
			this.comboBoxDropDownStyle.Text = "DropDown";
			this.comboBoxDropDownStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxDropDownStyle_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Dashed;
			this.panel1.Controls.Add(this.comboBoxDropDownStyle);
			this.panel1.Controls.Add(this.comboBoxAutoCompleteMode);
			this.panel1.Location = new System.Drawing.Point(52, 90);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(230, 189);
			this.panel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Configuration";
			// 
			// AutoComplete
			// 
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.comboBox1);
			this.MinimumSize = new System.Drawing.Size(574, 222);
			this.Name = "AutoComplete";
			this.Size = new System.Drawing.Size(665, 348);
			this.Load += new System.EventHandler(this.AutoComplete_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.ComboBox comboBox1;
        private Web.ComboBox comboBoxAutoCompleteMode;
        private Web.ComboBox comboBoxDropDownStyle;
        private Web.Panel panel1;
        private Web.Label label1;
    }
}
