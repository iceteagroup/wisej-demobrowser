using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSymbolPalette : TestBase
	{
		public ejSymbolPalette()
		{
			InitializeComponent();

			this.ejSymbolPalette1.Instance.onSelectionChange += new WidgetEventHandler(ejSymbolPalette1_WidgetEvent);
		}

		private void ejSymbolPalette_Load(object sender, EventArgs e)
		{
			this.ejSymbolPalette1.Options.palettes = new object[]
			{
				new
				{
					name = "Flow Shapes",
					expanded = true, addInfo = new
					{
						source = "Images/SymbolPalette/flow.PNG"
					},
					items = new object[]
					{
						new
						{
							name = "Process",
							width = 44, height = 40, offsetX = 20, offsetY = 20, fillColor = "white",
							borderWidth = 1, type = "flow",
							shape = "process"
						},
						new
						{
							name = "Decision",
							width = 44, height = 40, offsetX = 20, offsetY = 20, fillColor = "white",
							borderWidth = 1, type = "flow",
							shape = "decision"
						},
						new
						{
							name = "Sort",
							width = 44, height = 40, offsetX = 20, offsetY = 20, fillColor = "white",
							borderWidth = 1, type = "flow",
							shape = "sort"
						},
						new
						{
							name = "Document",
							width = 44, height = 40, offsetX = 20, offsetY = 15, fillColor = "white",
							borderWidth = 1, type = "flow",
							shape = "document"
						},
						new
						{
							name = "MultiDocument",
							width = 43, height = 40, offsetX = 20, offsetY = 15, fillColor = "white",
							borderWidth = 1, type = "flow",
							shape = "multidocument"
						}
					}
				},
				new
				{
					name = "Connectors",
					expanded = true, addInfo = new
					{
						source = "Images/SymbolPalette/connector.PNG"
					},
					items = new object[]
					{
						new
						{
							name = "Link1",
							segments = new object[]
							{
								new
								{
									type = "orthogonal"
								}
							},
							sourcePoint = new
							{
								x = 0,
								y = 0
							},
							targetPoint = new
							{
								x = 40,
								y = 40
							},
							targetDecorator = new
							{
								shape = "arrow"
							},
							paletteItem = new
							{
								height = 45,
								width = 57,
								enableScale = false
							}
						},
						new
						{
							name = "link2",
							segments = new object[]
							{
								new
								{
									type = "orthogonal"
								}
							},
							sourcePoint = new
							{
								x = 0,
								y = 0
							},
							targetPoint = new
							{
								x = 40,
								y = 40
							},
							targetDecorator = new
							{
								shape = "none"
							},
							paletteItem = new
							{
								height = 45,
								width = 57,
								enableScale = false
							}
						},
						new
						{
							name = "Link3",
							segments = new object[]
							{
								new
								{
									type = "straight"
								}
							},
							sourcePoint = new
							{
								x = 0,
								y = 0
							},
							targetPoint = new
							{
								x = 40,
								y = 40
							},
							targetDecorator = new
							{
								shape = "arrow"
							},
							paletteItem = new
							{
								height = 45,
								width = 57,
								enableScale = false
							}
						},
						new
						{
							name = "Link4",
							segments = new object[]
							{
								new
								{
									type = "straight"
								}
							},
							sourcePoint = new
							{
								x = 0,
								y = 0
							},
							targetPoint = new
							{
								x = 40,
								y = 40
							},
							targetDecorator = new
							{
								shape = "none"
							},
							paletteItem = new
							{
								height = 45,
								width = 57,
								enableScale = false
							}
						}
					}
				},
				new
				{
					name = "Basic Shapes",
					expanded = true, addInfo = new
					{
						source = "Images/SymbolPalette/basic.PNG"
					},
					items = new object[]
					{
						new
						{
							name = "Rectangle",
							width = 80, height = 160, paletteItem = new
							{
								enableScale = false,
								margin = new
								{
									left = 4,
									right = 4,
									top = 12,
									bottom = 10
								}
							},
							fillColor = "white",
							borderWidth = 1, type = "basic",
							shape = "rectangle"
						},
						new
						{
							name = "Rectangle",
							width = 70, height = 70, fillColor = "white",
							borderWidth = 1.5, type = "basic",
							shape = "rectangle"
						},
						new
						{
							name = "Ellipse",
							width = 70, height = 70, fillColor = "white",
							borderWidth = 1.5, type = "basic",
							shape = "ellipse"
						},
						new
						{
							name = "Hexagon",
							width = 70, height = 70, fillColor = "white",
							borderWidth = 1.5, type = "basic",
							shape = "polygon",
							points = new object[]
							{
								new {x = 25, y = 0}, new {x = 75, y = 0}, new {x = 100, y = 50}, new {x = 75, y = 100},
								new {x = 25, y = 100}, new {x = 0, y = 50}
							}
						},
						new
						{
							name = "Triangle",
							width = 70, height = 70, fillColor = "white",
							borderWidth = 1.5, type = "basic",
							shape = "polygon",
							points = new object[]
							{
								new {x = 50, y = 0}, new {x = 100, y = 100}, new {x = 0, y = 100}
							}
						}
					}
				}
			};
		}

		private void ejDiagram1_Appear(object sender, EventArgs e)
		{
			this.ejSymbolPalette1.Options.diagramId = $"id_{this.ejDiagram1.Handle}_container";
		}

		private void ejSymbolPalette1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSymbolPalette1.Options.allowDrag = this.checkBox2.Checked;
			this.ejSymbolPalette1.Options.showPaletteItemText = this.checkBox1.Checked;
			this.ejSymbolPalette1.Options.previewHeight = this.numericUpDown1.Value;
			this.ejSymbolPalette1.Options.headerHeight = this.numericUpDown2.Value;

			this.ejSymbolPalette1.Update();
		}
	}
}