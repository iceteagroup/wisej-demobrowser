namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Sparkline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sparkline));
            this.sparkline1 = new Wisej.Web.Ext.Syncfusion2.Sparkline();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/sparkline/es5-getting-started" +
    "/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/sparkline";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.sparkline1);
            this.panel.Size = new System.Drawing.Size(861, 564);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/sparkline/default.html";
            // 
            // sparkline1
            // 
            this.sparkline1.Anchor = Wisej.Web.AnchorStyles.None;
            this.sparkline1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.sparkline1.Location = new System.Drawing.Point(211, 133);
            this.sparkline1.Name = "sparkline1";
            this.sparkline1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("sparkline1.Options"))));
            this.sparkline1.Size = new System.Drawing.Size(437, 297);
            this.sparkline1.TabIndex = 0;
            this.sparkline1.Text = "sparkline1";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Line",
            "Area",
            "WinLoss",
            "Column"});
            this.comboBox1.LabelText = "Type";
            this.comboBox1.Location = new System.Drawing.Point(28, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 53);
            this.comboBox1.TabIndex = 1;
            // 
            // Sparkline
            // 
            this.Name = "Sparkline";
            this.Size = new System.Drawing.Size(1270, 754);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Sparkline sparkline1;
        private ComboBox comboBox1;
    }
}
