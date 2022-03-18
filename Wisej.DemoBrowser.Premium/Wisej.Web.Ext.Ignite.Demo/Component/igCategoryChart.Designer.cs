namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igCategoryChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igCategoryChart));
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.igCategoryChart1 = new Wisej.Web.Ext.Ignite.igCategoryChart();
            this.buttonLoad = new Wisej.Web.Upload();
            this.buttonSave = new Wisej.Web.Button();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 464);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 383);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igCategoryChart1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/category-chart/overview";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igcategorychart";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igcategorychart-landingpage";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.LabelText = "Chart Type";
            this.comboBox1.Location = new System.Drawing.Point(28, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 57);
            this.comboBox1.TabIndex = 3;
            // 
            // igCategoryChart1
            // 
            this.igCategoryChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.igCategoryChart1.Location = new System.Drawing.Point(17, 23);
            this.igCategoryChart1.Name = "igCategoryChart1";
            this.igCategoryChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igCategoryChart1.Options"))));
            this.igCategoryChart1.Size = new System.Drawing.Size(1054, 496);
            this.igCategoryChart1.TabIndex = 0;
            this.igCategoryChart1.Text = "igCategoryChart1";
            widgetFunction2.Name = "yAxisFormatLabel";
            widgetFunction2.Source = "var value = arguments[0];\r\n\r\nreturn value + \" M\";";
            this.igCategoryChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction2};
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(28, 311);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
            // 
            // buttonSave
            // 
            this.buttonSave.Display = Wisej.Web.Display.Icon;
            this.buttonSave.ImageSource = "icon-save";
            this.buttonSave.Location = new System.Drawing.Point(76, 311);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(42, 42);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Align Gridlines to Pixels";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(28, 104);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 46);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Final Value Annotations";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(28, 172);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 38);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Item Highlighting";
            // 
            // igCategoryChart
            // 
            this.Name = "igCategoryChart";
            this.Load += new System.EventHandler(this.igCategoryChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Ignite.igCategoryChart igCategoryChart1;
		private ComboBox comboBox1;
		private Upload buttonLoad;
		private Button buttonSave;
		private CheckBox checkBox1;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
	}
}
