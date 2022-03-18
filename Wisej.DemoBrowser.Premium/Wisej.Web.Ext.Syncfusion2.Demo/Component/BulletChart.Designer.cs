namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class BulletChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulletChart));
            this.bulletChart1 = new Wisej.Web.Ext.Syncfusion2.BulletChart();
            this.numericUpDownValue = new Wisej.Web.NumericUpDown();
            this.numericUpDownTarget = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Size = new System.Drawing.Size(642, 24);
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/bullet-chart/es5-getting-star" +
    "ted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/bullet-chart/overview/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownTarget);
            this.groupBox1.Controls.Add(this.numericUpDownValue);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownValue, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownTarget, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.bulletChart1);
            this.panel.Size = new System.Drawing.Size(525, 322);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/bullet-chart/default.html";
            // 
            // bulletChart1
            // 
            this.bulletChart1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.bulletChart1.Location = new System.Drawing.Point(8, 8);
            this.bulletChart1.Name = "bulletChart1";
            this.bulletChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("bulletChart1.Options"))));
            this.bulletChart1.Size = new System.Drawing.Size(507, 121);
            this.bulletChart1.TabIndex = 0;
            this.bulletChart1.Text = "bulletChart1";
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.LabelText = "Value";
            this.numericUpDownValue.Location = new System.Drawing.Point(11, 56);
            this.numericUpDownValue.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(231, 53);
            this.numericUpDownValue.TabIndex = 1;
            this.numericUpDownValue.Value = new decimal(new int[] {
            270,
            0,
            0,
            0});
            // 
            // numericUpDownTarget
            // 
            this.numericUpDownTarget.LabelText = "Target";
            this.numericUpDownTarget.Location = new System.Drawing.Point(11, 139);
            this.numericUpDownTarget.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownTarget.Name = "numericUpDownTarget";
            this.numericUpDownTarget.Size = new System.Drawing.Size(231, 53);
            this.numericUpDownTarget.TabIndex = 2;
            this.numericUpDownTarget.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // BulletChart
            // 
            this.Name = "BulletChart";
            this.Size = new System.Drawing.Size(934, 512);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.BulletChart bulletChart1;
        private NumericUpDown numericUpDownValue;
        private NumericUpDown numericUpDownTarget;
    }
}
