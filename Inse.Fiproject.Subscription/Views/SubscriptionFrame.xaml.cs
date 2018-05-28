using System.Windows.Controls;


namespace Inse.Fiproject.Subscription.Views
{
    public partial class SubscriptionFrame : Page
    {
        public SubscriptionFrame()
        {
            InitializeComponent();

            base.DataContext = new ViewModels.SubscriptionFrameViewModel();
        }
    }
}
