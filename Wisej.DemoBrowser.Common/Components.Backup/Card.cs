using System;
using System.ComponentModel;
using System.Drawing.Design;
using Wisej.Design;
using Wisej.Web;

namespace Wisej.DemoBrowser.Common.Components
{
    public partial class Card : Wisej.Web.UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        #region Properties
        [DesignerActionList]
        [RefreshProperties(RefreshProperties.All)]
        [Description("Returns or sets the card's background.")]
        public System.Drawing.Color BackgroundColor
        {
            get => this._backgroundColor;
            set
            {
                this._backgroundColor = value;
                this.panel1.BackColor = this._backgroundColor;
                this.button.BackColor = this._backgroundColor;

                Update();
            }
        }

        [DesignerActionList]
        [RefreshProperties(RefreshProperties.All)]
        [Description("Returns or sets the card's text color.")]
        public System.Drawing.Color ForegroundColor
        {
            get => this._foregroundColor;
            set
            {
                this._foregroundColor = value;
                this.labelTitle.ForeColor = this._foregroundColor;
                this.labelContent.ForeColor = this._foregroundColor;
                this.button.ForeColor = this._foregroundColor;
                this.ForeColor = this._foregroundColor;

                Update();
            }
        }

        [DesignerActionList]
        [RefreshProperties(RefreshProperties.All)]
        [Description("Returns or sets the card's text color.")]
        public string Title
        {
            get => this._cardTitle;
            set
            {
                this._cardTitle = value;
                this.labelTitle.Text = value;
            }
        }

        [DesignerActionList]
        [RefreshProperties(RefreshProperties.All)]
        [Description("Returns or sets the card's text color.")]
        public string Content
        {
            get => this._cardContent;
            set
            {
                this._cardContent = value;
                this.labelContent.Text = this._cardContent;
            }
        }

        [DesignerActionList]
        [RefreshProperties(RefreshProperties.All)]
        [Description("Returns or sets the card's text color.")]
        public string ButtonText
        {
            get => this._buttonText;
            set
            {
                this._buttonText = value;
                this.button.Text = this._buttonText;
            }
        }

        [DesignerActionList()]
        [Description("The image source of the icon.")]
        [TypeConverter("Wisej.Design.ImageSourceConverter, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171")]
        [Editor("Wisej.Design.ImageSourceEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
        public string CardIconSource
        {
            get => this.pictureBox.ImageSource;
            set => this.pictureBox.ImageSource = value;
        }

        [DesignerActionList()]
        [Description("The image source of the icon.")]
        [TypeConverter("Wisej.Design.ImageSourceConverter, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171")]
        [Editor("Wisej.Design.ImageSourceEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
        public string ButtonImageSource
        {
            get => this.button.ImageSource;
            set => this.button.ImageSource = value;
        }
        #endregion

        private System.Drawing.Color _backgroundColor;
        private System.Drawing.Color _foregroundColor;
        private string _cardTitle;
        private string _cardContent;
        private string _buttonText;
    }
}
