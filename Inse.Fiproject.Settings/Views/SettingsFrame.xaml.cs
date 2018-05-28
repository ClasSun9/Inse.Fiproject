using System.Windows.Controls;


namespace Inse.Fiproject.Settings.Views
{
    public partial class SettingsFrame : Page
    {
        public SettingsFrame()
        {
            InitializeComponent();

            base.DataContext = new ViewModels.SettingsFrameViewModel();
        }
    }
}
