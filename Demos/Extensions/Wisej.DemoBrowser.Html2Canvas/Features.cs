﻿using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;
using Wisej.Web.Ext.Html2Canvas;

namespace Wisej.DemoBrowser.Html2Canvas
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void Features_Load(object sender, EventArgs e)
        {
            PolarAreaDataSet polarDataSet = new PolarAreaDataSet(); 
            polarDataSet.BackgroundColor = new Color[] {
                Color.FromArgb(49, 255, 0, 0),
                Color.FromArgb(58, 102, 255, 0),
                Color.FromArgb(52, 0, 183, 255),
                Color.FromArgb(53, 247, 0, 255),
                Color.FromArgb(52, 191, 123, 63),
                Color.FromArgb(53, 191, 63, 86),
                Color.FromArgb(104, 255, 0, 118),
                Color.FromArgb(237, 130, 237),
                Color.FromArgb(88, 64, 224, 208),
                Color.FromArgb(84, 255, 98, 70),
                Color.FromArgb(60, 41, 69, 70),
                Color.FromArgb(98, 0, 0, 128)};

            CreateRandomData(polarDataSet);
            this.chartJS.DataSets.Add(polarDataSet);
        }

        void CreateRandomData(DataSet dataSet)
        {
            var data = new object[12];
            Random random = new Random();
            for (int i = 0; i < 12; i++)
                data[i] = random.Next(100);

            dataSet.Data = data;
        }

        private void buttonScreenshot_Click(object sender, EventArgs e)
        {
            Web.Ext.Html2Canvas.Html2Canvas.Screenshot(this, (image) =>
            {
                Application.Download(image, $"html2canvas-demo-{DateTime.UtcNow}.jpg");
            });
        }
    }
}
