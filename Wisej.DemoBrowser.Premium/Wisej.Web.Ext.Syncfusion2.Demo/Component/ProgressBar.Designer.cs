namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class ProgressBar
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
            this.progressBar1 = new Wisej.Web.Ext.Syncfusion2.ProgressBar();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.checkBoxAnimationEnable = new Wisej.Web.CheckBox();
            this.numericUpDownAnimationDuration = new Wisej.Web.NumericUpDown();
            this.numericUpDownAnimationDelay = new Wisej.Web.NumericUpDown();
            this.checkBoxPieProgress = new Wisej.Web.CheckBox();
            this.checkBoxProcessSegment = new Wisej.Web.CheckBox();
            this.checkBoxIsIndeterminate = new Wisej.Web.CheckBox();
            this.checkBoxIsStriped = new Wisej.Web.CheckBox();
            this.comboBoxType = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimationDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimationDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/progress-bar/es5-getting-star" +
    "ted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/progressbar";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.progressBar1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxPieProgress);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxProcessSegment);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxIsIndeterminate);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxIsStriped);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxType);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/progress-bar/linear.html";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(107, 261);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":70,\"trackThickness\":15,\"progressThickness\":15,\"showProgressValue\":true,\"" +
        "height\":\"30\",\"animation\":{\"enable\":true,\"duration\":2000,\"delay\":0}}")));
            this.progressBar1.Size = new System.Drawing.Size(874, 36);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Text = "progressBar1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxAnimationEnable);
            this.groupBox2.Controls.Add(this.numericUpDownAnimationDuration);
            this.groupBox2.Controls.Add(this.numericUpDownAnimationDelay);
            this.flowLayoutPanel1.SetFillWeight(this.groupBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.groupBox2, true);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "Animation";
            // 
            // checkBoxAnimationEnable
            // 
            this.checkBoxAnimationEnable.Checked = true;
            this.checkBoxAnimationEnable.Location = new System.Drawing.Point(6, 27);
            this.checkBoxAnimationEnable.Name = "checkBoxAnimationEnable";
            this.checkBoxAnimationEnable.Size = new System.Drawing.Size(81, 27);
            this.checkBoxAnimationEnable.TabIndex = 3;
            this.checkBoxAnimationEnable.Text = "Enable";
            this.checkBoxAnimationEnable.CheckedChanged += new System.EventHandler(this.checkBoxAnimationEnable_CheckedChanged);
            // 
            // numericUpDownAnimationDuration
            // 
            this.numericUpDownAnimationDuration.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAnimationDuration.LabelText = "Duration";
            this.numericUpDownAnimationDuration.Location = new System.Drawing.Point(6, 111);
            this.numericUpDownAnimationDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAnimationDuration.Name = "numericUpDownAnimationDuration";
            this.numericUpDownAnimationDuration.Size = new System.Drawing.Size(200, 57);
            this.numericUpDownAnimationDuration.TabIndex = 2;
            this.numericUpDownAnimationDuration.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericUpDownAnimationDelay
            // 
            this.numericUpDownAnimationDelay.LabelText = "Delay";
            this.numericUpDownAnimationDelay.Location = new System.Drawing.Point(6, 52);
            this.numericUpDownAnimationDelay.Name = "numericUpDownAnimationDelay";
            this.numericUpDownAnimationDelay.Size = new System.Drawing.Size(200, 57);
            this.numericUpDownAnimationDelay.TabIndex = 1;
            // 
            // checkBoxPieProgress
            // 
            this.checkBoxPieProgress.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxPieProgress, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxPieProgress, true);
            this.checkBoxPieProgress.Location = new System.Drawing.Point(3, 194);
            this.checkBoxPieProgress.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxPieProgress.Name = "checkBoxPieProgress";
            this.checkBoxPieProgress.Size = new System.Drawing.Size(212, 24);
            this.checkBoxPieProgress.TabIndex = 4;
            this.checkBoxPieProgress.Text = "Enable Pie Progress";
            // 
            // checkBoxProcessSegment
            // 
            this.checkBoxProcessSegment.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxProcessSegment, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxProcessSegment, true);
            this.checkBoxProcessSegment.Location = new System.Drawing.Point(3, 237);
            this.checkBoxProcessSegment.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxProcessSegment.Name = "checkBoxProcessSegment";
            this.checkBoxProcessSegment.Size = new System.Drawing.Size(212, 24);
            this.checkBoxProcessSegment.TabIndex = 5;
            this.checkBoxProcessSegment.Text = "Process Segment";
            // 
            // checkBoxIsIndeterminate
            // 
            this.checkBoxIsIndeterminate.Anchor = Wisej.Web.AnchorStyles.Left;
            this.checkBoxIsIndeterminate.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxIsIndeterminate, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxIsIndeterminate, true);
            this.checkBoxIsIndeterminate.Location = new System.Drawing.Point(3, 280);
            this.checkBoxIsIndeterminate.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxIsIndeterminate.Name = "checkBoxIsIndeterminate";
            this.checkBoxIsIndeterminate.Size = new System.Drawing.Size(212, 24);
            this.checkBoxIsIndeterminate.TabIndex = 6;
            this.checkBoxIsIndeterminate.Text = "Is Indeterminate";
            // 
            // checkBoxIsStriped
            // 
            this.checkBoxIsStriped.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxIsStriped, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxIsStriped, true);
            this.checkBoxIsStriped.Location = new System.Drawing.Point(3, 323);
            this.checkBoxIsStriped.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxIsStriped.Name = "checkBoxIsStriped";
            this.checkBoxIsStriped.Size = new System.Drawing.Size(212, 24);
            this.checkBoxIsStriped.TabIndex = 7;
            this.checkBoxIsStriped.Text = "Is Striped";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxType, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxType, true);
            this.comboBoxType.Items.AddRange(new object[] {
            "Linear",
            "Circular"});
            this.comboBoxType.LabelText = "Type";
            this.comboBoxType.Location = new System.Drawing.Point(3, 366);
            this.comboBoxType.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(212, 57);
            this.comboBoxType.TabIndex = 9;
            // 
            // ProgressBar
            // 
            this.Name = "ProgressBar";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimationDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimationDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.ProgressBar progressBar1;
        private CheckBox checkBoxIsStriped;
        private CheckBox checkBoxIsIndeterminate;
        private CheckBox checkBoxProcessSegment;
        private CheckBox checkBoxPieProgress;
        private GroupBox groupBox2;
        private CheckBox checkBoxAnimationEnable;
        private NumericUpDown numericUpDownAnimationDuration;
        private NumericUpDown numericUpDownAnimationDelay;
        private ComboBox comboBoxType;
    }
}
