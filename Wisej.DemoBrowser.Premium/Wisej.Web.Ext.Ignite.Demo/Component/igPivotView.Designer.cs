namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igPivotView
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
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igPivotView));
            this.igPivotView1 = new Wisej.Web.Ext.Ignite.igPivotView();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.checkBox6 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Size = new System.Drawing.Size(250, 590);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox6, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 509);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igPivotView1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/pivot-view/overview";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igPivotView";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igpivotview";
            // 
            // igPivotView1
            // 
            this.igPivotView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.igPivotView1.Location = new System.Drawing.Point(20, 24);
            this.igPivotView1.Name = "igPivotView1";
            this.igPivotView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"pivotGridOptions\":{\"allowSorting\":true,\"compactColumnHeaders\":true,\"gridOptions" +
        "\":{\"alternateRowStyles\":true}},\"pivotGridPanel\":{\"collapsible\":false}}")));
            this.igPivotView1.Size = new System.Drawing.Size(1049, 509);
            this.igPivotView1.TabIndex = 0;
            this.igPivotView1.Text = "igPivotView1";
            widgetFunction1.Name = "loadTheData";
            widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
            this.igPivotView1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.LabelText = "Default Row Header Width";
            this.numericUpDown1.Location = new System.Drawing.Point(28, 409);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 79);
            this.numericUpDown1.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Alternate Row Styles";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.Location = new System.Drawing.Point(28, 96);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Allow Sorting";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.checkBox3.Location = new System.Drawing.Point(28, 155);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 42);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Compact Column Headers";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.checkBox4.Location = new System.Drawing.Point(28, 218);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(195, 38);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Fixed Headers";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.checkBox5.Location = new System.Drawing.Point(28, 277);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(195, 46);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Hide Columns Drop Area";
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox6.AutoSize = false;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox6.Checked = true;
            this.checkBox6.Location = new System.Drawing.Point(28, 344);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(195, 44);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Pivot Grid Collapsible";
            // 
            // igPivotView
            // 
            this.Name = "igPivotView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Ignite.igPivotView igPivotView1;
		private NumericUpDown numericUpDown1;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private CheckBox checkBox6;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
	}
}
