namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoStepper
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoStepper));
            this.kendoStepper1 = new Wisej.Web.Ext.Kendo.kendoStepper();
            this.buttonAddStep = new Wisej.Web.Button();
            this.textBoxStepName = new Wisej.Web.TextBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoStepper1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/stepper/index";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/stepper";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/stepper/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.textBoxStepName);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonAddStep);
            // 
            // kendoStepper1
            // 
            this.kendoStepper1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.kendoStepper1.Location = new System.Drawing.Point(26, 243);
            this.kendoStepper1.Name = "kendoStepper1";
            this.kendoStepper1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoStepper1.Options"))));
            this.kendoStepper1.Size = new System.Drawing.Size(837, 91);
            this.kendoStepper1.TabIndex = 0;
            this.kendoStepper1.Text = "kendoStepper1";
            // 
            // buttonAddStep
            // 
            this.buttonAddStep.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonAddStep.Location = new System.Drawing.Point(3, 66);
            this.buttonAddStep.Name = "buttonAddStep";
            this.buttonAddStep.Size = new System.Drawing.Size(212, 38);
            this.buttonAddStep.TabIndex = 0;
            this.buttonAddStep.Text = "Add Step";
            this.buttonAddStep.Click += new System.EventHandler(this.buttonAddStep_Click);
            // 
            // textBoxStepName
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.textBoxStepName, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.textBoxStepName, true);
            this.textBoxStepName.LabelText = "Step Name";
            this.textBoxStepName.Location = new System.Drawing.Point(3, 3);
            this.textBoxStepName.Name = "textBoxStepName";
            this.textBoxStepName.Size = new System.Drawing.Size(212, 57);
            this.textBoxStepName.TabIndex = 1;
            // 
            // kendoStepper
            // 
            this.Name = "kendoStepper";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoStepper kendoStepper1;
        private Button buttonAddStep;
        private TextBox textBoxStepName;
    }
}
