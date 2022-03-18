namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class TimeLine
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeLine));
			this.timeLine1 = new Wisej.Web.Ext.Webix.TimeLine();
			this.SuspendLayout();
			// 
			// timeLine1
			// 
			this.timeLine1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
			this.timeLine1.Location = new System.Drawing.Point(612, 20);
			this.timeLine1.Name = "timeLine1";
			this.timeLine1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("timeLine1.Options"))));
			this.timeLine1.Size = new System.Drawing.Size(307, 436);
			this.timeLine1.TabIndex = 11;
			this.timeLine1.Text = "timeLine1";
			// 
			// TimeLine
			// 
			this.Controls.Add(this.timeLine1);
			this.Name = "TimeLine";
			this.Controls.SetChildIndex(this.timeLine1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.TimeLine timeLine1;
	}
}
