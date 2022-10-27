namespace Wisej.DemoBrowser
{
    partial class MainViewMobile
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
            this.imageList1 = new Wisej.Web.ImageList(this.components);
            this.animation1 = new Wisej.Web.Animation(this.components);
            this.animation2 = new Wisej.Web.Animation(this.components);
            this.panelControls = new Wisej.Web.Panel();
            this.buttonBack = new Wisej.Web.Button();
            this.panelContainer = new Wisej.Web.Panel();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(24, 24);
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonBack);
            this.panelControls.Dock = Wisej.Web.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new Wisej.Web.Padding(16, 0, 0, 0);
            this.panelControls.Size = new System.Drawing.Size(1714, 30);
            this.panelControls.TabIndex = 22;
            this.panelControls.TabStop = true;
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BorderStyle = Wisej.Web.BorderStyle.None;
            this.buttonBack.Dock = Wisej.Web.DockStyle.Left;
            this.buttonBack.Focusable = false;
            this.buttonBack.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.buttonBack.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/go-back-left-arrow.svg";
            this.buttonBack.Location = new System.Drawing.Point(16, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(61, 30);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = Wisej.Web.DockStyle.Fill;
            this.panelContainer.Font = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panelContainer.Location = new System.Drawing.Point(0, 30);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1714, 616);
            this.panelContainer.TabIndex = 23;
            // 
            // MainViewMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelControls);
            this.Name = "MainViewMobile";
            this.Size = new System.Drawing.Size(1714, 646);
            this.Load += new System.EventHandler(this.MainViewMobile_Load);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Web.ImageList imageList1;
        private Web.Animation animation1;
        private Web.Animation animation2;
        private Web.Panel panelControls;
        private Web.Button buttonBack;
        private Web.Panel panelContainer;
    }
}
