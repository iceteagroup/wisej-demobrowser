namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class DocumentEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentEditor));
            this.documentEditor1 = new Wisej.Web.Ext.Syncfusion2.DocumentEditor();
            this.buttonSave = new Wisej.Web.Button();
            this.comboBoxDataSource = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/document-editor/getting-start" +
    "ed/";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/document-editor-container" +
    "";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.documentEditor1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBoxDataSource);
            this.flowLayoutPanel1.Controls.Add(this.buttonSave);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/document-editor/default.html";
            // 
            // documentEditor1
            // 
            this.documentEditor1.Dock = Wisej.Web.DockStyle.Fill;
            this.documentEditor1.Location = new System.Drawing.Point(8, 8);
            this.documentEditor1.Name = "documentEditor1";
            this.documentEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("documentEditor1.Options"))));
            this.documentEditor1.Size = new System.Drawing.Size(1073, 542);
            this.documentEditor1.TabIndex = 0;
            this.documentEditor1.Text = "documentEditor1";
            this.documentEditor1.WidgetEvents = new Wisej.Web.Ext.Syncfusion2.ej2Base.WidgetEventHandler[0];
            this.documentEditor1.WebRequest += new Wisej.Web.WebRequestHandler(this.documentEditor1_WebRequest);
            // 
            // buttonSave
            // 
            this.flowLayoutPanel1.SetFillWeight(this.buttonSave, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.buttonSave, true);
            this.buttonSave.Location = new System.Drawing.Point(3, 82);
            this.buttonSave.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(212, 40);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save Document";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxDataSource
            // 
            this.comboBoxDataSource.AutoSize = false;
            this.comboBoxDataSource.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxDataSource, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxDataSource, true);
            this.comboBoxDataSource.Label.Size = 50;
            this.comboBoxDataSource.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBoxDataSource.LabelText = "Data Source";
            this.comboBoxDataSource.Location = new System.Drawing.Point(3, 3);
            this.comboBoxDataSource.Name = "comboBoxDataSource";
            this.comboBoxDataSource.Size = new System.Drawing.Size(212, 60);
            this.comboBoxDataSource.TabIndex = 4;
            // 
            // DocumentEditor
            // 
            this.Name = "DocumentEditor";
            this.Load += new System.EventHandler(this.DocumentEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.DocumentEditor documentEditor1;
		private Button buttonSave;
		private ComboBox comboBoxDataSource;
	}
}
