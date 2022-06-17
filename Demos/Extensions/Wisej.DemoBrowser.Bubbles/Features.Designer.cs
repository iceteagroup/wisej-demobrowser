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
            this.bubbleNotification1 = new Wisej.Web.Ext.Bubbles.BubbleNotification(this.components);
            this.cmbBubblesAlignment = new Wisej.Web.ComboBox();
            this.cmbBubbleStyle = new Wisej.Web.ComboBox();
            this.textBox = new Wisej.Web.TextBox();
            this.button = new Wisej.Web.Button();
            this.bubbleNotification2 = new Wisej.Web.Ext.Bubbles.BubbleNotification(this.components);
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bubbleNotification1
            // 
            this.bubbleNotification1.Click += new Wisej.Web.Ext.Bubbles.BubbleEventHandler(this.bubbleNotification_Click);
            // 
            // cmbBubblesAlignment
            // 
            this.cmbBubblesAlignment.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbBubblesAlignment.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbBubblesAlignment.LabelText = "Alignment";
            this.cmbBubblesAlignment.Location = new System.Drawing.Point(161, 97);
            this.cmbBubblesAlignment.Name = "cmbBubblesAlignment";
            this.cmbBubblesAlignment.Size = new System.Drawing.Size(175, 53);
            this.cmbBubblesAlignment.TabIndex = 1;
            this.cmbBubblesAlignment.Text = "TopRight";
            this.cmbBubblesAlignment.SelectedIndexChanged += new System.EventHandler(this.cmbBubblesAlignment_SelectedIndexChanged);
            // 
            // cmbBubbleStyle
            // 
            this.cmbBubbleStyle.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbBubbleStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbBubbleStyle.LabelText = "Style";
            this.cmbBubbleStyle.Location = new System.Drawing.Point(161, 180);
            this.cmbBubbleStyle.Name = "cmbBubbleStyle";
            this.cmbBubbleStyle.Size = new System.Drawing.Size(175, 53);
            this.cmbBubbleStyle.TabIndex = 2;
            this.cmbBubbleStyle.SelectedIndexChanged += new System.EventHandler(this.cmbBubbleStyle_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(17, 92);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(462, 207);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "You can use the Bubble extension to display values, like this bubble here that sh" +
    "ows you the length of this text :)";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // button
            // 
            this.button.Anchor = Wisej.Web.AnchorStyles.None;
            this.button.Location = new System.Drawing.Point(175, 33);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(137, 37);
            this.button.TabIndex = 4;
            this.button.Text = "Button";
            // 
            // bubbleNotification2
            // 
            this.bubbleNotification2.Click += new Wisej.Web.Ext.Bubbles.BubbleEventHandler(this.bubbleNotification_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBubbleStyle);
            this.panel1.Controls.Add(this.cmbBubblesAlignment);
            this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 330);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button);
            this.panel2.Controls.Add(this.textBox);
            this.flowLayoutPanel1.SetFillWeight(this.panel2, 1);
            this.panel2.Location = new System.Drawing.Point(506, 3);
            this.panel2.MinimumSize = new System.Drawing.Size(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 330);
            this.panel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(209, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1005, 342);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // Features
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Web.Ext.Bubbles.BubbleNotification bubbleNotification1;
        private Web.ComboBox cmbBubblesAlignment;
        private Web.ComboBox cmbBubbleStyle;
        private Web.TextBox textBox;
        private Web.Button button;
        private Web.Ext.Bubbles.BubbleNotification bubbleNotification2;
        private Web.Panel panel1;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Panel panel2;
    }
}
