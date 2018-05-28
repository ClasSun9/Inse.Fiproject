using Inse.Fiproject.Wpf.Controls;


namespace Inse.Fiproject.Views
{
    public partial class MainWindow : FrameWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            base.DataContext = new ViewModels.MainWindowViewModel();
        }
    }
}
