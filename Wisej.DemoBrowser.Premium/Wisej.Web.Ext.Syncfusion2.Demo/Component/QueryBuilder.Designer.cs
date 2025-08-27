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
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/query-builder/es5-getting-sta" +
    "rted/";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/query-builder/";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.queryBuilder1);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.button1);
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
			this.queryBuilder1.Size = new System.Drawing.Size(872, 560);
			this.queryBuilder1.TabIndex = 0;
			this.queryBuilder1.Text = "queryBuilder1";
			// 
			// button1
			// 
			this.flowLayoutPanel1.SetFillWeight(this.button1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.button1, true);
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(212, 35);
			this.button1.TabIndex = 1;
			this.button1.Text = "Get SQL Rules";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// QueryBuilder
			// 
			this.Name = "QueryBuilder";
			this.Load += new System.EventHandler(this.QueryBuilder_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.QueryBuilder queryBuilder1;
		private Button button1;
	}
}
