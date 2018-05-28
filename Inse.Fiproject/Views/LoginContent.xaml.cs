using System.Windows.Controls;


namespace Inse.Fiproject.Views
{
    public partial class LoginContent : UserControl
    {
        public LoginContent()
        {
            InitializeComponent();

            base.DataContext = new ViewModels.LoginContentViewModel();
        }
    }
}
