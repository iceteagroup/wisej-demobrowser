namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igHierarchicalGrid
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
            this.igHierarchicalGrid1 = new Wisej.Web.Ext.Ignite.igHierarchicalGrid();
            this.checkBoxAlternateRowStyles = new Wisej.Web.CheckBox();
            this.checkBoxHoverStyles = new Wisej.Web.CheckBox();
            this.checkBoxAnimations = new Wisej.Web.CheckBox();
            this.textBoxCaption = new Wisej.Web.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igHierarchicalGrid1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/hierarchical-grid/overview";
            // 
            // linkApi
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igHierarchicalGrid";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/ighierarchicalgrid-ighierarchicalgrid";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxHoverStyles);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAlternateRowStyles);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAnimations);
            this.flowLayoutPanel1.Controls.Add(this.textBoxCaption);
            // 
            // igHierarchicalGrid1
            // 
            this.igHierarchicalGrid1.Dock = Wisej.Web.DockStyle.Fill;
            this.igHierarchicalGrid1.Location = new System.Drawing.Point(8, 8);
            this.igHierarchicalGrid1.Name = "igHierarchicalGrid1";
            this.igHierarchicalGrid1.Size = new System.Drawing.Size(872, 560);
            this.igHierarchicalGrid1.TabIndex = 0;
            this.igHierarchicalGrid1.Text = "igHierarchicalGrid1";
            // 
            // checkBoxAlternateRowStyles
            // 
            this.checkBoxAlternateRowStyles.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAlternateRowStyles.AutoSize = false;
            this.checkBoxAlternateRowStyles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAlternateRowStyles.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxAlternateRowStyles, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxAlternateRowStyles, true);
            this.checkBoxAlternateRowStyles.Location = new System.Drawing.Point(3, 60);
            this.checkBoxAlternateRowStyles.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxAlternateRowStyles.Name = "checkBoxAlternateRowStyles";
            this.checkBoxAlternateRowStyles.Size = new System.Drawing.Size(212, 38);
            this.checkBoxAlternateRowStyles.TabIndex = 1;
            this.checkBoxAlternateRowStyles.Text = "Alternate Row Styles";
            // 
            // checkBoxHoverStyles
            // 
            this.checkBoxHoverStyles.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxHoverStyles.AutoSize = false;
            this.checkBoxHoverStyles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxHoverStyles.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxHoverStyles, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxHoverStyles, true);
            this.checkBoxHoverStyles.Location = new System.Drawing.Point(3, 3);
            this.checkBoxHoverStyles.Name = "checkBoxHoverStyles";
            this.checkBoxHoverStyles.Size = new System.Drawing.Size(212, 38);
            this.checkBoxHoverStyles.TabIndex = 0;
            this.checkBoxHoverStyles.Text = "Enable Hover Styles";
            // 
            // checkBoxAnimations
            // 
            this.checkBoxAnimations.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAnimations.AutoSize = false;
            this.checkBoxAnimations.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAnimations.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxAnimations, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxAnimations, true);
            this.checkBoxAnimations.Location = new System.Drawing.Point(3, 117);
            this.checkBoxAnimations.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxAnimations.Name = "checkBoxAnimations";
            this.checkBoxAnimations.Size = new System.Drawing.Size(212, 50);
            this.checkBoxAnimations.TabIndex = 2;
            this.checkBoxAnimations.Text = "Expand Collapse Animations";
            // 
            // textBox1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.textBoxCaption, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxCaption, true);
            this.textBoxCaption.LabelText = "Caption Text";
            this.textBoxCaption.Location = new System.Drawing.Point(3, 186);
            this.textBoxCaption.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.textBoxCaption.Name = "textBox1";
            this.textBoxCaption.Size = new System.Drawing.Size(212, 57);
            this.textBoxCaption.TabIndex = 3;
            this.textBoxCaption.Text = "Sales Data";
            // 
            // igHierarchicalGrid
            // 
            this.Name = "igHierarchicalGrid";
            this.Load += new System.EventHandler(this.igHierarchicalGrid_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igHierarchicalGrid igHierarchicalGrid1;
		private CheckBox checkBoxAlternateRowStyles;
		private CheckBox checkBoxHoverStyles;
		private CheckBox checkBoxAnimations;
        private TextBox textBoxCaption;
    }
}
