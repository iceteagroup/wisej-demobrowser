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
			this.ckEditor1 = new Wisej.Web.Ext.CKEditor.CKEditor();
			this.checkBoxToolbar = new Wisej.Web.CheckBox();
			this.checkBoxFooter = new Wisej.Web.CheckBox();
			this.checkBoxReadOnly = new Wisej.Web.CheckBox();
			this.SuspendLayout();
			// 
			// ckEditor1
			// 
			this.ckEditor1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ckEditor1.Location = new System.Drawing.Point(413, 3);
			this.ckEditor1.Name = "ckEditor1";
			this.ckEditor1.Size = new System.Drawing.Size(839, 468);
			this.ckEditor1.TabIndex = 0;
			this.ckEditor1.Text = "ckEditor1";
			// 
			// checkBoxToolbar
			// 
			this.checkBoxToolbar.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxToolbar.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxToolbar.AutoSize = false;
			this.checkBoxToolbar.Checked = true;
			this.checkBoxToolbar.Location = new System.Drawing.Point(170, 289);
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
			this.checkBoxFooter.Location = new System.Drawing.Point(170, 220);
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
			this.checkBoxReadOnly.Location = new System.Drawing.Point(170, 151);
			this.checkBoxReadOnly.Name = "checkBoxReadOnly";
			this.checkBoxReadOnly.Size = new System.Drawing.Size(200, 35);
			this.checkBoxReadOnly.TabIndex = 6;
			this.checkBoxReadOnly.Text = "Read Only";
			this.checkBoxReadOnly.CheckedChanged += new System.EventHandler(this.checkBoxReadOnly_CheckedChanged);
			// 
			// Features
			// 
			this.Controls.Add(this.checkBoxToolbar);
			this.Controls.Add(this.checkBoxFooter);
			this.Controls.Add(this.checkBoxReadOnly);
			this.Controls.Add(this.ckEditor1);
			this.Name = "Features";
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.CKEditor.CKEditor ckEditor1;
		private Web.CheckBox checkBoxToolbar;
		private Web.CheckBox checkBoxFooter;
		private Web.CheckBox checkBoxReadOnly;
	}
}
