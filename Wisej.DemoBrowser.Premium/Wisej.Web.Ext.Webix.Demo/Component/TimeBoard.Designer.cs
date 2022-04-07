namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class TimeBoard
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
            this.timeBoard1 = new Wisej.Web.Ext.Webix.TimeBoard();
            this.checkBoxShowSeconds = new Wisej.Web.CheckBox();
            this.checkBoxShowTwelve = new Wisej.Web.CheckBox();
            this.checkBoxEnableStringResult = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__timeboard.html";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#timeboard";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.timeboard.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.timeBoard1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowTwelve);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowSeconds);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableStringResult);
            // 
            // timeBoard1
            // 
            this.timeBoard1.Anchor = Wisej.Web.AnchorStyles.None;
            this.timeBoard1.Location = new System.Drawing.Point(294, 188);
            this.timeBoard1.Name = "timeBoard1";
            this.timeBoard1.Size = new System.Drawing.Size(500, 183);
            this.timeBoard1.TabIndex = 11;
            this.timeBoard1.Text = "timeBoard1";
            // 
            // checkBoxShowSeconds
            // 
            this.checkBoxShowSeconds.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxShowSeconds.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowSeconds.AutoSize = false;
            this.checkBoxShowSeconds.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowSeconds.Location = new System.Drawing.Point(3, 35);
            this.checkBoxShowSeconds.Name = "checkBoxShowSeconds";
            this.checkBoxShowSeconds.Size = new System.Drawing.Size(212, 26);
            this.checkBoxShowSeconds.TabIndex = 0;
            this.checkBoxShowSeconds.Text = "Show seconds";
            // 
            // checkBoxShowTwelve
            // 
            this.checkBoxShowTwelve.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxShowTwelve.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowTwelve.AutoSize = false;
            this.checkBoxShowTwelve.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowTwelve.Location = new System.Drawing.Point(3, 3);
            this.checkBoxShowTwelve.Name = "checkBoxShowTwelve";
            this.checkBoxShowTwelve.Size = new System.Drawing.Size(212, 26);
            this.checkBoxShowTwelve.TabIndex = 1;
            this.checkBoxShowTwelve.Text = "Show twelve";
            // 
            // checkBoxEnableStringResult
            // 
            this.checkBoxEnableStringResult.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableStringResult.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableStringResult.AutoSize = false;
            this.checkBoxEnableStringResult.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEnableStringResult.Location = new System.Drawing.Point(3, 67);
            this.checkBoxEnableStringResult.Name = "checkBoxEnableStringResult";
            this.checkBoxEnableStringResult.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableStringResult.TabIndex = 2;
            this.checkBoxEnableStringResult.Text = "Enable string result";
            // 
            // TimeBoard
            // 
            this.Name = "TimeBoard";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.TimeBoard timeBoard1;
        private CheckBox checkBoxShowSeconds;
        private CheckBox checkBoxShowTwelve;
        private CheckBox checkBoxEnableStringResult;
    }
}
