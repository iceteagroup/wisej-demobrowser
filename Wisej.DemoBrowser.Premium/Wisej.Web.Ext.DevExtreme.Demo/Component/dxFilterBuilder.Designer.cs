namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxFilterBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxFilterBuilder));
            this.dxFilterBuilder1 = new Wisej.Web.Ext.DevExtreme.dxFilterBuilder();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/FilterBuilder/Overview/";
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/FilterBuilder/WithDataGrid/jQ" +
    "uery/Light/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxFilterBuilder/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxFilterBuilder1);
            // 
            // dxFilterBuilder1
            // 
            this.dxFilterBuilder1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dxFilterBuilder1.Location = new System.Drawing.Point(240, 94);
            this.dxFilterBuilder1.Name = "dxFilterBuilder1";
            this.dxFilterBuilder1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxFilterBuilder1.Options"))));
            this.dxFilterBuilder1.Size = new System.Drawing.Size(608, 370);
            this.dxFilterBuilder1.TabIndex = 0;
            // 
            // dxFilterBuilder
            // 
            this.MinimumSize = new System.Drawing.Size(1028, 571);
            this.Name = "dxFilterBuilder";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxFilterBuilder dxFilterBuilder1;
	}
}
