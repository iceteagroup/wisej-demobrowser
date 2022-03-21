namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class RichTextEditor
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
            this.richTextEditor1 = new Wisej.Web.Ext.Syncfusion2.RichTextEditor();
            this.button1 = new Wisej.Web.Button();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/rich-text-editor/es5-getting-" +
    "started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/rich-text-editor/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Size = new System.Drawing.Size(286, 393);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 311);
            this.buttonUpdate.Size = new System.Drawing.Size(231, 52);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.richTextEditor1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/rich-text-editor/tools.html";
            // 
            // richTextEditor1
            // 
            this.richTextEditor1.Dock = Wisej.Web.DockStyle.Fill;
            this.richTextEditor1.Location = new System.Drawing.Point(8, 8);
            this.richTextEditor1.Name = "richTextEditor1";
            this.richTextEditor1.Size = new System.Drawing.Size(1073, 542);
            this.richTextEditor1.TabIndex = 0;
            this.richTextEditor1.TextChanged += new System.EventHandler(this.richTextEditor1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Value";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.Location = new System.Drawing.Point(28, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 35);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Enable Auto URL";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.Location = new System.Drawing.Point(28, 133);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 35);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Enable Tab Key";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.Checked = true;
            this.checkBox3.Location = new System.Drawing.Point(28, 183);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(231, 35);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Enable HTML Sanitizer";
            // 
            // RichTextEditor
            // 
            this.Name = "RichTextEditor";
            this.Load += new System.EventHandler(this.RichTextEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.RichTextEditor richTextEditor1;
		private Button button1;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
