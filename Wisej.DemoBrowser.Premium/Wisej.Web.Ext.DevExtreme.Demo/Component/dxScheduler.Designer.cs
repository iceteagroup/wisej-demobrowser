namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxScheduler));
            this.dxScheduler1 = new Wisej.Web.Ext.DevExtreme.dxScheduler();
            this.comboBoxCurrentView = new Wisej.Web.ComboBox();
            this.checkBoxAllowAdding = new Wisej.Web.CheckBox();
            this.checkBoxAllowDeleting = new Wisej.Web.CheckBox();
            this.checkBoxAllowDragging = new Wisej.Web.CheckBox();
            this.checkBoxAllowResizing = new Wisej.Web.CheckBox();
            this.checkBoxAllowTimeZoneEditing = new Wisej.Web.CheckBox();
            this.checkBoxAllowUpdating = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Scheduler/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Scheduler/Overview/jQuery/Lig" +
    "ht/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxScheduler/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxScheduler1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBoxCurrentView);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowAdding);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowDeleting);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowDragging);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowResizing);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowUpdating);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowTimeZoneEditing);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 441);
            // 
            // dxScheduler1
            // 
            this.dxScheduler1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxScheduler1.Location = new System.Drawing.Point(27, 17);
            this.dxScheduler1.Name = "dxScheduler1";
            this.dxScheduler1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxScheduler1.Options"))));
            this.dxScheduler1.Size = new System.Drawing.Size(1034, 524);
            this.dxScheduler1.TabIndex = 0;
            // 
            // comboBoxCurrentView
            // 
            this.comboBoxCurrentView.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxCurrentView.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxCurrentView.Items.AddRange(new object[] {
            "agenda",
            "day  ",
            "month  ",
            "timelineDay  ",
            "timelineMonth  ",
            "timelineWeek  ",
            "timelineWorkWeek  ",
            "week  ",
            "workWeek "});
            this.comboBoxCurrentView.LabelText = "Current view";
            this.comboBoxCurrentView.Location = new System.Drawing.Point(3, 3);
            this.comboBoxCurrentView.Name = "comboBoxCurrentView";
            this.comboBoxCurrentView.Size = new System.Drawing.Size(212, 46);
            this.comboBoxCurrentView.TabIndex = 0;
            // 
            // checkBoxAllowAdding
            // 
            this.checkBoxAllowAdding.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxAllowAdding.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowAdding.AutoSize = false;
            this.checkBoxAllowAdding.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllowAdding.Checked = true;
            this.checkBoxAllowAdding.Location = new System.Drawing.Point(3, 55);
            this.checkBoxAllowAdding.Name = "checkBoxAllowAdding";
            this.checkBoxAllowAdding.Size = new System.Drawing.Size(212, 26);
            this.checkBoxAllowAdding.TabIndex = 1;
            this.checkBoxAllowAdding.Text = "Allow adding";
            // 
            // checkBoxAllowDeleting
            // 
            this.checkBoxAllowDeleting.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxAllowDeleting.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowDeleting.AutoSize = false;
            this.checkBoxAllowDeleting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllowDeleting.Checked = true;
            this.checkBoxAllowDeleting.Location = new System.Drawing.Point(3, 87);
            this.checkBoxAllowDeleting.Name = "checkBoxAllowDeleting";
            this.checkBoxAllowDeleting.Size = new System.Drawing.Size(212, 26);
            this.checkBoxAllowDeleting.TabIndex = 2;
            this.checkBoxAllowDeleting.Text = "Allow deleting";
            // 
            // checkBoxAllowDragging
            // 
            this.checkBoxAllowDragging.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxAllowDragging.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowDragging.AutoSize = false;
            this.checkBoxAllowDragging.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllowDragging.Checked = true;
            this.checkBoxAllowDragging.Location = new System.Drawing.Point(3, 119);
            this.checkBoxAllowDragging.Name = "checkBoxAllowDragging";
            this.checkBoxAllowDragging.Size = new System.Drawing.Size(212, 26);
            this.checkBoxAllowDragging.TabIndex = 3;
            this.checkBoxAllowDragging.Text = "Allow dragging";
            // 
            // checkBoxAllowResizing
            // 
            this.checkBoxAllowResizing.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxAllowResizing.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowResizing.AutoSize = false;
            this.checkBoxAllowResizing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllowResizing.Checked = true;
            this.checkBoxAllowResizing.Location = new System.Drawing.Point(3, 151);
            this.checkBoxAllowResizing.Name = "checkBoxAllowResizing";
            this.checkBoxAllowResizing.Size = new System.Drawing.Size(212, 26);
            this.checkBoxAllowResizing.TabIndex = 4;
            this.checkBoxAllowResizing.Text = "Allow resizing";
            // 
            // checkBoxAllowTimeZoneEditing
            // 
            this.checkBoxAllowTimeZoneEditing.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxAllowTimeZoneEditing.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowTimeZoneEditing.AutoSize = false;
            this.checkBoxAllowTimeZoneEditing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllowTimeZoneEditing.Checked = true;
            this.checkBoxAllowTimeZoneEditing.Location = new System.Drawing.Point(3, 215);
            this.checkBoxAllowTimeZoneEditing.Name = "checkBoxAllowTimeZoneEditing";
            this.checkBoxAllowTimeZoneEditing.Size = new System.Drawing.Size(212, 26);
            this.checkBoxAllowTimeZoneEditing.TabIndex = 5;
            this.checkBoxAllowTimeZoneEditing.Text = "Allow timezone editing";
            // 
            // checkBoxAllowUpdating
            // 
            this.checkBoxAllowUpdating.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxAllowUpdating.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowUpdating.AutoSize = false;
            this.checkBoxAllowUpdating.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllowUpdating.Checked = true;
            this.checkBoxAllowUpdating.Location = new System.Drawing.Point(3, 183);
            this.checkBoxAllowUpdating.Name = "checkBoxAllowUpdating";
            this.checkBoxAllowUpdating.Size = new System.Drawing.Size(212, 26);
            this.checkBoxAllowUpdating.TabIndex = 6;
            this.checkBoxAllowUpdating.Text = "Allow updating";
            // 
            // dxScheduler
            // 
            this.MinimumSize = new System.Drawing.Size(1003, 615);
            this.Name = "dxScheduler";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxScheduler dxScheduler1;
        private ComboBox comboBoxCurrentView;
        private CheckBox checkBoxAllowAdding;
        private CheckBox checkBoxAllowDeleting;
        private CheckBox checkBoxAllowDragging;
        private CheckBox checkBoxAllowResizing;
        private CheckBox checkBoxAllowUpdating;
        private CheckBox checkBoxAllowTimeZoneEditing;
    }
}
