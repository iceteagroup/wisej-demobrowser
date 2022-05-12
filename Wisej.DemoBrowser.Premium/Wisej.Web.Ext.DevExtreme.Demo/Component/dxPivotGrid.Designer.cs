namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxPivotGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxPivotGrid));
            this.dxPivotGrid1 = new Wisej.Web.Ext.DevExtreme.dxPivotGrid();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox7 = new Wisej.Web.CheckBox();
            this.checkBox8 = new Wisej.Web.CheckBox();
            this.checkBox9 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/PivotGrid/Visual_Elements/";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/PivotGrid/Overview/jQuery/Lig" +
    "ht/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxPivotGrid/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxPivotGrid1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.checkBox7);
            this.flowLayoutPanel1.Controls.Add(this.checkBox8);
            this.flowLayoutPanel1.Controls.Add(this.checkBox9);
            // 
            // dxPivotGrid1
            // 
            this.dxPivotGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxPivotGrid1.Location = new System.Drawing.Point(23, 24);
            this.dxPivotGrid1.Name = "dxPivotGrid1";
            this.dxPivotGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxPivotGrid1.Options"))));
            this.dxPivotGrid1.Size = new System.Drawing.Size(842, 527);
            this.dxPivotGrid1.TabIndex = 0;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 51);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "Hide Empty Summary Cells";
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox7.AutoSize = false;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox7.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox7, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox7, true);
            this.checkBox7.Location = new System.Drawing.Point(3, 60);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(212, 38);
            this.checkBox7.TabIndex = 18;
            this.checkBox7.Text = "Show Column Totals";
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox8.AutoSize = false;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox8.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox8, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox8, true);
            this.checkBox8.Location = new System.Drawing.Point(3, 104);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(212, 47);
            this.checkBox8.TabIndex = 19;
            this.checkBox8.Text = "Show Row Grand Totals";
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox9.AutoSize = false;
            this.checkBox9.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox9.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox9, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox9, true);
            this.checkBox9.Location = new System.Drawing.Point(3, 157);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(212, 38);
            this.checkBox9.TabIndex = 20;
            this.checkBox9.Text = "Show Row Totals";
            // 
            // dxPivotGrid
            // 
            this.AutoScroll = true;
            this.Name = "dxPivotGrid";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxPivotGrid dxPivotGrid1;
		private CheckBox checkBox9;
		private CheckBox checkBox8;
		private CheckBox checkBox7;
		private CheckBox checkBox4;
	}
}
