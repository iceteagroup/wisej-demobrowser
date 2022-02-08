namespace Wisej.DemoBrowser.Notification
{
	partial class Features
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
			this.components = new System.ComponentModel.Container();
			this.notification1 = new Wisej.Web.Ext.Notification.Notification(this.components);
			this.buttonProgress = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// notification1
			// 
			this.notification1.Click += new Wisej.Web.Ext.Notification.NotificationClickEventHandler(this.notification1_Click);
			// 
			// buttonProgress
			// 
			this.buttonProgress.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonProgress.Location = new System.Drawing.Point(618, 219);
			this.buttonProgress.Name = "buttonProgress";
			this.buttonProgress.Size = new System.Drawing.Size(186, 37);
			this.buttonProgress.TabIndex = 0;
			this.buttonProgress.Text = "Start Task";
			this.buttonProgress.Click += new System.EventHandler(this.buttonProgress_Click);
			// 
			// Features
			// 
			this.Controls.Add(this.buttonProgress);
			this.Name = "Features";
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.Notification.Notification notification1;
		private Web.Button buttonProgress;
	}
}
