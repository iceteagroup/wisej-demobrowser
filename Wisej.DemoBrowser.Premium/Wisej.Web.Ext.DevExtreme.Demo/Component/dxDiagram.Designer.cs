namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxDiagram
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
			this.dxDiagram1 = new Wisej.Web.Ext.DevExtreme.dxDiagram();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.buttonExport = new Wisej.Web.Button();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Diagram/Getting_Started_wit" +
    "h_Diagram/";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDiagram/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.buttonExport);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 514);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 433);
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxDiagram1);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Diagram/Overview/jQuery/Light" +
    "/";
			// 
			// dxDiagram1
			// 
			this.dxDiagram1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxDiagram1.Location = new System.Drawing.Point(21, 28);
			this.dxDiagram1.Name = "dxDiagram1";
			this.dxDiagram1.Size = new System.Drawing.Size(1046, 502);
			this.dxDiagram1.TabIndex = 0;
			this.dxDiagram1.Text = "dxDiagram1";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.Location = new System.Drawing.Point(28, 37);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Snap to Grid";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 95);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Simple View";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "Inches",
            "Centimeters",
            "Pixels"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Units";
			this.comboBox1.Location = new System.Drawing.Point(28, 211);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "Inches";
			// 
			// buttonExport
			// 
			this.buttonExport.Display = Wisej.Web.Display.Icon;
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
			this.buttonExport.Location = new System.Drawing.Point(28, 371);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(42, 42);
			this.buttonExport.TabIndex = 5;
			// 
			// comboBox2
			// 
			this.comboBox2.AutoSize = false;
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "fitContent",
            "fitWidth",
            "disabled"});
			this.comboBox2.Label.Size = 50;
			this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox2.LabelText = "Auto Zoom";
			this.comboBox2.Location = new System.Drawing.Point(28, 291);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 60);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.Text = "disabled";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Checked = true;
			this.checkBox3.Location = new System.Drawing.Point(28, 153);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Show Grid";
			// 
			// dxDiagram
			// 
			this.Name = "dxDiagram";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxDiagram dxDiagram1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
		private Button buttonExport;
		private ComboBox comboBox2;
		private CheckBox checkBox3;
	}
}
