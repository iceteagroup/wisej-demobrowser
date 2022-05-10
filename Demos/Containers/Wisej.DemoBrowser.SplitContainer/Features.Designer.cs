namespace Wisej.DemoBrowser.SplitContainer
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
			Wisej.Web.TreeNode treeNode1 = new Wisej.Web.TreeNode();
			Wisej.Web.TreeNode treeNode2 = new Wisej.Web.TreeNode();
			Wisej.Web.TreeNode treeNode3 = new Wisej.Web.TreeNode();
			Wisej.Web.TreeNode treeNode4 = new Wisej.Web.TreeNode();
			Wisej.Web.TreeNode treeNode5 = new Wisej.Web.TreeNode();
			this.splitContainer1 = new Wisej.Web.SplitContainer();
			this.treeViewControls = new Wisej.Web.TreeView();
			this.label1 = new Wisej.Web.Label();
			this.splitContainer2 = new Wisej.Web.SplitContainer();
			this.panelDesigner = new Wisej.Web.Panel();
			this.label2 = new Wisej.Web.Label();
			this.textBoxOutput = new Wisej.Web.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.White;
			this.splitContainer1.Dock = Wisej.Web.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(20, 20);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeViewControls);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Padding = new Wisej.Web.Padding(20);
			this.splitContainer1.Panel1.TabStop = true;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel2.TabStop = true;
			this.splitContainer1.Size = new System.Drawing.Size(871, 421);
			this.splitContainer1.SplitterDistance = 266;
			this.splitContainer1.TabIndex = 1;
			// 
			// treeViewControls
			// 
			this.treeViewControls.AllowDrag = true;
			this.treeViewControls.Dock = Wisej.Web.DockStyle.Fill;
			this.treeViewControls.Location = new System.Drawing.Point(20, 46);
			this.treeViewControls.Name = "treeViewControls";
			treeNode1.Name = "Node0";
			treeNode1.Text = "Button";
			treeNode2.Name = "Node4";
			treeNode2.Text = "CheckBox";
			treeNode3.Name = "Node1";
			treeNode3.Text = "DateTimePicker";
			treeNode4.Name = "Node2";
			treeNode4.Text = "Label";
			treeNode5.Name = "Node3";
			treeNode5.Text = "Line";
			this.treeViewControls.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
			this.treeViewControls.Size = new System.Drawing.Size(224, 353);
			this.treeViewControls.TabIndex = 1;
			this.treeViewControls.NodeDrag += new Wisej.Web.TreeViewNodeDragEventHandler(this.treeViewControls_NodeDrag);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Padding = new Wisej.Web.Padding(8, 0, 0, 8);
			this.label1.Size = new System.Drawing.Size(224, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Controls";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = Wisej.Web.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = Wisej.Web.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.panelDesigner);
			this.splitContainer2.Panel1.Controls.Add(this.label2);
			this.splitContainer2.Panel1.Padding = new Wisej.Web.Padding(20);
			this.splitContainer2.Panel1.TabStop = true;
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.textBoxOutput);
			this.splitContainer2.Panel2.Padding = new Wisej.Web.Padding(20);
			this.splitContainer2.Panel2.TabStop = true;
			this.splitContainer2.Size = new System.Drawing.Size(596, 421);
			this.splitContainer2.SplitterDistance = 210;
			this.splitContainer2.TabIndex = 2;
			// 
			// panelDesigner
			// 
			this.panelDesigner.AllowDrop = true;
			this.panelDesigner.BackColor = System.Drawing.Color.White;
			this.panelDesigner.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panelDesigner.Dock = Wisej.Web.DockStyle.Fill;
			this.panelDesigner.Location = new System.Drawing.Point(20, 46);
			this.panelDesigner.Name = "panelDesigner";
			this.panelDesigner.Size = new System.Drawing.Size(554, 142);
			this.panelDesigner.TabIndex = 0;
			this.panelDesigner.DragDrop += new Wisej.Web.DragEventHandler(this.panelDesigner_DragDrop);
			this.panelDesigner.DragEnter += new Wisej.Web.DragEventHandler(this.panelDesigner_DragEnter);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = Wisej.Web.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(20, 20);
			this.label2.Name = "label2";
			this.label2.Padding = new Wisej.Web.Padding(0, 0, 0, 8);
			this.label2.Size = new System.Drawing.Size(554, 26);
			this.label2.TabIndex = 3;
			this.label2.Text = "Designer";
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Dock = Wisej.Web.DockStyle.Fill;
			this.textBoxOutput.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 8);
			this.textBoxOutput.LabelText = "Output";
			this.textBoxOutput.Location = new System.Drawing.Point(20, 20);
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.Size = new System.Drawing.Size(554, 160);
			this.textBoxOutput.TabIndex = 2;
			// 
			// Features
			// 
			this.Controls.Add(this.splitContainer1);
			this.Name = "Features";
			this.Padding = new Wisej.Web.Padding(20);
			this.Size = new System.Drawing.Size(911, 461);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private Web.SplitContainer splitContainer1;
        private Web.SplitContainer splitContainer2;
        private Web.TreeView treeViewControls;
        private Web.Label label1;
        private Web.Panel panelDesigner;
        private Web.Label label2;
        private Web.TextBox textBoxOutput;
    }
}
