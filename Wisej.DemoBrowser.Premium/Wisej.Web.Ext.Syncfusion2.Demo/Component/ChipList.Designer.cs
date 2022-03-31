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
            this.flowLayoutPanel1.SuspendLayout();
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
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chipList1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxDelete);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxSelection);
            this.flowLayoutPanel1.Controls.Add(this.textBoxAvatarText);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/chips/default.html";
            // 
            // chipList1
            // 
            this.chipList1.Anchor = Wisej.Web.AnchorStyles.None;
            this.chipList1.Location = new System.Drawing.Point(359, 260);
            this.chipList1.Name = "chipList1";
            this.chipList1.Size = new System.Drawing.Size(371, 39);
            this.chipList1.TabIndex = 0;
            this.chipList1.Text = "chipList1";
            // 
            // comboBoxSelection
            // 
            this.comboBoxSelection.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxSelection, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxSelection, true);
            this.comboBoxSelection.Items.AddRange(new object[] {
            "Input chip",
            "Choice chip",
            "Filter chip",
            "Action chip"});
            this.comboBoxSelection.LabelText = "Selection";
            this.comboBoxSelection.Location = new System.Drawing.Point(3, 46);
            this.comboBoxSelection.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxSelection.Name = "comboBoxSelection";
            this.comboBoxSelection.Size = new System.Drawing.Size(212, 46);
            this.comboBoxSelection.TabIndex = 1;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxDelete, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxDelete, true);
            this.checkBoxDelete.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(212, 24);
            this.checkBoxDelete.TabIndex = 2;
            this.checkBoxDelete.Text = "Enable Delete";
            // 
            // textBoxAvatarText
            // 
            this.flowLayoutPanel1.SetFillWeight(this.textBoxAvatarText, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.textBoxAvatarText, true);
            this.textBoxAvatarText.LabelText = "Avatar Text";
            this.textBoxAvatarText.Location = new System.Drawing.Point(3, 111);
            this.textBoxAvatarText.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.textBoxAvatarText.Name = "textBoxAvatarText";
            this.textBoxAvatarText.Size = new System.Drawing.Size(212, 46);
            this.textBoxAvatarText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AllowHtml = true;
            this.flowLayoutPanel1.SetFillWeight(this.label4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.label4, true);
            this.label4.Location = new System.Drawing.Point(3, 176);
            this.label4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = "Note: Avatar Text will take first letter";
            // 
            // ChipList
            // 
            this.Name = "ChipList";
            this.Load += new System.EventHandler(this.ChipList_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
