namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejSparkline
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
            this.ejSparkline1 = new Wisej.Web.Ext.Syncfusion.ejSparkline();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/sparkline/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 370);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 284);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(583, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/sparkline/DefaultFunctionalities" +
    "";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejsparkline";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejSparkline1);
            this.panel.TabIndex = 7;
            // 
            // ejSparkline1
            // 
            this.ejSparkline1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejSparkline1.Location = new System.Drawing.Point(8, 8);
            this.ejSparkline1.Name = "ejSparkline1";
            this.ejSparkline1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"isResponsive\":true,\"dataSource\":[2,6,-1,1,12,5,-2,7,-3,5,8,10],\"negativePointCo" +
        "lor\":\"red\",\"highPointColor\":\"blue\",\"tooltip\":{\"visible\":true,\"font\":{\"size\":\"12p" +
        "x\"}},\"type\":\"column\"}")));
            this.ejSparkline1.Size = new System.Drawing.Size(1073, 542);
            this.ejSparkline1.TabIndex = 0;
            this.ejSparkline1.Text = "ejSparkline1";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Line",
            "WinLoss",
            "Column",
            "Area"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Chart Type";
            this.comboBox1.Location = new System.Drawing.Point(28, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 60);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Line";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(28, 34);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Marker Visible";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(28, 110);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 38);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Axis Line Visible";
            // 
            // ejSparkline
            // 
            this.Name = "ejSparkline";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSparkline ejSparkline1;
		private ComboBox comboBox1;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
	}
}
