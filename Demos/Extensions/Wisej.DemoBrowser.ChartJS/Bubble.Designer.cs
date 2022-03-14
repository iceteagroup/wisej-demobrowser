namespace Wisej.DemoBrowser.ChartJS
{
	partial class Bubble
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
            this.buttonAdd = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.chartJS1 = new Wisej.Web.Ext.ChartJS.ChartJS();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = Wisej.Web.AnchorStyles.Left;
            this.buttonAdd.Location = new System.Drawing.Point(163, 197);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(168, 37);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add DataSet";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(163, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove DataSet";
            this.button1.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // chartJS1
            // 
            this.chartJS1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.chartJS1.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Bubble;
            this.chartJS1.Location = new System.Drawing.Point(409, 43);
            this.chartJS1.Name = "chartJS1";
            this.chartJS1.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartJS1.Options.DataLabel.Opacity = 1F;
            this.chartJS1.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS.DataLabelTextAlignment.Start;
            this.chartJS1.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartJS1.Size = new System.Drawing.Size(604, 389);
            this.chartJS1.TabIndex = 3;
            this.chartJS1.Text = "Bubble Chart";
            this.chartJS1.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS1_ChartClick);
            // 
            // Bubble
            // 
            this.Controls.Add(this.chartJS1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.MinimumSize = new System.Drawing.Size(1422, 474);
            this.Name = "Bubble";
            this.Load += new System.EventHandler(this.Scatter_Load);
            this.ResumeLayout(false);

		}

		#endregion
		private Web.Button buttonAdd;
		private Web.Button button1;
        private Web.Ext.ChartJS.ChartJS chartJS1;
    }
}
