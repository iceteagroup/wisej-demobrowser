using System;
using Wisej.Web;

namespace Wisej.DemoBrowser.Common.Components
{
    public partial class DashboardItemView : BaseControl
    {
        public DashboardItemView()
        {
            InitializeComponent();
            this.button1.Parent = this;
        }
    }
}
