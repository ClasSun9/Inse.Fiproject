using System.Windows.Controls;


namespace Inse.Fiproject.Settings.Views
{
    public partial class SettingsContent : UserControl
    {
        public SettingsContent()
        {
            InitializeComponent();

            base.DataContext = new ViewModels.SettingsContentViewModel();
        }
    }
}
