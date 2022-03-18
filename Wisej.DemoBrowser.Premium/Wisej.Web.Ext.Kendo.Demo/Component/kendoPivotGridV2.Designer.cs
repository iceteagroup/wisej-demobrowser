namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoPivotGridV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoPivotGridV2));
            this.kendoPivotGridV21 = new Wisej.Web.Ext.Kendo.kendoPivotGridV2();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoPivotGridV21);
            // 
            // kendoPivotGridV21
            // 
            this.kendoPivotGridV21.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoPivotGridV21.Location = new System.Drawing.Point(8, 8);
            this.kendoPivotGridV21.Name = "kendoPivotGridV21";
            this.kendoPivotGridV21.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoPivotGridV21.Options"))));
            this.kendoPivotGridV21.Size = new System.Drawing.Size(1073, 542);
            this.kendoPivotGridV21.TabIndex = 0;
            this.kendoPivotGridV21.Text = "kendoPivotGridV21";
            // 
            // kendoPivotGridV2
            // 
            this.Name = "kendoPivotGridV2";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoPivotGridV2 kendoPivotGridV21;
	}
}
