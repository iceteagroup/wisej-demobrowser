namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igSparkline
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
			this.igSparkline1 = new Wisej.Web.Ext.Ignite.igSparkline();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonSave = new Wisej.Web.Button();
			this.button1 = new Wisej.Web.Button();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Size = new System.Drawing.Size(250, 487);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 403);
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igSparkline1);
			this.panel.Size = new System.Drawing.Size(565, 487);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/sparkline/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "https://www.igniteui.com/help/api/2019.2/ui.igsparkline";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igsparkline-landing";
			// 
			// igSparkline1
			// 
			this.igSparkline1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igSparkline1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.igSparkline1.Location = new System.Drawing.Point(21, 120);
			this.igSparkline1.Name = "igSparkline1";
			this.igSparkline1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"valueMemberPath\":\"ExtendedPrice\",\"tooltipTemplate\":\"Low:${Low}<br>High:${High}\"" +
        "}")));
			this.igSparkline1.Size = new System.Drawing.Size(520, 244);
			this.igSparkline1.TabIndex = 0;
			this.igSparkline1.Text = "igSparkline1";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 326);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 4;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(76, 326);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 5;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 3;
			this.button1.Text = "Add Random Item";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "line",
            "area",
            "column",
            "winLoss"});
			this.comboBox1.Label.Text = "Display Type";
			this.comboBox1.Location = new System.Drawing.Point(28, 112);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 41);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "line";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Line Thickness";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 188);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "none",
            "linearFit",
            "quadraticFit",
            "cubicFit",
            "quarticFit",
            "quinticFit",
            "logarithmicFit",
            "exponentialFit",
            "powerLawFit",
            "simpleAverage",
            "exponentialAverage",
            "modifiedAverage",
            "cumulativeAverage",
            "weightedAverage"});
			this.comboBox2.Label.Text = "Trend Line Type";
			this.comboBox2.Location = new System.Drawing.Point(28, 36);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 41);
			this.comboBox2.TabIndex = 0;
			this.comboBox2.Text = "none";
			// 
			// igSparkline
			// 
			this.Name = "igSparkline";
			this.Size = new System.Drawing.Size(974, 677);
			this.Load += new System.EventHandler(this.igSparkline_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igSparkline igSparkline1;
		private Upload buttonLoad;
		private Button buttonSave;
		private NumericUpDown numericUpDown1;
		private ComboBox comboBox1;
		private Button button1;
		private ComboBox comboBox2;
	}
}
