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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCellLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonToColor);
            this.groupBox1.Controls.Add(this.buttonFromColor);
            this.groupBox1.Controls.Add(this.checkBoxSelection);
            this.groupBox1.Size = new System.Drawing.Size(250, 401);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxSelection, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonFromColor, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonToColor, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxCellLabel, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 320);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.heatMap1);
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
            this.checkBoxSelection.Location = new System.Drawing.Point(16, 33);
            this.checkBoxSelection.Name = "checkBoxSelection";
            this.checkBoxSelection.Size = new System.Drawing.Size(159, 24);
            this.checkBoxSelection.TabIndex = 8;
            this.checkBoxSelection.Text = "Allow selection";
            // 
            // buttonFromColor
            // 
            this.buttonFromColor.BackColor = System.Drawing.Color.FromArgb(18, 215, 182);
            this.buttonFromColor.Location = new System.Drawing.Point(15, 130);
            this.buttonFromColor.Name = "buttonFromColor";
            this.buttonFromColor.Size = new System.Drawing.Size(100, 27);
            this.buttonFromColor.TabIndex = 9;
            this.buttonFromColor.Text = "From";
            this.buttonFromColor.Click += new System.EventHandler(this.buttonFromColor_Click);
            // 
            // buttonToColor
            // 
            this.buttonToColor.BackColor = System.Drawing.Color.FromArgb(19, 110, 214);
            this.buttonToColor.Location = new System.Drawing.Point(132, 130);
            this.buttonToColor.Name = "buttonToColor";
            this.buttonToColor.Size = new System.Drawing.Size(100, 27);
            this.buttonToColor.TabIndex = 10;
            this.buttonToColor.Text = "To";
            this.buttonToColor.Click += new System.EventHandler(this.buttonToColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Palette settings";
            // 
            // checkBoxCellLabel
            // 
            this.checkBoxCellLabel.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxCellLabel.Location = new System.Drawing.Point(16, 72);
            this.checkBoxCellLabel.Name = "checkBoxCellLabel";
            this.checkBoxCellLabel.Size = new System.Drawing.Size(159, 24);
            this.checkBoxCellLabel.TabIndex = 12;
            this.checkBoxCellLabel.Text = "Show cell label";
            // 
            // HeatMap
            // 
            this.Name = "HeatMap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
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
