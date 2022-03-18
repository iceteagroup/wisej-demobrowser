namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxPivotGridFieldChooser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxPivotGridFieldChooser));
			this.dxPivotGridFieldChooser1 = new Wisej.Web.Ext.DevExtreme.dxPivotGridFieldChooser();
			this.dxPivotGrid1 = new Wisej.Web.Ext.DevExtreme.dxPivotGrid();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/PivotGrid/Visual_Elements/#" +
    "Field_Chooser";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxPivotGridFieldC" +
    "hooser/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxPivotGrid1);
			this.panel.Controls.Add(this.dxPivotGridFieldChooser1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/PivotGrid/IntegratedFieldChoo" +
    "ser/jQuery/Light/";
			// 
			// dxPivotGridFieldChooser1
			// 
			this.dxPivotGridFieldChooser1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxPivotGridFieldChooser1.Location = new System.Drawing.Point(3, 154);
			this.dxPivotGridFieldChooser1.Name = "dxPivotGridFieldChooser1";
			this.dxPivotGridFieldChooser1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"texts\":{\"allFields\":\"All\",\"columnFields\":\"Columns\",\"dataFields\":\"Data\",\"rowFiel" +
        "ds\":\"Rows\",\"filterFields\":\"Filter\"},\"dataSource\":{\"store\":\"\"}}")));
			this.dxPivotGridFieldChooser1.Size = new System.Drawing.Size(447, 156);
			this.dxPivotGridFieldChooser1.TabIndex = 2;
			this.dxPivotGridFieldChooser1.Text = "dxPivotGridFieldChooser1";
			// 
			// dxPivotGrid1
			// 
			this.dxPivotGrid1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxPivotGrid1.Location = new System.Drawing.Point(3, 3);
			this.dxPivotGrid1.Name = "dxPivotGrid1";
			this.dxPivotGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxPivotGrid1.Options"))));
			this.dxPivotGrid1.Size = new System.Drawing.Size(447, 145);
			this.dxPivotGrid1.TabIndex = 1;
			this.dxPivotGrid1.Text = "dxPivotGrid1";
			// 
			// dxPivotGridFieldChooser
			// 
			this.Name = "dxPivotGridFieldChooser";
			this.Load += new System.EventHandler(this.dxPivotGridFieldChooser_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxPivotGridFieldChooser dxPivotGridFieldChooser1;
		private DevExtreme.dxPivotGrid dxPivotGrid1;
	}
}
