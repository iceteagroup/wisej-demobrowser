namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejTimePicker
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
            this.ejTimePicker1 = new Wisej.Web.Ext.Syncfusion.ejTimePicker();
            this.buttonGetTime = new Wisej.Web.Button();
            this.buttonTimeNow = new Wisej.Web.Button();
            this.buttonShowHidePopup = new Wisej.Web.Button();
            this.checkBoxEnabled = new Wisej.Web.CheckBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/timepicker/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBoxEnabled);
            this.groupBox1.Controls.Add(this.buttonShowHidePopup);
            this.groupBox1.Controls.Add(this.buttonTimeNow);
            this.groupBox1.Controls.Add(this.buttonGetTime);
            this.groupBox1.Size = new System.Drawing.Size(250, 478);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonGetTime, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonTimeNow, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonShowHidePopup, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxEnabled, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 386);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(530, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/timepicker/defaultfunctionalitie" +
    "s";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejtimepicker";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejTimePicker1);
            this.panel.TabIndex = 7;
            // 
            // ejTimePicker1
            // 
            this.ejTimePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejTimePicker1.Location = new System.Drawing.Point(394, 264);
            this.ejTimePicker1.Name = "ejTimePicker1";
            this.ejTimePicker1.Size = new System.Drawing.Size(300, 30);
            this.ejTimePicker1.TabIndex = 0;
            this.ejTimePicker1.Text = "ejTimePicker1";
            // 
            // buttonGetTime
            // 
            this.buttonGetTime.Location = new System.Drawing.Point(28, 254);
            this.buttonGetTime.Name = "buttonGetTime";
            this.buttonGetTime.Size = new System.Drawing.Size(195, 30);
            this.buttonGetTime.TabIndex = 4;
            this.buttonGetTime.Text = "Get Time";
            this.buttonGetTime.Click += new System.EventHandler(this.buttonGetTime_Click);
            // 
            // buttonTimeNow
            // 
            this.buttonTimeNow.Location = new System.Drawing.Point(28, 298);
            this.buttonTimeNow.Name = "buttonTimeNow";
            this.buttonTimeNow.Size = new System.Drawing.Size(195, 30);
            this.buttonTimeNow.TabIndex = 5;
            this.buttonTimeNow.Text = "Time Now";
            this.buttonTimeNow.Click += new System.EventHandler(this.buttonTimeNow_Click);
            // 
            // buttonShowHidePopup
            // 
            this.buttonShowHidePopup.Location = new System.Drawing.Point(28, 342);
            this.buttonShowHidePopup.Name = "buttonShowHidePopup";
            this.buttonShowHidePopup.Size = new System.Drawing.Size(195, 30);
            this.buttonShowHidePopup.TabIndex = 6;
            this.buttonShowHidePopup.Text = "Show / Hide Popup";
            this.buttonShowHidePopup.Click += new System.EventHandler(this.buttonShowHidePopup_Click);
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnabled.AutoSize = false;
            this.checkBoxEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEnabled.Checked = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(28, 36);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(195, 38);
            this.checkBoxEnabled.TabIndex = 0;
            this.checkBoxEnabled.Text = "Enabled";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(28, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Enable Strict Mode";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.Location = new System.Drawing.Point(28, 140);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Show Popup button";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(28, 192);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 48);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Show Rounded Corner";
            // 
            // ejTimePicker
            // 
            this.Name = "ejTimePicker";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTimePicker ejTimePicker1;
		private Button buttonShowHidePopup;
		private Button buttonTimeNow;
		private Button buttonGetTime;
		private CheckBox checkBoxEnabled;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
