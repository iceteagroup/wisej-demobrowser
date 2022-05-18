namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
    partial class ejColorPicker
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
            this.ejColorPicker1 = new Wisej.Web.Ext.Syncfusion.ejColorPicker();
            this.textBoxColor = new Wisej.Web.TextBox();
            this.label4 = new Wisej.Web.Label();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/colorpicker/overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/colorpicker";
            // 
            // linkAPI
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "https://help.syncfusion.com/api/js/ejcolorpicker";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.ejColorPicker1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.textBoxColor);
            // 
            // ejColorPicker1
            // 
            this.ejColorPicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejColorPicker1.Location = new System.Drawing.Point(394, 262);
            this.ejColorPicker1.Name = "ejColorPicker1";
            this.ejColorPicker1.Size = new System.Drawing.Size(300, 35);
            this.ejColorPicker1.TabIndex = 1;
            this.ejColorPicker1.Text = "Choose Color";
            this.ejColorPicker1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.ejColorPicker1_WidgetEvent);
            // 
            // textBoxColor
            // 
            this.textBoxColor.AutoSize = false;
            this.flowLayoutPanelProperties.SetFillWeight(this.textBoxColor, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.textBoxColor, true);
            this.textBoxColor.Label.Size = 50;
            this.textBoxColor.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBoxColor.LabelText = "Value (prefix with #)";
            this.textBoxColor.Location = new System.Drawing.Point(3, 3);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(212, 60);
            this.textBoxColor.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = Wisej.Web.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Choose Color";
            // 
            // ejColorPicker
            // 
            this.Name = "ejColorPicker";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void EjColorPicker1_WidgetEvent(object sender, WidgetEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private Syncfusion.ejColorPicker ejColorPicker1;

        #endregion

        private TextBox textBoxColor;
        private Label label4;
    }
}
