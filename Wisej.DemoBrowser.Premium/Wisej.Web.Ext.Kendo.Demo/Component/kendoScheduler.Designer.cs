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
            this.checkBoxAllDay = new Wisej.Web.CheckBox();
            this.checkBoxEditable = new Wisej.Web.CheckBox();
            this.checkBoxShowWorkHours = new Wisej.Web.CheckBox();
            this.checkBoxSnap = new Wisej.Web.CheckBox();
            this.buttonExport = new Wisej.Web.Button();
            this.kendoScheduler1 = new Wisej.Web.Ext.Kendo.kendoScheduler();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoScheduler1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/scheduler/index";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/scheduler";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/scheduling/scheduler/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxAllDay);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxEditable);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxShowWorkHours);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxSnap);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonExport);
            // 
            // checkBoxAllDay
            // 
            this.checkBoxAllDay.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllDay.AutoSize = false;
            this.checkBoxAllDay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllDay.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxAllDay, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxAllDay, true);
            this.checkBoxAllDay.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAllDay.Name = "checkBoxAllDay";
            this.checkBoxAllDay.Size = new System.Drawing.Size(212, 38);
            this.checkBoxAllDay.TabIndex = 5;
            this.checkBoxAllDay.Text = "All Day Slot";
            // 
            // checkBoxEditable
            // 
            this.checkBoxEditable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEditable.AutoSize = false;
            this.checkBoxEditable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEditable.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxEditable, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxEditable, true);
            this.checkBoxEditable.Location = new System.Drawing.Point(3, 60);
            this.checkBoxEditable.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEditable.Name = "checkBoxEditable";
            this.checkBoxEditable.Size = new System.Drawing.Size(212, 38);
            this.checkBoxEditable.TabIndex = 6;
            this.checkBoxEditable.Text = "Editable";
            // 
            // checkBoxShowWorkHours
            // 
            this.checkBoxShowWorkHours.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowWorkHours.AutoSize = false;
            this.checkBoxShowWorkHours.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxShowWorkHours, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxShowWorkHours, true);
            this.checkBoxShowWorkHours.Location = new System.Drawing.Point(3, 117);
            this.checkBoxShowWorkHours.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxShowWorkHours.Name = "checkBoxShowWorkHours";
            this.checkBoxShowWorkHours.Size = new System.Drawing.Size(212, 38);
            this.checkBoxShowWorkHours.TabIndex = 8;
            this.checkBoxShowWorkHours.Text = "Show Work Hours";
            // 
            // checkBoxSnap
            // 
            this.checkBoxSnap.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxSnap.AutoSize = false;
            this.checkBoxSnap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSnap.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxSnap, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxSnap, true);
            this.checkBoxSnap.Location = new System.Drawing.Point(3, 174);
            this.checkBoxSnap.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxSnap.Name = "checkBoxSnap";
            this.checkBoxSnap.Size = new System.Drawing.Size(212, 38);
            this.checkBoxSnap.TabIndex = 9;
            this.checkBoxSnap.Text = "Snap";
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
            this.buttonExport.Location = new System.Drawing.Point(3, 231);
            this.buttonExport.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(42, 42);
            this.buttonExport.TabIndex = 10;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // kendoScheduler1
            // 
            this.kendoScheduler1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.kendoScheduler1.Location = new System.Drawing.Point(26, 38);
            this.kendoScheduler1.Name = "kendoScheduler1";
            this.kendoScheduler1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoScheduler1.Options"))));
            this.kendoScheduler1.Size = new System.Drawing.Size(836, 501);
            this.kendoScheduler1.TabIndex = 0;
            this.kendoScheduler1.Text = "kendoScheduler1";
            this.kendoScheduler1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoScheduler1_WebRequest);
            // 
            // kendoScheduler
            // 
            this.Name = "kendoScheduler";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoScheduler kendoScheduler1;
		private CheckBox checkBoxEditable;
		private CheckBox checkBoxAllDay;
		private CheckBox checkBoxSnap;
		private CheckBox checkBoxShowWorkHours;
		private Button buttonExport;
	}
}
