namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class HeatMap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeatMap));
            this.heatMap1 = new Wisej.Web.Ext.Syncfusion2.HeatMap();
            this.checkBoxSelection = new Wisej.Web.CheckBox();
            this.colorDialogFrom = new Wisej.Web.ColorDialog(this.components);
            this.colorDialogTo = new Wisej.Web.ColorDialog(this.components);
            this.buttonFromColor = new Wisej.Web.Button();
            this.buttonToColor = new Wisej.Web.Button();
            this.label4 = new Wisej.Web.Label();
            this.checkBoxCellLabel = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/heatmap-chart/getting-started" +
    "/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/heatmap/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.heatMap1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxSelection);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxCellLabel);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.buttonFromColor);
            this.flowLayoutPanel1.Controls.Add(this.buttonToColor);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/heatmap-chart/default.html";
            // 
            // heatMap1
            // 
            this.heatMap1.Dock = Wisej.Web.DockStyle.Fill;
            this.heatMap1.Location = new System.Drawing.Point(8, 8);
            this.heatMap1.Name = "heatMap1";
            this.heatMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("heatMap1.Options"))));
            this.heatMap1.Size = new System.Drawing.Size(1073, 542);
            this.heatMap1.TabIndex = 0;
            this.heatMap1.Text = "heatMap1";
            // 
            // checkBoxSelection
            // 
            this.checkBoxSelection.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxSelection, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxSelection, true);
            this.checkBoxSelection.Location = new System.Drawing.Point(3, 3);
            this.checkBoxSelection.Name = "checkBoxSelection";
            this.checkBoxSelection.Size = new System.Drawing.Size(212, 24);
            this.checkBoxSelection.TabIndex = 8;
            this.checkBoxSelection.Text = "Allow Selection";
            // 
            // buttonFromColor
            // 
            this.buttonFromColor.BackColor = System.Drawing.Color.FromArgb(18, 215, 182);
            this.flowLayoutPanel1.SetFillWeight(this.buttonFromColor, 1);
            this.buttonFromColor.ForeColor = System.Drawing.Color.White;
            this.buttonFromColor.Location = new System.Drawing.Point(3, 117);
            this.buttonFromColor.Name = "buttonFromColor";
            this.buttonFromColor.Size = new System.Drawing.Size(103, 27);
            this.buttonFromColor.TabIndex = 9;
            this.buttonFromColor.Text = "From";
            this.buttonFromColor.Click += new System.EventHandler(this.buttonFromColor_Click);
            // 
            // buttonToColor
            // 
            this.buttonToColor.BackColor = System.Drawing.Color.FromArgb(19, 110, 214);
            this.flowLayoutPanel1.SetFillWeight(this.buttonToColor, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.buttonToColor, true);
            this.buttonToColor.ForeColor = System.Drawing.Color.White;
            this.buttonToColor.Location = new System.Drawing.Point(112, 117);
            this.buttonToColor.Name = "buttonToColor";
            this.buttonToColor.Size = new System.Drawing.Size(103, 27);
            this.buttonToColor.TabIndex = 10;
            this.buttonToColor.Text = "To";
            this.buttonToColor.Click += new System.EventHandler(this.buttonToColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.flowLayoutPanel1.SetFillWeight(this.label4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.label4, true);
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Palette Settings";
            // 
            // checkBoxCellLabel
            // 
            this.checkBoxCellLabel.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxCellLabel, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxCellLabel, true);
            this.checkBoxCellLabel.Location = new System.Drawing.Point(3, 46);
            this.checkBoxCellLabel.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxCellLabel.Name = "checkBoxCellLabel";
            this.checkBoxCellLabel.Size = new System.Drawing.Size(212, 24);
            this.checkBoxCellLabel.TabIndex = 12;
            this.checkBoxCellLabel.Text = "Show Cell Label";
            // 
            // HeatMap
            // 
            this.Name = "HeatMap";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.HeatMap heatMap1;
        private Button buttonToColor;
        private Button buttonFromColor;
        private CheckBox checkBoxSelection;
        private ColorDialog colorDialogFrom;
        private ColorDialog colorDialogTo;
        private Label label4;
        private CheckBox checkBoxCellLabel;
    }
}
