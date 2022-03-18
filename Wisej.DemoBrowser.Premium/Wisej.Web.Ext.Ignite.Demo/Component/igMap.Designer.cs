namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igMap));
            Wisej.Web.Ext.Ignite.igBase.WidgetTemplate widgetTemplate1 = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate();
            this.igMap1 = new Wisej.Web.Ext.Ignite.igMap();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.textBox2 = new Wisej.Web.TextBox();
            this.button1 = new Wisej.Web.Button();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.textBox1 = new Wisej.Web.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Size = new System.Drawing.Size(250, 521);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 440);
            this.buttonUpdate.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igMap1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/map/overview";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igmap";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igmap-landing-page";
            // 
            // igMap1
            // 
            this.igMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.igMap1.Location = new System.Drawing.Point(21, 21);
            this.igMap1.Name = "igMap1";
            this.igMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igMap1.Options"))));
            this.igMap1.Size = new System.Drawing.Size(1046, 516);
            this.igMap1.TabIndex = 0;
            this.igMap1.Text = "igMap1";
            widgetTemplate1.Id = "tooltipTemplate";
            widgetTemplate1.Template = resources.GetString("widgetTemplate1.Template");
            widgetTemplate1.Type = "text/x-jquery-tmpl";
            this.igMap1.WidgetTemplates = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate[] {
        widgetTemplate1};
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(23, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 342);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = "Add a Marker";
            // 
            // textBox2
            // 
            this.textBox2.LabelText = "Country";
            this.textBox2.Location = new System.Drawing.Point(6, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 57);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.LabelText = "Longitude";
            this.numericUpDown2.Location = new System.Drawing.Point(6, 237);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(188, 57);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.LabelText = "Latitude";
            this.numericUpDown1.Location = new System.Drawing.Point(6, 165);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(188, 57);
            this.numericUpDown1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.LabelText = "Name";
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 57);
            this.textBox1.TabIndex = 0;
            // 
            // igMap
            // 
            this.Name = "igMap";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Ignite.igMap igMap1;
		private GroupBox groupBox2;
		private Button button1;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
		private TextBox textBox1;
		private TextBox textBox2;
	}
}
