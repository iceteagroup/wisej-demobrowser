namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igZoombar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igZoombar));
            this.igDataChart1 = new Wisej.Web.Ext.Ignite.igDataChart();
            this.panel1 = new Wisej.Web.Panel();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.numericUpDown3 = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.igDataChart1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/zoombar/overview";
            // 
            // linkAPI
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igzoombar";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://www.igniteui.com/help/igzoombar-landingpage";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown2);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown3);
            // 
            // igDataChart1
            // 
            this.igDataChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.igDataChart1.Location = new System.Drawing.Point(35, 26);
            this.igDataChart1.Name = "igDataChart1";
            this.igDataChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igDataChart1.Options"))));
            this.igDataChart1.Size = new System.Drawing.Size(1019, 436);
            this.igDataChart1.TabIndex = 0;
            this.igDataChart1.Text = "igDataChart1";
            this.igDataChart1.WidgetTemplates = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate[0];
            this.igDataChart1.Appear += new System.EventHandler(this.igDataChart1_Appear);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(35, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 57);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
            this.numericUpDown1.LabelText = "Zoom Window Move Distance";
            this.numericUpDown1.Location = new System.Drawing.Point(3, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 79);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown2, true);
            this.numericUpDown2.LabelText = "Zoom Window Min Width";
            this.numericUpDown2.Location = new System.Drawing.Point(3, 101);
            this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown3, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown3, true);
            this.numericUpDown3.LabelText = "Window Pan Duration";
            this.numericUpDown3.Location = new System.Drawing.Point(3, 177);
            this.numericUpDown3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // igZoombar
            // 
            this.Name = "igZoombar";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private Ignite.igDataChart igDataChart1;
		private Panel panel1;
		private NumericUpDown numericUpDown3;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
	}
}
