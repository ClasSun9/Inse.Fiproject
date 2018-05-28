using Inse.Fiproject.Events;
using Inse.Fiproject.Wpf.Mvvm;
using Inse.Fiproject.Wpf.Controls;
using Inse.Fiproject.Wpf.ViewModel;
using Inse.Fiproject.Youtube;

using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.YouTube;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Threading;
using System.Threading.Tasks;


namespace Inse.Fiproject.ViewModels
{
    public class LoginContentViewModel : AbstractViewModel
    {
        //---------------------------------------------------------------------
        //
        //  field
        //
        //---------------------------------------------------------------------
        
        private ICommand loginCommand = null;
        private ICommand closeCommand = null;

        //---------------------------------------------------------------------
        //
        //  property
        //
        //---------------------------------------------------------------------

        public ICommand LoginCommand
        {
            get { return this.loginCommand; }
        }

        public ICommand CloseCommand
        {
            get { return this.closeCommand; }
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
        private void OnLogin()
        {
            string identifier = base.GetNamedDependencyObject<TextBox>("IdentifierBox").Text;

            //
            Dispatcher uiDispatcher = Dispatcher.CurrentDispatcher;

            //
            this.GoToConnectingState();

            //
            Task.Run(async () =>
            {
                Thread.Sleep(1800);

                //
                await YoutubeConnection.Open(identifier, "client_secret.json");

                if (YoutubeConnection.IsOpen)
                {
                    uiDispatcher.Invoke(() =>
                    {
                        InternalEventAggregator.Current
                            .GetEvent<SwitchContentEvent>()
                            .Publish(ContentType.Check);
                    });
                }
                else
                {
                    uiDispatcher.Invoke(() =>
                    {
                        this.GoToFormState();
                        Dialog.ShowMessage("Message", "로그인 실패", MessageBoxButton.OK);
                    });
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        private void OnClose()
        {
            Application.Current.MainWindow.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        private void GoToFormState()
        {
            //
            Border formLayout       = base.GetNamedDependencyObject<Border>("FormLayout");
            Border connectingLayout = base.GetNamedDependencyObject<Border>("ConnectingLayout");

            if (formLayout != null && connectingLayout != null)
            {
                formLayout.Visibility       = Visibility.Visible;
                connectingLayout.Visibility = Visibility.Collapsed;
            }

            //
            LoadingAnimation loading = base.GetNamedDependencyObject<LoadingAnimation>("Loading");

            if (loading != null)
            {
                loading.IsActive = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void GoToConnectingState()
        {
            //
            Border formLayout       = base.GetNamedDependencyObject<Border>("FormLayout");
            Border connectingLayout = base.GetNamedDependencyObject<Border>("ConnectingLayout");

            if (formLayout != null && connectingLayout != null)
            {
                formLayout.Visibility       = Visibility.Collapsed;
                connectingLayout.Visibility = Visibility.Visible;
            }

            //
            LoadingAnimation loading = base.GetNamedDependencyObject<LoadingAnimation>("Loading");

            if (loading != null)
            {
                loading.IsActive = true;
            }
        }

        //---------------------------------------------------------------------
        //
        //  constructor
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public LoginContentViewModel()
        {
            this.loginCommand = new RelayCommand(this.OnLogin);
            this.closeCommand = new RelayCommand(this.OnClose);
        }
    }
}
