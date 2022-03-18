namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Toolbar
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
            this.toolbar1 = new Wisej.Web.Ext.Syncfusion2.Toolbar();
            this.comboBoxOverflowMode = new Wisej.Web.ComboBox();
            this.checkBoxEnableCollision = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/toolbar/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/toolbar/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEnableCollision);
            this.groupBox1.Controls.Add(this.comboBoxOverflowMode);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxOverflowMode, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxEnableCollision, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.toolbar1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/toolbar/default.html";
            // 
            // toolbar1
            // 
            this.toolbar1.Dock = Wisej.Web.DockStyle.Top;
            this.toolbar1.Location = new System.Drawing.Point(8, 8);
            this.toolbar1.Name = "toolbar1";
            this.toolbar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"items\":[{\"text\":\"Cut\"},{\"text\":\"Copy\"},{\"text\":\"Paste\"},{\"type\":\"Separator\"},{\"" +
        "text\":\"Bold\"},{\"text\":\"Italic\"},{\"text\":\"Underline\"}]}")));
            this.toolbar1.Size = new System.Drawing.Size(1073, 52);
            this.toolbar1.TabIndex = 0;
            this.toolbar1.Text = "toolbar1";
            // 
            // comboBoxOverflowMode
            // 
            this.comboBoxOverflowMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxOverflowMode.Items.AddRange(new object[] {
            "Scrollable",
            "Popup",
            "MultiRow",
            "Extended"});
            this.comboBoxOverflowMode.LabelText = "Overflow Mode";
            this.comboBoxOverflowMode.Location = new System.Drawing.Point(17, 29);
            this.comboBoxOverflowMode.Name = "comboBoxOverflowMode";
            this.comboBoxOverflowMode.Size = new System.Drawing.Size(216, 42);
            this.comboBoxOverflowMode.TabIndex = 1;
            // 
            // checkBoxEnableCollision
            // 
            this.checkBoxEnableCollision.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableCollision.Checked = true;
            this.checkBoxEnableCollision.Location = new System.Drawing.Point(17, 95);
            this.checkBoxEnableCollision.Name = "checkBoxEnableCollision";
            this.checkBoxEnableCollision.Size = new System.Drawing.Size(146, 24);
            this.checkBoxEnableCollision.TabIndex = 2;
            this.checkBoxEnableCollision.Text = "Enable Collision";
            // 
            // Toolbar
            // 
            this.Name = "Toolbar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Toolbar toolbar1;
        private ComboBox comboBoxOverflowMode;
        private CheckBox checkBoxEnableCollision;
    }
}
