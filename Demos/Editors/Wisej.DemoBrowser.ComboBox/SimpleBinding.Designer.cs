
namespace Wisej.DemoBrowser.ComboBox
{
    partial class SimpleBinding
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
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.comboBox3 = new Wisej.Web.ComboBox();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBox1.Location = new System.Drawing.Point(30, 43);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(313, 30);
			this.comboBox1.TabIndex = 0;
			// 
			// comboBox2
			// 
			this.comboBox2.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBox2.Location = new System.Drawing.Point(30, 104);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(313, 30);
			this.comboBox2.TabIndex = 1;
			// 
			// comboBox3
			// 
			this.comboBox3.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBox3.Location = new System.Drawing.Point(30, 165);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(313, 30);
			this.comboBox3.TabIndex = 2;
			// 
			// SimpleBinding
			// 
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.MinimumSize = new System.Drawing.Size(328, 168);
			this.Name = "SimpleBinding";
			this.Size = new System.Drawing.Size(372, 239);
			this.Load += new System.EventHandler(this.SimpleBinding_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Web.ComboBox comboBox1;
		private Web.ComboBox comboBox2;
		private Web.ComboBox comboBox3;
	}
}
