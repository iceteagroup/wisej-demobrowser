namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class TimeLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeLine));
            this.timeLine1 = new Wisej.Web.Ext.Webix.TimeLine();
            this.comboBoxLayout = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__timeline.html";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#timeline";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://docs.webix.com/api__refs__ui.timeline.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.timeLine1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBoxLayout);
            // 
            // timeLine1
            // 
            this.timeLine1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.timeLine1.Location = new System.Drawing.Point(56, 61);
            this.timeLine1.Name = "timeLine1";
            this.timeLine1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("timeLine1.Options"))));
            this.timeLine1.Size = new System.Drawing.Size(977, 436);
            this.timeLine1.TabIndex = 11;
            this.timeLine1.Text = "timeLine1";
            // 
            // comboBoxLayout
            // 
            this.comboBoxLayout.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxLayout.Items.AddRange(new object[] {
            "x",
            "y"});
            this.comboBoxLayout.LabelText = "Layout";
            this.comboBoxLayout.Location = new System.Drawing.Point(3, 3);
            this.comboBoxLayout.Name = "comboBoxLayout";
            this.comboBoxLayout.Size = new System.Drawing.Size(212, 46);
            this.comboBoxLayout.TabIndex = 1;
            // 
            // TimeLine
            // 
            this.Name = "TimeLine";
            this.Load += new System.EventHandler(this.TimeLine_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.TimeLine timeLine1;
        private ComboBox comboBoxLayout;
    }
}
