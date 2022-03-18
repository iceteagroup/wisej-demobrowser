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
			this.SuspendLayout();
			// 
			// unitList1
			// 
			this.unitList1.Anchor = Wisej.Web.AnchorStyles.None;
			this.unitList1.Location = new System.Drawing.Point(515, 38);
			this.unitList1.Name = "unitList1";
			this.unitList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("unitList1.Options"))));
			this.unitList1.Size = new System.Drawing.Size(500, 400);
			this.unitList1.TabIndex = 11;
			this.unitList1.Text = "unitList1";
			// 
			// UnitList
			// 
			this.Controls.Add(this.unitList1);
			this.Name = "UnitList";
			this.Controls.SetChildIndex(this.unitList1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.UnitList unitList1;
	}
}
