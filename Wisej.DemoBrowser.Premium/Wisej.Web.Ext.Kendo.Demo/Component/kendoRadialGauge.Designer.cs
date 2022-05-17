namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoRadialGauge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoRadialGauge));
            this.kendoRadialGauge1 = new Wisej.Web.Ext.Kendo.kendoRadialGauge();
            this.button1 = new Wisej.Web.Button();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoRadialGauge1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/radial-gauge/index";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/radialgauge";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/gauges/radialgauge/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanelProperties.Controls.Add(this.button1);
            // 
            // kendoRadialGauge1
            // 
            this.kendoRadialGauge1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.kendoRadialGauge1.Location = new System.Drawing.Point(51, 34);
            this.kendoRadialGauge1.Name = "kendoRadialGauge1";
            this.kendoRadialGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoRadialGauge1.Options"))));
            this.kendoRadialGauge1.Size = new System.Drawing.Size(785, 508);
            this.kendoRadialGauge1.TabIndex = 0;
            this.kendoRadialGauge1.Text = "kendoRadialGauge1";
            // 
            // button1
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.button1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.button1, true);
            this.button1.Location = new System.Drawing.Point(3, 139);
            this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Task";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown1, true);
            this.numericUpDown1.Label.Size = 50;
            this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown1.LabelText = "Value";
            this.numericUpDown1.Location = new System.Drawing.Point(3, 60);
            this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 60);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
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
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Transitions";
            // 
            // kendoRadialGauge
            // 
            this.Name = "kendoRadialGauge";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoRadialGauge kendoRadialGauge1;
		private Button button1;
		private NumericUpDown numericUpDown1;
		private CheckBox checkBox1;
	}
}
