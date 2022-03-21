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
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/split-button/es5-getting-star" +
    "ted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/split-button/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxIconPosition);
            this.groupBox1.Controls.Add(this.checkBoxDisabled);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxDisabled, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxIconPosition, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.splitButton1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/button/split-button.html";
            // 
            // splitButton1
            // 
            this.splitButton1.Anchor = Wisej.Web.AnchorStyles.None;
            this.splitButton1.Location = new System.Drawing.Point(163, 133);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("splitButton1.Options"))));
            this.splitButton1.Size = new System.Drawing.Size(126, 47);
            this.splitButton1.TabIndex = 0;
            this.splitButton1.Text = "splitButton1";
            // 
            // checkBoxDisabled
            // 
            this.checkBoxDisabled.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDisabled.Location = new System.Drawing.Point(16, 37);
            this.checkBoxDisabled.Name = "checkBoxDisabled";
            this.checkBoxDisabled.Size = new System.Drawing.Size(115, 24);
            this.checkBoxDisabled.TabIndex = 1;
            this.checkBoxDisabled.Text = "Disabled";
            // 
            // comboBoxIconPosition
            // 
            this.comboBoxIconPosition.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxIconPosition.LabelText = "Icon position";
            this.comboBoxIconPosition.Location = new System.Drawing.Point(16, 75);
            this.comboBoxIconPosition.Name = "comboBoxIconPosition";
            this.comboBoxIconPosition.Size = new System.Drawing.Size(214, 46);
            this.comboBoxIconPosition.TabIndex = 2;
            // 
            // SplitButton
            // 
            this.Name = "SplitButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.SplitButton splitButton1;
        private ComboBox comboBoxIconPosition;
        private CheckBox checkBoxDisabled;
    }
}
