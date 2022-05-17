namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejComboBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejComboBox));
            this.ejComboBox1 = new Wisej.Web.Ext.Syncfusion.ejComboBox();
            this.checkBoxAutofill = new Wisej.Web.CheckBox();
            this.checkBoxShowClearButton = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/combobox/overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(518, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/combobox/DefaultFunctionalities";
            // 
            // linkAPI
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "https://help.syncfusion.com/api/js/ejcombobox";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejComboBox1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxAutofill);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxShowClearButton);
            // 
            // ejComboBox1
            // 
            this.ejComboBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejComboBox1.Location = new System.Drawing.Point(394, 262);
            this.ejComboBox1.Name = "ejComboBox1";
            this.ejComboBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejComboBox1.Options"))));
            this.ejComboBox1.Size = new System.Drawing.Size(300, 35);
            this.ejComboBox1.TabIndex = 0;
            this.ejComboBox1.Text = "";
            // 
            // checkBoxAutofill
            // 
            this.checkBoxAutofill.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAutofill.AutoSize = false;
            this.checkBoxAutofill.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAutofill.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxAutofill, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxAutofill, true);
            this.checkBoxAutofill.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAutofill.Name = "checkBoxAutofill";
            this.checkBoxAutofill.Size = new System.Drawing.Size(212, 38);
            this.checkBoxAutofill.TabIndex = 0;
            this.checkBoxAutofill.Text = "Autofill";
            // 
            // checkBoxShowClearButton
            // 
            this.checkBoxShowClearButton.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowClearButton.AutoSize = false;
            this.checkBoxShowClearButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowClearButton.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxShowClearButton, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxShowClearButton, true);
            this.checkBoxShowClearButton.Location = new System.Drawing.Point(3, 60);
            this.checkBoxShowClearButton.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxShowClearButton.Name = "checkBoxShowClearButton";
            this.checkBoxShowClearButton.Size = new System.Drawing.Size(212, 38);
            this.checkBoxShowClearButton.TabIndex = 1;
            this.checkBoxShowClearButton.Text = "Show Clear Button";
            // 
            // ejComboBox
            // 
            this.Name = "ejComboBox";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejComboBox ejComboBox1;
		private CheckBox checkBoxAutofill;
		private CheckBox checkBoxShowClearButton;
	}
}
