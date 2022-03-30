namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Signature
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
            this.signature1 = new Wisej.Web.Ext.Syncfusion2.Signature();
            this.buttonUndo = new Wisej.Web.Button();
            this.buttonRedo = new Wisej.Web.Button();
            this.buttonSave = new Wisej.Web.Button();
            this.textBoxName = new Wisej.Web.TextBox();
            this.buttonClear = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.signature1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBoxName);
            this.flowLayoutPanel1.Controls.Add(this.buttonClear);
            this.flowLayoutPanel1.Controls.Add(this.buttonUndo);
            this.flowLayoutPanel1.Controls.Add(this.buttonRedo);
            this.flowLayoutPanel1.Controls.Add(this.buttonSave);
            // 
            // signature1
            // 
            this.signature1.Anchor = Wisej.Web.AnchorStyles.None;
            this.signature1.Location = new System.Drawing.Point(177, 119);
            this.signature1.Name = "signature1";
            this.signature1.Size = new System.Drawing.Size(735, 320);
            this.signature1.TabIndex = 0;
            this.signature1.Text = "signature1";
            // 
            // buttonUndo
            // 
            this.flowLayoutPanel1.SetFillWeight(this.buttonUndo, 1);
            this.buttonUndo.ImageSource = "icon-undo";
            this.buttonUndo.Location = new System.Drawing.Point(3, 135);
            this.buttonUndo.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(66, 50);
            this.buttonUndo.TabIndex = 1;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.flowLayoutPanel1.SetFillWeight(this.buttonRedo, 1);
            this.buttonRedo.ImageSource = "icon-redo";
            this.buttonRedo.Location = new System.Drawing.Point(75, 135);
            this.buttonRedo.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(67, 50);
            this.buttonRedo.TabIndex = 2;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // buttonSave
            // 
            this.flowLayoutPanel1.SetFillWeight(this.buttonSave, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.buttonSave, true);
            this.buttonSave.ImageSource = "icon-save";
            this.buttonSave.Location = new System.Drawing.Point(148, 135);
            this.buttonSave.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(67, 50);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxName
            // 
            this.flowLayoutPanel1.SetFillWeight(this.textBoxName, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxName, true);
            this.textBoxName.LabelText = "Name";
            this.textBoxName.Location = new System.Drawing.Point(3, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(212, 57);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.Text = "John Doe";
            // 
            // buttonClear
            // 
            this.flowLayoutPanel1.SetFillWeight(this.buttonClear, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.buttonClear, true);
            this.buttonClear.Location = new System.Drawing.Point(3, 79);
            this.buttonClear.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(212, 37);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Signature
            // 
            this.Name = "Signature";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Signature signature1;
		private Button buttonClear;
		private TextBox textBoxName;
		private Button buttonSave;
		private Button buttonRedo;
		private Button buttonUndo;
	}
}
