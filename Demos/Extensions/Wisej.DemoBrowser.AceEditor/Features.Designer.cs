namespace Wisej.DemoBrowser.AceEditor
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
			this.aceEditor1 = new Wisej.Web.Ext.AceEditor.AceEditor();
			this.checkBoxIndent = new Wisej.Web.CheckBox();
			this.checkBoxGutter = new Wisej.Web.CheckBox();
			this.checkBoxLineNumbers = new Wisej.Web.CheckBox();
			this.comboBoxLanguage = new Wisej.Web.ComboBox();
			this.checkBoxPrintMargin = new Wisej.Web.CheckBox();
			this.comboBoxTheme = new Wisej.Web.ComboBox();
			this.SuspendLayout();
			// 
			// aceEditor1
			// 
			this.aceEditor1.Anchor = Wisej.Web.AnchorStyles.None;
			this.aceEditor1.Location = new System.Drawing.Point(413, 3);
			this.aceEditor1.Name = "aceEditor1";
			this.aceEditor1.Size = new System.Drawing.Size(839, 468);
			this.aceEditor1.TabIndex = 0;
			this.aceEditor1.Text = "aceEditor1";
			// 
			// checkBoxIndent
			// 
			this.checkBoxIndent.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxIndent.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxIndent.AutoSize = false;
			this.checkBoxIndent.Checked = true;
			this.checkBoxIndent.Location = new System.Drawing.Point(171, 20);
			this.checkBoxIndent.Name = "checkBoxIndent";
			this.checkBoxIndent.Size = new System.Drawing.Size(200, 35);
			this.checkBoxIndent.TabIndex = 1;
			this.checkBoxIndent.Text = "Indent Guides";
			this.checkBoxIndent.CheckedChanged += new System.EventHandler(this.checkBoxIndent_CheckedChanged);
			// 
			// checkBoxGutter
			// 
			this.checkBoxGutter.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxGutter.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxGutter.AutoSize = false;
			this.checkBoxGutter.Checked = true;
			this.checkBoxGutter.Location = new System.Drawing.Point(171, 89);
			this.checkBoxGutter.Name = "checkBoxGutter";
			this.checkBoxGutter.Size = new System.Drawing.Size(200, 35);
			this.checkBoxGutter.TabIndex = 2;
			this.checkBoxGutter.Text = "Show Gutter";
			this.checkBoxGutter.CheckedChanged += new System.EventHandler(this.checkBoxGutter_CheckedChanged);
			// 
			// checkBoxLineNumbers
			// 
			this.checkBoxLineNumbers.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxLineNumbers.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxLineNumbers.AutoSize = false;
			this.checkBoxLineNumbers.Checked = true;
			this.checkBoxLineNumbers.Location = new System.Drawing.Point(171, 158);
			this.checkBoxLineNumbers.Name = "checkBoxLineNumbers";
			this.checkBoxLineNumbers.Size = new System.Drawing.Size(200, 35);
			this.checkBoxLineNumbers.TabIndex = 3;
			this.checkBoxLineNumbers.Text = "Show Line Numbers";
			this.checkBoxLineNumbers.CheckedChanged += new System.EventHandler(this.checkBoxLineNumbers_CheckedChanged);
			// 
			// comboBoxLanguage
			// 
			this.comboBoxLanguage.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBoxLanguage.AutoSize = false;
			this.comboBoxLanguage.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxLanguage.Items.AddRange(new object[] {
            "XML",
            "HTML",
            "JavaScript",
            "CSharp"});
			this.comboBoxLanguage.LabelText = "Language";
			this.comboBoxLanguage.Location = new System.Drawing.Point(171, 296);
			this.comboBoxLanguage.Name = "comboBoxLanguage";
			this.comboBoxLanguage.Size = new System.Drawing.Size(200, 60);
			this.comboBoxLanguage.TabIndex = 4;
			this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
			// 
			// checkBoxPrintMargin
			// 
			this.checkBoxPrintMargin.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxPrintMargin.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxPrintMargin.AutoSize = false;
			this.checkBoxPrintMargin.Checked = true;
			this.checkBoxPrintMargin.Location = new System.Drawing.Point(171, 227);
			this.checkBoxPrintMargin.Name = "checkBoxPrintMargin";
			this.checkBoxPrintMargin.Size = new System.Drawing.Size(200, 35);
			this.checkBoxPrintMargin.TabIndex = 5;
			this.checkBoxPrintMargin.Text = "Show Print Margin";
			this.checkBoxPrintMargin.CheckedChanged += new System.EventHandler(this.checkBoxPrintMargin_CheckedChanged);
			// 
			// comboBoxTheme
			// 
			this.comboBoxTheme.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBoxTheme.AutoSize = false;
			this.comboBoxTheme.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxTheme.Items.AddRange(new object[] {
            "ambiance",
            "chaos",
            "chrome",
            "clouds",
            "clouds_midnight",
            "cobalt",
            "crimson_editor",
            "dawn",
            "dracula",
            "dreamweaver",
            "eclipse",
            "github",
            "gob",
            "gruvbox",
            "idle_fingers",
            "iplastic",
            "katzenmilch",
            "kr_theme",
            "kuroir",
            "merbivore",
            "merbivore_soft",
            "mono_industrial",
            "monokai",
            "monokai",
            "nord_dark",
            "one_dark",
            "pastel_on_dark",
            "solarized_dark",
            "solarized_light",
            "sqlserver",
            "terminal",
            "textmate",
            "tomorrow",
            "tomorrow_night",
            "tomorrow_night_blue",
            "tomorrow_night_bright",
            "tomorrow_night_eighties",
            "twilight",
            "vibrant_ink",
            "xcode"});
			this.comboBoxTheme.LabelText = "Theme";
			this.comboBoxTheme.Location = new System.Drawing.Point(171, 390);
			this.comboBoxTheme.Name = "comboBoxTheme";
			this.comboBoxTheme.Size = new System.Drawing.Size(200, 60);
			this.comboBoxTheme.TabIndex = 6;
			this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
			// 
			// Features
			// 
			this.Controls.Add(this.comboBoxTheme);
			this.Controls.Add(this.checkBoxPrintMargin);
			this.Controls.Add(this.comboBoxLanguage);
			this.Controls.Add(this.checkBoxLineNumbers);
			this.Controls.Add(this.checkBoxGutter);
			this.Controls.Add(this.checkBoxIndent);
			this.Controls.Add(this.aceEditor1);
			this.Name = "Features";
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.AceEditor.AceEditor aceEditor1;
		private Web.CheckBox checkBoxIndent;
		private Web.CheckBox checkBoxGutter;
		private Web.CheckBox checkBoxLineNumbers;
		private Web.ComboBox comboBoxLanguage;
		private Web.CheckBox checkBoxPrintMargin;
		private Web.ComboBox comboBoxTheme;
	}
}
