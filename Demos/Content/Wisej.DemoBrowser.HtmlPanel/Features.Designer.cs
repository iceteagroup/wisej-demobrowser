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
			this.htmlPanelPreview = new Wisej.Web.HtmlPanel();
			this.label1 = new Wisej.Web.Label();
			this.aceEditorSource = new Wisej.Web.Ext.AceEditor.AceEditor();
			this.label2 = new Wisej.Web.Label();
			this.buttonApply = new Wisej.Web.Button();
			this.buttonReset = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// htmlPanelPreview
			// 
			this.htmlPanelPreview.Anchor = Wisej.Web.AnchorStyles.None;
			this.htmlPanelPreview.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.htmlPanelPreview.CssStyle = "background-color: white;";
			this.htmlPanelPreview.Location = new System.Drawing.Point(723, 57);
			this.htmlPanelPreview.Name = "htmlPanelPreview";
			this.htmlPanelPreview.Size = new System.Drawing.Size(650, 339);
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(723, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "HtmlPanel Preview";
			// 
			// aceEditorSource
			// 
			this.aceEditorSource.Anchor = Wisej.Web.AnchorStyles.None;
			this.aceEditorSource.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.aceEditorSource.CssStyle = "border-radius: 4px;";
			this.aceEditorSource.Language = "html";
			this.aceEditorSource.Location = new System.Drawing.Point(49, 57);
			this.aceEditorSource.Name = "aceEditorSource";
			this.aceEditorSource.ShowGutter = false;
			this.aceEditorSource.ShowLineNumbers = false;
			this.aceEditorSource.ShowPrintMargin = false;
			this.aceEditorSource.Size = new System.Drawing.Size(649, 339);
			this.aceEditorSource.TabIndex = 4;
			this.aceEditorSource.Text = "aceEditor1";
			// 
			// label2
			// 
			this.label2.Anchor = Wisej.Web.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = "HTML Source";
			// 
			// buttonApply
			// 
			this.buttonApply.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonApply.Location = new System.Drawing.Point(542, 405);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(156, 37);
			this.buttonApply.TabIndex = 7;
			this.buttonApply.Text = "Apply";
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonReset.Location = new System.Drawing.Point(380, 405);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(156, 37);
			this.buttonReset.TabIndex = 8;
			this.buttonReset.Text = "Reset";
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// Features
			// 
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.aceEditorSource);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.htmlPanelPreview);
			this.MinimumSize = new System.Drawing.Size(1335, 422);
			this.Name = "Features";
			this.Padding = new Wisej.Web.Padding(5);
			this.Load += new System.EventHandler(this.Features_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Web.HtmlPanel htmlPanelPreview;
		private Web.Label label1;
		private Web.Ext.AceEditor.AceEditor aceEditorSource;
		private Web.Label label2;
		private Web.Button buttonApply;
		private Web.Button buttonReset;
	}
}
