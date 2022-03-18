namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejDropDownTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejDropDownTree));
            this.ejDropDownTree1 = new Wisej.Web.Ext.Syncfusion.ejDropDownTree();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.numericUpDownPopupHeight = new Wisej.Web.NumericUpDown();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopupHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/dropdowntree/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.numericUpDownPopupHeight);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 437);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownPopupHeight, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 354);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(553, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/dropdowntree/DefaultFunctionalit" +
    "ies";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejdropdowntree";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejDropDownTree1);
            this.panel.TabIndex = 7;
            // 
            // ejDropDownTree1
            // 
            this.ejDropDownTree1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejDropDownTree1.Location = new System.Drawing.Point(394, 262);
            this.ejDropDownTree1.Name = "ejDropDownTree1";
            this.ejDropDownTree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejDropDownTree1.Options"))));
            this.ejDropDownTree1.Size = new System.Drawing.Size(300, 35);
            this.ejDropDownTree1.TabIndex = 0;
            this.ejDropDownTree1.Text = "ejDropDownTree1";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 47);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Rounded Corner";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(28, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 49);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Show Popup on Load";
            // 
            // numericUpDownPopupHeight
            // 
            this.numericUpDownPopupHeight.AutoSize = false;
            this.numericUpDownPopupHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownPopupHeight.Label.Size = 50;
            this.numericUpDownPopupHeight.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDownPopupHeight.LabelText = "Popup Height";
            this.numericUpDownPopupHeight.Location = new System.Drawing.Point(28, 266);
            this.numericUpDownPopupHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPopupHeight.Name = "numericUpDownPopupHeight";
            this.numericUpDownPopupHeight.Size = new System.Drawing.Size(195, 60);
            this.numericUpDownPopupHeight.TabIndex = 3;
            this.numericUpDownPopupHeight.Value = new decimal(new int[] {
            152,
            0,
            0,
            0});
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.checkBox3.Location = new System.Drawing.Point(28, 188);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 50);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Allow Keyboard Navigation";
            // 
            // ejDropDownTree
            // 
            this.Name = "ejDropDownTree";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopupHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDropDownTree ejDropDownTree1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private NumericUpDown numericUpDownPopupHeight;
		private CheckBox checkBox3;
	}
}
