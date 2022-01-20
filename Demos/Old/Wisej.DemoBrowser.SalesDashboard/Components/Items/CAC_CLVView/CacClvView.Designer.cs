
namespace Wisej.DemoBrowser.SalesDashboard.Components.Items.CAC_CLVView
{
    partial class CacClvView
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
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.smallCard1 = new Wisej.DemoBrowser.Common.Components.SmallCard();
            this.smallCard2 = new Wisej.DemoBrowser.Common.Components.SmallCard();
            this.smallCard3 = new Wisej.DemoBrowser.Common.Components.SmallCard();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 246);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.smallCard1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.smallCard2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.smallCard3, 0, 1);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new Wisej.Web.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 246);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // smallCard1
            // 
            this.smallCard1.BackgroundColor = System.Drawing.Color.FromName("@highlight");
            this.smallCard1.CardIconSource = "resource.wx/Wisej.Ext.FontAwesome/money.svg";
            this.smallCard1.CssStyle = "border-radius:15px;";
            this.smallCard1.Dock = Wisej.Web.DockStyle.Fill;
            this.smallCard1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.smallCard1.ForegroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.smallCard1.Location = new System.Drawing.Point(13, 13);
            this.smallCard1.Name = "smallCard1";
            this.smallCard1.Size = new System.Drawing.Size(717, 69);
            this.smallCard1.TabIndex = 6;
            this.smallCard1.Title = "Customer Aquision Rate: 2,3$";
            // 
            // smallCard2
            // 
            this.smallCard2.BackgroundColor = System.Drawing.Color.FromName("@info");
            this.smallCard2.CardIconSource = "resource.wx/Wisej.Ext.FontAwesome/smile-o.svg";
            this.smallCard2.CssStyle = "border-radius:15px;";
            this.smallCard2.Dock = Wisej.Web.DockStyle.Fill;
            this.smallCard2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.smallCard2.ForegroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.smallCard2.Location = new System.Drawing.Point(13, 163);
            this.smallCard2.Name = "smallCard2";
            this.smallCard2.Size = new System.Drawing.Size(717, 70);
            this.smallCard2.TabIndex = 7;
            this.smallCard2.Title = "Customer Live Value: 1490";
            // 
            // smallCard3
            // 
            this.smallCard3.BackgroundColor = System.Drawing.Color.FromName("@danger");
            this.smallCard3.CardIconSource = "resource.wx/Wisej.Ext.FontAwesome/line-chart.svg";
            this.smallCard3.CssStyle = "border-radius:15px;";
            this.smallCard3.Dock = Wisej.Web.DockStyle.Fill;
            this.smallCard3.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.smallCard3.ForegroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.smallCard3.Location = new System.Drawing.Point(13, 88);
            this.smallCard3.Name = "smallCard3";
            this.smallCard3.Size = new System.Drawing.Size(717, 69);
            this.smallCard3.TabIndex = 8;
            this.smallCard3.Title = "Average /Unit Profit: 12$";
            // 
            // CacClvView
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CacClvView";
            this.Size = new System.Drawing.Size(743, 284);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.TableLayoutPanel tableLayoutPanel1;
        private Common.Components.SmallCard smallCard1;
        private Common.Components.SmallCard smallCard2;
        private Common.Components.SmallCard smallCard3;
    }
}
