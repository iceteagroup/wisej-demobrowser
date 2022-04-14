namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoScheduler));
            this.kendoScheduler1 = new Wisej.Web.Ext.Kendo.kendoScheduler();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.buttonExport = new Wisej.Web.Button();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoScheduler1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/scheduler/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/scheduler";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/scheduling/scheduler/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox3);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox4);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox5);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonExport);
            // 
            // kendoScheduler1
            // 
            this.kendoScheduler1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.kendoScheduler1.Location = new System.Drawing.Point(18, 28);
            this.kendoScheduler1.Name = "kendoScheduler1";
            this.kendoScheduler1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoScheduler1.Options"))));
            this.kendoScheduler1.Size = new System.Drawing.Size(1052, 501);
            this.kendoScheduler1.TabIndex = 0;
            this.kendoScheduler1.Text = "kendoScheduler1";
            this.kendoScheduler1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoScheduler1_WebRequest);
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
            this.checkBox1.Text = "All Day Slot";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 60);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 38);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Editable";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox3, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox3, true);
            this.checkBox3.Location = new System.Drawing.Point(3, 117);
            this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(212, 38);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Mobile";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 174);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 38);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Show Work Hours";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox5, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox5, true);
            this.checkBox5.Location = new System.Drawing.Point(3, 231);
            this.checkBox5.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(212, 38);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Snap";
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
            this.buttonExport.Location = new System.Drawing.Point(3, 288);
            this.buttonExport.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(42, 42);
            this.buttonExport.TabIndex = 10;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // kendoScheduler
            // 
            this.MinimumSize = new System.Drawing.Size(996, 649);
            this.Name = "kendoScheduler";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoScheduler kendoScheduler1;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private Button buttonExport;
	}
}
