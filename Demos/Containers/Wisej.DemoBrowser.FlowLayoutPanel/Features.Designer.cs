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
            this.personCard9 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
            this.personCard8 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
            this.personCard7 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
            this.personCard6 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
            this.personCard5 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
            this.personCard4 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
            this.personCard2 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
            this.personCard1 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
            this.personCard3 = new Wisej.DemoBrowser.FlowLayoutPanel.PersonCard();
            this.flowLayoutPanel = new Wisej.Web.FlowLayoutPanel();
            this.comboBoxView = new Wisej.Web.ComboBox();
            this.buttonAdd = new Wisej.Web.Button();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // personCard9
            // 
            this.personCard9.Location = new System.Drawing.Point(361, 169);
            this.personCard9.Name = "personCard9";
            this.personCard9.TabIndex = 27;
            // 
            // personCard8
            // 
            this.personCard8.Location = new System.Drawing.Point(182, 169);
            this.personCard8.Name = "personCard8";
            this.personCard8.TabIndex = 26;
            // 
            // personCard7
            // 
            this.personCard7.Location = new System.Drawing.Point(3, 169);
            this.personCard7.Name = "personCard7";
            this.personCard7.TabIndex = 25;
            // 
            // personCard6
            // 
            this.personCard6.Location = new System.Drawing.Point(898, 3);
            this.personCard6.Name = "personCard6";
            this.personCard6.TabIndex = 24;
            // 
            // personCard5
            // 
            this.personCard5.Location = new System.Drawing.Point(719, 3);
            this.personCard5.Name = "personCard5";
            this.personCard5.TabIndex = 23;
            // 
            // personCard4
            // 
            this.personCard4.Location = new System.Drawing.Point(540, 3);
            this.personCard4.Name = "personCard4";
            this.personCard4.TabIndex = 22;
            // 
            // personCard2
            // 
            this.personCard2.Location = new System.Drawing.Point(361, 3);
            this.personCard2.Name = "personCard2";
            this.personCard2.TabIndex = 21;
            // 
            // personCard1
            // 
            this.personCard1.Location = new System.Drawing.Point(182, 3);
            this.personCard1.Name = "personCard1";
            this.personCard1.TabIndex = 20;
            // 
            // personCard3
            // 
            this.personCard3.Location = new System.Drawing.Point(3, 3);
            this.personCard3.Name = "personCard3";
            this.personCard3.TabIndex = 19;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.flowLayoutPanel.Controls.Add(this.personCard3);
            this.flowLayoutPanel.Controls.Add(this.personCard1);
            this.flowLayoutPanel.Controls.Add(this.personCard2);
            this.flowLayoutPanel.Controls.Add(this.personCard4);
            this.flowLayoutPanel.Controls.Add(this.personCard5);
            this.flowLayoutPanel.Controls.Add(this.personCard6);
            this.flowLayoutPanel.Controls.Add(this.personCard7);
            this.flowLayoutPanel.Controls.Add(this.personCard8);
            this.flowLayoutPanel.Controls.Add(this.personCard9);
            this.flowLayoutPanel.HeaderSize = 35;
            this.flowLayoutPanel.Location = new System.Drawing.Point(226, 8);
            this.flowLayoutPanel.Margin = new Wisej.Web.Padding(3, 3, 3, 8);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.ShowCloseButton = false;
            this.flowLayoutPanel.Size = new System.Drawing.Size(1183, 455);
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
            this.comboBoxView.Location = new System.Drawing.Point(23, 48);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(177, 53);
            this.comboBoxView.TabIndex = 5;
            this.comboBoxView.Text = "LeftToRight";
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(23, 128);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(177, 37);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add Items";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxView);
            this.Controls.Add(this.flowLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(828, 395);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PersonCard personCard9;
        private PersonCard personCard8;
        private PersonCard personCard7;
        private PersonCard personCard6;
        private PersonCard personCard5;
        private PersonCard personCard4;
        private PersonCard personCard2;
        private PersonCard personCard1;
        private PersonCard personCard3;
        private Web.FlowLayoutPanel flowLayoutPanel;
        private Web.ComboBox comboBoxView;
        private Web.Button buttonAdd;
    }
}
