namespace Wisej.DemoBrowser.CKEditor
{
	partial class Features
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
			this.checkBoxToolbar = new Wisej.Web.CheckBox();
			this.checkBoxFooter = new Wisej.Web.CheckBox();
			this.checkBoxReadOnly = new Wisej.Web.CheckBox();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.panel1 = new Wisej.Web.Panel();
			this.ckEditor1 = new Wisej.Web.Ext.CKEditor.CKEditor();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxToolbar
			// 
			this.checkBoxToolbar.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxToolbar.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxToolbar.AutoSize = false;
			this.checkBoxToolbar.Checked = true;
			this.checkBoxToolbar.Location = new System.Drawing.Point(69, 218);
			this.checkBoxToolbar.Name = "checkBoxToolbar";
			this.checkBoxToolbar.Size = new System.Drawing.Size(200, 35);
			this.checkBoxToolbar.TabIndex = 8;
			this.checkBoxToolbar.Text = "Show Toolbar";
			this.checkBoxToolbar.CheckedChanged += new System.EventHandler(this.checkBoxToolbar_CheckedChanged);
			// 
			// checkBoxFooter
			// 
			this.checkBoxFooter.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxFooter.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxFooter.AutoSize = false;
			this.checkBoxFooter.Checked = true;
			this.checkBoxFooter.Location = new System.Drawing.Point(69, 149);
			this.checkBoxFooter.Name = "checkBoxFooter";
			this.checkBoxFooter.Size = new System.Drawing.Size(200, 35);
			this.checkBoxFooter.TabIndex = 7;
			this.checkBoxFooter.Text = "Show Footer";
			this.checkBoxFooter.CheckedChanged += new System.EventHandler(this.checkBoxFooter_CheckedChanged);
			// 
			// checkBoxReadOnly
			// 
			this.checkBoxReadOnly.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxReadOnly.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxReadOnly.AutoSize = false;
			this.checkBoxReadOnly.Location = new System.Drawing.Point(69, 76);
			this.checkBoxReadOnly.Name = "checkBoxReadOnly";
			this.checkBoxReadOnly.Size = new System.Drawing.Size(200, 35);
			this.checkBoxReadOnly.TabIndex = 6;
			this.checkBoxReadOnly.Text = "Read Only";
			this.checkBoxReadOnly.CheckedChanged += new System.EventHandler(this.checkBoxReadOnly_CheckedChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = Wisej.Web.AnchorStyles.Left;
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.ckEditor1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 41);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1152, 385);
			this.flowLayoutPanel1.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBoxFooter);
			this.panel1.Controls.Add(this.checkBoxToolbar);
			this.panel1.Controls.Add(this.checkBoxReadOnly);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.MaximumSize = new System.Drawing.Size(800, 0);
			this.panel1.MinimumSize = new System.Drawing.Size(200, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(317, 379);
			this.panel1.TabIndex = 9;
			// 
			// ckEditor1
			// 
			this.ckEditor1.Location = new System.Drawing.Point(326, 3);
			this.ckEditor1.Name = "ckEditor1";
			this.ckEditor1.Size = new System.Drawing.Size(821, 379);
			this.ckEditor1.TabIndex = 0;
			this.ckEditor1.Text = "ckEditor1";
			// 
			// Features
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Features";
			this.Size = new System.Drawing.Size(1422, 475);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Web.CheckBox checkBoxToolbar;
		private Web.CheckBox checkBoxFooter;
		private Web.CheckBox checkBoxReadOnly;
        private Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.Ext.CKEditor.CKEditor ckEditor1;
		private Web.Panel panel1;
	}
}
