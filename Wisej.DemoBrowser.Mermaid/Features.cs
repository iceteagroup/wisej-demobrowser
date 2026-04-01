using System;
using System.Threading.Tasks;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.Mermaid;

namespace Wisej.DemoBrowser.Mermaid
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Features_Load(object sender, EventArgs e)
        {
            InitializeUiState();
            WireEvents();
        }

        private void InitializeUiState()
        {

            cmbLook.Items.AddRange(new object[] { "classic", "neo", "handDrawn" });
            cmbTheme.Items.AddRange(new object[] { "default", "dark", "forest", "neutral" });

            cmbLook.SelectedItem = "classic";
            cmbTheme.SelectedItem = "default";

            chkPanZoom.Checked = true;
            numZoom.Value = 1m;

            this.txtDiagram.Text = @"journey
title Onboarding Experience
section Registration
  Visit site: 4: User
  Create account: 3: User, System
section Activation
  Verify email: 3: User, System
  First login: 5: User";

            this.mermaid1.Diagram = this.txtDiagram.Text;
        }

        private void WireEvents()
        {
            btnApplyConfig.Click += (s, e) => ApplyConfig();
            btnValidate.Click += async (s, e) => await ValidateCurrentDiagramAsync();
            btnDownloadSvg.Click += (s, e) => DownloadSvg();
            btnExportImage.Click += async (s, e) => await ExportImageAsync();
            btnDownloadPdf.Click += (s, e) => DownloadPdf();

            txtDiagram.TextChanged += (s, e) => mermaid1.Diagram = txtDiagram.Text;

            cmbTheme.SelectedIndexChanged += (s, e) =>
            {
                mermaid1.Theme = cmbTheme.SelectedItem?.ToString() ?? "default";
                mermaid1.Update();
            };

            cmbLook.SelectedIndexChanged += (s, e) =>
            {
                mermaid1.Look = cmbLook.SelectedItem?.ToString() ?? "classic";
                mermaid1.Update();
            };

            mermaid1.DiagramChanged += Mermaid1_DiagramChanged;
            mermaid1.ElementClick += Mermaid1_ElementClick;
            mermaid1.Error += Mermaid1_Error;
        }

        private void Mermaid1_DiagramChanged(object sender, EventArgs e)
        {
            AlertBox.Show($"DiagramChanged: length={mermaid1.Diagram?.Length ?? 0}");
        }

        private void Mermaid1_ElementClick(object sender, ElementClickEventArgs e)
        {
            var type = e.Data?.elementType ?? "unknown";
            AlertBox.Show($"ElementClick: '{e.Element}' (type={type}, x={e.X}, y={e.Y})");
        }

        private void Mermaid1_Error(object sender, MermaidErrorEventArgs e)
        {
            AlertBox.Show($"Error: {e.Message}", MessageBoxIcon.Error);
        }

        private void ApplyConfig()
        {
            mermaid1.Look = cmbLook.SelectedItem?.ToString() ?? "classic";
            mermaid1.Theme = cmbTheme.SelectedItem?.ToString() ?? "default";

            mermaid1.EnablePanZoom = chkPanZoom.Checked;
            mermaid1.ZoomLevel = (float)numZoom.Value;

            mermaid1.Update();
            AlertBox.Show("Configuration applied");
        }

        private async Task ValidateCurrentDiagramAsync()
        {
            try
            {
                var result = await mermaid1.ValidateAsync(txtDiagram.Text);
                if (result.Valid)
                {
                    AlertBox.Show("Valid diagram");
                }
                else
                {
                    AlertBox.Show("Invalid diagram");
                }
            }
            catch (Exception ex)
            {
                AlertBox.Show($"Validation failed: {ex.Message}");
            }
        }

        private void DownloadSvg()
        {
            mermaid1.DownloadSvg("mermaid-demo.svg");
        }

        private async Task ExportImageAsync()
        {
            try
            {
                var image = await mermaid1.ExportToImageAsync();

                image.Save("mermaid-diagram.png", System.Drawing.Imaging.ImageFormat.Png);

                Application.Download("mermaid-diagram.png");
            }
            catch (Exception ex)
            {
                AlertBox.Show("Image export failed");
            }
        }

        private void DownloadPdf()
        {
            mermaid1.DownloadPdf("mermaid-demo.pdf", scale: 2, backgroundColor: "#ffffff", margin: 24, quality: 0.95);
        }
    }
}
