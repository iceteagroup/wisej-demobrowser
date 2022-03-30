namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoQRCode
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
            this.kendoQRCode1 = new Wisej.Web.Ext.Kendo.kendoQRCode();
            this.textBox2 = new Wisej.Web.TextBox();
            this.textBox1 = new Wisej.Web.TextBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoQRCode1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/qrcode/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/qrcode";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/barcodes/qrcode/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.textBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.textBox2);
            // 
            // kendoQRCode1
            // 
            this.kendoQRCode1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoQRCode1.Location = new System.Drawing.Point(418, 152);
            this.kendoQRCode1.Name = "kendoQRCode1";
            this.kendoQRCode1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"http://www.wisej.com/\",\"color\":\"#e15613\",\"background\":\"transparent\"}")));
            this.kendoQRCode1.Size = new System.Drawing.Size(253, 254);
            this.kendoQRCode1.TabIndex = 0;
            this.kendoQRCode1.Text = "kendoQRCode1";
            // 
            // textBox2
            // 
            this.textBox2.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.textBox2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.textBox2, true);
            this.textBox2.InputType.Type = Wisej.Web.TextBoxType.Color;
            this.textBox2.Label.Size = 50;
            this.textBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox2.LabelText = "Color";
            this.textBox2.Location = new System.Drawing.Point(3, 82);
            this.textBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 60);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "#E15613";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.textBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.textBox1, true);
            this.textBox1.Label.Size = 50;
            this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox1.LabelText = "Value";
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 60);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "http://www.wisej.com/";
            // 
            // kendoQRCode
            // 
            this.Name = "kendoQRCode";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoQRCode kendoQRCode1;
		private TextBox textBox1;
		private TextBox textBox2;
	}
}
