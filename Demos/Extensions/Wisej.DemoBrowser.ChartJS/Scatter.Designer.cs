namespace Wisej.DemoBrowser.ChartJS
{
	partial class Scatter
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
			Wisej.Web.Ext.ChartJS.OptionScalesAxesX optionScalesAxesX1 = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX();
			Wisej.Web.Ext.ChartJS.OptionsAxisGridLines optionsAxisGridLines1 = new Wisej.Web.Ext.ChartJS.OptionsAxisGridLines();
			this.chartJS1 = new Wisej.Web.Ext.ChartJS.ChartJS();
			this.buttonAdd = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// chartJS1
			// 
			this.chartJS1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.chartJS1.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Scatter;
			this.chartJS1.Location = new System.Drawing.Point(409, 43);
			this.chartJS1.Name = "chartJS1";
			this.chartJS1.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
			this.chartJS1.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
			this.chartJS1.Options.DataLabel.Color = System.Drawing.Color.Black;
			this.chartJS1.Options.DataLabel.Opacity = 1F;
			this.chartJS1.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS.DataLabelTextAlignment.Start;
			this.chartJS1.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
			this.chartJS1.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
			optionsAxisGridLines1.ZeroLineColor = System.Drawing.Color.Empty;
			optionScalesAxesX1.GridLines = optionsAxisGridLines1;
			optionScalesAxesX1.id = null;
			optionScalesAxesX1.Type = Wisej.Web.Ext.ChartJS.ScaleType.Linear;
			this.chartJS1.Options.Scales.xAxes = new Wisej.Web.Ext.ChartJS.OptionScalesAxesX[] {
        optionScalesAxesX1};
			this.chartJS1.Options.Title.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.chartJS1.Size = new System.Drawing.Size(604, 389);
			this.chartJS1.TabIndex = 0;
			this.chartJS1.Text = "Scatter Chart";
			this.chartJS1.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS1_ChartClick);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = Wisej.Web.AnchorStyles.Left;
			this.buttonAdd.Location = new System.Drawing.Point(163, 219);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(168, 37);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Add DataSet";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// Scatter
			// 
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.chartJS1);
			this.Name = "Scatter";
			this.Load += new System.EventHandler(this.Scatter_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.ChartJS.ChartJS chartJS1;
		private Web.Button buttonAdd;
	}
}
