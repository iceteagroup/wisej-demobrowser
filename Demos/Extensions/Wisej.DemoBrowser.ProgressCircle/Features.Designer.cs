namespace Wisej.DemoBrowser.ProgressCircle
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
            this.progressCircle1 = new Wisej.Web.Ext.ProgressCircle.ProgressCircle();
            this.checkBoxShowValue = new Wisej.Web.CheckBox();
            this.checkBoxFill = new Wisej.Web.CheckBox();
            this.comboBoxLineCap = new Wisej.Web.ComboBox();
            this.trackBarProgress = new Wisej.Web.TrackBar();
            this.label1 = new Wisej.Web.Label();
            this.panel1 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressCircle1
            // 
            this.progressCircle1.Anchor = Wisej.Web.AnchorStyles.None;
            this.flowLayoutPanel1.SetFillWeight(this.progressCircle1, 1);
            this.progressCircle1.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.progressCircle1.ForeColor = System.Drawing.Color.FromArgb(33, 139, 33);
            this.progressCircle1.LineWidth = 10;
            this.progressCircle1.Location = new System.Drawing.Point(556, 3);
            this.progressCircle1.MinimumSize = new System.Drawing.Size(250, 0);
            this.progressCircle1.Name = "progressCircle1";
            this.progressCircle1.Size = new System.Drawing.Size(547, 330);
            this.progressCircle1.Value = 10;
            // 
            // checkBoxShowValue
            // 
            this.checkBoxShowValue.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBoxShowValue.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowValue.AutoSize = false;
            this.checkBoxShowValue.Checked = true;
            this.checkBoxShowValue.Location = new System.Drawing.Point(173, 94);
            this.checkBoxShowValue.Name = "checkBoxShowValue";
            this.checkBoxShowValue.Size = new System.Drawing.Size(200, 35);
            this.checkBoxShowValue.TabIndex = 10;
            this.checkBoxShowValue.Text = "Show Value";
            this.checkBoxShowValue.CheckedChanged += new System.EventHandler(this.checkBoxShowValue_CheckedChanged);
            // 
            // checkBoxFill
            // 
            this.checkBoxFill.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBoxFill.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFill.AutoSize = false;
            this.checkBoxFill.Location = new System.Drawing.Point(173, 15);
            this.checkBoxFill.Name = "checkBoxFill";
            this.checkBoxFill.Size = new System.Drawing.Size(200, 35);
            this.checkBoxFill.TabIndex = 9;
            this.checkBoxFill.Text = "Fill Circle";
            this.checkBoxFill.CheckedChanged += new System.EventHandler(this.checkBoxFill_CheckedChanged);
            // 
            // comboBoxLineCap
            // 
            this.comboBoxLineCap.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxLineCap.AutoSize = false;
            this.comboBoxLineCap.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxLineCap.Items.AddRange(new object[] {
            "Butt",
            "Round",
            "Square"});
            this.comboBoxLineCap.LabelText = "Line Cap";
            this.comboBoxLineCap.Location = new System.Drawing.Point(173, 165);
            this.comboBoxLineCap.Name = "comboBoxLineCap";
            this.comboBoxLineCap.Size = new System.Drawing.Size(200, 60);
            this.comboBoxLineCap.TabIndex = 11;
            this.comboBoxLineCap.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineCap_SelectedIndexChanged);
            // 
            // trackBarProgress
            // 
            this.trackBarProgress.Anchor = Wisej.Web.AnchorStyles.None;
            this.trackBarProgress.Location = new System.Drawing.Point(173, 277);
            this.trackBarProgress.Maximum = 100;
            this.trackBarProgress.Name = "trackBarProgress";
            this.trackBarProgress.Size = new System.Drawing.Size(200, 34);
            this.trackBarProgress.TabIndex = 13;
            this.trackBarProgress.TickStyle = Wisej.Web.TickStyle.None;
            this.trackBarProgress.ValueChanged += new System.EventHandler(this.trackBarProgress_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = Wisej.Web.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Progress";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarProgress);
            this.panel1.Controls.Add(this.comboBoxLineCap);
            this.panel1.Controls.Add(this.checkBoxShowValue);
            this.panel1.Controls.Add(this.checkBoxFill);
            this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 331);
            this.panel1.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.progressCircle1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(158, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1106, 337);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // Features
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Ext.ProgressCircle.ProgressCircle progressCircle1;
		private Web.CheckBox checkBoxShowValue;
		private Web.CheckBox checkBoxFill;
		private Web.ComboBox comboBoxLineCap;
		private Web.TrackBar trackBarProgress;
		private Web.Label label1;
        private Web.Panel panel1;
        private Web.FlowLayoutPanel flowLayoutPanel1;
    }
}
