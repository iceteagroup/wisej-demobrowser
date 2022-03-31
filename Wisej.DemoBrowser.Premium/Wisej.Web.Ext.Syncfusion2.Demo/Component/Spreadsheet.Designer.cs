namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Spreadsheet
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
            this.spreadsheet1 = new Wisej.Web.Ext.Syncfusion2.Spreadsheet();
            this.button1 = new Wisej.Web.Button();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.checkBoxFormularBar = new Wisej.Web.CheckBox();
            this.checkBoxRibbon = new Wisej.Web.CheckBox();
            this.numericUpDownActiveSheetIndex = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActiveSheetIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/spreadsheet/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/spreadsheet";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.spreadsheet1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxFormularBar);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxRibbon);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownActiveSheetIndex);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(883, 24);
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/spreadsheet/default.html";
            // 
            // spreadsheet1
            // 
            this.spreadsheet1.Dock = Wisej.Web.DockStyle.Fill;
            this.spreadsheet1.Location = new System.Drawing.Point(8, 8);
            this.spreadsheet1.Name = "spreadsheet1";
            this.spreadsheet1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"sheets\":[{\"name\":\"Sheet one\"},{\"name\":\"Sheet two\"}]}")));
            this.spreadsheet1.Size = new System.Drawing.Size(1073, 542);
            this.spreadsheet1.TabIndex = 0;
            this.spreadsheet1.Text = "spreadsheet1";
            this.spreadsheet1.WebRequest += new Wisej.Web.WebRequestHandler(this.spreadsheet1_WebRequest);
            // 
            // button1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.button1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.button1, true);
            this.button1.Location = new System.Drawing.Point(3, 233);
            this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hide Headers";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Data Source";
            this.comboBox1.Location = new System.Drawing.Point(3, 89);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 3;
            // 
            // checkBoxFormularBar
            // 
            this.checkBoxFormularBar.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFormularBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxFormularBar, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxFormularBar, true);
            this.checkBoxFormularBar.Location = new System.Drawing.Point(3, 3);
            this.checkBoxFormularBar.Name = "checkBoxFormularBar";
            this.checkBoxFormularBar.Size = new System.Drawing.Size(212, 24);
            this.checkBoxFormularBar.TabIndex = 4;
            this.checkBoxFormularBar.Text = "Show Formular Bar";
            // 
            // checkBoxRibbon
            // 
            this.checkBoxRibbon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxRibbon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxRibbon, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxRibbon, true);
            this.checkBoxRibbon.Location = new System.Drawing.Point(3, 46);
            this.checkBoxRibbon.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxRibbon.Name = "checkBoxRibbon";
            this.checkBoxRibbon.Size = new System.Drawing.Size(212, 24);
            this.checkBoxRibbon.TabIndex = 5;
            this.checkBoxRibbon.Text = "Show Ribbon";
            // 
            // numericUpDownActiveSheetIndex
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownActiveSheetIndex, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownActiveSheetIndex, true);
            this.numericUpDownActiveSheetIndex.LabelText = "Active Sheet Index";
            this.numericUpDownActiveSheetIndex.Location = new System.Drawing.Point(3, 168);
            this.numericUpDownActiveSheetIndex.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownActiveSheetIndex.Name = "numericUpDownActiveSheetIndex";
            this.numericUpDownActiveSheetIndex.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownActiveSheetIndex.TabIndex = 6;
            // 
            // Spreadsheet
            // 
            this.Name = "Spreadsheet";
            this.Load += new System.EventHandler(this.Spreadsheet_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActiveSheetIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Spreadsheet spreadsheet1;
        private Button button1;
		private ComboBox comboBox1;
        private NumericUpDown numericUpDownActiveSheetIndex;
        private CheckBox checkBoxRibbon;
        private CheckBox checkBoxFormularBar;
    }
}
