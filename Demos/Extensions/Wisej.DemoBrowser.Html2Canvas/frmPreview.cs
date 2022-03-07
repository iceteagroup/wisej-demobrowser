using System;
using System.Drawing;
using System.Drawing.Imaging;
using Wisej.Web;


namespace Wisej.DemoBrowser.Html2Canvas
{
    public partial class frmPreview : Form
    {
        public frmPreview()
        {
            InitializeComponent();
        }

        private void frmPreview_ToolClick(object sender, ToolClickEventArgs e)
        {
            var image = this.pbResult.Image;
            Application.Download(image,$"html2canvas-demo-{DateTime.UtcNow.ToString()}.png");
        }
    }
}
