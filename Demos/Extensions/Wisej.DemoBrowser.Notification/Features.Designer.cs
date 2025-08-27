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
            this.buttonShowNotification = new Wisej.Web.Button();
            this.textBoxTitle = new Wisej.Web.TextBox();
            this.textBoxBody = new Wisej.Web.TextBox();
            this.checkBoxShowOnClick = new Wisej.Web.CheckBox();
            this.checkBoxRequireInteraction = new Wisej.Web.CheckBox();
            this.SuspendLayout();
            // 
            // notification1
            // 
            this.notification1.Click += new Wisej.Web.Ext.Notification.NotificationClickEventHandler(this.notification1_Click);
            // 
            // buttonShowNotification
            // 
            this.buttonShowNotification.Anchor = Wisej.Web.AnchorStyles.None;
            this.buttonShowNotification.Location = new System.Drawing.Point(619, 369);
            this.buttonShowNotification.Name = "buttonShowNotification";
            this.buttonShowNotification.Size = new System.Drawing.Size(185, 37);
            this.buttonShowNotification.TabIndex = 0;
            this.buttonShowNotification.Text = "Show Notification";
            this.buttonShowNotification.Click += new System.EventHandler(this.buttonShowNotification_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBoxTitle.LabelText = "Title";
            this.textBoxTitle.Location = new System.Drawing.Point(619, 69);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(185, 53);
            this.textBoxTitle.TabIndex = 2;
            this.textBoxTitle.Text = "Wisej";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBoxBody.LabelText = "Body";
            this.textBoxBody.Location = new System.Drawing.Point(619, 149);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(185, 53);
            this.textBoxBody.TabIndex = 3;
            this.textBoxBody.Text = "Integrate anything with Wisej.";
            // 
            // checkBoxShowOnClick
            // 
            this.checkBoxShowOnClick.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBoxShowOnClick.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowOnClick.AutoSize = false;
            this.checkBoxShowOnClick.Location = new System.Drawing.Point(619, 229);
            this.checkBoxShowOnClick.Name = "checkBoxShowOnClick";
            this.checkBoxShowOnClick.Size = new System.Drawing.Size(185, 43);
            this.checkBoxShowOnClick.TabIndex = 4;
            this.checkBoxShowOnClick.Text = "Show on Click";
            // 
            // checkBoxRequireInteraction
            // 
            this.checkBoxRequireInteraction.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBoxRequireInteraction.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxRequireInteraction.AutoSize = false;
            this.checkBoxRequireInteraction.Location = new System.Drawing.Point(619, 299);
            this.checkBoxRequireInteraction.Name = "checkBoxRequireInteraction";
            this.checkBoxRequireInteraction.Size = new System.Drawing.Size(185, 43);
            this.checkBoxRequireInteraction.TabIndex = 5;
            this.checkBoxRequireInteraction.Text = "Require Interaction";
            // 
            // Features
            // 
            this.Controls.Add(this.checkBoxRequireInteraction);
            this.Controls.Add(this.checkBoxShowOnClick);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonShowNotification);
            this.MinimumSize = new System.Drawing.Size(213, 361);
            this.Name = "Features";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Ext.Notification.Notification notification1;
		private Web.Button buttonShowNotification;
        private Web.TextBox textBoxTitle;
        private Web.TextBox textBoxBody;
        private Web.CheckBox checkBoxShowOnClick;
        private Web.CheckBox checkBoxRequireInteraction;
    }
}
