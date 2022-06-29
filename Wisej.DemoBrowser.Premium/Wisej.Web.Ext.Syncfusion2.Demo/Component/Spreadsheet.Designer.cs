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
            this.comboBoxDocument = new Wisej.Web.ComboBox();
            this.checkBoxFormularBar = new Wisej.Web.CheckBox();
            this.checkBoxRibbon = new Wisej.Web.CheckBox();
            this.numericUpDownActiveSheetIndex = new Wisej.Web.NumericUpDown();
            this.checkBoxAllowDelete = new Wisej.Web.CheckBox();
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
            // linkApi
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/spreadsheet";
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
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowDelete);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxFormularBar);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxRibbon);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxDocument);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownActiveSheetIndex);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 45);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 470);
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
            this.spreadsheet1.Size = new System.Drawing.Size(872, 560);
            this.spreadsheet1.TabIndex = 0;
            this.spreadsheet1.Text = "spreadsheet1";
            this.spreadsheet1.WebRequest += new Wisej.Web.WebRequestHandler(this.spreadsheet1_WebRequest);
            // 
            // comboBoxDocument
            // 
            this.comboBoxDocument.AutoSize = false;
            this.comboBoxDocument.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxDocument, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxDocument, true);
            this.comboBoxDocument.Label.Size = 50;
            this.comboBoxDocument.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBoxDocument.LabelText = "Document";
            this.comboBoxDocument.Location = new System.Drawing.Point(3, 132);
            this.comboBoxDocument.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxDocument.Name = "comboBoxDocument";
            this.comboBoxDocument.Size = new System.Drawing.Size(212, 60);
            this.comboBoxDocument.TabIndex = 3;
            this.comboBoxDocument.SelectedIndexChanged += new System.EventHandler(this.comboBoxDocument_SelectedIndexChanged);
            // 
            // checkBoxFormularBar
            // 
            this.checkBoxFormularBar.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFormularBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxFormularBar.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxFormularBar, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxFormularBar, true);
            this.checkBoxFormularBar.Location = new System.Drawing.Point(3, 46);
            this.checkBoxFormularBar.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxFormularBar.Name = "checkBoxFormularBar";
            this.checkBoxFormularBar.Size = new System.Drawing.Size(212, 24);
            this.checkBoxFormularBar.TabIndex = 4;
            this.checkBoxFormularBar.Text = "Show Formular Bar";
            // 
            // checkBoxRibbon
            // 
            this.checkBoxRibbon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxRibbon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRibbon.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxRibbon, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxRibbon, true);
            this.checkBoxRibbon.Location = new System.Drawing.Point(3, 89);
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
            this.numericUpDownActiveSheetIndex.Location = new System.Drawing.Point(3, 211);
            this.numericUpDownActiveSheetIndex.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDownActiveSheetIndex.Name = "numericUpDownActiveSheetIndex";
            this.numericUpDownActiveSheetIndex.Size = new System.Drawing.Size(212, 57);
            this.numericUpDownActiveSheetIndex.TabIndex = 6;
            // 
            // checkBoxAllowDelete
            // 
            this.checkBoxAllowDelete.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllowDelete.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxAllowDelete, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxAllowDelete, true);
            this.checkBoxAllowDelete.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAllowDelete.Name = "checkBoxAllowDelete";
            this.checkBoxAllowDelete.Size = new System.Drawing.Size(212, 24);
            this.checkBoxAllowDelete.TabIndex = 7;
            this.checkBoxAllowDelete.Text = "Allow Delete";
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

		}

		#endregion

		private Syncfusion2.Spreadsheet spreadsheet1;
		private ComboBox comboBoxDocument;
        private NumericUpDown numericUpDownActiveSheetIndex;
        private CheckBox checkBoxRibbon;
        private CheckBox checkBoxFormularBar;
        private CheckBox checkBoxAllowDelete;
    }
}
