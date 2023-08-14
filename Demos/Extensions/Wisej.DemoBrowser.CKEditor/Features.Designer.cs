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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
			this.ckEditor1 = new Wisej.Web.Ext.CKEditor.CKEditor();
			this.checkBoxToolbar = new Wisej.Web.CheckBox();
			this.checkBoxFooter = new Wisej.Web.CheckBox();
			this.checkBoxReadOnly = new Wisej.Web.CheckBox();
			this.panel1 = new Wisej.Web.Panel();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ckEditor1
			// 
			this.ckEditor1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ckEditor1.CssClass = "shadow";
			this.flowLayoutPanel1.SetFillWeight(this.ckEditor1, 2);
			this.ckEditor1.Location = new System.Drawing.Point(426, 3);
			this.ckEditor1.MaximumSize = new System.Drawing.Size(700, 0);
			this.ckEditor1.MinimumSize = new System.Drawing.Size(400, 0);
			this.ckEditor1.Name = "ckEditor1";
			this.ckEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ckEditor1.Options"))));
			this.ckEditor1.ShowFooter = false;
			this.ckEditor1.Size = new System.Drawing.Size(700, 346);
			this.ckEditor1.TabIndex = 0;
			this.ckEditor1.Text = "ckEditor1";
			// 
			// checkBoxToolbar
			// 
			this.checkBoxToolbar.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxToolbar.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxToolbar.AutoSize = false;
			this.checkBoxToolbar.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxToolbar.Location = new System.Drawing.Point(108, 225);
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
			this.checkBoxFooter.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxFooter.Location = new System.Drawing.Point(108, 156);
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
			this.checkBoxReadOnly.Location = new System.Drawing.Point(108, 87);
			this.checkBoxReadOnly.Name = "checkBoxReadOnly";
			this.checkBoxReadOnly.Size = new System.Drawing.Size(200, 35);
			this.checkBoxReadOnly.TabIndex = 6;
			this.checkBoxReadOnly.Text = "Read Only";
			this.checkBoxReadOnly.CheckedChanged += new System.EventHandler(this.checkBoxReadOnly_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBoxToolbar);
			this.panel1.Controls.Add(this.checkBoxReadOnly);
			this.panel1.Controls.Add(this.checkBoxFooter);
			this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.MaximumSize = new System.Drawing.Size(800, 0);
			this.panel1.MinimumSize = new System.Drawing.Size(350, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(417, 346);
			this.panel1.TabIndex = 9;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.ckEditor1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(73, 61);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1129, 352);
			this.flowLayoutPanel1.TabIndex = 10;
			// 
			// Features
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Features";
			this.Size = new System.Drawing.Size(1422, 475);
			this.panel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Ext.CKEditor.CKEditor ckEditor1;
		private Web.CheckBox checkBoxToolbar;
		private Web.CheckBox checkBoxFooter;
		private Web.CheckBox checkBoxReadOnly;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Panel panel1;
    }
}
