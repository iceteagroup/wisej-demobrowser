namespace Wisej.DemoBrowser.TagTextBox
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
			this.tagDefault = new Wisej.Web.TagTextBox();
			this.tagCustomRender = new Wisej.Web.TagTextBox();
			this.tagAutoComplete = new Wisej.Web.TagTextBox();
			this.SuspendLayout();
			// 
			// tagDefault
			// 
			this.tagDefault.Anchor = Wisej.Web.AnchorStyles.None;
			this.tagDefault.LabelText = "Default TagTextBox";
			this.tagDefault.Location = new System.Drawing.Point(281, 42);
			this.tagDefault.Name = "tagDefault";
			this.tagDefault.Size = new System.Drawing.Size(253, 51);
			this.tagDefault.TabIndex = 0;
			this.tagDefault.TagRemoved += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Removed);
			this.tagDefault.TagRejected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Rejected);
			this.tagDefault.TagSelected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Selected);
			// 
			// tagCustomRender
			// 
			this.tagCustomRender.Anchor = Wisej.Web.AnchorStyles.None;
			this.tagCustomRender.LabelText = "Custom Tag Rendering";
			this.tagCustomRender.Location = new System.Drawing.Point(600, 42);
			this.tagCustomRender.Name = "tagCustomRender";
			this.tagCustomRender.Size = new System.Drawing.Size(253, 51);
			this.tagCustomRender.TabIndex = 1;
			this.tagCustomRender.TagRemoved += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Removed);
			this.tagCustomRender.TagRejected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Rejected);
			this.tagCustomRender.TagSelected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Selected);
			this.tagCustomRender.TagRender += new Wisej.Web.TagTextBoxRenderEventHandler(this.tagTextBox2_TagRender);
			// 
			// tagAutoComplete
			// 
			this.tagAutoComplete.Anchor = Wisej.Web.AnchorStyles.None;
			this.tagAutoComplete.AutoCompleteList = new string[] {
        "Alabama",
        "Alaska",
        "American Samoa",
        "Arizona",
        "Arkansas",
        "California",
        "Colorado",
        "Connecticut",
        "Delaware",
        "District of Columbia",
        "Florida",
        "Georgia",
        "Guam",
        "Hawaii",
        "Idaho",
        "Illinois",
        "Indiana",
        "Iowa",
        "Kansas",
        "Kentucky",
        "Louisiana",
        "Maine",
        "Maryland",
        "Massachusetts",
        "Michigan",
        "Minnesota",
        "Minor Outlying Islands",
        "Mississippi",
        "Missouri",
        "Montana",
        "Nebraska",
        "Nevada",
        "New Hampshire",
        "New Jersey",
        "New Mexico",
        "New York",
        "North Carolina",
        "North Dakota",
        "Northern Mariana Islands",
        "Ohio",
        "Oklahoma",
        "Oregon",
        "Pennsylvania",
        "Puerto Rico",
        "Rhode Island",
        "South Carolina",
        "South Dakota",
        "Tennessee",
        "Texas",
        "U.S. Virgin Islands",
        "Utah",
        "Vermont",
        "Virginia",
        "Washington",
        "West Virginia",
        "Wisconsin",
        "Wyoming"};
			this.tagAutoComplete.LabelText = "Auto Complete TagTextBox";
			this.tagAutoComplete.Location = new System.Drawing.Point(889, 42);
			this.tagAutoComplete.Name = "tagAutoComplete";
			this.tagAutoComplete.Size = new System.Drawing.Size(253, 51);
			this.tagAutoComplete.TabIndex = 2;
			this.tagAutoComplete.Text = "Alabama,\r\nAlaska,\r\nAmerican Samoa,\r\nArizona,";
			this.tagAutoComplete.TagAdded += new Wisej.Web.TagTextBoxEventHandler(this.tagAutoComplete_TagAdded);
			this.tagAutoComplete.TagRemoved += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Removed);
			this.tagAutoComplete.TagRejected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Rejected);
			this.tagAutoComplete.TagSelected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Selected);
			// 
			// Features
			// 
			this.Controls.Add(this.tagAutoComplete);
			this.Controls.Add(this.tagCustomRender);
			this.Controls.Add(this.tagDefault);
			this.Name = "Features";
			this.Load += new System.EventHandler(this.Features_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.TagTextBox tagDefault;
		private Web.TagTextBox tagCustomRender;
		private Web.TagTextBox tagAutoComplete;
	}
}
