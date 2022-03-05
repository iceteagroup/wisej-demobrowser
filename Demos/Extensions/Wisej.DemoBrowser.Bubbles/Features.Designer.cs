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
            this.SuspendLayout();
            // 
            // bubbleNotification1
            // 
            this.bubbleNotification1.Click += new Wisej.Web.Ext.Bubbles.BubbleEventHandler(this.bubbleNotification_Click);
            // 
            // cmbBubblesAlignment
            // 
            this.cmbBubblesAlignment.LabelText = "Alignment";
            this.cmbBubblesAlignment.Location = new System.Drawing.Point(302, 188);
            this.cmbBubblesAlignment.Name = "cmbBubblesAlignment";
            this.cmbBubblesAlignment.Size = new System.Drawing.Size(272, 42);
            this.cmbBubblesAlignment.TabIndex = 1;
            this.cmbBubblesAlignment.SelectedIndexChanged += new System.EventHandler(this.cmbBubblesAlignment_SelectedIndexChanged);
            // 
            // cmbBubbleStyle
            // 
            this.cmbBubbleStyle.LabelText = "Style";
            this.cmbBubbleStyle.Location = new System.Drawing.Point(302, 271);
            this.cmbBubbleStyle.Name = "cmbBubbleStyle";
            this.cmbBubbleStyle.Size = new System.Drawing.Size(272, 42);
            this.cmbBubbleStyle.TabIndex = 2;
            this.cmbBubbleStyle.SelectedIndexChanged += new System.EventHandler(this.cmbBubbleStyle_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(684, 155);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(437, 207);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "You can use the Bubble extension to display values, like this bubble here that sh" +
    "ows you the length of this text :)";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(834, 112);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(137, 37);
            this.button.TabIndex = 4;
            this.button.Text = "Button";
            // 
            // bubbleNotification2
            // 
            this.bubbleNotification2.Click += new Wisej.Web.Ext.Bubbles.BubbleEventHandler(this.bubbleNotification_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.cmbBubbleStyle);
            this.Controls.Add(this.cmbBubblesAlignment);
            this.MinimumSize = new System.Drawing.Size(978, 340);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
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
    }
}
