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
            this.flowLayoutPanelExamples = new Wisej.Web.FlowLayoutPanel();
            this.btnCaptureChart = new Wisej.Web.Button();
            this.btnHtmlPanel = new Wisej.Web.Button();
            this.btnCapturePanel = new Wisej.Web.Button();
            this.btnCaptureWindow = new Wisej.Web.Button();
            this.pnlDemo.SuspendLayout();
            this.flowLayoutPanelExamples.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDemo
            // 
            this.pnlDemo.Anchor = Wisej.Web.AnchorStyles.None;
            this.pnlDemo.BackColor = System.Drawing.Color.White;
            this.pnlDemo.Controls.Add(this.htmlPanel);
            this.pnlDemo.Controls.Add(this.chartJS);
            this.pnlDemo.Location = new System.Drawing.Point(166, 31);
            this.pnlDemo.Name = "pnlDemo";
            this.pnlDemo.ShowCloseButton = false;
            this.pnlDemo.ShowHeader = true;
            this.pnlDemo.Size = new System.Drawing.Size(1228, 416);
            this.pnlDemo.TabIndex = 5;
            this.pnlDemo.Text = "Panel";
            // 
            // htmlPanel
            // 
            this.htmlPanel.Anchor = Wisej.Web.AnchorStyles.None;
            this.htmlPanel.Html = resources.GetString("htmlPanel.Html");
            this.htmlPanel.Location = new System.Drawing.Point(236, 10);
            this.htmlPanel.Name = "htmlPanel";
            this.htmlPanel.Size = new System.Drawing.Size(989, 367);
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
            this.chartJS.Location = new System.Drawing.Point(10, 10);
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
            // flowLayoutPanelExamples
            // 
            this.flowLayoutPanelExamples.AppearanceKey = "panel-demo";
            this.flowLayoutPanelExamples.AutoShow = Wisej.Web.PanelAutoShowMode.OnPointerOver;
            this.flowLayoutPanelExamples.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanelExamples.Collapsed = true;
            this.flowLayoutPanelExamples.CollapseSide = Wisej.Web.HeaderPosition.Left;
            this.flowLayoutPanelExamples.Controls.Add(this.btnCaptureChart);
            this.flowLayoutPanelExamples.Controls.Add(this.btnHtmlPanel);
            this.flowLayoutPanelExamples.Controls.Add(this.btnCapturePanel);
            this.flowLayoutPanelExamples.Controls.Add(this.btnCaptureWindow);
            this.flowLayoutPanelExamples.CssStyle = "border-right: 1px solid #E5E8E9;";
            this.flowLayoutPanelExamples.Dock = Wisej.Web.DockStyle.Left;
            this.flowLayoutPanelExamples.HeaderPosition = Wisej.Web.HeaderPosition.Left;
            this.flowLayoutPanelExamples.HeaderSize = 40;
            this.flowLayoutPanelExamples.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelExamples.Name = "flowLayoutPanelExamples";
            this.flowLayoutPanelExamples.Padding = new Wisej.Web.Padding(16, 0, 0, 0);
            this.flowLayoutPanelExamples.RestoreBounds = new System.Drawing.Rectangle(0, 0, 232, 474);
            this.flowLayoutPanelExamples.ShowHeader = true;
            this.flowLayoutPanelExamples.Size = new System.Drawing.Size(40, 474);
            this.flowLayoutPanelExamples.TabIndex = 9;
            this.flowLayoutPanelExamples.Text = "Examples";
            // 
            // btnCaptureChart
            // 
            this.btnCaptureChart.AppearanceKey = "button-demo";
            this.btnCaptureChart.CharacterCasing = Wisej.Web.CharacterCasing.Capitalize;
            this.flowLayoutPanelExamples.SetFillWeight(this.btnCaptureChart, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.btnCaptureChart, true);
            this.btnCaptureChart.Focusable = false;
            this.btnCaptureChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaptureChart.ImageSource = "icon-right";
            this.btnCaptureChart.Location = new System.Drawing.Point(19, 3);
            this.btnCaptureChart.Name = "btnCaptureChart";
            this.btnCaptureChart.Size = new System.Drawing.Size(170, 37);
            this.btnCaptureChart.TabIndex = 0;
            this.btnCaptureChart.Text = "Chart";
            this.btnCaptureChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaptureChart.Click += new System.EventHandler(this.btnCaptureChart_Click);
            // 
            // btnHtmlPanel
            // 
            this.btnHtmlPanel.AppearanceKey = "button-demo";
            this.btnHtmlPanel.CharacterCasing = Wisej.Web.CharacterCasing.Capitalize;
            this.flowLayoutPanelExamples.SetFillWeight(this.btnHtmlPanel, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.btnHtmlPanel, true);
            this.btnHtmlPanel.Focusable = false;
            this.btnHtmlPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHtmlPanel.ImageSource = "icon-right";
            this.btnHtmlPanel.Location = new System.Drawing.Point(19, 46);
            this.btnHtmlPanel.Name = "btnHtmlPanel";
            this.btnHtmlPanel.Size = new System.Drawing.Size(170, 37);
            this.btnHtmlPanel.TabIndex = 1;
            this.btnHtmlPanel.Text = "Html panel";
            this.btnHtmlPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHtmlPanel.Click += new System.EventHandler(this.btnHtmlPanel_Click);
            // 
            // btnCapturePanel
            // 
            this.btnCapturePanel.AppearanceKey = "button-demo";
            this.btnCapturePanel.CharacterCasing = Wisej.Web.CharacterCasing.Capitalize;
            this.flowLayoutPanelExamples.SetFillWeight(this.btnCapturePanel, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.btnCapturePanel, true);
            this.btnCapturePanel.Focusable = false;
            this.btnCapturePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapturePanel.ImageSource = "icon-right";
            this.btnCapturePanel.Location = new System.Drawing.Point(19, 89);
            this.btnCapturePanel.Name = "btnCapturePanel";
            this.btnCapturePanel.Size = new System.Drawing.Size(170, 37);
            this.btnCapturePanel.TabIndex = 2;
            this.btnCapturePanel.Text = "Panel";
            this.btnCapturePanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapturePanel.Click += new System.EventHandler(this.btnCapturePanel_Click);
            // 
            // btnCaptureWindow
            // 
            this.btnCaptureWindow.AppearanceKey = "button-demo";
            this.btnCaptureWindow.CharacterCasing = Wisej.Web.CharacterCasing.Capitalize;
            this.flowLayoutPanelExamples.SetFillWeight(this.btnCaptureWindow, 1);
            this.flowLayoutPanelExamples.SetFlowBreak(this.btnCaptureWindow, true);
            this.btnCaptureWindow.Focusable = false;
            this.btnCaptureWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaptureWindow.ImageSource = "icon-right";
            this.btnCaptureWindow.Location = new System.Drawing.Point(19, 132);
            this.btnCaptureWindow.Name = "btnCaptureWindow";
            this.btnCaptureWindow.Size = new System.Drawing.Size(170, 37);
            this.btnCaptureWindow.TabIndex = 3;
            this.btnCaptureWindow.Text = "Browser";
            this.btnCaptureWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaptureWindow.Click += new System.EventHandler(this.btnCaptureWindow_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.flowLayoutPanelExamples);
            this.Controls.Add(this.pnlDemo);
            this.MinimumSize = new System.Drawing.Size(1079, 285);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.pnlDemo.ResumeLayout(false);
            this.flowLayoutPanelExamples.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Web.Panel pnlDemo;
        private Web.HtmlPanel htmlPanel;
        private Web.Ext.ChartJS.ChartJS chartJS;
        private Web.FlowLayoutPanel flowLayoutPanelExamples;
        private Web.Button btnCaptureChart;
        private Web.Button btnHtmlPanel;
        private Web.Button btnCapturePanel;
        private Web.Button btnCaptureWindow;
    }
}
