﻿namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class TreeMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeMap));
			this.treeMap1 = new Wisej.Web.Ext.Syncfusion2.TreeMap();
			this.comboBoxRenderDirection = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/treemap/es5-getting-started/";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/treemap/";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.treeMap1);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.comboBoxRenderDirection);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/treemap/default.html";
			// 
			// treeMap1
			// 
			this.treeMap1.Dock = Wisej.Web.DockStyle.Fill;
			this.treeMap1.Location = new System.Drawing.Point(8, 8);
			this.treeMap1.Name = "treeMap1";
			this.treeMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeMap1.Options"))));
			this.treeMap1.Size = new System.Drawing.Size(872, 560);
			this.treeMap1.TabIndex = 0;
			this.treeMap1.Text = "treeMap1";
			this.treeMap1.WidgetEvents = new Wisej.Web.Ext.Syncfusion2.ej2Base.WidgetEventHandler[0];
			// 
			// comboBoxRenderDirection
			// 
			this.comboBoxRenderDirection.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxRenderDirection.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanel1.SetFillWeight(this.comboBoxRenderDirection, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.comboBoxRenderDirection, true);
			this.comboBoxRenderDirection.Items.AddRange(new object[] {
            "TopLeftBottomRight",
            "TopRightBottomLeft",
            "BottomRightTopLeft",
            "BottomLeftTopRight"});
			this.comboBoxRenderDirection.LabelText = "Render Direction";
			this.comboBoxRenderDirection.Location = new System.Drawing.Point(3, 3);
			this.comboBoxRenderDirection.Name = "comboBoxRenderDirection";
			this.comboBoxRenderDirection.Size = new System.Drawing.Size(212, 51);
			this.comboBoxRenderDirection.TabIndex = 2;
			this.comboBoxRenderDirection.Text = "TopLeftBottomRight";
			// 
			// TreeMap
			// 
			this.Name = "TreeMap";
			this.Load += new System.EventHandler(this.TreeMap_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.TreeMap treeMap1;
        private ComboBox comboBoxRenderDirection;
    }
}
