namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxHtmlEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxHtmlEditor));
            this.dxHtmlEditor1 = new Wisej.Web.Ext.DevExtreme.dxHtmlEditor();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.userComboBox1 = new Wisej.Web.UserComboBox();
            this.checkedListBox1 = new Wisej.Web.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/HtmlEditor/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(16, 476);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/HtmlEditor/Overview/jQuery/Li" +
    "ght/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxHtmlEditor/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxHtmlEditor1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.userComboBox1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkedListBox1);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 490);
            // 
            // dxHtmlEditor1
            // 
            this.dxHtmlEditor1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxHtmlEditor1.Location = new System.Drawing.Point(26, 25);
            this.dxHtmlEditor1.Name = "dxHtmlEditor1";
            this.dxHtmlEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxHtmlEditor1.Options"))));
            this.dxHtmlEditor1.Size = new System.Drawing.Size(1037, 507);
            this.dxHtmlEditor1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "html",
            "markdown"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Value Type";
            this.comboBox1.Location = new System.Drawing.Point(3, 196);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "html";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 38);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Is Valid";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 60);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 38);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Media Resizing";
            // 
            // userComboBox1
            // 
            this.userComboBox1.AutoSize = false;
            this.userComboBox1.DropDownControl = this.checkedListBox1;
            this.flowLayoutPanel1.SetFillWeight(this.userComboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.userComboBox1, true);
            this.userComboBox1.LabelText = "Toolbar Items";
            this.userComboBox1.Location = new System.Drawing.Point(3, 117);
            this.userComboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.userComboBox1.Name = "userComboBox1";
            this.userComboBox1.Size = new System.Drawing.Size(212, 60);
            this.userComboBox1.TabIndex = 16;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "background",
            "bold",
            "color",
            "italic",
            "link",
            "image",
            "strike",
            "subscript",
            "superscript",
            "underline",
            "blockquote",
            "header",
            "increaseIndent",
            "decreaseIndent",
            "orderedList",
            "bulletList",
            "alignLeft",
            "alignCenter",
            "alignRight",
            "alignJustify",
            "codeBlock",
            "variable",
            "separator",
            "undo",
            "redo",
            "clear"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 262);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(195, 201);
            this.checkedListBox1.TabIndex = 15;
            this.checkedListBox1.AfterItemCheck += new Wisej.Web.ItemCheckEventHandler(this.checkedListBox1_AfterItemCheck);
            // 
            // dxHtmlEditor
            // 
            this.Name = "dxHtmlEditor";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxHtmlEditor dxHtmlEditor1;
        private ComboBox comboBox1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private UserComboBox userComboBox1;
		private CheckedListBox checkedListBox1;
	}
}
