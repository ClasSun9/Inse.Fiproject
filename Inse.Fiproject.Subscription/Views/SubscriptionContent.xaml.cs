using System.Windows.Controls;


namespace Inse.Fiproject.Subscription.Views
{
    public partial class SubscriptionContent : UserControl
    {
        public SubscriptionContent()
        {
            InitializeComponent();

            base.DataContext = new ViewModels.SubscriptionContentViewModel();
        }
    }
}
