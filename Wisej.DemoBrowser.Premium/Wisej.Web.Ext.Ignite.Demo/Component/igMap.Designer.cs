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
            this.textBox2 = new Wisej.Web.TextBox();
            this.button1 = new Wisej.Web.Button();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.textBox1 = new Wisej.Web.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
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
            // linkApi
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igmap";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igmap-landing-page";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown2);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            // 
            // igMap1
            // 
            this.igMap1.Dock = Wisej.Web.DockStyle.Fill;
            this.igMap1.Location = new System.Drawing.Point(8, 8);
            this.igMap1.Name = "igMap1";
            this.igMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igMap1.Options"))));
            this.igMap1.Size = new System.Drawing.Size(872, 560);
            this.igMap1.TabIndex = 0;
            this.igMap1.Text = "igMap1";
            widgetTemplate1.Id = "tooltipTemplate";
            widgetTemplate1.Template = resources.GetString("widgetTemplate1.Template");
            this.igMap1.WidgetTemplates = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate[] {
        widgetTemplate1};
            // 
            // textBox2
            // 
            this.flowLayoutPanel1.SetFillWeight(this.textBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBox2, true);
            this.textBox2.LabelText = "Country";
            this.textBox2.Location = new System.Drawing.Point(3, 231);
            this.textBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 57);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Disneyland";
            // 
            // button1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.button1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.button1, true);
            this.button1.Location = new System.Drawing.Point(3, 307);
            this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 6;
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown2, true);
            this.numericUpDown2.LabelText = "Longitude";
            this.numericUpDown2.Location = new System.Drawing.Point(3, 155);
            this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            117918976,
            0,
            0,
            -2147090432});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 6;
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
            this.numericUpDown1.LabelText = "Latitude";
            this.numericUpDown1.Location = new System.Drawing.Point(3, 79);
            this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            33812511,
            0,
            0,
            393216});
            // 
            // textBox1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.textBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBox1, true);
            this.textBox1.LabelText = "Name";
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 57);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Ancient Sanctum";
            // 
            // igMap
            // 
            this.Name = "igMap";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igMap igMap1;
		private Button button1;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
		private TextBox textBox1;
		private TextBox textBox2;
	}
}
