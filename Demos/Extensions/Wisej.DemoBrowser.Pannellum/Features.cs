using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Pannellum
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            switch (button.Text)
            {
                case "Auto rotate":
                {
                    this.pannellum.Options = new
                    {
                        type = "equirectangular",
                        autoLoad = true,
                        autoRotate = -2,
                        panorama = "https://pannellum.org/images/alma.jpg"
                    };
                        break;
                }
                case "Hot spots":
                {
                    this.pannellum.Options = new
                    {
                        type = "equirectangular",
                        autoLoad = true,
                        autoRotate = -2,
                        panorama = "https://pannellum.org/images/bma-1.jpg",

                        hotSpots = new object[] {
                            new {
                                pitch= 14.1,
                                yaw= 1.5,
                                type= "info",
                                text= "Baltimore Museum of Art",
                                url = "https://artbma.org/"

                            },
                            new {
                                pitch= -9.4,
                                yaw= 222.6,
                                type= "info",
                                text= "Art Museum Drive"
                            },
                            new {
                                pitch= -0.9,
                                yaw= 144.4,
                                type= "info",
                                text= "North Charles Street"
                            }
                        }
                    };
                    break;
                }
                case "Cube map":
                {
                    this.pannellum.Options = new
                    {
                        type = "cubemap",
                        autoLoad = true,
                        cubeMap = new[] {
                            "https://pannellum.org/images/wyman-park-playground-cubic/face0.jpg",
                            "https://pannellum.org/images/wyman-park-playground-cubic/face1.jpg",
                            "https://pannellum.org/images/wyman-park-playground-cubic/face2.jpg",
                            "https://pannellum.org/images/wyman-park-playground-cubic/face3.jpg",
                            "https://pannellum.org/images/wyman-park-playground-cubic/face4.jpg",
                            "https://pannellum.org/images/wyman-park-playground-cubic/face5.jpg" }
                    };
                        break;
                }
                case "multires":
                {
                    this.pannellum.Options = new
                    {
                        type = "multires",
                        autoLoad = true,
                        multiRes = new
                        {
                            basePath = "https://pannellum.org/images/multires/library",
                            path = "/%l/%s%y_%x",
                            fallbackPath = "/fallback/%s",
                            extension = "jpg",
                            tileResolution = 512,
                            maxLevel = 6,
                            cubeResolution = 8432
                        }
                    };
                    break;
                }
                default:
                {
                    this.pannellum.Options = new
                    {
                        type = "equirectangular",
                        autoLoad = true,
                        panorama = "https://pannellum.org/images/alma.jpg"
                    };
                        break;
                }
            }

            if (this._selectedButton != null)
                UnselectButton(this._selectedButton);

            this._selectedButton = button;

            SelectButton(button);
        }

        private Button _selectedButton;
        private void SelectButton(Button button)
        {
            button.ForeColor = Color.FromArgb(0, 56, 160);
        }

        private void UnselectButton(Button button)
        {
            button.ForeColor = Color.Black;
        }

        private void pannellum_WidgetEvent(object sender, WidgetEventArgs e)
        {
            if (e.Type == "hotspot")
                AlertBox.Show(e.Data.text);
        }
    }
}
