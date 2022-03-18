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
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoScheduler1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 409);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 328);
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
            this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(28, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "All Day Slot";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(28, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Editable";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(28, 117);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 38);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Mobile";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Location = new System.Drawing.Point(28, 161);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(195, 38);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Show Work Hours";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(28, 205);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(195, 38);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Snap";
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
            this.buttonExport.Location = new System.Drawing.Point(28, 280);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(42, 42);
            this.buttonExport.TabIndex = 10;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // kendoScheduler
            // 
            this.Name = "kendoScheduler";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
