namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class UnitList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitList));
            this.unitList1 = new Wisej.Web.Ext.Webix.UnitList();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__unitlist.html";
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#unitlist";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.unitlist.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.unitList1);
            // 
            // unitList1
            // 
            this.unitList1.Anchor = Wisej.Web.AnchorStyles.None;
            this.unitList1.Location = new System.Drawing.Point(294, 79);
            this.unitList1.Name = "unitList1";
            this.unitList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("unitList1.Options"))));
            this.unitList1.Size = new System.Drawing.Size(500, 400);
            this.unitList1.TabIndex = 11;
            this.unitList1.Text = "unitList1";
            // 
            // UnitList
            // 
            this.Name = "UnitList";
            this.Load += new System.EventHandler(this.UnitList_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.UnitList unitList1;
	}
}
