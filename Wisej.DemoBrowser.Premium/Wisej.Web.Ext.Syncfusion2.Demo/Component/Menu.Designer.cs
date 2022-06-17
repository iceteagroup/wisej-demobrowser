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
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/menu/es5-getting-started/";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/menu/";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.menu1);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.comboBoxOrientation);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/menu/default.html";
			// 
			// menu1
			// 
			this.menu1.Dock = Wisej.Web.DockStyle.Fill;
			this.menu1.Location = new System.Drawing.Point(8, 8);
			this.menu1.Name = "menu1";
			this.menu1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("menu1.Options"))));
			this.menu1.Size = new System.Drawing.Size(872, 560);
			this.menu1.TabIndex = 0;
			this.menu1.Text = "menu1";
			// 
			// comboBoxOrientation
			// 
			this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanel1.SetFillWeight(this.comboBoxOrientation, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.comboBoxOrientation, true);
			this.comboBoxOrientation.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
			this.comboBoxOrientation.LabelText = "Orientation";
			this.comboBoxOrientation.Location = new System.Drawing.Point(3, 3);
			this.comboBoxOrientation.Name = "comboBoxOrientation";
			this.comboBoxOrientation.Size = new System.Drawing.Size(212, 51);
			this.comboBoxOrientation.TabIndex = 2;
			this.comboBoxOrientation.Text = "Horizontal";
			// 
			// Menu
			// 
			this.Name = "Menu";
			this.Load += new System.EventHandler(this.Menu_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.Menu menu1;
        private ComboBox comboBoxOrientation;
    }
}
