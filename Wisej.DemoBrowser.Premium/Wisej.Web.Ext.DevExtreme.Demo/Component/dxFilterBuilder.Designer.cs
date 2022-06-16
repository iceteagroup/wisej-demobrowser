namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxFilterBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxFilterBuilder));
            this.dxFilterBuilder1 = new Wisej.Web.Ext.DevExtreme.dxFilterBuilder();
            this.buttonGetFilterExpression = new Wisej.Web.Button();
            this.tagTextBoxGroupOperation = new Wisej.Web.TagTextBox();
            this.label4 = new Wisej.Web.Label();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/FilterBuilder/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/FilterBuilder/WithDataGrid/jQ" +
    "uery/Light/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxFilterBuilder/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxFilterBuilder1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tagTextBoxGroupOperation);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.buttonGetFilterExpression);
            // 
            // dxFilterBuilder1
            // 
            this.dxFilterBuilder1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dxFilterBuilder1.Location = new System.Drawing.Point(140, 103);
            this.dxFilterBuilder1.Name = "dxFilterBuilder1";
            this.dxFilterBuilder1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxFilterBuilder1.Options"))));
            this.dxFilterBuilder1.Size = new System.Drawing.Size(608, 370);
            this.dxFilterBuilder1.TabIndex = 0;
            // 
            // buttonGetFilterExpression
            // 
            this.buttonGetFilterExpression.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonGetFilterExpression.Location = new System.Drawing.Point(3, 146);
            this.buttonGetFilterExpression.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonGetFilterExpression.Name = "buttonGetFilterExpression";
            this.buttonGetFilterExpression.Size = new System.Drawing.Size(212, 35);
            this.buttonGetFilterExpression.TabIndex = 16;
            this.buttonGetFilterExpression.Text = "Get Filter Expression";
            this.buttonGetFilterExpression.Click += new System.EventHandler(this.buttonGetFilterExpression_Click);
            // 
            // tagTextBoxGroupOperation
            // 
            this.tagTextBoxGroupOperation.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tagTextBoxGroupOperation.LabelText = "Group Operations";
            this.tagTextBoxGroupOperation.Location = new System.Drawing.Point(3, 3);
            this.tagTextBoxGroupOperation.Name = "tagTextBoxGroupOperation";
            this.tagTextBoxGroupOperation.Size = new System.Drawing.Size(212, 57);
            this.tagTextBoxGroupOperation.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 48);
            this.label4.TabIndex = 18;
            this.label4.Text = "Accepted Values: \'and\' | \'or\' | \'notAnd\' | \'notOr\'";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dxFilterBuilder
            // 
            this.Name = "dxFilterBuilder";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxFilterBuilder dxFilterBuilder1;
        private Button buttonGetFilterExpression;
        private TagTextBox tagTextBoxGroupOperation;
        private Label label4;
    }
}
