namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejSignature
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
            this.ejSignature1 = new Wisej.Web.Ext.Syncfusion.ejSignature();
            this.button1 = new Wisej.Web.Button();
            this.buttonClear = new Wisej.Web.Button();
            this.buttonUndo = new Wisej.Web.Button();
            this.buttonRedo = new Wisej.Web.Button();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/signature/overview";
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(616, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/signature/DefaultFunctionalities" +
    "";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejsignature";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejSignature1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.button1);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonClear);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonUndo);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonRedo);
            // 
            // ejSignature1
            // 
            this.ejSignature1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejSignature1.Location = new System.Drawing.Point(8, 8);
            this.ejSignature1.Name = "ejSignature1";
            this.ejSignature1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"isResponsive\":true,\"strokeWidth\":3}")));
            this.ejSignature1.Size = new System.Drawing.Size(1073, 542);
            this.ejSignature1.TabIndex = 0;
            this.ejSignature1.Text = "ejSignature1";
            // 
            // button1
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.button1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.button1, true);
            this.button1.Location = new System.Drawing.Point(3, 131);
            this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Image";
            this.button1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.buttonClear, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.buttonClear, true);
            this.buttonClear.Location = new System.Drawing.Point(3, 180);
            this.buttonClear.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(212, 30);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Display = Wisej.Web.Display.Icon;
            this.buttonUndo.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/undo-button.svg";
            this.buttonUndo.Location = new System.Drawing.Point(3, 229);
            this.buttonUndo.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(42, 42);
            this.buttonUndo.TabIndex = 4;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Display = Wisej.Web.Display.Icon;
            this.buttonRedo.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/refresh-button-1.svg";
            this.buttonRedo.Location = new System.Drawing.Point(51, 229);
            this.buttonRedo.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(42, 42);
            this.buttonRedo.TabIndex = 5;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 45);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Save With Background";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 67);
            this.checkBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 45);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Show Rounded Corner";
            // 
            // ejSignature
            // 
            this.Name = "ejSignature";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSignature ejSignature1;
		private Button button1;
		private Button buttonClear;
		private Button buttonRedo;
		private Button buttonUndo;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
	}
}
