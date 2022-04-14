namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoTreeMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoTreeMap));
            this.kendoTreeMap1 = new Wisej.Web.Ext.Kendo.kendoTreeMap();
            this.comboBoxType = new Wisej.Web.ComboBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoTreeMap1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/treemap/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/treemap";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/charts/treemap/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxType);
            // 
            // kendoTreeMap1
            // 
            this.kendoTreeMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.kendoTreeMap1.Location = new System.Drawing.Point(44, 32);
            this.kendoTreeMap1.Name = "kendoTreeMap1";
            this.kendoTreeMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoTreeMap1.Options"))));
            this.kendoTreeMap1.Size = new System.Drawing.Size(1001, 495);
            this.kendoTreeMap1.TabIndex = 0;
            this.kendoTreeMap1.Text = "kendoTreeMap1";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxType.Items.AddRange(new object[] {
            "Squarified",
            "Horizontal",
            "Vertical"});
            this.comboBoxType.LabelText = "Type";
            this.comboBoxType.Location = new System.Drawing.Point(3, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(212, 57);
            this.comboBoxType.TabIndex = 0;
            // 
            // kendoTreeMap
            // 
            this.MinimumSize = new System.Drawing.Size(961, 582);
            this.Name = "kendoTreeMap";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoTreeMap kendoTreeMap1;
        private ComboBox comboBoxType;
    }
}
