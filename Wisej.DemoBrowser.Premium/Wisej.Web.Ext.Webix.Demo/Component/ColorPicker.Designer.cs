namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class ColorPicker
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
            this.colorPicker1 = new Wisej.Web.Ext.Webix.ColorPicker();
            this.checkBoxClear = new Wisej.Web.CheckBox();
            this.checkBoxShowIcon = new Wisej.Web.CheckBox();
            this.checkBoxStringResult = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#colorpicker";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.colorpicker.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.colorPicker1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxClear);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowIcon);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxStringResult);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 434);
            // 
            // colorPicker1
            // 
            this.colorPicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.colorPicker1.Location = new System.Drawing.Point(394, 259);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(300, 40);
            this.colorPicker1.TabIndex = 11;
            this.colorPicker1.Text = "colorPicker1";
            // 
            // checkBoxClear
            // 
            this.checkBoxClear.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxClear.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxClear.AutoSize = false;
            this.checkBoxClear.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxClear, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxClear, true);
            this.checkBoxClear.Location = new System.Drawing.Point(3, 3);
            this.checkBoxClear.Name = "checkBoxClear";
            this.checkBoxClear.Size = new System.Drawing.Size(212, 26);
            this.checkBoxClear.TabIndex = 0;
            this.checkBoxClear.Text = "Clear";
            // 
            // checkBoxShowIcon
            // 
            this.checkBoxShowIcon.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxShowIcon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowIcon.AutoSize = false;
            this.checkBoxShowIcon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxShowIcon, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxShowIcon, true);
            this.checkBoxShowIcon.Location = new System.Drawing.Point(3, 48);
            this.checkBoxShowIcon.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxShowIcon.Name = "checkBoxShowIcon";
            this.checkBoxShowIcon.Size = new System.Drawing.Size(212, 26);
            this.checkBoxShowIcon.TabIndex = 1;
            this.checkBoxShowIcon.Text = "Show Icons";
            // 
            // checkBoxStringResult
            // 
            this.checkBoxStringResult.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxStringResult.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxStringResult.AutoSize = false;
            this.checkBoxStringResult.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxStringResult, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxStringResult, true);
            this.checkBoxStringResult.Location = new System.Drawing.Point(3, 93);
            this.checkBoxStringResult.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxStringResult.Name = "checkBoxStringResult";
            this.checkBoxStringResult.Size = new System.Drawing.Size(212, 26);
            this.checkBoxStringResult.TabIndex = 2;
            this.checkBoxStringResult.Text = "String Result";
            // 
            // ColorPicker
            // 
            this.Name = "ColorPicker";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.ColorPicker colorPicker1;
        private CheckBox checkBoxClear;
        private CheckBox checkBoxShowIcon;
        private CheckBox checkBoxStringResult;
    }
}
