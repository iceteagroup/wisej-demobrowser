namespace Wisej.Web.Ext.Webix.Demo.Component
{
    partial class Diagram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagram));
            this.diagram1 = new Wisej.Web.Ext.Webix.Diagram();
            this.checkBoxAllowScroll = new Wisej.Web.CheckBox();
            this.checkBoxAllowSelect = new Wisej.Web.CheckBox();
            this.numericUpDownZoomLevel = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoomLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery/diagram";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.diagram.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.diagram1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowScroll);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowSelect);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownZoomLevel);
            // 
            // diagram1
            // 
            this.diagram1.Dock = Wisej.Web.DockStyle.Fill;
            this.diagram1.Location = new System.Drawing.Point(8, 8);
            this.diagram1.Name = "diagram1";
            this.diagram1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("diagram1.Options"))));
            this.diagram1.Size = new System.Drawing.Size(1073, 542);
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // checkBoxAllowScroll
            // 
            this.checkBoxAllowScroll.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxAllowScroll.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowScroll.AutoSize = false;
            this.checkBoxAllowScroll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllowScroll.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAllowScroll.Name = "checkBoxAllowScroll";
            this.checkBoxAllowScroll.Size = new System.Drawing.Size(212, 26);
            this.checkBoxAllowScroll.TabIndex = 3;
            this.checkBoxAllowScroll.Text = "Allow scroll";
            // 
            // checkBoxAllowSelect
            // 
            this.checkBoxAllowSelect.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxAllowSelect.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowSelect.AutoSize = false;
            this.checkBoxAllowSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllowSelect.Location = new System.Drawing.Point(3, 35);
            this.checkBoxAllowSelect.Name = "checkBoxAllowSelect";
            this.checkBoxAllowSelect.Size = new System.Drawing.Size(212, 26);
            this.checkBoxAllowSelect.TabIndex = 4;
            this.checkBoxAllowSelect.Text = "Allow select";
            // 
            // numericUpDownZoomLevel
            // 
            this.numericUpDownZoomLevel.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.numericUpDownZoomLevel.DecimalPlaces = 2;
            this.numericUpDownZoomLevel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownZoomLevel.LabelText = "Zoom level";
            this.numericUpDownZoomLevel.Location = new System.Drawing.Point(3, 67);
            this.numericUpDownZoomLevel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownZoomLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownZoomLevel.Name = "numericUpDownZoomLevel";
            this.numericUpDownZoomLevel.Size = new System.Drawing.Size(212, 46);
            this.numericUpDownZoomLevel.TabIndex = 5;
            this.numericUpDownZoomLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Diagram
            // 
            this.Name = "Diagram";
            this.Load += new System.EventHandler(this.Diagram_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoomLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Webix.Diagram diagram1;
        private CheckBox checkBoxAllowScroll;
        private CheckBox checkBoxAllowSelect;
        private NumericUpDown numericUpDownZoomLevel;
    }
}
