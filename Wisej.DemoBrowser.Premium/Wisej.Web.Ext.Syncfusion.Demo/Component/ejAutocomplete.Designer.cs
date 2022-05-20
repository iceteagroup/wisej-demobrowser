namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejAutocomplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejAutocomplete));
            this.ejAutocomplete1 = new Wisej.Web.Ext.Syncfusion.ejAutocomplete();
            this.button1 = new Wisej.Web.Button();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.checkBox6 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Size = new System.Drawing.Size(585, 24);
            this.linkDocs.Text = "https://help.syncfusion.com/js/autocomplete/overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(572, 24);
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/autocomplete/DefaultFunctionalit" +
    "ies";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://help.syncfusion.com/api/js/ejautocomplete";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejAutocomplete1);
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox3);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox4);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox5);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox6);
            this.flowLayoutPanelProperties.Controls.Add(this.button1);
            // 
            // ejAutocomplete1
            // 
            this.ejAutocomplete1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejAutocomplete1.Location = new System.Drawing.Point(294, 273);
            this.ejAutocomplete1.Name = "ejAutocomplete1";
            this.ejAutocomplete1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejAutocomplete1.Options"))));
            this.ejAutocomplete1.Size = new System.Drawing.Size(300, 30);
            this.ejAutocomplete1.TabIndex = 0;
            this.ejAutocomplete1.Text = "ejAutocomplete1";
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanelProperties.SetFillWeight(this.button1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.button1, true);
            this.button1.Location = new System.Drawing.Point(3, 295);
            this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get TextBox Value";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 30);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Auto Focus";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 52);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 33);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Case Sensitive";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox3, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox3, true);
            this.checkBox3.Location = new System.Drawing.Point(3, 104);
            this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(212, 30);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Highlight Search";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 153);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 25);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Show Empty Result";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox5, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox5, true);
            this.checkBox5.Location = new System.Drawing.Point(3, 197);
            this.checkBox5.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(212, 30);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Show Reset Icon";
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox6.AutoSize = false;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox6, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox6, true);
            this.checkBox6.Location = new System.Drawing.Point(3, 246);
            this.checkBox6.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(212, 30);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Show Popup Button";
            // 
            // ejAutocomplete
            // 
            this.Name = "ejAutocomplete";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejAutocomplete ejAutocomplete1;
		private Button button1;
		private CheckBox checkBox1;
		private CheckBox checkBox6;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
	}
}
