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
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.tagAllowDuplicates = new Wisej.Web.TagTextBox();
			this.chkAutoSize = new Wisej.Web.CheckBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tagDefault
			// 
			this.tagDefault.Anchor = Wisej.Web.AnchorStyles.None;
			this.flowLayoutPanel1.SetFillWeight(this.tagDefault, 1);
			this.tagDefault.LabelText = "Default TagTextBox";
			this.tagDefault.Location = new System.Drawing.Point(3, 3);
			this.tagDefault.Name = "tagDefault";
			this.tagDefault.Size = new System.Drawing.Size(287, 42);
			this.tagDefault.TabIndex = 0;
			this.tagDefault.TagRemoved += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Removed);
			this.tagDefault.TagRejected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Rejected);
			this.tagDefault.TagSelected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Selected);
			// 
			// tagCustomRender
			// 
			this.tagCustomRender.Anchor = Wisej.Web.AnchorStyles.None;
			this.flowLayoutPanel1.SetFillWeight(this.tagCustomRender, 1);
			this.tagCustomRender.LabelText = "Custom Tag Rendering";
			this.tagCustomRender.Location = new System.Drawing.Point(296, 3);
			this.tagCustomRender.Name = "tagCustomRender";
			this.tagCustomRender.Size = new System.Drawing.Size(286, 42);
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
			this.flowLayoutPanel1.SetFillWeight(this.tagAutoComplete, 1);
			this.tagAutoComplete.LabelText = "Auto Complete";
			this.tagAutoComplete.Location = new System.Drawing.Point(588, 3);
			this.tagAutoComplete.Name = "tagAutoComplete";
			this.tagAutoComplete.Size = new System.Drawing.Size(286, 42);
			this.tagAutoComplete.TabIndex = 2;
			this.tagAutoComplete.Text = "Alabama,\r\nAlaska,\r\nAmerican Samoa,\r\nArizona,";
			this.tagAutoComplete.TagAdded += new Wisej.Web.TagTextBoxEventHandler(this.tagAutoComplete_TagAdded);
			this.tagAutoComplete.TagRemoved += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Removed);
			this.tagAutoComplete.TagRejected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Rejected);
			this.tagAutoComplete.TagSelected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Selected);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.tagDefault);
			this.flowLayoutPanel1.Controls.Add(this.tagCustomRender);
			this.flowLayoutPanel1.Controls.Add(this.tagAutoComplete);
			this.flowLayoutPanel1.Controls.Add(this.tagAllowDuplicates);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(202, 206);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1169, 63);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// tagAllowDuplicates
			// 
			this.tagAllowDuplicates.AllowDuplicateTags = true;
			this.tagAllowDuplicates.Anchor = Wisej.Web.AnchorStyles.None;
			this.flowLayoutPanel1.SetFillWeight(this.tagAllowDuplicates, 1);
			this.tagAllowDuplicates.LabelText = "AllowDuplicateTags";
			this.tagAllowDuplicates.Location = new System.Drawing.Point(880, 3);
			this.tagAllowDuplicates.Name = "tagAllowDuplicates";
			this.tagAllowDuplicates.Size = new System.Drawing.Size(286, 42);
			this.tagAllowDuplicates.TabIndex = 3;
			this.tagAllowDuplicates.Text = "AA,\r\nAA,\r\nAL,\r\nAL,\r\nTX,\r\nTX,";
			this.tagAllowDuplicates.TagRemoved += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Rejected);
			this.tagAllowDuplicates.TagSelected += new Wisej.Web.TagTextBoxEventHandler(this.Tag_Selected);
			// 
			// chkAutoSize
			// 
			this.chkAutoSize.Anchor = Wisej.Web.AnchorStyles.None;
			this.chkAutoSize.Checked = true;
			this.chkAutoSize.Location = new System.Drawing.Point(44, 229);
			this.chkAutoSize.Name = "chkAutoSize";
			this.chkAutoSize.Size = new System.Drawing.Size(129, 22);
			this.chkAutoSize.TabIndex = 4;
			this.chkAutoSize.Text = "Enable AutoSize";
			this.chkAutoSize.CheckedChanged += new System.EventHandler(this.chkAutoSize_CheckedChanged);
			// 
			// Features
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.chkAutoSize);
			this.Controls.Add(this.flowLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(903, 315);
			this.Name = "Features";
			this.Load += new System.EventHandler(this.Features_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.TagTextBox tagDefault;
		private Web.TagTextBox tagCustomRender;
		private Web.TagTextBox tagAutoComplete;
        private Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.TagTextBox tagAllowDuplicates;
		private Web.CheckBox chkAutoSize;
	}
}
