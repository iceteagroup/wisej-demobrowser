namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menu1 = new Wisej.Web.Ext.Syncfusion2.Menu();
            this.comboBoxOrientation = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/menu/es5-getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/menu/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxOrientation);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxOrientation, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.menu1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/menu/default.html";
            // 
            // menu1
            // 
            this.menu1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.menu1.Location = new System.Drawing.Point(8, 10);
            this.menu1.Name = "menu1";
            this.menu1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("menu1.Options"))));
            this.menu1.Size = new System.Drawing.Size(1070, 539);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "menu1";
            // 
            // comboBoxOrientation
            // 
            this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxOrientation.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.comboBoxOrientation.LabelText = "Orientation";
            this.comboBoxOrientation.Location = new System.Drawing.Point(22, 35);
            this.comboBoxOrientation.Name = "comboBoxOrientation";
            this.comboBoxOrientation.Size = new System.Drawing.Size(207, 42);
            this.comboBoxOrientation.TabIndex = 2;
            // 
            // Menu
            // 
            this.Name = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Menu menu1;
        private ComboBox comboBoxOrientation;
    }
}
