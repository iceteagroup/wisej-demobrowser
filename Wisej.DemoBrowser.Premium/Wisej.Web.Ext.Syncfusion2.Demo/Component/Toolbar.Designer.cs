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
            this.flowLayoutPanel1.SuspendLayout();
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
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.toolbar1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableCollision);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxOverflowMode);
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
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxOverflowMode, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxOverflowMode, true);
            this.comboBoxOverflowMode.Items.AddRange(new object[] {
            "Scrollable",
            "Popup",
            "MultiRow",
            "Extended"});
            this.comboBoxOverflowMode.LabelText = "Overflow Mode";
            this.comboBoxOverflowMode.Location = new System.Drawing.Point(3, 46);
            this.comboBoxOverflowMode.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxOverflowMode.Name = "comboBoxOverflowMode";
            this.comboBoxOverflowMode.Size = new System.Drawing.Size(212, 46);
            this.comboBoxOverflowMode.TabIndex = 1;
            // 
            // checkBoxEnableCollision
            // 
            this.checkBoxEnableCollision.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableCollision.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEnableCollision.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableCollision, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableCollision, true);
            this.checkBoxEnableCollision.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEnableCollision.Name = "checkBoxEnableCollision";
            this.checkBoxEnableCollision.Size = new System.Drawing.Size(212, 24);
            this.checkBoxEnableCollision.TabIndex = 2;
            this.checkBoxEnableCollision.Text = "Enable Collision";
            // 
            // Toolbar
            // 
            this.Name = "Toolbar";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Toolbar toolbar1;
        private ComboBox comboBoxOverflowMode;
        private CheckBox checkBoxEnableCollision;
    }
}
