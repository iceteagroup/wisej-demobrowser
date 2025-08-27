using Wisej.Web;

namespace Wisej.DemoBrowser.ChatControl.Controls
{
	public partial class OptionsMessageControl
	{
		#region Initialization

		private void InitializeComponent()
		{
			this.flexLayoutPanelContainer = new Wisej.Web.FlexLayoutPanel();
			this.labelTitle = new Wisej.Web.Label();
			this.flexLayoutPanelButtons = new Wisej.Web.FlexLayoutPanel();
			this.flexLayoutPanelContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// flexLayoutPanelContainer
			// 
			this.flexLayoutPanelContainer.AutoSize = true;
			this.flexLayoutPanelContainer.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.flexLayoutPanelContainer.Controls.Add(this.labelTitle);
			this.flexLayoutPanelContainer.Controls.Add(this.flexLayoutPanelButtons);
			this.flexLayoutPanelContainer.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanelContainer.Location = new System.Drawing.Point(0, 0);
			this.flexLayoutPanelContainer.Name = "flexLayoutPanelContainer";
			this.flexLayoutPanelContainer.Size = new System.Drawing.Size(41, 75);
			this.flexLayoutPanelContainer.TabIndex = 0;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(3, 3);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(35, 18);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Title";
			// 
			// flexLayoutPanelButtons
			// 
			this.flexLayoutPanelButtons.AutoSize = true;
			this.flexLayoutPanelButtons.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanelButtons.Location = new System.Drawing.Point(3, 37);
			this.flexLayoutPanelButtons.MinimumSize = new System.Drawing.Size(35, 35);
			this.flexLayoutPanelButtons.Name = "flexLayoutPanelButtons";
			this.flexLayoutPanelButtons.Size = new System.Drawing.Size(35, 35);
			this.flexLayoutPanelButtons.TabIndex = 1;
			// 
			// OptionsMessageControl
			// 
			this.AutoSize = true;
			//this.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.flexLayoutPanelContainer);
			this.Name = "OptionsMessageControl";
			this.Size = new System.Drawing.Size(44, 78);
			this.flexLayoutPanelContainer.ResumeLayout(false);
			this.flexLayoutPanelContainer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FlexLayoutPanel flexLayoutPanelContainer;
		private Label labelTitle;
		private FlexLayoutPanel flexLayoutPanelButtons;
	}
}
