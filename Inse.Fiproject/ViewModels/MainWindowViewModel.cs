using Inse.Fiproject.Events;
using Inse.Fiproject.Wpf.Mvvm;
using Inse.Fiproject.Wpf.Controls;
using Inse.Fiproject.Wpf.ViewModel;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;


namespace Inse.Fiproject.ViewModels
{
    public class MainWindowViewModel : AbstractViewModel
    {
        //---------------------------------------------------------------------
        //
        //  field
        //
        //---------------------------------------------------------------------

        //  null

        //---------------------------------------------------------------------
        //
        //  property
        //
        //---------------------------------------------------------------------

        public RoutedEventHandler FrameWindowLoadedHandler
        {
            get { return this.OnFrameWindowLoaded; }
        }

        //---------------------------------------------------------------------
        //
        //  event
        //
        //---------------------------------------------------------------------

        //  null

        //---------------------------------------------------------------------
        //
        //  function
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnFrameWindowLoaded(object sender, RoutedEventArgs args)
        {
            this.GetFrameWindow()?.ShowOverlay(new Views.LoginContent());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        private void OnSwitchContent(ContentType type)
        {
            FrameWindow window = this.GetFrameWindow();
            if (window == null)
            {
                return;
            }

            switch (type)
            {
                case ContentType.Login:
                    window.HideOverlay();
                    window.ShowOverlay(new Views.LoginContent());
                    break;

                case ContentType.Check:
                    window.HideOverlay();
                    window.ShowOverlay(new Views.CheckContent());
                    break;

                case ContentType.Main:
                    window.HideOverlay();
                    window.MenuItems = new Wpf.Controls.MenuItemCollection()
                    {
                        new Wpf.Controls.MenuItem()
                        {
                            Name   = "구독",
                            Source = new Uri("pack://application:,,,/Inse.Fiproject.Subscription;component/Views/SubscriptionFrame.xaml")
                        }
                    };
                    window.HomeUri     = new Uri("pack://application:,,,/Inse.Fiproject.Home;component/Views/HomeFrame.xaml");
                    window.SettingsUri = new Uri("pack://application:,,,/Inse.Fiproject.Settings;component/Views/SettingsFrame.xaml");
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private FrameWindow GetFrameWindow()
        {
            FrameWindow window = base.NamedDependencyObjects["FrameWindow"] as FrameWindow;
            if (window == null)
            {
                Dialog.ShowMessage("Error Message", "Not found FrameWindow", MessageBoxButton.OK);
            }

            return window;
        }

        //---------------------------------------------------------------------
        //
        //  constructor
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public MainWindowViewModel()
        {
            InternalEventAggregator.Current
                .GetEvent<SwitchContentEvent>()
                .Subscribe(OnSwitchContent);
        }
    }
}
