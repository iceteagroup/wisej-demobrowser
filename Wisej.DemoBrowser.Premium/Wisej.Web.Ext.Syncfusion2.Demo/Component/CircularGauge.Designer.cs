namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class CircularGauge
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
            this.circularGauge1 = new Wisej.Web.Ext.Syncfusion2.CircularGauge();
            this.numericUpDownValue = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/circular-gauge/es5-getting-st" +
    "arted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/circular-gauge/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownValue);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownValue, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.circularGauge1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/circular-gauge/default.html";
            // 
            // circularGauge1
            // 
            this.circularGauge1.Location = new System.Drawing.Point(8, 8);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"enablePointerDrag\":true,\"enableRangeDrag\":true,\"axes\":[{\"pointers\":[{\"value\":35" +
        "}]}]}")));
            this.circularGauge1.Size = new System.Drawing.Size(1073, 542);
            this.circularGauge1.TabIndex = 0;
            this.circularGauge1.Text = "circularGauge1";
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.numericUpDownValue.LabelText = "Value";
            this.numericUpDownValue.Location = new System.Drawing.Point(28, 74);
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(195, 53);
            this.numericUpDownValue.TabIndex = 1;
            this.numericUpDownValue.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // CircularGauge
            // 
            this.Name = "CircularGauge";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.CircularGauge circularGauge1;
        private NumericUpDown numericUpDownValue;
    }
}
