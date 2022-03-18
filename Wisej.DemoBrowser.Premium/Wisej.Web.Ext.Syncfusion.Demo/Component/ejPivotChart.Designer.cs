namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejPivotChart
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
            this.ejPivotChart1 = new Wisej.Web.Ext.Syncfusion.ejPivotChart();
            this.buttonLoad = new Wisej.Web.Upload();
            this.buttonExportExcel = new Wisej.Web.Button();
            this.buttonSaveJson = new Wisej.Web.Button();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.numericUpDownRotation = new Wisej.Web.NumericUpDown();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/pivotchart/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.numericUpDownRotation);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.buttonSaveJson);
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.buttonExportExcel);
            this.groupBox1.Size = new System.Drawing.Size(250, 476);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonExportExcel, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonSaveJson, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownRotation, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 389);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/knockout/PivotChart";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejpivotchart";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejPivotChart1);
            this.panel.TabIndex = 7;
            // 
            // ejPivotChart1
            // 
            this.ejPivotChart1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejPivotChart1.Location = new System.Drawing.Point(8, 8);
            this.ejPivotChart1.Name = "ejPivotChart1";
            this.ejPivotChart1.Size = new System.Drawing.Size(1073, 542);
            this.ejPivotChart1.TabIndex = 0;
            this.ejPivotChart1.Text = "ejPivotChart1";
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".xlsx";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(28, 324);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Display = Wisej.Web.Display.Icon;
            this.buttonExportExcel.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/microsoft-excel-logo.svg";
            this.buttonExportExcel.Location = new System.Drawing.Point(76, 324);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(42, 42);
            this.buttonExportExcel.TabIndex = 5;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // buttonSaveJson
            // 
            this.buttonSaveJson.Display = Wisej.Web.Display.Icon;
            this.buttonSaveJson.ImageSource = "icon-save";
            this.buttonSaveJson.Location = new System.Drawing.Point(124, 324);
            this.buttonSaveJson.Name = "buttonSaveJson";
            this.buttonSaveJson.Size = new System.Drawing.Size(42, 42);
            this.buttonSaveJson.TabIndex = 6;
            this.buttonSaveJson.Click += new System.EventHandler(this.buttonSaveJson_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable 3D";
            // 
            // numericUpDownRotation
            // 
            this.numericUpDownRotation.AutoSize = false;
            this.numericUpDownRotation.Label.Size = 50;
            this.numericUpDownRotation.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDownRotation.LabelText = "Rotation";
            this.numericUpDownRotation.Location = new System.Drawing.Point(28, 241);
            this.numericUpDownRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownRotation.Name = "numericUpDownRotation";
            this.numericUpDownRotation.Size = new System.Drawing.Size(195, 60);
            this.numericUpDownRotation.TabIndex = 3;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(28, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Enable Scrollbar";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Line",
            "Spline",
            "Column",
            "Area",
            "SplineArea",
            "StepLine",
            "StepArea",
            "Pie",
            "Bar",
            "StackingArea",
            "StackingColumn",
            "StackingBar",
            "Pyramid",
            "Funnel",
            "Doughnut",
            "Scatter",
            "Bubble"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Common Series Type";
            this.comboBox1.Location = new System.Drawing.Point(28, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 60);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Column";
            // 
            // ejPivotChart
            // 
            this.Name = "ejPivotChart";
            this.Load += new System.EventHandler(this.ejPivotChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPivotChart ejPivotChart1;
		private Upload buttonLoad;
		private Button buttonExportExcel;
		private Button buttonSaveJson;
		private CheckBox checkBox1;
		private NumericUpDown numericUpDownRotation;
		private CheckBox checkBox2;
		private ComboBox comboBox1;
	}
}
