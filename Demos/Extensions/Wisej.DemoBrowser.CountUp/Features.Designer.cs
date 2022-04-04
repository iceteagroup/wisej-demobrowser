namespace Wisej.DemoBrowser.CountUp
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
            this.countUp1 = new Wisej.Web.Ext.CountUp.CountUp();
            this.numericUpDownValue = new Wisej.Web.NumericUpDown();
            this.numericUpDownDuration = new Wisej.Web.NumericUpDown();
            this.checkBoxGrouping = new Wisej.Web.CheckBox();
            this.checkBoxEasing = new Wisej.Web.CheckBox();
            this.buttonUpdate = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // countUp1
            // 
            this.countUp1.Anchor = Wisej.Web.AnchorStyles.None;
            this.countUp1.Font = new System.Drawing.Font("windowTitle", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.countUp1.ForeColor = System.Drawing.Color.FromArgb(77, 99, 188);
            this.countUp1.Location = new System.Drawing.Point(564, 206);
            this.countUp1.Name = "countUp1";
            this.countUp1.Size = new System.Drawing.Size(294, 62);
            this.countUp1.TabIndex = 0;
            this.countUp1.Text = "countUp1";
            this.countUp1.TextAlign = Wisej.Web.HorizontalAlignment.Center;
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDownValue.LabelText = "Value";
            this.numericUpDownValue.Location = new System.Drawing.Point(289, 324);
            this.numericUpDownValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(103, 53);
            this.numericUpDownValue.TabIndex = 1;
            this.numericUpDownValue.ValueChanged += new System.EventHandler(this.numericUpDownValue_ValueChanged);
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDownDuration.LabelText = "Duration";
            this.numericUpDownDuration.Location = new System.Drawing.Point(289, 232);
            this.numericUpDownDuration.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(200, 53);
            this.numericUpDownDuration.TabIndex = 2;
            this.numericUpDownDuration.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownDuration.ValueChanged += new System.EventHandler(this.numericUpDownDuration_ValueChanged);
            // 
            // checkBoxGrouping
            // 
            this.checkBoxGrouping.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBoxGrouping.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxGrouping.AutoSize = false;
            this.checkBoxGrouping.Checked = true;
            this.checkBoxGrouping.Location = new System.Drawing.Point(289, 162);
            this.checkBoxGrouping.Name = "checkBoxGrouping";
            this.checkBoxGrouping.Size = new System.Drawing.Size(200, 35);
            this.checkBoxGrouping.TabIndex = 3;
            this.checkBoxGrouping.Text = "Use Grouping";
            this.checkBoxGrouping.CheckedChanged += new System.EventHandler(this.checkBoxGrouping_CheckedChanged);
            // 
            // checkBoxEasing
            // 
            this.checkBoxEasing.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBoxEasing.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEasing.AutoSize = false;
            this.checkBoxEasing.Checked = true;
            this.checkBoxEasing.Location = new System.Drawing.Point(289, 92);
            this.checkBoxEasing.Name = "checkBoxEasing";
            this.checkBoxEasing.Size = new System.Drawing.Size(200, 35);
            this.checkBoxEasing.TabIndex = 4;
            this.checkBoxEasing.Text = "Use Easing";
            this.checkBoxEasing.CheckedChanged += new System.EventHandler(this.checkBoxEasing_CheckedChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = Wisej.Web.AnchorStyles.None;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.ImageSource = "icon-refresh";
            this.buttonUpdate.Location = new System.Drawing.Point(398, 347);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(91, 30);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.checkBoxEasing);
            this.Controls.Add(this.checkBoxGrouping);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.numericUpDownValue);
            this.Controls.Add(this.countUp1);
            this.Name = "Features";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Ext.CountUp.CountUp countUp1;
		private Web.NumericUpDown numericUpDownValue;
		private Web.NumericUpDown numericUpDownDuration;
		private Web.CheckBox checkBoxGrouping;
		private Web.CheckBox checkBoxEasing;
        private Web.Button buttonUpdate;
    }
}
