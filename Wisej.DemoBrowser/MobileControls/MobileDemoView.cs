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
            }
        }
        
        public event WidgetEventHandler ViewRequested;

        public void OnViewRequested(WidgetEventArgs e)
        {
            this.ViewRequested?.Invoke(this, e);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.animation1 = new Wisej.Web.Animation(this.components);
            this.animation2 = new Wisej.Web.Animation(this.components);
            this.SuspendLayout();
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
            this.Name = "MobileDemoView";
            this.ResumeLayout(false);

        }
    }
}
