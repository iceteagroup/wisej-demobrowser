namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class SplitButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitButton));
            this.splitButton1 = new Wisej.Web.Ext.Syncfusion2.SplitButton();
            this.checkBoxDisabled = new Wisej.Web.CheckBox();
            this.comboBoxIconPosition = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/split-button/es5-getting-star" +
    "ted/";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/split-button/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.splitButton1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxDisabled);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxIconPosition);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/button/split-button.html";
            // 
            // splitButton1
            // 
            this.splitButton1.Anchor = Wisej.Web.AnchorStyles.None;
            this.splitButton1.Location = new System.Drawing.Point(481, 256);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("splitButton1.Options"))));
            this.splitButton1.Size = new System.Drawing.Size(126, 47);
            this.splitButton1.TabIndex = 0;
            this.splitButton1.Text = "splitButton1";
            // 
            // checkBoxDisabled
            // 
            this.checkBoxDisabled.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDisabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxDisabled, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxDisabled, true);
            this.checkBoxDisabled.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDisabled.Name = "checkBoxDisabled";
            this.checkBoxDisabled.Size = new System.Drawing.Size(212, 24);
            this.checkBoxDisabled.TabIndex = 1;
            this.checkBoxDisabled.Text = "Disabled";
            // 
            // comboBoxIconPosition
            // 
            this.comboBoxIconPosition.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxIconPosition, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxIconPosition, true);
            this.comboBoxIconPosition.LabelText = "Icon Position";
            this.comboBoxIconPosition.Location = new System.Drawing.Point(3, 46);
            this.comboBoxIconPosition.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxIconPosition.Name = "comboBoxIconPosition";
            this.comboBoxIconPosition.Size = new System.Drawing.Size(212, 46);
            this.comboBoxIconPosition.TabIndex = 2;
            // 
            // SplitButton
            // 
            this.Name = "SplitButton";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.SplitButton splitButton1;
        private ComboBox comboBoxIconPosition;
        private CheckBox checkBoxDisabled;
    }
}
