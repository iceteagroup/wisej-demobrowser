namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxMap));
			this.dxMap1 = new Wisej.Web.Ext.DevExtreme.dxMap();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.groupBox2 = new Wisej.Web.GroupBox();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.numericUpDown3 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Map/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxMap/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown3);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 593);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown3, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 507);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxMap1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Map/ProvidersAndTypes/jQuery/" +
    "Light/";
			// 
			// dxMap1
			// 
			this.dxMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxMap1.Location = new System.Drawing.Point(18, 25);
			this.dxMap1.Name = "dxMap1";
			this.dxMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxMap1.Options"))));
			this.dxMap1.Size = new System.Drawing.Size(1052, 508);
			this.dxMap1.TabIndex = 0;
			this.dxMap1.Text = "dxMap1";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.Location = new System.Drawing.Point(28, 35);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Auto Adjust";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numericUpDown2);
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Location = new System.Drawing.Point(28, 352);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(195, 139);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.Text = "Center Map";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.DecimalPlaces = 14;
			this.numericUpDown2.LabelText = "Longitude";
			this.numericUpDown2.Location = new System.Drawing.Point(18, 84);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(159, 53);
			this.numericUpDown2.TabIndex = 1;
			this.numericUpDown2.Value = new decimal(new int[] {
            -817490707,
            172263,
            0,
            -2146631680});
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 14;
			this.numericUpDown1.LabelText = "Latitude";
			this.numericUpDown1.Location = new System.Drawing.Point(18, 26);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(159, 53);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.Value = new decimal(new int[] {
            965722076,
            948802,
            0,
            917504});
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 89);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 12;
			this.checkBox2.Text = "Controls";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "hybrid",
            "roadmap",
            "satellite"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Type";
			this.comboBox1.Location = new System.Drawing.Point(28, 219);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 13;
			this.comboBox1.Text = "roadmap";
			// 
			// comboBox2
			// 
			this.comboBox2.AutoSize = false;
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "bing",
            "google",
            "googleStatic"});
			this.comboBox2.Label.Size = 50;
			this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox2.LabelText = "Provider";
			this.comboBox2.Location = new System.Drawing.Point(28, 143);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 60);
			this.comboBox2.TabIndex = 14;
			this.comboBox2.Text = "bing";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.LabelText = "Zoom Level";
			this.numericUpDown3.Location = new System.Drawing.Point(28, 295);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(195, 53);
			this.numericUpDown3.TabIndex = 15;
			this.numericUpDown3.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
			// 
			// dxMap
			// 
			this.Name = "dxMap";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxMap dxMap1;
		private GroupBox groupBox2;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private ComboBox comboBox2;
		private ComboBox comboBox1;
		private NumericUpDown numericUpDown3;
	}
}
