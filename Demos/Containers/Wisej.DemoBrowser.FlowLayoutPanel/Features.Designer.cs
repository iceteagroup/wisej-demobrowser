namespace Wisej.DemoBrowser.FlowLayoutPanel
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
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
			this.flowLayoutPanel = new Wisej.Web.FlowLayoutPanel();
			this.comboBoxView = new Wisej.Web.ComboBox();
			this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.comboBoxView2 = new Wisej.Web.ComboBox();
			this.personCard10 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
			this.personCard11 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
			this.personCard16 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
			this.personCard17 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
			this.personCard18 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
			this.personCard3 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
			this.personCard1 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
			this.personCard6 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
			this.personCard7 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
			this.personCard8 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
			this.flowLayoutPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.AutoScroll = true;
			this.flowLayoutPanel.BorderStyle = Wisej.Web.BorderStyle.Dashed;
			this.flowLayoutPanel.Controls.Add(this.personCard3);
			this.flowLayoutPanel.Controls.Add(this.personCard1);
			this.flowLayoutPanel.Controls.Add(this.personCard6);
			this.flowLayoutPanel.Controls.Add(this.personCard7);
			this.flowLayoutPanel.Controls.Add(this.personCard8);
			this.flowLayoutPanel.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel.HeaderSize = 35;
			this.flowLayoutPanel.Location = new System.Drawing.Point(510, 62);
			this.flowLayoutPanel.Margin = new Wisej.Web.Padding(3, 3, 3, 8);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.ShowCloseButton = false;
			this.flowLayoutPanel.Size = new System.Drawing.Size(502, 544);
			this.flowLayoutPanel.TabIndex = 4;
			this.flowLayoutPanel.TabStop = true;
			this.flowLayoutPanel.Text = "Inbox";
			componentTool1.ImageSource = "resource.wx/Wisej.Ext.VaadinIcons/trash.svg";
			componentTool1.ToolTipText = "Clear Inbox";
			this.flowLayoutPanel.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
			// 
			// comboBoxView
			// 
			this.comboBoxView.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxView.LabelText = "View";
			this.comboBoxView.Location = new System.Drawing.Point(3, 3);
			this.comboBoxView.Name = "comboBoxView";
			this.comboBoxView.Size = new System.Drawing.Size(213, 53);
			this.comboBoxView.TabIndex = 5;
			this.comboBoxView.Text = "LeftToRight";
			this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxView, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxView2, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 29);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1015, 614);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BorderStyle = Wisej.Web.BorderStyle.Dashed;
			this.flowLayoutPanel1.Controls.Add(this.personCard10);
			this.flowLayoutPanel1.Controls.Add(this.personCard11);
			this.flowLayoutPanel1.Controls.Add(this.personCard16);
			this.flowLayoutPanel1.Controls.Add(this.personCard17);
			this.flowLayoutPanel1.Controls.Add(this.personCard18);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel1.HeaderSize = 35;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 62);
			this.flowLayoutPanel1.Margin = new Wisej.Web.Padding(3, 3, 3, 8);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.ShowCloseButton = false;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(501, 544);
			this.flowLayoutPanel1.TabIndex = 7;
			this.flowLayoutPanel1.TabStop = true;
			this.flowLayoutPanel1.Text = "Inbox";
			componentTool2.ImageSource = "resource.wx/Wisej.Ext.VaadinIcons/trash.svg";
			componentTool2.ToolTipText = "Clear Inbox";
			this.flowLayoutPanel1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
			// 
			// comboBoxView2
			// 
			this.comboBoxView2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxView2.LabelText = "View";
			this.comboBoxView2.Location = new System.Drawing.Point(510, 3);
			this.comboBoxView2.Name = "comboBoxView2";
			this.comboBoxView2.Size = new System.Drawing.Size(213, 53);
			this.comboBoxView2.TabIndex = 6;
			this.comboBoxView2.Text = "LeftToRight";
			this.comboBoxView2.SelectedIndexChanged += new System.EventHandler(this.comboBoxView2_SelectedIndexChanged);
			// 
			// personCard10
			// 
			this.personCard10.Location = new System.Drawing.Point(3, 3);
			this.personCard10.Name = "personCard10";
			this.personCard10.TabIndex = 19;
			// 
			// personCard11
			// 
			this.personCard11.Location = new System.Drawing.Point(182, 3);
			this.personCard11.Name = "personCard11";
			this.personCard11.TabIndex = 20;
			// 
			// personCard16
			// 
			this.personCard16.Location = new System.Drawing.Point(3, 169);
			this.personCard16.Name = "personCard16";
			this.personCard16.TabIndex = 25;
			// 
			// personCard17
			// 
			this.personCard17.Location = new System.Drawing.Point(182, 169);
			this.personCard17.Name = "personCard17";
			this.personCard17.TabIndex = 26;
			// 
			// personCard18
			// 
			this.personCard18.Location = new System.Drawing.Point(3, 335);
			this.personCard18.Name = "personCard18";
			this.personCard18.TabIndex = 27;
			// 
			// personCard3
			// 
			this.personCard3.Location = new System.Drawing.Point(3, 3);
			this.personCard3.Name = "personCard3";
			this.personCard3.TabIndex = 19;
			// 
			// personCard1
			// 
			this.personCard1.Location = new System.Drawing.Point(182, 3);
			this.personCard1.Name = "personCard1";
			this.personCard1.TabIndex = 20;
			// 
			// personCard6
			// 
			this.personCard6.Location = new System.Drawing.Point(3, 169);
			this.personCard6.Name = "personCard6";
			this.personCard6.TabIndex = 24;
			// 
			// personCard7
			// 
			this.personCard7.Location = new System.Drawing.Point(182, 169);
			this.personCard7.Name = "personCard7";
			this.personCard7.TabIndex = 25;
			// 
			// personCard8
			// 
			this.personCard8.Location = new System.Drawing.Point(3, 335);
			this.personCard8.Name = "personCard8";
			this.personCard8.TabIndex = 26;
			// 
			// Features
			// 
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Features";
			this.Size = new System.Drawing.Size(1076, 673);
			this.Load += new System.EventHandler(this.Features_Load);
			this.flowLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private PersonCard personCard8;
        private PersonCard personCard7;
        private PersonCard personCard6;
        private PersonCard personCard1;
        private PersonCard personCard3;
        private Web.FlowLayoutPanel flowLayoutPanel;
        private Web.ComboBox comboBoxView;
		private Web.TableLayoutPanel tableLayoutPanel1;
		private Web.FlowLayoutPanel flowLayoutPanel1;
		private PersonCard personCard10;
		private PersonCard personCard11;
		private PersonCard personCard16;
		private PersonCard personCard17;
		private PersonCard personCard18;
		private Web.ComboBox comboBoxView2;
	}
}
