namespace Wisej.DemoBrowser.Shape
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
            this.btnShapeColor = new Wisej.Web.Button();
            this.nudShapeRotation = new Wisej.Web.NumericUpDown();
            this.cmbShapeStyle = new Wisej.Web.ComboBox();
            this.shape1 = new Wisej.Web.Shape();
            this.nudShapeSize = new Wisej.Web.NumericUpDown();
            this.nudShapeRadius = new Wisej.Web.NumericUpDown();
            this.btnShapeBackColor = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudShapeRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShapeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShapeRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShapeColor
            // 
            this.btnShapeColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnShapeColor.Location = new System.Drawing.Point(358, 328);
            this.btnShapeColor.Name = "btnShapeColor";
            this.btnShapeColor.Size = new System.Drawing.Size(210, 30);
            this.btnShapeColor.TabIndex = 16;
            this.btnShapeColor.Text = "Color";
            this.btnShapeColor.Click += new System.EventHandler(this.btnShapeColor_Click);
            // 
            // nudShapeRotation
            // 
            this.nudShapeRotation.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudShapeRotation.LabelText = "Rotation";
            this.nudShapeRotation.Location = new System.Drawing.Point(358, 68);
            this.nudShapeRotation.Name = "nudShapeRotation";
            this.nudShapeRotation.Size = new System.Drawing.Size(210, 53);
            this.nudShapeRotation.TabIndex = 17;
            this.nudShapeRotation.ValueChanged += new System.EventHandler(this.nudShapeRotation_ValueChanged);
            // 
            // cmbShapeStyle
            // 
            this.cmbShapeStyle.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbShapeStyle.LabelText = "Style";
            this.cmbShapeStyle.Location = new System.Drawing.Point(358, 198);
            this.cmbShapeStyle.Name = "cmbShapeStyle";
            this.cmbShapeStyle.Size = new System.Drawing.Size(210, 53);
            this.cmbShapeStyle.TabIndex = 15;
            this.cmbShapeStyle.SelectedIndexChanged += new System.EventHandler(this.cmbShapeStyle_SelectedIndexChanged);
            // 
            // shape1
            // 
            this.shape1.Anchor = Wisej.Web.AnchorStyles.None;
            this.shape1.BackColor = System.Drawing.Color.White;
            this.shape1.BorderStyle.Color = System.Drawing.Color.FromName("@highlight");
            this.shape1.BorderStyle.Size = 10;
            this.shape1.BorderStyleBottom.Color = System.Drawing.Color.FromName("@highlight");
            this.shape1.BorderStyleBottom.Size = 10;
            this.shape1.BorderStyleLeft.Color = System.Drawing.Color.FromName("@highlight");
            this.shape1.BorderStyleLeft.Size = 10;
            this.shape1.BorderStyleRight.Color = System.Drawing.Color.FromName("@highlight");
            this.shape1.BorderStyleRight.Size = 10;
            this.shape1.BorderStyleTop.Color = System.Drawing.Color.FromName("@highlight");
            this.shape1.BorderStyleTop.Size = 10;
            this.shape1.Location = new System.Drawing.Point(750, 90);
            this.shape1.Name = "shape1";
            this.shape1.Size = new System.Drawing.Size(315, 294);
            // 
            // nudShapeSize
            // 
            this.nudShapeSize.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudShapeSize.LabelText = "Size";
            this.nudShapeSize.Location = new System.Drawing.Point(358, 133);
            this.nudShapeSize.Name = "nudShapeSize";
            this.nudShapeSize.Size = new System.Drawing.Size(210, 53);
            this.nudShapeSize.TabIndex = 14;
            this.nudShapeSize.ValueChanged += new System.EventHandler(this.nudShapeSize_ValueChanged);
            // 
            // nudShapeRadius
            // 
            this.nudShapeRadius.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudShapeRadius.LabelText = "Radius";
            this.nudShapeRadius.Location = new System.Drawing.Point(358, 263);
            this.nudShapeRadius.Name = "nudShapeRadius";
            this.nudShapeRadius.Size = new System.Drawing.Size(210, 53);
            this.nudShapeRadius.TabIndex = 13;
            this.nudShapeRadius.ValueChanged += new System.EventHandler(this.nudShapeRadius_ValueChanged);
            // 
            // btnShapeBackColor
            // 
            this.btnShapeBackColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnShapeBackColor.Location = new System.Drawing.Point(358, 370);
            this.btnShapeBackColor.Name = "btnShapeBackColor";
            this.btnShapeBackColor.Size = new System.Drawing.Size(210, 30);
            this.btnShapeBackColor.TabIndex = 19;
            this.btnShapeBackColor.Text = "Background Color";
            this.btnShapeBackColor.Click += new System.EventHandler(this.btnShapeBackColor_Click);
            // 
            // Features
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnShapeBackColor);
            this.Controls.Add(this.btnShapeColor);
            this.Controls.Add(this.nudShapeRotation);
            this.Controls.Add(this.cmbShapeStyle);
            this.Controls.Add(this.shape1);
            this.Controls.Add(this.nudShapeSize);
            this.Controls.Add(this.nudShapeRadius);
            this.MinimumSize = new System.Drawing.Size(940, 400);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudShapeRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShapeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShapeRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Button btnShapeColor;
        private Web.NumericUpDown nudShapeRotation;
        private Web.ComboBox cmbShapeStyle;
        private Web.Shape shape1;
        private Web.NumericUpDown nudShapeSize;
        private Web.NumericUpDown nudShapeRadius;
        private Web.Button btnShapeBackColor;
    }
}
