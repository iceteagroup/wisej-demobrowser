namespace Wisej.DemoBrowser.HtmlPanel
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
            this.aceEditorSource = new Wisej.Web.Ext.AceEditor.AceEditor();
            this.label2 = new Wisej.Web.Label();
            this.buttonApply = new Wisej.Web.Button();
            this.buttonReset = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel3 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.htmlPanelPreview = new Wisej.Web.HtmlPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // aceEditorSource
            // 
            this.aceEditorSource.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.aceEditorSource.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.aceEditorSource.CssClass = "shadow";
            this.aceEditorSource.Language = "html";
            this.aceEditorSource.Location = new System.Drawing.Point(17, 30);
            this.aceEditorSource.Name = "aceEditorSource";
            this.aceEditorSource.ShowGutter = false;
            this.aceEditorSource.ShowLineNumbers = false;
            this.aceEditorSource.ShowPrintMargin = false;
            this.aceEditorSource.Size = new System.Drawing.Size(520, 266);
            this.aceEditorSource.TabIndex = 4;
            this.aceEditorSource.Text = "aceEditor1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "HTML Source";
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(381, 310);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(156, 37);
            this.buttonApply.TabIndex = 7;
            this.buttonApply.Text = "Apply";
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(219, 310);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(156, 37);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.aceEditorSource);
            this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 359);
            this.panel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(155, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.ScrollBars = Wisej.Web.ScrollBars.Hidden;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1113, 365);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.htmlPanelPreview);
            this.flowLayoutPanel1.SetFillWeight(this.panel3, 1);
            this.panel3.Location = new System.Drawing.Point(560, 3);
            this.panel3.MinimumSize = new System.Drawing.Size(500, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 359);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "HtmlPanel Preview";
            // 
            // htmlPanelPreview
            // 
            this.htmlPanelPreview.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.htmlPanelPreview.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.htmlPanelPreview.CssStyle = "background-color: white;";
            this.htmlPanelPreview.Focusable = false;
            this.htmlPanelPreview.Location = new System.Drawing.Point(19, 35);
            this.htmlPanelPreview.Name = "htmlPanelPreview";
            this.htmlPanelPreview.Size = new System.Drawing.Size(513, 312);
            this.htmlPanelPreview.TabIndex = 11;
            this.htmlPanelPreview.TabStop = false;
            // 
            // Features
            // 
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		private Web.Ext.AceEditor.AceEditor aceEditorSource;
		private Web.Label label2;
		private Web.Button buttonApply;
		private Web.Button buttonReset;
		private Web.Panel panel1;
		private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Panel panel3;
        private Web.Label label1;
        private Web.HtmlPanel htmlPanelPreview;
    }
}
