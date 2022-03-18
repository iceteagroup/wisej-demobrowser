namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxGantt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxGantt));
			this.dxGantt1 = new Wisej.Web.Ext.DevExtreme.dxGantt();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonExport = new Wisej.Web.Button();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Gantt/Getting_Started_with_" +
    "Gantt/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxGantt/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExport);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 502);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 420);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxGantt1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Gantt/Overview/jQuery/Light/";
			// 
			// dxGantt1
			// 
			this.dxGantt1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxGantt1.Location = new System.Drawing.Point(37, 29);
			this.dxGantt1.Name = "dxGantt1";
			this.dxGantt1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxGantt1.Options"))));
			this.dxGantt1.Size = new System.Drawing.Size(1014, 500);
			this.dxGantt1.TabIndex = 0;
			this.dxGantt1.Text = "dxGantt1";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "Inside",
            "Outside",
            "None"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Task Title Position";
			this.comboBox1.Location = new System.Drawing.Point(28, 204);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.Text = "Inside";
			// 
			// comboBox2
			// 
			this.comboBox2.AutoSize = false;
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "Auto",
            "Minutes",
            "Hours",
            "Days",
            "Weeks",
            "Months",
            "Quarters",
            "Years"});
			this.comboBox2.Label.Size = 50;
			this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox2.LabelText = "Scale Type";
			this.comboBox2.Location = new System.Drawing.Point(28, 282);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 60);
			this.comboBox2.TabIndex = 6;
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 360);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 21;
			// 
			// buttonExport
			// 
			this.buttonExport.Display = Wisej.Web.Display.Icon;
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
			this.buttonExport.Location = new System.Drawing.Point(76, 360);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(42, 42);
			this.buttonExport.TabIndex = 20;
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 22;
			this.checkBox1.Text = "Allow Selection";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.Location = new System.Drawing.Point(28, 92);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 23;
			this.checkBox2.Text = "Show Resources";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Checked = true;
			this.checkBox3.Location = new System.Drawing.Point(28, 148);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 24;
			this.checkBox3.Text = "Show Row Lines";
			// 
			// dxGantt
			// 
			this.Name = "dxGantt";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxGantt dxGantt1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
		private Upload buttonLoad;
		private Button buttonExport;
		private CheckBox checkBox1;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
	}
}
