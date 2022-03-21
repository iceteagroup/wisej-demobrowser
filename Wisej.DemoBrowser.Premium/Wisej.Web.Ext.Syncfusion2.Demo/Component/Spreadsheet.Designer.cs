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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownActiveSheetIndex);
            this.groupBox1.Controls.Add(this.checkBoxRibbon);
            this.groupBox1.Controls.Add(this.checkBoxFormularBar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Size = new System.Drawing.Size(286, 551);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxFormularBar, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxRibbon, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownActiveSheetIndex, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 470);
            this.buttonUpdate.Size = new System.Drawing.Size(231, 52);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.spreadsheet1);
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
            this.button1.Location = new System.Drawing.Point(28, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hide Headers";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Data Source";
            this.comboBox1.Location = new System.Drawing.Point(28, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 47);
            this.comboBox1.TabIndex = 3;
            // 
            // checkBoxFormularBar
            // 
            this.checkBoxFormularBar.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFormularBar.AutoSize = false;
            this.checkBoxFormularBar.Location = new System.Drawing.Point(28, 138);
            this.checkBoxFormularBar.Name = "checkBoxFormularBar";
            this.checkBoxFormularBar.Size = new System.Drawing.Size(231, 24);
            this.checkBoxFormularBar.TabIndex = 4;
            this.checkBoxFormularBar.Text = "Show formular bar";
            // 
            // checkBoxRibbon
            // 
            this.checkBoxRibbon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxRibbon.Location = new System.Drawing.Point(28, 177);
            this.checkBoxRibbon.Name = "checkBoxRibbon";
            this.checkBoxRibbon.Size = new System.Drawing.Size(141, 24);
            this.checkBoxRibbon.TabIndex = 5;
            this.checkBoxRibbon.Text = "Show ribbon";
            // 
            // numericUpDownActiveSheetIndex
            // 
            this.numericUpDownActiveSheetIndex.LabelText = "Active sheet index";
            this.numericUpDownActiveSheetIndex.Location = new System.Drawing.Point(28, 216);
            this.numericUpDownActiveSheetIndex.Name = "numericUpDownActiveSheetIndex";
            this.numericUpDownActiveSheetIndex.Size = new System.Drawing.Size(231, 46);
            this.numericUpDownActiveSheetIndex.TabIndex = 6;
            // 
            // Spreadsheet
            // 
            this.Name = "Spreadsheet";
            this.Load += new System.EventHandler(this.Spreadsheet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
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
