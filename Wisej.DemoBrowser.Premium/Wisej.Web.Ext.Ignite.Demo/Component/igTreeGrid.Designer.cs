namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igTreeGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igTreeGrid));
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            this.buttonLoad = new Wisej.Web.Upload();
            this.buttonExport = new Wisej.Web.Button();
            this.igTreeGrid1 = new Wisej.Web.Ext.Ignite.igTreeGrid();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igTreeGrid1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/tree-grid/overview";
            // 
            // linkApi
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igTreeGrid";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igtreegrid-overview";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.buttonLoad);
            this.flowLayoutPanel1.Controls.Add(this.buttonExport);
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(3, 174);
            this.buttonLoad.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "icon-save";
            this.buttonExport.Location = new System.Drawing.Point(51, 174);
            this.buttonExport.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(42, 42);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // igTreeGrid1
            // 
            this.igTreeGrid1.Dock = Wisej.Web.DockStyle.Fill;
            this.igTreeGrid1.Location = new System.Drawing.Point(8, 8);
            this.igTreeGrid1.Name = "igTreeGrid1";
            this.igTreeGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igTreeGrid1.Options"))));
            this.igTreeGrid1.Size = new System.Drawing.Size(872, 560);
            this.igTreeGrid1.TabIndex = 0;
            this.igTreeGrid1.Text = "igTreeGrid1";
            widgetFunction1.Name = "customDropValidation";
            widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
            this.igTreeGrid1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Paging";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox3, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox3, true);
            this.checkBox3.Location = new System.Drawing.Point(3, 60);
            this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(212, 38);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Show Header";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 117);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 38);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Enable Hover Styles";
            // 
            // igTreeGrid
            // 
            this.Name = "igTreeGrid";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igTreeGrid igTreeGrid1;
		private Upload buttonLoad;
		private Button buttonExport;
		private CheckBox checkBox1;
		private CheckBox checkBox3;
		private CheckBox checkBox4;
	}
}
