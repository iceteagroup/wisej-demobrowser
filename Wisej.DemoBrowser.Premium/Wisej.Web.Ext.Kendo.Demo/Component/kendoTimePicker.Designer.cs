namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoTimePicker
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
			this.kendoTimePicker1 = new Wisej.Web.Ext.Kendo.kendoTimePicker();
			this.comboBoxFillMode = new Wisej.Web.ComboBox();
			this.textBoxMinimum = new Wisej.Web.TextBox();
			this.textBoxMaximum = new Wisej.Web.TextBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoTimePicker1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/timepicker/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/timepicker";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/timepicker/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.comboBoxFillMode);
			this.flowLayoutPanelProperties.Controls.Add(this.textBoxMinimum);
			this.flowLayoutPanelProperties.Controls.Add(this.textBoxMaximum);
			// 
			// kendoTimePicker1
			// 
			this.kendoTimePicker1.Anchor = Wisej.Web.AnchorStyles.None;
			this.kendoTimePicker1.Location = new System.Drawing.Point(294, 268);
			this.kendoTimePicker1.Name = "kendoTimePicker1";
			this.kendoTimePicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"2022-05-09T16:31:03.826\"}")));
			this.kendoTimePicker1.Size = new System.Drawing.Size(300, 40);
			this.kendoTimePicker1.TabIndex = 0;
			this.kendoTimePicker1.Value = new System.DateTime(2022, 5, 9, 16, 31, 3, 826);
			// 
			// comboBoxFillMode
			// 
			this.comboBoxFillMode.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxFillMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxFillMode.Items.AddRange(new object[] {
            "null",
            "solid",
            "flat",
            "outline"});
			this.comboBoxFillMode.LabelText = "Fill Mode";
			this.comboBoxFillMode.Location = new System.Drawing.Point(3, 3);
			this.comboBoxFillMode.Name = "comboBoxFillMode";
			this.comboBoxFillMode.Size = new System.Drawing.Size(212, 57);
			this.comboBoxFillMode.TabIndex = 0;
			this.comboBoxFillMode.Text = "solid";
			// 
			// textBoxMinimum
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.textBoxMinimum, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.textBoxMinimum, true);
			this.textBoxMinimum.InputType.Type = Wisej.Web.TextBoxType.Time;
			this.textBoxMinimum.LabelText = "Minimum Time";
			this.textBoxMinimum.Location = new System.Drawing.Point(3, 79);
			this.textBoxMinimum.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBoxMinimum.Name = "textBoxMinimum";
			this.textBoxMinimum.Size = new System.Drawing.Size(212, 57);
			this.textBoxMinimum.TabIndex = 1;
			// 
			// textBoxMaximum
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.textBoxMaximum, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.textBoxMaximum, true);
			this.textBoxMaximum.InputType.Type = Wisej.Web.TextBoxType.Time;
			this.textBoxMaximum.LabelText = "Maximum Time";
			this.textBoxMaximum.Location = new System.Drawing.Point(3, 155);
			this.textBoxMaximum.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBoxMaximum.Name = "textBoxMaximum";
			this.textBoxMaximum.Size = new System.Drawing.Size(212, 57);
			this.textBoxMaximum.TabIndex = 2;
			// 
			// kendoTimePicker
			// 
			this.Name = "kendoTimePicker";
			this.Load += new System.EventHandler(this.kendoTimePicker_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.flowLayoutPanelProperties.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoTimePicker kendoTimePicker1;
        private ComboBox comboBoxFillMode;
        private TextBox textBoxMinimum;
        private TextBox textBoxMaximum;
    }
}
