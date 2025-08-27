namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoMultiSelect
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoMultiSelect));
			this.kendoMultiSelect1 = new Wisej.Web.Ext.Kendo.kendoMultiSelect();
			this.checkBoxAutoClose = new Wisej.Web.CheckBox();
			this.tagTextBoxDataSource = new Wisej.Web.TagTextBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoMultiSelect1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/multiselect/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/multiselect";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/multiselect/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBoxAutoClose);
			this.flowLayoutPanelProperties.Controls.Add(this.tagTextBoxDataSource);
			// 
			// kendoMultiSelect1
			// 
			this.kendoMultiSelect1.Anchor = Wisej.Web.AnchorStyles.None;
			this.kendoMultiSelect1.Location = new System.Drawing.Point(171, 164);
			this.kendoMultiSelect1.Name = "kendoMultiSelect1";
			this.kendoMultiSelect1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"dataTextField\":\"text\",\"dataValueField\":\"value\",\"dataSource\":[{\"text\":\"Item1\",\"v" +
        "alue\":\"1\"},{\"text\":\"Item2\",\"value\":\"2\"}]}")));
			this.kendoMultiSelect1.Size = new System.Drawing.Size(547, 248);
			this.kendoMultiSelect1.TabIndex = 0;
			this.kendoMultiSelect1.Text = "kendoMultiSelect1";
			// 
			// checkBoxAutoClose
			// 
			this.checkBoxAutoClose.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.checkBoxAutoClose.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAutoClose.AutoSize = false;
			this.checkBoxAutoClose.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAutoClose.Location = new System.Drawing.Point(3, 3);
			this.checkBoxAutoClose.Name = "checkBoxAutoClose";
			this.checkBoxAutoClose.Size = new System.Drawing.Size(170, 21);
			this.checkBoxAutoClose.TabIndex = 0;
			this.checkBoxAutoClose.Text = "Auto Close";
			// 
			// tagTextBoxDataSource
			// 
			this.tagTextBoxDataSource.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.tagTextBoxDataSource.AutoSize = false;
			this.tagTextBoxDataSource.LabelText = "Data Source";
			this.tagTextBoxDataSource.Location = new System.Drawing.Point(3, 37);
			this.tagTextBoxDataSource.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.tagTextBoxDataSource.Name = "tagTextBoxDataSource";
			this.tagTextBoxDataSource.Size = new System.Drawing.Size(212, 66);
			this.tagTextBoxDataSource.TabIndex = 1;
			this.tagTextBoxDataSource.Text = resources.GetString("tagTextBoxDataSource.Text");
			// 
			// kendoMultiSelect
			// 
			this.Name = "kendoMultiSelect";
			this.Load += new System.EventHandler(this.kendoMultiSelect_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoMultiSelect kendoMultiSelect1;
        private CheckBox checkBoxAutoClose;
        private TagTextBox tagTextBoxDataSource;
    }
}
