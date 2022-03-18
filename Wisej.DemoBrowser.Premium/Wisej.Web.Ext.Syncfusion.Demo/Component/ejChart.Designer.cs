namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejChart));
            this.ejChart1 = new Wisej.Web.Ext.Syncfusion.ejChart();
            this.comboBoxLegendAlignment = new Wisej.Web.ComboBox();
            this.textBoxTitle = new Wisej.Web.TextBox();
            this.buttonPrint = new Wisej.Web.Button();
            this.buttonSave = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://help.syncfusion.com/js/chart/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonPrint);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.comboBoxLegendAlignment);
            this.groupBox1.Size = new System.Drawing.Size(250, 382);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxLegendAlignment, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBoxTitle, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonPrint, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 301);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/chart/line";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejchart";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejChart1);
            // 
            // ejChart1
            // 
            this.ejChart1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejChart1.Location = new System.Drawing.Point(8, 8);
            this.ejChart1.Name = "ejChart1";
            this.ejChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejChart1.Options"))));
            this.ejChart1.Size = new System.Drawing.Size(1073, 542);
            this.ejChart1.TabIndex = 0;
            this.ejChart1.Text = "ejChart1";
            // 
            // comboBoxLegendAlignment
            // 
            this.comboBoxLegendAlignment.AutoSize = false;
            this.comboBoxLegendAlignment.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxLegendAlignment.Items.AddRange(new object[] {
            "Center",
            "Near",
            "Far"});
            this.comboBoxLegendAlignment.Label.Size = 50;
            this.comboBoxLegendAlignment.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBoxLegendAlignment.LabelText = "Legend Alignment";
            this.comboBoxLegendAlignment.Location = new System.Drawing.Point(25, 44);
            this.comboBoxLegendAlignment.Name = "comboBoxLegendAlignment";
            this.comboBoxLegendAlignment.Size = new System.Drawing.Size(195, 60);
            this.comboBoxLegendAlignment.TabIndex = 3;
            this.comboBoxLegendAlignment.Text = "Center";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AutoSize = false;
            this.textBoxTitle.Label.Size = 50;
            this.textBoxTitle.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBoxTitle.LabelText = "Chart Title";
            this.textBoxTitle.Location = new System.Drawing.Point(25, 124);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(195, 60);
            this.textBoxTitle.TabIndex = 4;
            this.textBoxTitle.Text = "Efficiency of oil-fired power production";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Display = Wisej.Web.Display.Icon;
            this.buttonPrint.ImageSource = "icon-print";
            this.buttonPrint.Location = new System.Drawing.Point(28, 219);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(42, 42);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Display = Wisej.Web.Display.Icon;
            this.buttonSave.ImageSource = "icon-save";
            this.buttonSave.Location = new System.Drawing.Point(76, 219);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(42, 42);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ejChart
            // 
            this.Name = "ejChart";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejChart ejChart1;
		private ComboBox comboBoxLegendAlignment;
		private TextBox textBoxTitle;
		private Button buttonSave;
		private Button buttonPrint;
	}
}
