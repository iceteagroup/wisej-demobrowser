namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxSwitch
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
            this.dxSwitch1 = new Wisej.Web.Ext.DevExtreme.dxSwitch();
            this.checkBoxIsValid = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Switch/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Switch/Overview/jQuery/Light/" +
    "";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxSwitch/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxSwitch1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxIsValid);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 441);
            // 
            // dxSwitch1
            // 
            this.dxSwitch1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dxSwitch1.Location = new System.Drawing.Point(513, 262);
            this.dxSwitch1.Name = "dxSwitch1";
            this.dxSwitch1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"switchedOnText\":\"on\",\"switchedOffText\":\"off\",\"isValid\":false}")));
            this.dxSwitch1.Size = new System.Drawing.Size(63, 35);
            this.dxSwitch1.TabIndex = 0;
            // 
            // checkBoxIsValid
            // 
            this.checkBoxIsValid.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxIsValid.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxIsValid.AutoSize = false;
            this.checkBoxIsValid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxIsValid.Location = new System.Drawing.Point(3, 16);
            this.checkBoxIsValid.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxIsValid.Name = "checkBoxIsValid";
            this.checkBoxIsValid.Size = new System.Drawing.Size(212, 26);
            this.checkBoxIsValid.TabIndex = 2;
            this.checkBoxIsValid.Text = "Is Valid";
            // 
            // dxSwitch
            // 
            this.MinimumSize = new System.Drawing.Size(815, 403);
            this.Name = "dxSwitch";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxSwitch dxSwitch1;
        private CheckBox checkBoxIsValid;
    }
}
