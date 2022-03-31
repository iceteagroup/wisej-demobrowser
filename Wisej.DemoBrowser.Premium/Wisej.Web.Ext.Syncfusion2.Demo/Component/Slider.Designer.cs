namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Slider
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
            this.slider1 = new Wisej.Web.Ext.Syncfusion2.Slider();
            this.comboBoxOrientation = new Wisej.Web.ComboBox();
            this.checkBoxShowButton = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/range-slider/getting-started/" +
    "";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/slider/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.slider1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowButton);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxOrientation);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/slider/default.html";
            // 
            // slider1
            // 
            this.slider1.Anchor = Wisej.Web.AnchorStyles.None;
            this.slider1.Location = new System.Drawing.Point(173, 247);
            this.slider1.Name = "slider1";
            this.slider1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"type\":\"Range\",\"value\":[30,70],\"tooltip\":{\"isVisible\":true,\"placement\":\"Before\"," +
        "\"showOn\":\"Focus\"}}")));
            this.slider1.Size = new System.Drawing.Size(743, 64);
            this.slider1.TabIndex = 0;
            this.slider1.Text = "slider1";
            // 
            // comboBoxOrientation
            // 
            this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxOrientation, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxOrientation, true);
            this.comboBoxOrientation.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.comboBoxOrientation.LabelText = "Orientation";
            this.comboBoxOrientation.Location = new System.Drawing.Point(3, 46);
            this.comboBoxOrientation.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxOrientation.Name = "comboBoxOrientation";
            this.comboBoxOrientation.Size = new System.Drawing.Size(212, 46);
            this.comboBoxOrientation.TabIndex = 1;
            // 
            // checkBoxShowButton
            // 
            this.checkBoxShowButton.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxShowButton, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxShowButton, true);
            this.checkBoxShowButton.Location = new System.Drawing.Point(3, 3);
            this.checkBoxShowButton.Name = "checkBoxShowButton";
            this.checkBoxShowButton.Size = new System.Drawing.Size(212, 24);
            this.checkBoxShowButton.TabIndex = 2;
            this.checkBoxShowButton.Text = "Show Buttons";
            // 
            // Slider
            // 
            this.Name = "Slider";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Slider slider1;
        private CheckBox checkBoxShowButton;
        private ComboBox comboBoxOrientation;
    }
}
