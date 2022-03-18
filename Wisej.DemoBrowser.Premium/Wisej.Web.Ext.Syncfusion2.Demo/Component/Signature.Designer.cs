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
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonClear);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.Add(this.buttonRedo);
			this.groupBox1.Controls.Add(this.buttonUndo);
			this.groupBox1.Size = new System.Drawing.Size(250, 429);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonUndo, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonRedo, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonSave, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBoxName, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonClear, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 348);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.signature1);
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
			this.buttonUndo.ImageSource = "icon-undo";
			this.buttonUndo.Location = new System.Drawing.Point(28, 274);
			this.buttonUndo.Name = "buttonUndo";
			this.buttonUndo.Size = new System.Drawing.Size(50, 50);
			this.buttonUndo.TabIndex = 1;
			this.buttonUndo.Text = "Undo";
			this.buttonUndo.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
			this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
			// 
			// buttonRedo
			// 
			this.buttonRedo.ImageSource = "icon-redo";
			this.buttonRedo.Location = new System.Drawing.Point(100, 274);
			this.buttonRedo.Name = "buttonRedo";
			this.buttonRedo.Size = new System.Drawing.Size(50, 50);
			this.buttonRedo.TabIndex = 2;
			this.buttonRedo.Text = "Redo";
			this.buttonRedo.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
			this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(173, 274);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(50, 50);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Save";
			this.buttonSave.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// textBoxName
			// 
			this.textBoxName.LabelText = "Name";
			this.textBoxName.Location = new System.Drawing.Point(28, 39);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(195, 53);
			this.textBoxName.TabIndex = 4;
			this.textBoxName.Text = "John Doe";
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(28, 219);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(195, 37);
			this.buttonClear.TabIndex = 5;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// Signature
			// 
			this.Name = "Signature";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
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
