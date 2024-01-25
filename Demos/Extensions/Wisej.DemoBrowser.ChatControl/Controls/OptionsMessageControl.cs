using System;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl.Controls
{
	/// <summary>
	/// A message that allows a user to select an option from a defined list.
	/// </summary>
	public partial class OptionsMessageControl : MessageControl
	{
		#region Constructor

		/// <summary>
		/// Creates a new instance of <see cref="OptionsMessageControl" />.
		/// </summary>
		public OptionsMessageControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Creates a new instance of <see cref="OptionsMessageControl"/> with the given configuration.
		/// </summary>
		/// <param name="option1">The first option</param>
		/// <param name="option2">The second option</param>
		/// <param name="option3">The third option</param>
		public OptionsMessageControl(string title, params string[] options)
		{
			InitializeComponent();

			Configure(title, options);
		}

		#endregion

		#region Properties

		public bool DisableOnClick { get; set; }

		#endregion

		#region Methods

		public void Configure(string title, string[] options)
		{
			this.labelTitle.Text = title;

			foreach (var option in options)
			{
				var b = new Button { AutoSize = true, Text = option };

				b.Click += buttonOption_Click;

				this.flexLayoutPanelButtons.Controls.Add(b);
			}
		}

		private void buttonOption_Click(object sender, EventArgs e)
		{
			if (DisableOnClick)
			{
				foreach (Control b in this.flexLayoutPanelButtons.Controls)
				{
					b.Enabled = false;
				}
			}
		}

		#endregion

	}
}
