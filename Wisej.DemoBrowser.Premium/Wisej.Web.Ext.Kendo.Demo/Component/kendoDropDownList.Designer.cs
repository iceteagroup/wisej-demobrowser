﻿namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDropDownList
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
            this.kendoDropDownListColor = new Wisej.Web.Ext.Kendo.kendoDropDownList();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.label4 = new Wisej.Web.Label();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.label5 = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.kendoDropDownListSize = new Wisej.Web.Ext.Kendo.kendoDropDownList();
            this.comboBoxFilter = new Wisej.Web.ComboBox();
            this.checkBoxIgnoreCase = new Wisej.Web.CheckBox();
            this.label1 = new Wisej.Web.Label();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.flowLayoutPanel1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.spacer1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.flowLayoutPanelProperties, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/dropdownlist/index";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/dropdownlist";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/dropdownlist/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxIgnoreCase);
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxFilter);
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(218, 403);
            // 
            // kendoDropDownListColor
            // 
            this.kendoDropDownListColor.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.SetFillWeight(this.kendoDropDownListColor, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.kendoDropDownListColor, true);
            this.kendoDropDownListColor.Location = new System.Drawing.Point(19, 246);
            this.kendoDropDownListColor.Name = "kendoDropDownListColor";
            this.kendoDropDownListColor.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"optionLabel\":\"Select a Color...\"}")));
            this.kendoDropDownListColor.Size = new System.Drawing.Size(324, 30);
            this.kendoDropDownListColor.TabIndex = 0;
            this.kendoDropDownListColor.Text = "kendoDropDownList1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = Wisej.Web.AnchorStyles.None;
            this.flowLayoutPanel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.kendoDropDownListColor);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.kendoDropDownListSize);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(262, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(16);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 356);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.flowLayoutPanel1.SetFillWeight(this.label4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.label4, true);
            this.label4.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Margin = new Wisej.Web.Padding(3, 3, 3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customize your Kendo Cap";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanel1.SetFillWeight(this.pictureBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.pictureBox1, true);
            this.pictureBox1.ImageSource = "Images\\DropDownList\\orange-cap.png";
            this.pictureBox1.Location = new System.Drawing.Point(19, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 159);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.flowLayoutPanel1.SetFillWeight(this.label5, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.label5, true);
            this.label5.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(19, 217);
            this.label5.Margin = new Wisej.Web.Padding(3, 3, 3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cap Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.flowLayoutPanel1.SetFillWeight(this.label6, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.label6, true);
            this.label6.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(19, 282);
            this.label6.Margin = new Wisej.Web.Padding(3, 3, 3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cap Size";
            // 
            // kendoDropDownListSize
            // 
            this.kendoDropDownListSize.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.SetFillWeight(this.kendoDropDownListSize, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.kendoDropDownListSize, true);
            this.kendoDropDownListSize.Location = new System.Drawing.Point(19, 311);
            this.kendoDropDownListSize.Name = "kendoDropDownListSize";
            this.kendoDropDownListSize.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"optionLabel\":\"Select a Size...\"}")));
            this.kendoDropDownListSize.Size = new System.Drawing.Size(324, 30);
            this.kendoDropDownListSize.TabIndex = 4;
            this.kendoDropDownListSize.Text = "kendoDropDownList2";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxFilter.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "startswith",
            "endswith",
            "contains"});
            this.comboBoxFilter.LabelText = "Filter";
            this.comboBoxFilter.Location = new System.Drawing.Point(3, 46);
            this.comboBoxFilter.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(212, 57);
            this.comboBoxFilter.TabIndex = 1;
            this.comboBoxFilter.Text = "startswith";
            // 
            // checkBoxIgnoreCase
            // 
            this.checkBoxIgnoreCase.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxIgnoreCase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxIgnoreCase.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxIgnoreCase, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxIgnoreCase, true);
            this.checkBoxIgnoreCase.Location = new System.Drawing.Point(3, 3);
            this.checkBoxIgnoreCase.Name = "checkBoxIgnoreCase";
            this.checkBoxIgnoreCase.Size = new System.Drawing.Size(212, 24);
            this.checkBoxIgnoreCase.TabIndex = 3;
            this.checkBoxIgnoreCase.Text = "Ignore Case";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(239, 116, 47);
            this.label1.CssStyle = "border-radius: 4px;\r\nbox-shadow: rgba(0, 0, 0, 0.1) 0px 1px 3px 0px, rgba(0, 0, 0" +
    ", 0.06) 0px 1px 2px 0px;";
            this.label1.Dock = Wisej.Web.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(16, 441);
            this.label1.Name = "label1";
            this.label1.Padding = new Wisej.Web.Padding(8);
            this.label1.Size = new System.Drawing.Size(218, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Changes only apply to \"Cap Color\".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kendoDropDownList
            // 
            this.Name = "kendoDropDownList";
            this.Load += new System.EventHandler(this.kendoDropDownList_Load);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoDropDownList kendoDropDownListColor;
		private FlowLayoutPanel flowLayoutPanel1;
		private Label label4;
		private PictureBox pictureBox1;
		private Label label5;
		private Label label6;
		private Kendo.kendoDropDownList kendoDropDownListSize;
        private ComboBox comboBoxFilter;
        private CheckBox checkBoxIgnoreCase;
        private Label label1;
    }
}
