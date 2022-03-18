namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class QueryBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryBuilder));
            this.queryBuilder1 = new Wisej.Web.Ext.Syncfusion2.QueryBuilder();
            this.button1 = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/query-builder/es5-getting-sta" +
    "rted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/query-builder/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.queryBuilder1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/query-builder/default.html";
            // 
            // queryBuilder1
            // 
            this.queryBuilder1.Dock = Wisej.Web.DockStyle.Fill;
            this.queryBuilder1.Location = new System.Drawing.Point(8, 8);
            this.queryBuilder1.Name = "queryBuilder1";
            this.queryBuilder1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("queryBuilder1.Options"))));
            this.queryBuilder1.Size = new System.Drawing.Size(1073, 542);
            this.queryBuilder1.TabIndex = 0;
            this.queryBuilder1.Text = "queryBuilder1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get SQL Rules";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QueryBuilder
            // 
            this.Name = "QueryBuilder";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.QueryBuilder queryBuilder1;
		private Button button1;
	}
}
