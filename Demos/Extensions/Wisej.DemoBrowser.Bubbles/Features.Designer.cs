namespace Wisej.DemoBrowser.Bubbles
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.bubbleNotification1 = new Wisej.Web.Ext.Bubbles.BubbleNotification(this.components);
            this.cmbBubblesAlignment = new Wisej.Web.ComboBox();
            this.cmbBubbleStyle = new Wisej.Web.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(640, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // cmbBubblesAlignment
            // 
            this.cmbBubblesAlignment.LabelText = "Alignment";
            this.cmbBubblesAlignment.Location = new System.Drawing.Point(215, 174);
            this.cmbBubblesAlignment.Name = "cmbBubblesAlignment";
            this.cmbBubblesAlignment.Size = new System.Drawing.Size(272, 53);
            this.cmbBubblesAlignment.TabIndex = 1;
            this.cmbBubblesAlignment.SelectedIndexChanged += new System.EventHandler(this.cmbBubblesAlignment_SelectedIndexChanged);
            // 
            // cmbBubbleStyle
            // 
            this.cmbBubbleStyle.LabelText = "Style";
            this.cmbBubbleStyle.Location = new System.Drawing.Point(215, 257);
            this.cmbBubbleStyle.Name = "cmbBubbleStyle";
            this.cmbBubbleStyle.Size = new System.Drawing.Size(272, 53);
            this.cmbBubbleStyle.TabIndex = 2;
            this.cmbBubbleStyle.SelectedIndexChanged += new System.EventHandler(this.cmbBubbleStyle_SelectedIndexChanged);
            // 
            // Features
            // 
            this.Controls.Add(this.cmbBubbleStyle);
            this.Controls.Add(this.cmbBubblesAlignment);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.DataGridView dataGridView1;
        private Web.Ext.Bubbles.BubbleNotification bubbleNotification1;
        private Web.ComboBox cmbBubblesAlignment;
        private Web.ComboBox cmbBubbleStyle;
    }
}
