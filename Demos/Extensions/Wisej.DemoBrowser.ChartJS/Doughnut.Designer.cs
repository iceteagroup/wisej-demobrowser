namespace Wisej.DemoBrowser.ChartJS
{
	partial class Doughnut
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
            this.chartJS1 = new Wisej.Web.Ext.ChartJS.ChartJS();
            this.buttonAdd = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartJS1
            // 
            this.chartJS1.ChartType = Wisej.Web.Ext.ChartJS.ChartType.Doughnut;
            this.flowLayoutPanel1.SetFillWeight(this.chartJS1, 3);
            this.chartJS1.Location = new System.Drawing.Point(272, 3);
            this.chartJS1.MinimumSize = new System.Drawing.Size(300, 0);
            this.chartJS1.Name = "chartJS1";
            this.chartJS1.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartJS1.Options.DataLabel.Opacity = 1F;
            this.chartJS1.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS.DataLabelTextAlignment.Start;
            this.chartJS1.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartJS1.Size = new System.Drawing.Size(789, 355);
            this.chartJS1.TabIndex = 0;
            this.chartJS1.Text = "Doughnut Chart";
            this.chartJS1.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS1_ChartClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = Wisej.Web.AnchorStyles.None;
            this.buttonAdd.Location = new System.Drawing.Point(47, 139);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(168, 37);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add DataSet";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(47, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove DataSet";
            this.button1.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(225, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 355);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.chartJS1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(179, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1064, 363);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Doughnut
            // 
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Doughnut";
            this.Load += new System.EventHandler(this.Doughnut_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Ext.ChartJS.ChartJS chartJS1;
		private Web.Button buttonAdd;
		private Web.Button button1;
        private Web.Panel panel1;
        private Web.FlowLayoutPanel flowLayoutPanel1;
    }
}
