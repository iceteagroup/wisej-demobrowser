namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoGantt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoGantt));
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.buttonPDF = new Wisej.Web.Button();
            this.kendoGantt1 = new Wisej.Web.Ext.Kendo.kendoGantt();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoGantt1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPDF);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 555);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonPDF, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 473);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/gantt/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/gantt";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/scheduling/gantt/overview";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(28, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Selectable";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(28, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Navigatable";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(28, 145);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 38);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Snap";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(28, 203);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(195, 38);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Show Work Days";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(28, 261);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(195, 38);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Show Work Hours";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = false;
            this.numericUpDown1.Label.Size = 50;
            this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown1.LabelText = "Row Height (px)";
            this.numericUpDown1.Location = new System.Drawing.Point(28, 319);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonPDF
            // 
            this.buttonPDF.Display = Wisej.Web.Display.Icon;
            this.buttonPDF.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-pdf-file.svg";
            this.buttonPDF.Location = new System.Drawing.Point(28, 425);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(42, 42);
            this.buttonPDF.TabIndex = 13;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // kendoGantt1
            // 
            this.kendoGantt1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.kendoGantt1.Location = new System.Drawing.Point(23, 21);
            this.kendoGantt1.Name = "kendoGantt1";
            this.kendoGantt1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoGantt1.Options"))));
            this.kendoGantt1.Size = new System.Drawing.Size(1042, 515);
            this.kendoGantt1.TabIndex = 0;
            this.kendoGantt1.Text = "kendoGantt1";
            this.kendoGantt1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoGantt1_WebRequest);
            this.kendoGantt1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.kendoGantt1_WidgetEvent);
            // 
            // kendoGantt
            // 
            this.Name = "kendoGantt";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoGantt kendoGantt1;
		private CheckBox checkBox1;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private NumericUpDown numericUpDown1;
		private Button buttonPDF;
	}
}
