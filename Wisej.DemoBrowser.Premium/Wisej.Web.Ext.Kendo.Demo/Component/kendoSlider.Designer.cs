namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoSlider
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
            this.kendoSlider1 = new Wisej.Web.Ext.Kendo.kendoSlider();
            this.kendoSlider2 = new Wisej.Web.Ext.Kendo.kendoSlider();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoSlider2);
            this.panel.Controls.Add(this.kendoSlider1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/slider/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/slider";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/slider/overview";
            // 
            // kendoSlider1
            // 
            this.kendoSlider1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoSlider1.Location = new System.Drawing.Point(374, 85);
            this.kendoSlider1.Name = "kendoSlider1";
            this.kendoSlider1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"increaseButtonTitle\":\"Right\",\"decreaseButtonTitle\":\"Left\",\"min\":-10,\"max\":10,\"s" +
        "mallStep\":2,\"largeStep\":1}")));
            this.kendoSlider1.Size = new System.Drawing.Size(340, 26);
            this.kendoSlider1.TabIndex = 0;
            this.kendoSlider1.Text = "kendoSlider1";
            // 
            // kendoSlider2
            // 
            this.kendoSlider2.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoSlider2.Location = new System.Drawing.Point(528, 133);
            this.kendoSlider2.Name = "kendoSlider2";
            this.kendoSlider2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"orientation\":\"vertical\",\"min\":-20,\"max\":20,\"smallStep\":1,\"largeStep\":20,\"showBu" +
        "ttons\":false}")));
            this.kendoSlider2.Size = new System.Drawing.Size(33, 340);
            this.kendoSlider2.TabIndex = 1;
            this.kendoSlider2.Text = "kendoSlider2";
            // 
            // kendoSlider
            // 
            this.Name = "kendoSlider";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoSlider kendoSlider1;
		private Kendo.kendoSlider kendoSlider2;
	}
}
