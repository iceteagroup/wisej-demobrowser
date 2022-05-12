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
            this.checkedListBoxColors = new Wisej.Web.CheckedListBox();
            this.labelColors = new Wisej.Web.Label();
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
            this.flowLayoutPanelProperties.Controls.Add(this.labelColors);
            this.flowLayoutPanelProperties.Controls.Add(this.checkedListBoxColors);
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
            this.comboBoxType.Text = "Squarified";
            // 
            // checkedListBoxColors
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.checkedListBoxColors, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkedListBoxColors, true);
            this.checkedListBoxColors.Items.AddRange(new object[] {
            "LightSalmon",
            "Coral",
            "Tomato",
            "OrangeRed",
            "DarkOrange",
            "Orange",
            "Gold",
            "Yellow",
            "LightYellow",
            "LemonChiffon"});
            this.checkedListBoxColors.Location = new System.Drawing.Point(3, 107);
            this.checkedListBoxColors.Name = "checkedListBoxColors";
            this.checkedListBoxColors.SelectionMode = Wisej.Web.SelectionMode.MultiExtended;
            this.checkedListBoxColors.Size = new System.Drawing.Size(212, 309);
            this.checkedListBoxColors.TabIndex = 1;
            // 
            // labelColors
            // 
            this.labelColors.AutoSize = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.labelColors, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.labelColors, true);
            this.labelColors.Location = new System.Drawing.Point(3, 79);
            this.labelColors.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.labelColors.Name = "labelColors";
            this.labelColors.Size = new System.Drawing.Size(212, 22);
            this.labelColors.TabIndex = 2;
            this.labelColors.Text = "Colors";
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
        private Label labelColors;
        private CheckedListBox checkedListBoxColors;
    }
}
