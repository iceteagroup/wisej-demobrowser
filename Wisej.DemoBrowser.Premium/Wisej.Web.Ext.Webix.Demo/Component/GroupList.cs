using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class GroupList : ViewBase
	{
		public GroupList()
		{
			InitializeComponent();
		}

		private void GroupList_Load(object sender, EventArgs e)
		{
			groupList1.Options.data = new dynamic[]
			{
				new
				{
					id = "1",
					type = "folder",
					value = "Music",
					data = new dynamic[]
					{
						new
						{
							id = "m_0",
							type = "folder",
							value = "Jimi Hendrix",
							data = new[]
							{
								new
								{
									id = "m_0_1",
									type = "file",
									value = "1967 - Are You Experienced?"
								},
								new
								{
									id = "m_0_2",
									type = "file",
									value = "1967 - Axis: Bold as Love"
								},
								new
								{
									id = "m_0_3",
									type = "file",
									value = "1968 - Electric Lady Land"
								}
							}
						},
						new
						{
							id = "m_1",
							type = "folder",
							value = "Georgy Sviridov",
							data = new[]
							{
								new
								{
									id = "m_1_0",
									type = "file",
									value = "Petersburg a Vocal Poem"
								},
								new
								{
									id = "m_1_1",
									type = "file",
									value = "A Russia Flying Away"
								}
							}
						}
					}
				},
				new
				{
					id = "2",
					type = "folder",
					value = "Images",
					data = new dynamic[]
					{
						new
						{
							id = "p_0",
							type = "folder",
							value = "01 - Christmas",
							data = new[]
							{
								new
								{
									id = "p_0_1",
									type = "file",
									value = "IMG_10034"
								},
								new
								{
									id = "p_0_2",
									type = "file",
									value = "IMG_10035"
								},
								new
								{
									id = "p_0_3",
									type = "file",
									value = "IMG_10036"
								},
								new
								{
									id = "p_0_4",
									type = "file",
									value = "IMG_10037"
								},
								new
								{
									id = "p_0_5",
									type = "file",
									value = "IMG_10038"
								},
								new
								{
									id = "p_0_6",
									type = "file",
									value = "IMG_10039"
								},
								new
								{
									id = "p_0_7",
									type = "file",
									value = "IMG_10040"
								}
							}
						},
						new
						{
							id = "p_1",
							type = "folder",
							value = "02 - New Year's Eve",
							data = new[]
							{
								new
								{
									id = "p_1_0",
									type = "file",
									value = "DSC10384"
								},
								new
								{
									id = "p_1_1",
									type = "file",
									value = "DSC10385"
								},
								new
								{
									id = "p_1_2",
									type = "file",
									value = "DSC10386"
								},
								new
								{
									id = "p_1_3",
									type = "file",
									value = "DSC10387"
								},
								new
								{
									id = "p_1_4",
									type = "file",
									value = "DSC10388"
								},
								new
								{
									id = "p_1_5",
									type = "file",
									value = "DSC10389"
								}
							}
						}
					}
				}
			};
		}
	}
}