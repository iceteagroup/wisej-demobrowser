using System;
using System.IO;
using System.Linq;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser
{
    public class MobileDemoView : DemoView
    {
        private Web.Animation animation1;
        private Web.Animation animation2;
        public Web.Label labelDescription;
        public Web.Label labelTitle;
        public Web.PictureBox pictureBoxIcon;
        private Web.Panel panelTitleContainer;
        private System.ComponentModel.IContainer components;

        public MobileDemoView() : base()
        {
            InitializeComponent();
        }

        public MobileDemoView(dynamic config, string role=null, string name=null) : base()
        {
            InitializeComponent();

            // retrieve the localized description or default to english.
            var culture = Application.CurrentCulture.TwoLetterISOLanguageName;
            var description = config[$"description-{culture}"] ?? config["description-en"];

            this.labelTitle.Text = name;
            this.labelDescription.Text = description;

            var fullyQualifiedName = (string)config.assembly ?? null;
            if (fullyQualifiedName != null)
            {
                var components = fullyQualifiedName.Split(',');
                var assemblyName = components[1].Trim();
                var typeName = components[0].Trim();

                var directory = Path.GetDirectoryName(Application.ExecutablePath);
                var path = Path.Combine(directory, assemblyName);
                var assembly = Application.LoadAssembly(path);
                var type = assembly.GetTypes().Where(t => t.Name == typeName).ToArray()[0] ?? null;

                var demoInstance = (Control)Activator.CreateInstance(type);

                demoInstance.Dock = DockStyle.Fill;

                this.Controls.Add(demoInstance);
                demoInstance.BringToFront();

                this.Minimize(true);
            }
        }
        
        public event WidgetEventHandler ViewRequested;

        public void OnViewRequested(WidgetEventArgs e)
        {
            this.ViewRequested?.Invoke(this, e);
        }

        public void Minimize(bool keepDescription=false)
        {
            if (!keepDescription)
                this.labelDescription.Hide();

            this.pictureBoxIcon.Width = 30;
            this.panelTitleContainer.Height = 60;
            this.labelTitle.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        }

        public void Maximize()
        {
            this.labelDescription.Show();

            this.pictureBoxIcon.Width = 48;
            this.panelTitleContainer.Height = 80;
            this.labelTitle.Font = new System.Drawing.Font("@condensedWindowTitle", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobileDemoView));
            this.animation1 = new Wisej.Web.Animation(this.components);
            this.animation2 = new Wisej.Web.Animation(this.components);
            this.labelDescription = new Wisej.Web.Label();
            this.labelTitle = new Wisej.Web.Label();
            this.pictureBoxIcon = new Wisej.Web.PictureBox();
            this.panelTitleContainer = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelTitleContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AllowHtml = true;
            this.labelDescription.CssStyle = "transition: font-size 0.25s;";
            this.labelDescription.Dock = Wisej.Web.DockStyle.Top;
            this.labelDescription.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDescription.Location = new System.Drawing.Point(16, 80);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new Wisej.Web.Padding(0, 0, 0, 24);
            this.labelDescription.Size = new System.Drawing.Size(1390, 100);
            this.labelDescription.TabIndex = 23;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.CssStyle = "transition: font-size 0.25s;";
            this.labelTitle.Dock = Wisej.Web.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("@condensedWindowTitle", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.Location = new System.Drawing.Point(48, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new Wisej.Web.Padding(16, 0, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(1342, 48);
            this.labelTitle.TabIndex = 22;
            this.labelTitle.Text = "Wisej.NET Demos";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = Wisej.Web.DockStyle.Left;
            this.pictureBoxIcon.ImageSource = "Images\\wisej.png";
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 16);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxIcon.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // panelTitleContainer
            // 
            this.panelTitleContainer.Controls.Add(this.labelTitle);
            this.panelTitleContainer.Controls.Add(this.pictureBoxIcon);
            this.panelTitleContainer.Dock = Wisej.Web.DockStyle.Top;
            this.panelTitleContainer.Location = new System.Drawing.Point(16, 0);
            this.panelTitleContainer.Name = "panelTitleContainer";
            this.panelTitleContainer.Padding = new Wisej.Web.Padding(0, 16, 0, 16);
            this.panelTitleContainer.Size = new System.Drawing.Size(1390, 80);
            this.panelTitleContainer.TabIndex = 25;
            // 
            // MobileDemoView
            // 
            this.animation1.GetAnimation(this).Duration = 350;
            this.animation1.GetAnimation(this).Event = "appear";
            this.animation1.GetAnimation(this).Name = "slideRightIn";
            this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.animation2.GetAnimation(this).Duration = 350;
            this.animation2.GetAnimation(this).Event = "disappear";
            this.animation2.GetAnimation(this).Name = "slideLeftOut";
            this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.panelTitleContainer);
            this.Name = "MobileDemoView";
            this.Padding = new Wisej.Web.Padding(16, 0, 16, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelTitleContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
