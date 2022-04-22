namespace Wisej.DemoBrowser.DataGridView
{
    partial class Features
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
            this.components = new System.ComponentModel.Container();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colId = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colAvatar = new Wisej.Web.DataGridViewImageColumn();
            this.colDesignation = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFirstname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLastname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colUsername = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colAge = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colGender = new Wisej.Web.DataGridViewComboBoxColumn();
            this.genderBindingSource = new Wisej.Web.BindingSource(this.components);
            this.colCartid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSSN = new Wisej.Web.DataGridViewMaskedTextBoxColumn();
            this.colAddress = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colMail = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colRating = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colProgress = new Wisej.DemoBrowser.DataGridView.DataGridViewProgressBarColumn();
            this.colButton = new Wisej.Web.DataGridViewButtonColumn();
            this.personBindingSource = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colId,
            this.colAvatar,
            this.colDesignation,
            this.colFirstname,
            this.colLastname,
            this.colUsername,
            this.colAge,
            this.colGender,
            this.colCartid,
            this.colSSN,
            this.colAddress,
            this.colMail,
            this.colRating,
            this.colProgress,
            this.colButton});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1382, 412);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colId
            // 
            this.colId.AllowHtml = true;
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.colId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Width = 50;
            // 
            // colAvatar
            // 
            this.colAvatar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet;
            this.colAvatar.DataPropertyName = "Avatar";
            this.colAvatar.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAvatar.HeaderImageSource = "resource.wx/Wisej.Ext.VisualStudioIcons/User.svg";
            this.colAvatar.HeaderText = "Avatar";
            this.colAvatar.Name = "colAvatar";
            // 
            // colDesignation
            // 
            this.colDesignation.DataPropertyName = "Designation";
            this.colDesignation.HeaderText = "Designation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.Width = 200;
            // 
            // colFirstname
            // 
            this.colFirstname.DataPropertyName = "FirstName";
            this.colFirstname.HeaderText = "First Name";
            this.colFirstname.Name = "colFirstname";
            // 
            // colLastname
            // 
            this.colLastname.DataPropertyName = "LastName";
            this.colLastname.HeaderText = "Last Name";
            this.colLastname.Name = "colLastname";
            // 
            // colUsername
            // 
            this.colUsername.DataPropertyName = "UserName";
            this.colUsername.HeaderText = "User Name";
            this.colUsername.Name = "colUsername";
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            // 
            // colGender
            // 
            this.colGender.AllowHtml = true;
            this.colGender.DataPropertyName = "Gender";
            this.colGender.DataSource = this.genderBindingSource;
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            // 
            // colCartid
            // 
            this.colCartid.DataPropertyName = "CartId";
            this.colCartid.HeaderText = "Cart ID";
            this.colCartid.Name = "colCartid";
            this.colCartid.Visible = false;
            // 
            // colSSN
            // 
            this.colSSN.DataPropertyName = "SSN";
            this.colSSN.HeaderText = "SSN";
            this.colSSN.Mask = "___-__-____";
            this.colSSN.Name = "colSSN";
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            // 
            // colMail
            // 
            this.colMail.DataPropertyName = "Mail";
            this.colMail.HeaderImageSource = "resource.wx/Wisej.Ext.VisualStudioIcons/MailOpen.svg";
            this.colMail.HeaderText = "Mail";
            this.colMail.Name = "colMail";
            // 
            // colRating
            // 
            this.colRating.AllowHtml = true;
            this.colRating.DataPropertyName = "Rating";
            this.colRating.HeaderImageSource = "resource.wx/Wisej.Ext.VisualStudioIcons/Rating.svg";
            this.colRating.HeaderText = "Rating";
            this.colRating.Name = "colRating";
            // 
            // colProgress
            // 
            this.colProgress.DataPropertyName = "Progress";
            this.colProgress.HeaderImageSource = "resource.wx/Wisej.Ext.VisualStudioIcons/ProgressBar.svg";
            this.colProgress.HeaderText = "Progress";
            this.colProgress.Name = "colProgress";
            this.colProgress.SortMode = Wisej.Web.DataGridViewColumnSortMode.Automatic;
            // 
            // colButton
            // 
            this.colButton.HeaderText = "Action";
            this.colButton.Name = "colButton";
            this.colButton.Text = "Delete";
            this.colButton.UseColumnTextForButtonValue = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Wisej.DemoBrowser.DataGridView.Person);
            // 
            // Features
            // 
            this.Controls.Add(this.dataGridView1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.ColumnTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.DataGridView dataGridView1;
        private Web.BindingSource personBindingSource;
        private Web.DataGridViewTextBoxColumn colFirstname;
        private Web.DataGridViewTextBoxColumn colLastname;
        private Web.DataGridViewTextBoxColumn colUsername;
        private Web.DataGridViewTextBoxColumn colAge;
        private Web.DataGridViewComboBoxColumn colGender;
        private Web.DataGridViewTextBoxColumn colCartid;
        private Web.DataGridViewMaskedTextBoxColumn colSSN;
        private Web.DataGridViewTextBoxColumn colAddress;
        private Web.DataGridViewTextBoxColumn colDesignation;
        private Web.DataGridViewTextBoxColumn colMail;
        private Web.DataGridViewTextBoxColumn colRating;
        private Web.DataGridViewButtonColumn colButton;
        private Web.DataGridViewTextBoxColumn colId;
        private DataGridViewProgressBarColumn colProgress;
        private Web.BindingSource genderBindingSource;
        private Web.DataGridViewImageColumn colAvatar;
    }
}
