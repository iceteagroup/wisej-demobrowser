namespace Wisej.DemoBrowser.AspNetPanel
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
            this.label1 = new Wisej.Web.Label();
            this.aceEditorSource = new Wisej.Web.Ext.AceEditor.AceEditor();
            this.label2 = new Wisej.Web.Label();
            this.aspNetPanel1 = new Wisej.Web.AspNetPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = Wisej.Web.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "AspNetPanel Preview";
            // 
            // aceEditorSource
            // 
            this.aceEditorSource.Anchor = Wisej.Web.AnchorStyles.None;
            this.aceEditorSource.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.aceEditorSource.CssStyle = "border-radius: 4px;";
            this.aceEditorSource.Language = "html";
            this.aceEditorSource.Location = new System.Drawing.Point(49, 57);
            this.aceEditorSource.Name = "aceEditorSource";
            this.aceEditorSource.ReadOnly = true;
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
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "HTML Source";
            // 
            // aspNetPanel1
            // 
            this.aspNetPanel1.Location = new System.Drawing.Point(723, 58);
            this.aspNetPanel1.Name = "aspNetPanel1";
            this.aspNetPanel1.PageSource = "Sample.aspx";
            this.aspNetPanel1.Size = new System.Drawing.Size(649, 339);
            this.aspNetPanel1.TabIndex = 9;
            this.aspNetPanel1.Text = "aspNetPanel1";
            // 
            // Features
            // 
            this.Controls.Add(this.aspNetPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aceEditorSource);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1422, 474);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(5);
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		private Web.Label label1;
		private Web.Ext.AceEditor.AceEditor aceEditorSource;
		private Web.Label label2;
        private Web.AspNetPanel aspNetPanel1;
    }
}
