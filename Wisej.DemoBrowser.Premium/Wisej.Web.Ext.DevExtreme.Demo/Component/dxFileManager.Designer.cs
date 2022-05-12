namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxFileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxFileManager));
            this.dxFileManager1 = new Wisej.Web.Ext.DevExtreme.dxFileManager();
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
            this.linkDocs.Size = new System.Drawing.Size(1028, 24);
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/UI_Components/FileManager/Getting_S" +
    "tarted_with_File_Manager/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/FileManager/Overview/jQuery/L" +
    "ight/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxFileManager/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxFileManager1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.userComboBox1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkedListBox1);
            // 
            // dxFileManager1
            // 
            this.dxFileManager1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxFileManager1.Location = new System.Drawing.Point(11, 11);
            this.dxFileManager1.Name = "dxFileManager1";
            this.dxFileManager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxFileManager1.Options"))));
            this.dxFileManager1.Size = new System.Drawing.Size(866, 550);
            this.dxFileManager1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "details",
            "thumbnails"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Item View Mode";
            this.comboBox1.Location = new System.Drawing.Point(3, 196);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Details";
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
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show Folders";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 60);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 38);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Active State Enabled";
            // 
            // userComboBox1
            // 
            this.userComboBox1.AutoSize = false;
            this.userComboBox1.DropDownControl = this.checkedListBox1;
            this.userComboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.userComboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.userComboBox1, true);
            this.userComboBox1.LabelText = "Allowed File Extensions";
            this.userComboBox1.Location = new System.Drawing.Point(3, 117);
            this.userComboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.userComboBox1.Name = "userComboBox1";
            this.userComboBox1.Size = new System.Drawing.Size(212, 60);
            this.userComboBox1.TabIndex = 14;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            ".txt",
            ".rtf",
            ".doc",
            ".docx",
            ".odt",
            ".xls",
            ".xlsx",
            ".ods",
            ".ppt",
            ".pptx",
            ".pdf",
            ".xml",
            ".png",
            ".jpg",
            ".jpeg",
            ".ico",
            ".bmp"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 262);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(195, 143);
            this.checkedListBox1.TabIndex = 8;
            this.checkedListBox1.AfterItemCheck += new Wisej.Web.ItemCheckEventHandler(this.checkedListBox1_AfterItemCheck);
            // 
            // dxFileManager
            // 
            this.Name = "dxFileManager";
            this.Load += new System.EventHandler(this.dxFileManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxFileManager dxFileManager1;
        private ComboBox comboBox1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private UserComboBox userComboBox1;
		private CheckedListBox checkedListBox1;
	}
}
