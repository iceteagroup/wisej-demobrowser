
namespace Wisej.DemoBrowser.ComboBox.Views
{
    partial class Playground
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
            this.smallCard1 = new Wisej.DemoBrowser.Common.Components.SmallCard();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.cmbAutoCompleteMode = new Wisej.Web.ComboBox();
            this.chkIncrementalSearch = new Wisej.Web.CheckBox();
            this.chkVirtualMode = new Wisej.Web.CheckBox();
            this.chkSorting = new Wisej.Web.CheckBox();
            this.cmbDropDownStyle = new Wisej.Web.ComboBox();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.line1 = new Wisej.Web.Line();
            this.btnUpdate = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.labelTitle.Size = new System.Drawing.Size(303, 40);
            this.labelTitle.Text = "ComboBox Playground";
            // 
            // picBoxControl
            // 
            this.pictureBoxControl.ImageSource = "resource.wx/Wisej.Ext.VisualStudioIcons/3DScene.svg";
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1606, 163);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(1606, 687);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Size = new System.Drawing.Size(1600, 663);
            // 
            // smallCard1
            // 
            this.smallCard1.BackgroundColor = System.Drawing.Color.FromName("@activeCaption");
            this.smallCard1.CardIconSource = "resource.wx/Wisej.Ext.FontAwesome/book.svg";
            this.smallCard1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.smallCard1.ForegroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.smallCard1.Location = new System.Drawing.Point(475, 3);
            this.smallCard1.Name = "smallCard1";
            this.smallCard1.Size = new System.Drawing.Size(232, 70);
            this.smallCard1.TabIndex = 0;
            this.smallCard1.Title = "Docs";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.Simple;
            this.comboBox1.LabelText = "ComboBox";
            this.comboBox1.Location = new System.Drawing.Point(564, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1026, 485);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Watermark = "Demo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.line1);
            this.groupBox2.Controls.Add(this.cmbAutoCompleteMode);
            this.groupBox2.Controls.Add(this.chkIncrementalSearch);
            this.groupBox2.Controls.Add(this.chkVirtualMode);
            this.groupBox2.Controls.Add(this.chkSorting);
            this.groupBox2.Controls.Add(this.cmbDropDownStyle);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = Wisej.Web.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 663);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.Text = "Properties";
            // 
            // cmbAutoCompleteMode
            // 
            this.cmbAutoCompleteMode.LabelText = "AutoComplete Mode";
            this.cmbAutoCompleteMode.Location = new System.Drawing.Point(81, 425);
            this.cmbAutoCompleteMode.Name = "cmbAutoCompleteMode";
            this.cmbAutoCompleteMode.Size = new System.Drawing.Size(275, 53);
            this.cmbAutoCompleteMode.TabIndex = 23;
            // 
            // chkIncrementalSearch
            // 
            this.chkIncrementalSearch.Appearance = Wisej.Web.Appearance.Switch;
            this.chkIncrementalSearch.Location = new System.Drawing.Point(81, 395);
            this.chkIncrementalSearch.Name = "chkIncrementalSearch";
            this.chkIncrementalSearch.Size = new System.Drawing.Size(162, 24);
            this.chkIncrementalSearch.TabIndex = 22;
            this.chkIncrementalSearch.Text = "Incremental Search";
            // 
            // chkVirtualMode
            // 
            this.chkVirtualMode.Appearance = Wisej.Web.Appearance.Switch;
            this.chkVirtualMode.Location = new System.Drawing.Point(81, 353);
            this.chkVirtualMode.Name = "chkVirtualMode";
            this.chkVirtualMode.Size = new System.Drawing.Size(127, 24);
            this.chkVirtualMode.TabIndex = 21;
            this.chkVirtualMode.Text = "Virtual Mode";
            // 
            // chkSorting
            // 
            this.chkSorting.Appearance = Wisej.Web.Appearance.Switch;
            this.chkSorting.Location = new System.Drawing.Point(81, 313);
            this.chkSorting.Name = "chkSorting";
            this.chkSorting.Size = new System.Drawing.Size(136, 24);
            this.chkSorting.TabIndex = 20;
            this.chkSorting.Text = "Enable Sorting";
            // 
            // cmbDropDownStyle
            // 
            this.cmbDropDownStyle.LabelText = "DropDown Style";
            this.cmbDropDownStyle.Location = new System.Drawing.Point(81, 244);
            this.cmbDropDownStyle.Name = "cmbDropDownStyle";
            this.cmbDropDownStyle.Size = new System.Drawing.Size(275, 53);
            this.cmbDropDownStyle.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(255, 0, 70);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.button2.Location = new System.Drawing.Point(221, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "Clear ComboBox";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Item";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(56, 503);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(332, 8);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/refresh.svg";
            this.btnUpdate.Location = new System.Drawing.Point(157, 517);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 37);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Playground
            // 
            this.Name = "Playground";
            this.Load += new System.EventHandler(this.Playground_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Components.SmallCard smallCard1;
        private Web.GroupBox groupBox2;
        private Web.ComboBox cmbAutoCompleteMode;
        private Web.CheckBox chkIncrementalSearch;
        private Web.CheckBox chkVirtualMode;
        private Web.CheckBox chkSorting;
        private Web.ComboBox cmbDropDownStyle;
        private Web.Button button2;
        private Web.Button button1;
        private Web.ComboBox comboBox1;
        private Web.Button btnUpdate;
        private Web.Line line1;
    }
}
