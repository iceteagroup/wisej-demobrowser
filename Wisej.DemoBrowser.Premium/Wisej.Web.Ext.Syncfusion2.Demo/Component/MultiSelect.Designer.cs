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
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/multi-select/es5-getting-star" +
    "ted/";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/multi-select/";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.multiSelect1);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBoxCustomValue);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxChangeOnBlur);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxClosePopupOnSelect);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxHideSelectedItem);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxOpenOnClick);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxClearButton);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxDropDownIcon);
			this.flowLayoutPanel1.Controls.Add(this.comboBoxMode);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/multi-select/default.html";
			// 
			// multiSelect1
			// 
			this.multiSelect1.Anchor = Wisej.Web.AnchorStyles.None;
			this.multiSelect1.Location = new System.Drawing.Point(269, 268);
			this.multiSelect1.Name = "multiSelect1";
			this.multiSelect1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"dataSource\":[\"Badminton\",\"Cricket\",\"Football\",\"Golf\",\"Tennis\"]}")));
			this.multiSelect1.Size = new System.Drawing.Size(350, 40);
			this.multiSelect1.TabIndex = 0;
			this.multiSelect1.Text = "multiSelect1";
			// 
			// checkBoxCustomValue
			// 
			this.checkBoxCustomValue.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxCustomValue.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxCustomValue, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxCustomValue, true);
			this.checkBoxCustomValue.Location = new System.Drawing.Point(3, 3);
			this.checkBoxCustomValue.Name = "checkBoxCustomValue";
			this.checkBoxCustomValue.Size = new System.Drawing.Size(212, 24);
			this.checkBoxCustomValue.TabIndex = 1;
			this.checkBoxCustomValue.Text = "Allow Custom Value";
			// 
			// checkBoxChangeOnBlur
			// 
			this.checkBoxChangeOnBlur.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxChangeOnBlur.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxChangeOnBlur, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxChangeOnBlur, true);
			this.checkBoxChangeOnBlur.Location = new System.Drawing.Point(3, 46);
			this.checkBoxChangeOnBlur.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxChangeOnBlur.Name = "checkBoxChangeOnBlur";
			this.checkBoxChangeOnBlur.Size = new System.Drawing.Size(212, 24);
			this.checkBoxChangeOnBlur.TabIndex = 2;
			this.checkBoxChangeOnBlur.Text = "Change on Blur";
			// 
			// checkBoxClosePopupOnSelect
			// 
			this.checkBoxClosePopupOnSelect.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxClosePopupOnSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxClosePopupOnSelect, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxClosePopupOnSelect, true);
			this.checkBoxClosePopupOnSelect.Location = new System.Drawing.Point(3, 89);
			this.checkBoxClosePopupOnSelect.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxClosePopupOnSelect.Name = "checkBoxClosePopupOnSelect";
			this.checkBoxClosePopupOnSelect.Size = new System.Drawing.Size(212, 24);
			this.checkBoxClosePopupOnSelect.TabIndex = 3;
			this.checkBoxClosePopupOnSelect.Text = "Close Popup on Select";
			// 
			// checkBoxHideSelectedItem
			// 
			this.checkBoxHideSelectedItem.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxHideSelectedItem.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxHideSelectedItem, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxHideSelectedItem, true);
			this.checkBoxHideSelectedItem.Location = new System.Drawing.Point(3, 132);
			this.checkBoxHideSelectedItem.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxHideSelectedItem.Name = "checkBoxHideSelectedItem";
			this.checkBoxHideSelectedItem.Size = new System.Drawing.Size(212, 24);
			this.checkBoxHideSelectedItem.TabIndex = 4;
			this.checkBoxHideSelectedItem.Text = "Hide Selected Item ";
			// 
			// checkBoxOpenOnClick
			// 
			this.checkBoxOpenOnClick.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxOpenOnClick.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxOpenOnClick, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxOpenOnClick, true);
			this.checkBoxOpenOnClick.Location = new System.Drawing.Point(3, 175);
			this.checkBoxOpenOnClick.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxOpenOnClick.Name = "checkBoxOpenOnClick";
			this.checkBoxOpenOnClick.Size = new System.Drawing.Size(212, 24);
			this.checkBoxOpenOnClick.TabIndex = 7;
			this.checkBoxOpenOnClick.Text = "Open on Click";
			// 
			// comboBoxMode
			// 
			this.comboBoxMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanel1.SetFillWeight(this.comboBoxMode, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.comboBoxMode, true);
			this.comboBoxMode.Items.AddRange(new object[] {
            "Box",
            "Delimiter",
            "Default",
            "CheckBox"});
			this.comboBoxMode.LabelText = "Mode";
			this.comboBoxMode.Location = new System.Drawing.Point(3, 304);
			this.comboBoxMode.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBoxMode.Name = "comboBoxMode";
			this.comboBoxMode.Size = new System.Drawing.Size(212, 51);
			this.comboBoxMode.TabIndex = 8;
			this.comboBoxMode.Text = "Default";
			// 
			// checkBoxClearButton
			// 
			this.checkBoxClearButton.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxClearButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxClearButton, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxClearButton, true);
			this.checkBoxClearButton.Location = new System.Drawing.Point(3, 218);
			this.checkBoxClearButton.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxClearButton.Name = "checkBoxClearButton";
			this.checkBoxClearButton.Size = new System.Drawing.Size(212, 24);
			this.checkBoxClearButton.TabIndex = 9;
			this.checkBoxClearButton.Text = "Show clear Button";
			// 
			// checkBoxDropDownIcon
			// 
			this.checkBoxDropDownIcon.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxDropDownIcon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxDropDownIcon, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxDropDownIcon, true);
			this.checkBoxDropDownIcon.Location = new System.Drawing.Point(3, 261);
			this.checkBoxDropDownIcon.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxDropDownIcon.Name = "checkBoxDropDownIcon";
			this.checkBoxDropDownIcon.Size = new System.Drawing.Size(212, 24);
			this.checkBoxDropDownIcon.TabIndex = 10;
			this.checkBoxDropDownIcon.Text = "Show Dropdown Icon";
			// 
			// MultiSelect
			// 
			this.Name = "MultiSelect";
			this.Load += new System.EventHandler(this.MultiSelect_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

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
