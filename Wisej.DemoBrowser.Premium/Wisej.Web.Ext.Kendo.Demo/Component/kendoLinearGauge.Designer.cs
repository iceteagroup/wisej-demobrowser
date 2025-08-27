namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoLinearGauge
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoLinearGauge));
			this.kendoLinearGauge1 = new Wisej.Web.Ext.Kendo.kendoLinearGauge();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.button1 = new Wisej.Web.Button();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoLinearGauge1);
			this.panel.Padding = new Wisej.Web.Padding(16);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/linear-gauge/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/lineargauge";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/gauges/lineargauge/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown1);
			this.flowLayoutPanelProperties.Controls.Add(this.button1);
			// 
			// kendoLinearGauge1
			// 
			this.kendoLinearGauge1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoLinearGauge1.Location = new System.Drawing.Point(18, 25);
			this.kendoLinearGauge1.Name = "kendoLinearGauge1";
			this.kendoLinearGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoLinearGauge1.Options"))));
			this.kendoLinearGauge1.Size = new System.Drawing.Size(853, 526);
			this.kendoLinearGauge1.TabIndex = 0;
			this.kendoLinearGauge1.Text = "kendoLinearGauge1";
			// 
			// numericUpDown1
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown1, true);
			this.numericUpDown1.LabelText = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(3, 60);
			this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 57);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// button1
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.button1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.button1, true);
			this.button1.Location = new System.Drawing.Point(3, 136);
			this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(212, 40);
			this.button1.TabIndex = 2;
			this.button1.Text = "Start Task";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
			this.checkBox1.Location = new System.Drawing.Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(212, 38);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Transitions";
			// 
			// kendoLinearGauge
			// 
			this.Name = "kendoLinearGauge";
			this.Load += new System.EventHandler(this.kendoLinearGauge_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.flowLayoutPanelProperties.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoLinearGauge kendoLinearGauge1;
		private NumericUpDown numericUpDown1;
		private Button button1;
		private CheckBox checkBox1;
	}
}
