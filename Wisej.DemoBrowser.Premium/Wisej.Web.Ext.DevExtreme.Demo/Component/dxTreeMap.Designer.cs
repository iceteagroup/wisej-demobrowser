namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxTreeMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxTreeMap));
			this.dxTreeMap1 = new Wisej.Web.Ext.DevExtreme.dxTreeMap();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox3 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "N/A";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/d" +
    "xTreeMap/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox3);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Size = new System.Drawing.Size(250, 466);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 382);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxTreeMap1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Charts/FlatDataStructure/jQue" +
    "ry/Light/";
			// 
			// dxTreeMap1
			// 
			this.dxTreeMap1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dxTreeMap1.Location = new System.Drawing.Point(71, 31);
			this.dxTreeMap1.Name = "dxTreeMap1";
			this.dxTreeMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxTreeMap1.Options"))));
			this.dxTreeMap1.Size = new System.Drawing.Size(946, 497);
			this.dxTreeMap1.TabIndex = 0;
			this.dxTreeMap1.Text = "dxTreeMap1";
			this.dxTreeMap1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[0];
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 20;
			this.checkBox1.Text = "Interact With Group";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "leftBottomRightTop",
            "leftTopRightBottom",
            "rightBottomLeftTop",
            "rightTopLeftBottom"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Layout Direction";
			this.comboBox1.Location = new System.Drawing.Point(28, 106);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 21;
			this.comboBox1.Text = "leftTopRightBottom";
			// 
			// comboBox3
			// 
			this.comboBox3.AutoSize = false;
			this.comboBox3.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox3.Items.AddRange(new object[] {
            "undefined",
            "multiple",
            "none",
            "single"});
			this.comboBox3.Label.Size = 50;
			this.comboBox3.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox3.LabelText = "Selection Mode";
			this.comboBox3.Location = new System.Drawing.Point(28, 290);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(195, 60);
			this.comboBox3.TabIndex = 22;
			this.comboBox3.Text = "undefined";
			// 
			// comboBox2
			// 
			this.comboBox2.AutoSize = false;
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "Bright",
            "Harmony Light",
            "Ocean",
            "Pastel",
            "Soft",
            "Soft Pastel",
            "Vintage",
            "Violet",
            "Carmine",
            "Dark Moon",
            "Dark Violet",
            "Green Mist",
            "Soft Blue",
            "Material",
            "Office"});
			this.comboBox2.Label.Size = 50;
			this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox2.LabelText = "Palette";
			this.comboBox2.Location = new System.Drawing.Point(28, 198);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 60);
			this.comboBox2.TabIndex = 18;
			this.comboBox2.Text = "Material";
			// 
			// dxTreeMap
			// 
			this.Name = "dxTreeMap";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxTreeMap dxTreeMap1;
		private ComboBox comboBox1;
		private CheckBox checkBox1;
		private ComboBox comboBox3;
		private ComboBox comboBox2;
	}
}
