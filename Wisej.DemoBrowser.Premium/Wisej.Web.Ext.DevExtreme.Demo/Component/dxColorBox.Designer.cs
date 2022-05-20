namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxColorBox
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
            this.dxColorBox1 = new Wisej.Web.Ext.DevExtreme.dxColorBox();
            this.checkBoxCustomValue = new Wisej.Web.CheckBox();
            this.checkBoxActiveStateEnabled = new Wisej.Web.CheckBox();
            this.comboBoxValueMode = new Wisej.Web.ComboBox();
            this.checkBoxValidInput = new Wisej.Web.CheckBox();
            this.checkBoxClearButton = new Wisej.Web.CheckBox();
            this.checkBoxDropDownButton = new Wisej.Web.CheckBox();
            this.buttonGetValue = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/ColorBox/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/ColorBox/Overview/";
            // 
            // linkApi
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxColorBox/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxColorBox1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxCustomValue);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxActiveStateEnabled);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxValidInput);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxClearButton);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxDropDownButton);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxValueMode);
            this.flowLayoutPanel1.Controls.Add(this.buttonGetValue);
            // 
            // dxColorBox1
            // 
            this.dxColorBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dxColorBox1.Location = new System.Drawing.Point(269, 271);
            this.dxColorBox1.Name = "dxColorBox1";
            this.dxColorBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"#f05b41\",\"editAlphaChannel\":true,\"stylingMode\":\"outlined\"}")));
            this.dxColorBox1.Size = new System.Drawing.Size(350, 35);
            this.dxColorBox1.TabIndex = 0;
            // 
            // checkBoxCustomValue
            // 
            this.checkBoxCustomValue.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxCustomValue.AutoSize = false;
            this.checkBoxCustomValue.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCustomValue.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxCustomValue, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxCustomValue, true);
            this.checkBoxCustomValue.Location = new System.Drawing.Point(3, 3);
            this.checkBoxCustomValue.Name = "checkBoxCustomValue";
            this.checkBoxCustomValue.Size = new System.Drawing.Size(212, 40);
            this.checkBoxCustomValue.TabIndex = 0;
            this.checkBoxCustomValue.Text = "Accept Custom Value";
            // 
            // checkBoxActiveStateEnabled
            // 
            this.checkBoxActiveStateEnabled.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxActiveStateEnabled.AutoSize = false;
            this.checkBoxActiveStateEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActiveStateEnabled.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxActiveStateEnabled, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxActiveStateEnabled, true);
            this.checkBoxActiveStateEnabled.Location = new System.Drawing.Point(3, 62);
            this.checkBoxActiveStateEnabled.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxActiveStateEnabled.Name = "checkBoxActiveStateEnabled";
            this.checkBoxActiveStateEnabled.Size = new System.Drawing.Size(212, 40);
            this.checkBoxActiveStateEnabled.TabIndex = 1;
            this.checkBoxActiveStateEnabled.Text = "Active State Enabled";
            // 
            // comboBoxValueMode
            // 
            this.comboBoxValueMode.AutoSize = false;
            this.comboBoxValueMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxValueMode, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxValueMode, true);
            this.comboBoxValueMode.Items.AddRange(new object[] {
            "instantly",
            "useButtons"});
            this.comboBoxValueMode.Label.Size = 50;
            this.comboBoxValueMode.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBoxValueMode.LabelText = "Apply Value Mode";
            this.comboBoxValueMode.Location = new System.Drawing.Point(3, 298);
            this.comboBoxValueMode.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxValueMode.Name = "comboBoxValueMode";
            this.comboBoxValueMode.Size = new System.Drawing.Size(212, 60);
            this.comboBoxValueMode.TabIndex = 5;
            this.comboBoxValueMode.Text = "useButtons";
            // 
            // checkBoxValidInput
            // 
            this.checkBoxValidInput.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxValidInput.AutoSize = false;
            this.checkBoxValidInput.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxValidInput.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxValidInput, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxValidInput, true);
            this.checkBoxValidInput.Location = new System.Drawing.Point(3, 121);
            this.checkBoxValidInput.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxValidInput.Name = "checkBoxValidInput";
            this.checkBoxValidInput.Size = new System.Drawing.Size(212, 40);
            this.checkBoxValidInput.TabIndex = 2;
            this.checkBoxValidInput.Text = "Input is Valid";
            // 
            // checkBoxClearButton
            // 
            this.checkBoxClearButton.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxClearButton.AutoSize = false;
            this.checkBoxClearButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxClearButton, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxClearButton, true);
            this.checkBoxClearButton.Location = new System.Drawing.Point(3, 180);
            this.checkBoxClearButton.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxClearButton.Name = "checkBoxClearButton";
            this.checkBoxClearButton.Size = new System.Drawing.Size(212, 40);
            this.checkBoxClearButton.TabIndex = 3;
            this.checkBoxClearButton.Text = "Show Clear Button";
            // 
            // checkBoxDropDownButton
            // 
            this.checkBoxDropDownButton.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDropDownButton.AutoSize = false;
            this.checkBoxDropDownButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDropDownButton.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxDropDownButton, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxDropDownButton, true);
            this.checkBoxDropDownButton.Location = new System.Drawing.Point(3, 239);
            this.checkBoxDropDownButton.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxDropDownButton.Name = "checkBoxDropDownButton";
            this.checkBoxDropDownButton.Size = new System.Drawing.Size(212, 40);
            this.checkBoxDropDownButton.TabIndex = 4;
            this.checkBoxDropDownButton.Text = "DropDown Button";
            // 
            // buttonGetValue
            // 
            this.buttonGetValue.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonGetValue.Location = new System.Drawing.Point(3, 377);
            this.buttonGetValue.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonGetValue.Name = "buttonGetValue";
            this.buttonGetValue.Size = new System.Drawing.Size(212, 35);
            this.buttonGetValue.TabIndex = 16;
            this.buttonGetValue.Text = "Get Value";
            this.buttonGetValue.Click += new System.EventHandler(this.buttonGetValue_Click);
            // 
            // dxColorBox
            // 
            this.Name = "dxColorBox";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxColorBox dxColorBox1;
		private CheckBox checkBoxActiveStateEnabled;
		private CheckBox checkBoxCustomValue;
		private CheckBox checkBoxDropDownButton;
		private CheckBox checkBoxClearButton;
		private CheckBox checkBoxValidInput;
		private ComboBox comboBoxValueMode;
        private Button buttonGetValue;
    }
}
