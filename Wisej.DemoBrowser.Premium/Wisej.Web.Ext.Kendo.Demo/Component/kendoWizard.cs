using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoWizard : TestBase
	{
		public kendoWizard()
		{
			InitializeComponent();

			this.kendoWizard1.Instance.onDone += new WidgetEventHandler(kendoWizard1_WidgetEvent);
			this.kendoWizard1.Instance.onSelect += new WidgetEventHandler(kendoWizard1_WidgetEvent);
			this.kendoWizard1.Instance.onActivate += new WidgetEventHandler(kendoWizard1_WidgetEvent);
			this.kendoWizard1.Instance.onFormValidateFailed += new WidgetEventHandler(kendoWizard1_WidgetEvent);
		}

		private void kendoWizard_Load(object sender, EventArgs e)
		{
			kendoWizard1.Options.pager = true;
			kendoWizard1.Options.steps = new object[]
			{
				new
				{
					title = "Account Details",
					buttons = new object[]
					{
						"next"
					},
					form = new
					{
						orientation = "vertical",
						formData = new
						{
							Username = "johny",
							Email = "john.doe@email.com",
							Password = "pass123"
						},
						items = new object[]
						{
							new
							{
								field = "Username",
								label = "Username:",
								validation = new
								{
									required = true
								}
							},
							new
							{
								field = "Email",
								label = "Email:",
								validation = new
								{
									required = true,
									email = true
								}
							},
							new
							{
								field = "Password",
								label = "Password:",
								validation = new
								{
									required = true
								},
								hint = "Hint: enter alphanumeric characters only.",
								attributes = new
								{
									type = "password"
								}
							}
						}
					}
				},
				new
				{
					title = "Personal Details",
					buttons = new object[]
					{
						"previous", "next"
					},
					form = new
					{
						orientation = "vertical",
						items = new object[]
						{
							new
							{
								field = "FullName",
								label = "Full Name:",
								validation = new
								{
									required = true
								}
							},
							new
							{
								field = "Country",
								label = "Country:",
								validation = new
								{
									required = true
								},
								editor = "AutoComplete",
								editorOptions = new
								{
									dataSource = new object[]
									{
										"France", "Germany", "Italy", "Netherlands", "Norway", "Spain"
									},
									filter = "startswith",
									placeholder = "Select country..."
								}
							},
							new
							{
								field = "Gender",
								label = "Gender:",
								validation = new
								{
									required = true
								},
								editor = "RadioGroup",
								editorOptions = new
								{
									items = new object[]
									{
										"Female", "Male", "Other"
									},
									layout = "horizontal",
									labelPosition = "before"
								}
							},
							new
							{
								field = "About",
								label = new
								{
									text = "About:",
									optional = true
								}
							}
						}
					}
				},
				new
				{
					title = "Payment Details",
					buttons = new object[]
					{
						"previous", "done"
					},
					form = new
					{
						orientation = "vertical",
						items = new object[]
						{
							new
							{
								type = "group",
								label = "Payment Details:",
								layout = "grid",
								grid = new
								{
									cols = 3,
									gutter = 10
								},
								items = new object[]
								{
									new
									{
										field = "PaymentType",
										label = "Payment Type:",
										validation = new
										{
											required = true,
											payment = "payment"
										},
										editor = "paymentEditor",
										colSpan = 3
									},
									new
									{
										field = "CardNumber",
										label = "Card Number:",
										attributes = new
										{
											data_validmaskNumber_Msg = "Card number is incomplete"
										},
										validation = new
										{
											required = true,
											validmaskNumber = "validmaskNumber"
										},
										editor = "MaskedTextBox",
										editorOptions = new
										{
											mask = "0000-0000-0000-0000"
										},
										colSpan = 2
									},
									new
									{
										field = "CSVNumber",
										label = "CSV Number:",
										attributes = new
										{
											data_validmaskCSV_Msg = "CSV code is incomplete"
										},
										validation = new
										{
											required = true
										},
										editor = "MaskedTextBox",
										editorOptions = new
										{
											mask = "000"
										},
										colSpan = 1, hint = "The last 3 digids on the back"
									},
									new
									{
										field = "ExpirationDate",
										label = "Expiration Date:",
										validation = new
										{
											required = true
										},
										editor = "DateInput",
										editorOptions = new
										{
											format = "MM/yyyy"
										},
										colSpan = 3
									},
									new
									{
										field = "CardHolderName",
										label = "Card Holder Name:",
										validation = new
										{
											required = true
										},
										colSpan = 3
									}
								}
							}
						}
					}
				}
			};

		}

		private void kendoWizard1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"{e.Type} {JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information, allowHtml: false);

			Application.Play(MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.kendoWizard1.Instance.previous();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.kendoWizard1.Instance.next();
		}
	}
}
