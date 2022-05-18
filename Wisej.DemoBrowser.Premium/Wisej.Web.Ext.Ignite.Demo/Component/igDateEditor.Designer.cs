namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igDateEditor
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
            this.igDateEditor1 = new Wisej.Web.Ext.Ignite.igDateEditor();
            this.comboBoxButtonType = new Wisej.Web.ComboBox();
            this.comboBoxSelectionOnFocus = new Wisej.Web.ComboBox();
            this.buttonGetSelectedDate = new Wisej.Web.Button();
            this.comboBoxDataMode = new Wisej.Web.ComboBox();
            this.checkBoxRevertIfNotValid = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igDateEditor1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/editors/date-editor";
            // 
            // linkAPI
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igdateeditor";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igeditors-landingpage";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxRevertIfNotValid);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxButtonType);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxSelectionOnFocus);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxDataMode);
            this.flowLayoutPanel1.Controls.Add(this.buttonGetSelectedDate);
            // 
            // igDateEditor1
            // 
            this.igDateEditor1.Anchor = Wisej.Web.AnchorStyles.None;
            this.igDateEditor1.Location = new System.Drawing.Point(394, 259);
            this.igDateEditor1.Name = "igDateEditor1";
            this.igDateEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"dateInputFormat\":\"dateTime\",\"value\":\"2020-01-01\",\"dataMode\":\"date\"}")));
            this.igDateEditor1.Size = new System.Drawing.Size(300, 40);
            this.igDateEditor1.TabIndex = 0;
            this.igDateEditor1.Text = "igDateEditor1";
            // 
            // comboBoxButtonType
            // 
            this.comboBoxButtonType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxButtonType, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxButtonType, true);
            this.comboBoxButtonType.Items.AddRange(new object[] {
            "none",
            "clear",
            "spin"});
            this.comboBoxButtonType.LabelText = "Button Type";
            this.comboBoxButtonType.Location = new System.Drawing.Point(3, 60);
            this.comboBoxButtonType.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxButtonType.Name = "comboBoxButtonType";
            this.comboBoxButtonType.Size = new System.Drawing.Size(212, 57);
            this.comboBoxButtonType.TabIndex = 1;
            this.comboBoxButtonType.Text = "none";
            // 
            // comboBoxSelectionOnFocus
            // 
            this.comboBoxSelectionOnFocus.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxSelectionOnFocus, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxSelectionOnFocus, true);
            this.comboBoxSelectionOnFocus.Items.AddRange(new object[] {
            "selectAll",
            "atStart",
            "atEnd",
            "browserDefault"});
            this.comboBoxSelectionOnFocus.LabelText = "Selection on Focus";
            this.comboBoxSelectionOnFocus.Location = new System.Drawing.Point(3, 136);
            this.comboBoxSelectionOnFocus.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxSelectionOnFocus.Name = "comboBoxSelectionOnFocus";
            this.comboBoxSelectionOnFocus.Size = new System.Drawing.Size(212, 57);
            this.comboBoxSelectionOnFocus.TabIndex = 2;
            this.comboBoxSelectionOnFocus.Text = "selectAll";
            // 
            // buttonGetSelectedDate
            // 
            this.flowLayoutPanel1.SetFillWeight(this.buttonGetSelectedDate, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.buttonGetSelectedDate, true);
            this.buttonGetSelectedDate.Location = new System.Drawing.Point(3, 288);
            this.buttonGetSelectedDate.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonGetSelectedDate.Name = "buttonGetSelectedDate";
            this.buttonGetSelectedDate.Size = new System.Drawing.Size(212, 40);
            this.buttonGetSelectedDate.TabIndex = 4;
            this.buttonGetSelectedDate.Text = "Get Selected Date";
            this.buttonGetSelectedDate.Click += new System.EventHandler(this.buttonGetSelectedDate_Click);
            // 
            // comboBoxDataMode
            // 
            this.comboBoxDataMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxDataMode, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxDataMode, true);
            this.comboBoxDataMode.Items.AddRange(new object[] {
            "date",
            "displayModeText",
            "editModeText"});
            this.comboBoxDataMode.LabelText = "Data Mode";
            this.comboBoxDataMode.Location = new System.Drawing.Point(3, 212);
            this.comboBoxDataMode.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxDataMode.Name = "comboBoxDataMode";
            this.comboBoxDataMode.Size = new System.Drawing.Size(212, 57);
            this.comboBoxDataMode.TabIndex = 3;
            this.comboBoxDataMode.Text = "date";
            // 
            // checkBoxRevertIfNotValid
            // 
            this.checkBoxRevertIfNotValid.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxRevertIfNotValid.AutoSize = false;
            this.checkBoxRevertIfNotValid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRevertIfNotValid.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxRevertIfNotValid, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxRevertIfNotValid, true);
            this.checkBoxRevertIfNotValid.Location = new System.Drawing.Point(3, 3);
            this.checkBoxRevertIfNotValid.Name = "checkBoxRevertIfNotValid";
            this.checkBoxRevertIfNotValid.Size = new System.Drawing.Size(212, 38);
            this.checkBoxRevertIfNotValid.TabIndex = 0;
            this.checkBoxRevertIfNotValid.Text = "Revert if Not Valid";
            // 
            // igDateEditor
            // 
            this.Name = "igDateEditor";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Ignite.igDateEditor igDateEditor1;
		private ComboBox comboBoxButtonType;
		private ComboBox comboBoxSelectionOnFocus;
		private Button buttonGetSelectedDate;
		private ComboBox comboBoxDataMode;
		private CheckBox checkBoxRevertIfNotValid;
	}
}
