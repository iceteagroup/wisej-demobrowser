namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class MultiSelect
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
            this.multiSelect1 = new Wisej.Web.Ext.Syncfusion2.MultiSelect();
            this.checkBoxCustomValue = new Wisej.Web.CheckBox();
            this.checkBoxChangeOnBlur = new Wisej.Web.CheckBox();
            this.checkBoxClosePopupOnSelect = new Wisej.Web.CheckBox();
            this.checkBoxHideSelectedItem = new Wisej.Web.CheckBox();
            this.checkBoxOpenOnClick = new Wisej.Web.CheckBox();
            this.comboBoxMode = new Wisej.Web.ComboBox();
            this.checkBoxClearButton = new Wisej.Web.CheckBox();
            this.checkBoxDropDownIcon = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/multi-select/es5-getting-star" +
    "ted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/multi-select/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDropDownIcon);
            this.groupBox1.Controls.Add(this.checkBoxClearButton);
            this.groupBox1.Controls.Add(this.comboBoxMode);
            this.groupBox1.Controls.Add(this.checkBoxOpenOnClick);
            this.groupBox1.Controls.Add(this.checkBoxHideSelectedItem);
            this.groupBox1.Controls.Add(this.checkBoxClosePopupOnSelect);
            this.groupBox1.Controls.Add(this.checkBoxChangeOnBlur);
            this.groupBox1.Controls.Add(this.checkBoxCustomValue);
            this.groupBox1.Size = new System.Drawing.Size(250, 370);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxCustomValue, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxChangeOnBlur, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxClosePopupOnSelect, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxHideSelectedItem, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxOpenOnClick, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxMode, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxClearButton, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxDropDownIcon, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 289);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.multiSelect1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/multi-select/default.html";
            // 
            // multiSelect1
            // 
            this.multiSelect1.Anchor = Wisej.Web.AnchorStyles.None;
            this.multiSelect1.Location = new System.Drawing.Point(459, 229);
            this.multiSelect1.Name = "multiSelect1";
            this.multiSelect1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"dataSource\":[\"Badminton\",\"Cricket\",\"Football\",\"Golf\",\"Tennis\"]}")));
            this.multiSelect1.Size = new System.Drawing.Size(350, 35);
            this.multiSelect1.TabIndex = 0;
            this.multiSelect1.Text = "multiSelect1";
            // 
            // checkBoxCustomValue
            // 
            this.checkBoxCustomValue.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxCustomValue.Location = new System.Drawing.Point(20, 24);
            this.checkBoxCustomValue.Name = "checkBoxCustomValue";
            this.checkBoxCustomValue.Size = new System.Drawing.Size(164, 24);
            this.checkBoxCustomValue.TabIndex = 1;
            this.checkBoxCustomValue.Text = "Allow custom value";
            // 
            // checkBoxChangeOnBlur
            // 
            this.checkBoxChangeOnBlur.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxChangeOnBlur.Location = new System.Drawing.Point(20, 52);
            this.checkBoxChangeOnBlur.Name = "checkBoxChangeOnBlur";
            this.checkBoxChangeOnBlur.Size = new System.Drawing.Size(141, 24);
            this.checkBoxChangeOnBlur.TabIndex = 2;
            this.checkBoxChangeOnBlur.Text = "Change on blur";
            // 
            // checkBoxClosePopupOnSelect
            // 
            this.checkBoxClosePopupOnSelect.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxClosePopupOnSelect.Location = new System.Drawing.Point(20, 80);
            this.checkBoxClosePopupOnSelect.Name = "checkBoxClosePopupOnSelect";
            this.checkBoxClosePopupOnSelect.Size = new System.Drawing.Size(181, 24);
            this.checkBoxClosePopupOnSelect.TabIndex = 3;
            this.checkBoxClosePopupOnSelect.Text = "Close popup on select";
            // 
            // checkBoxHideSelectedItem
            // 
            this.checkBoxHideSelectedItem.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxHideSelectedItem.Location = new System.Drawing.Point(20, 108);
            this.checkBoxHideSelectedItem.Name = "checkBoxHideSelectedItem";
            this.checkBoxHideSelectedItem.Size = new System.Drawing.Size(159, 24);
            this.checkBoxHideSelectedItem.TabIndex = 4;
            this.checkBoxHideSelectedItem.Text = "Hide selected item ";
            // 
            // checkBoxOpenOnClick
            // 
            this.checkBoxOpenOnClick.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxOpenOnClick.Location = new System.Drawing.Point(20, 136);
            this.checkBoxOpenOnClick.Name = "checkBoxOpenOnClick";
            this.checkBoxOpenOnClick.Size = new System.Drawing.Size(131, 24);
            this.checkBoxOpenOnClick.TabIndex = 7;
            this.checkBoxOpenOnClick.Text = "Open on click";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Box",
            "Delimiter",
            "Default",
            "CheckBox"});
            this.comboBoxMode.LabelText = "Mode";
            this.comboBoxMode.Location = new System.Drawing.Point(24, 223);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(195, 42);
            this.comboBoxMode.TabIndex = 8;
            // 
            // checkBoxClearButton
            // 
            this.checkBoxClearButton.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxClearButton.Location = new System.Drawing.Point(20, 164);
            this.checkBoxClearButton.Name = "checkBoxClearButton";
            this.checkBoxClearButton.Size = new System.Drawing.Size(157, 24);
            this.checkBoxClearButton.TabIndex = 9;
            this.checkBoxClearButton.Text = "Show clear button";
            // 
            // checkBoxDropDownIcon
            // 
            this.checkBoxDropDownIcon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDropDownIcon.Location = new System.Drawing.Point(20, 192);
            this.checkBoxDropDownIcon.Name = "checkBoxDropDownIcon";
            this.checkBoxDropDownIcon.Size = new System.Drawing.Size(173, 24);
            this.checkBoxDropDownIcon.TabIndex = 10;
            this.checkBoxDropDownIcon.Text = "Show dropdown icon";
            // 
            // MultiSelect
            // 
            this.Name = "MultiSelect";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.MultiSelect multiSelect1;
        private CheckBox checkBoxOpenOnClick;
        private CheckBox checkBoxHideSelectedItem;
        private CheckBox checkBoxClosePopupOnSelect;
        private CheckBox checkBoxChangeOnBlur;
        private CheckBox checkBoxCustomValue;
        private ComboBox comboBoxMode;
        private CheckBox checkBoxClearButton;
        private CheckBox checkBoxDropDownIcon;
    }
}
