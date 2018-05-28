using System.Windows.Controls;


namespace Inse.Fiproject.Views
{
    public partial class CheckContent : UserControl
    {
        public CheckContent()
        {
            InitializeComponent();

            base.DataContext = new ViewModels.CheckContentViewModel();
        }
    }
}
