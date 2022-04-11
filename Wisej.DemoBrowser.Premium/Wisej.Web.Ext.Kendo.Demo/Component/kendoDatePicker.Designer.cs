namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDatePicker
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
            this.kendoDatePicker1 = new Wisej.Web.Ext.Kendo.kendoDatePicker();
            this.label4 = new Wisej.Web.Label();
            this.tagTextBoxDisableDate = new Wisej.Web.TagTextBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoDatePicker1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/datepicker/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/datepicker";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/datepicker/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.tagTextBoxDisableDate);
            this.flowLayoutPanelProperties.Controls.Add(this.label4);
            this.flowLayoutPanelProperties.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(218, 437);
            // 
            // kendoDatePicker1
            // 
            this.kendoDatePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoDatePicker1.Location = new System.Drawing.Point(394, 259);
            this.kendoDatePicker1.Name = "kendoDatePicker1";
            this.kendoDatePicker1.Size = new System.Drawing.Size(300, 40);
            this.kendoDatePicker1.TabIndex = 0;
            this.kendoDatePicker1.Text = "kendoDatePicker1";
            // 
            // label4
            // 
            this.label4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 95);
            this.label4.TabIndex = 1;
            this.label4.Text = "You must use that values [\"mo\",\"tu\",\"we\",\"th\",\"fr\",\"sa\",\"su\"] Check doc for more " +
    "details";
            // 
            // tagTextBoxDisableDate
            // 
            this.tagTextBoxDisableDate.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tagTextBoxDisableDate.LabelText = "Disable date";
            this.tagTextBoxDisableDate.Location = new System.Drawing.Point(3, 3);
            this.tagTextBoxDisableDate.Name = "tagTextBoxDisableDate";
            this.tagTextBoxDisableDate.Size = new System.Drawing.Size(212, 52);
            this.tagTextBoxDisableDate.TabIndex = 2;
            // 
            // kendoDatePicker
            // 
            this.Name = "kendoDatePicker";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDatePicker kendoDatePicker1;
        private TagTextBox tagTextBoxDisableDate;
        private Label label4;
    }
}
