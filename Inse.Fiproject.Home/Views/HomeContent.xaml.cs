using System.Windows.Controls;


namespace Inse.Fiproject.Home.Views
{
    public partial class HomeContent : Page
    {
        public HomeContent()
        {
            InitializeComponent();

            base.DataContext = new ViewModels.HomeContentViewModel();
        }
    }
}
