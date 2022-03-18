namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class ChipList
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
            this.chipList1 = new Wisej.Web.Ext.Syncfusion2.ChipList();
            this.comboBoxSelection = new Wisej.Web.ComboBox();
            this.checkBoxDelete = new Wisej.Web.CheckBox();
            this.textBoxAvatarText = new Wisej.Web.TextBox();
            this.label4 = new Wisej.Web.Label();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/chips/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/chips/chipList/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAvatarText);
            this.groupBox1.Controls.Add(this.checkBoxDelete);
            this.groupBox1.Controls.Add(this.comboBoxSelection);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxSelection, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxDelete, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBoxAvatarText, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chipList1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/chips/default.html";
            // 
            // chipList1
            // 
            this.chipList1.Anchor = Wisej.Web.AnchorStyles.None;
            this.chipList1.Location = new System.Drawing.Point(41, 137);
            this.chipList1.Name = "chipList1";
            this.chipList1.Size = new System.Drawing.Size(371, 39);
            this.chipList1.TabIndex = 0;
            this.chipList1.Text = "chipList1";
            // 
            // comboBoxSelection
            // 
            this.comboBoxSelection.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxSelection.Items.AddRange(new object[] {
            "Input chip",
            "Choice chip",
            "Filter chip",
            "Action chip"});
            this.comboBoxSelection.LabelText = "Selection";
            this.comboBoxSelection.Location = new System.Drawing.Point(19, 53);
            this.comboBoxSelection.Name = "comboBoxSelection";
            this.comboBoxSelection.Size = new System.Drawing.Size(211, 53);
            this.comboBoxSelection.TabIndex = 1;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.Location = new System.Drawing.Point(19, 24);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(108, 23);
            this.checkBoxDelete.TabIndex = 2;
            this.checkBoxDelete.Text = "Enable delete";
            // 
            // textBoxAvatarText
            // 
            this.textBoxAvatarText.LabelText = "Avatar Text";
            this.textBoxAvatarText.Location = new System.Drawing.Point(19, 113);
            this.textBoxAvatarText.Name = "textBoxAvatarText";
            this.textBoxAvatarText.Size = new System.Drawing.Size(211, 53);
            this.textBoxAvatarText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AllowHtml = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "<b>Note: Avatar Text will take firt letter</b>";
            // 
            // ChipList
            // 
            this.Controls.Add(this.label4);
            this.Name = "ChipList";
            this.Load += new System.EventHandler(this.ChipList_Load);
            this.Controls.SetChildIndex(this.linkDocs, 0);
            this.Controls.SetChildIndex(this.linkAPI, 0);
            this.Controls.SetChildIndex(this.linkDemo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.panel, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.ChipList chipList1;
        private ComboBox comboBoxSelection;
        private TextBox textBoxAvatarText;
        private CheckBox checkBoxDelete;
        private Label label4;
    }
}
