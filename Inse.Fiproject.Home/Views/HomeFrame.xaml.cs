using System.Windows.Controls;


namespace Inse.Fiproject.Home.Views
{
    public partial class HomeFrame : Page
    {
        public HomeFrame()
        {
            InitializeComponent();

            this.DataContext = new ViewModels.HomeFrameViewModel();
        }
    }
}
