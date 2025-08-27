namespace Wisej.DemoBrowser.Html2Canvas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            this.pnlDemo = new Wisej.Web.Panel();
            this.htmlPanel = new Wisej.Web.HtmlPanel();
            this.chartJS = new Wisej.Web.Ext.ChartJS.ChartJS();
            this.buttonScreenshot = new Wisej.Web.Button();
            this.pnlDemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDemo
            // 
            this.pnlDemo.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pnlDemo.BackColor = System.Drawing.Color.White;
            this.pnlDemo.Controls.Add(this.htmlPanel);
            this.pnlDemo.Controls.Add(this.chartJS);
            this.pnlDemo.Location = new System.Drawing.Point(16, 71);
            this.pnlDemo.Name = "pnlDemo";
            this.pnlDemo.ShowCloseButton = false;
            this.pnlDemo.ShowHeader = true;
            this.pnlDemo.Size = new System.Drawing.Size(1390, 387);
            this.pnlDemo.TabIndex = 5;
            this.pnlDemo.Text = "Panel";
            // 
            // htmlPanel
            // 
            this.htmlPanel.Anchor = Wisej.Web.AnchorStyles.None;
            this.htmlPanel.Focusable = false;
            this.htmlPanel.Html = resources.GetString("htmlPanel.Html");
            this.htmlPanel.Location = new System.Drawing.Point(317, -5);
            this.htmlPanel.Name = "htmlPanel";
            this.htmlPanel.Size = new System.Drawing.Size(989, 367);
            this.htmlPanel.TabIndex = 0;
            this.htmlPanel.TabStop = false;
            // 
            // chartJS
            // 
            this.chartJS.Anchor = Wisej.Web.AnchorStyles.None;
            this.chartJS.AppearanceKey = "chartjs";
            this.chartJS.ChartType = Wisej.Web.Ext.ChartJS.ChartType.PolarArea;
            this.chartJS.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
            this.chartJS.Location = new System.Drawing.Point(91, -5);
            this.chartJS.Margin = new Wisej.Web.Padding(10);
            this.chartJS.MinimumSize = new System.Drawing.Size(200, 200);
            this.chartJS.Name = "chartJS";
            this.chartJS.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartJS.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartJS.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartJS.Options.DataLabel.Opacity = 1F;
            this.chartJS.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS.DataLabelTextAlignment.Start;
            this.chartJS.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartJS.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartJS.Options.Legend.Display = false;
            this.chartJS.Size = new System.Drawing.Size(213, 367);
            this.chartJS.TabIndex = 9;
            this.chartJS.Text = "Polar Area Chart";
            // 
            // buttonScreenshot
            // 
            this.buttonScreenshot.ImageSource = "resource.wx/Wisej.DemoBrowser.Html2Canvas/Images/download.png";
            this.buttonScreenshot.Location = new System.Drawing.Point(16, 16);
            this.buttonScreenshot.Name = "buttonScreenshot";
            this.buttonScreenshot.Size = new System.Drawing.Size(171, 37);
            this.buttonScreenshot.TabIndex = 6;
            this.buttonScreenshot.Text = "Take Screenshot";
            this.buttonScreenshot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonScreenshot.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.buttonScreenshot.Click += new System.EventHandler(this.buttonScreenshot_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.buttonScreenshot);
            this.Controls.Add(this.pnlDemo);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(16, 0, 16, 16);
            this.Load += new System.EventHandler(this.Features_Load);
            this.pnlDemo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Web.Panel pnlDemo;
        private Web.HtmlPanel htmlPanel;
        private Web.Ext.ChartJS.ChartJS chartJS;
        private Web.Button buttonScreenshot;
    }
}
