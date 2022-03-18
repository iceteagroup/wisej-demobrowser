namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejPager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejPager));
            this.ejPager1 = new Wisej.Web.Ext.Syncfusion.ejPager();
            this.ejRotator1 = new Wisej.Web.Ext.Syncfusion.ejRotator();
            this.buttonGoToFirstPage = new Wisej.Web.Button();
            this.numericSelectedPage = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelectedPage)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/pager/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericSelectedPage);
            this.groupBox1.Controls.Add(this.buttonGoToFirstPage);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonGoToFirstPage, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericSelectedPage, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 233);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(519, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/pager/DefaultFunctionalities";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejpager";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejRotator1);
            this.panel.Controls.Add(this.ejPager1);
            this.panel.TabIndex = 7;
            // 
            // ejPager1
            // 
            this.ejPager1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejPager1.Location = new System.Drawing.Point(229, 434);
            this.ejPager1.Name = "ejPager1";
            this.ejPager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"pageSize\":1,\"totalPages\":6,\"totalRecordsCount\":6,\"pageCount\":3,\"isResponsive\":t" +
        "rue}")));
            this.ejPager1.Size = new System.Drawing.Size(630, 44);
            this.ejPager1.TabIndex = 1;
            this.ejPager1.Text = "ejPager1";
            // 
            // ejRotator1
            // 
            this.ejRotator1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejRotator1.Location = new System.Drawing.Point(229, 81);
            this.ejRotator1.Name = "ejRotator1";
            this.ejRotator1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejRotator1.Options"))));
            this.ejRotator1.Size = new System.Drawing.Size(630, 347);
            this.ejRotator1.TabIndex = 0;
            this.ejRotator1.Text = "ejRotator1";
            // 
            // buttonGoToFirstPage
            // 
            this.buttonGoToFirstPage.Location = new System.Drawing.Point(28, 150);
            this.buttonGoToFirstPage.Name = "buttonGoToFirstPage";
            this.buttonGoToFirstPage.Size = new System.Drawing.Size(195, 30);
            this.buttonGoToFirstPage.TabIndex = 1;
            this.buttonGoToFirstPage.Text = "Go To First Page";
            this.buttonGoToFirstPage.Click += new System.EventHandler(this.buttonGoToFirstPage_Click);
            // 
            // numericSelectedPage
            // 
            this.numericSelectedPage.AutoSize = false;
            this.numericSelectedPage.Label.Size = 50;
            this.numericSelectedPage.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericSelectedPage.LabelText = "Selected Page";
            this.numericSelectedPage.Location = new System.Drawing.Point(28, 37);
            this.numericSelectedPage.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericSelectedPage.Name = "numericSelectedPage";
            this.numericSelectedPage.Size = new System.Drawing.Size(195, 60);
            this.numericSelectedPage.TabIndex = 0;
            this.numericSelectedPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ejPager
            // 
            this.Name = "ejPager";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSelectedPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPager ejPager1;
		private Syncfusion.ejRotator ejRotator1;
		private Button buttonGoToFirstPage;
		private NumericUpDown numericSelectedPage;
	}
}
