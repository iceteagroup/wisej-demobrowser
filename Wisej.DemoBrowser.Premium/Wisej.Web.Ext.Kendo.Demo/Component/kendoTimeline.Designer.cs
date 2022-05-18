namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoTimeline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoTimeline));
            this.kendoTimeline1 = new Wisej.Web.Ext.Kendo.kendoTimeline();
            this.comboBoxOrientation = new Wisej.Web.ComboBox();
            this.checkBoxShowDateLabel = new Wisej.Web.CheckBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoTimeline1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/timeline/index";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/timeline";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/timeline/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxShowDateLabel);
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxOrientation);
            // 
            // kendoTimeline1
            // 
            this.kendoTimeline1.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoTimeline1.Location = new System.Drawing.Point(8, 8);
            this.kendoTimeline1.Name = "kendoTimeline1";
            this.kendoTimeline1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoTimeline1.Options"))));
            this.kendoTimeline1.Size = new System.Drawing.Size(872, 560);
            this.kendoTimeline1.TabIndex = 0;
            this.kendoTimeline1.Text = "kendoTimeline1";
            // 
            // comboBoxOrientation
            // 
            this.comboBoxOrientation.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxOrientation.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.comboBoxOrientation.LabelText = "Orientation";
            this.comboBoxOrientation.Location = new System.Drawing.Point(3, 48);
            this.comboBoxOrientation.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxOrientation.Name = "comboBoxOrientation";
            this.comboBoxOrientation.Size = new System.Drawing.Size(212, 57);
            this.comboBoxOrientation.TabIndex = 0;
            // 
            // checkBoxShowDateLabel
            // 
            this.checkBoxShowDateLabel.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxShowDateLabel.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowDateLabel.AutoSize = false;
            this.checkBoxShowDateLabel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowDateLabel.Checked = true;
            this.checkBoxShowDateLabel.Location = new System.Drawing.Point(3, 3);
            this.checkBoxShowDateLabel.Name = "checkBoxShowDateLabel";
            this.checkBoxShowDateLabel.Size = new System.Drawing.Size(213, 26);
            this.checkBoxShowDateLabel.TabIndex = 1;
            this.checkBoxShowDateLabel.Text = "Show Date Label";
            // 
            // kendoTimeline
            // 
            this.Name = "kendoTimeline";
            this.Size = new System.Drawing.Size(1320, 699);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoTimeline kendoTimeline1;
        private ComboBox comboBoxOrientation;
        private CheckBox checkBoxShowDateLabel;
    }
}
