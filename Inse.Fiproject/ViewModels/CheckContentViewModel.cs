using Inse.Fiproject.Events;
using Inse.Fiproject.Wpf.Mvvm;
using Inse.Fiproject.Wpf.Controls;
using Inse.Fiproject.Wpf.ViewModel;

using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Threading;
using System.Threading.Tasks;



namespace Inse.Fiproject.ViewModels
{
    public class CheckContentViewModel : AbstractViewModel
    {
        //---------------------------------------------------------------------
        //
        //  field
        //
        //---------------------------------------------------------------------

        

        //---------------------------------------------------------------------
        //
        //  property
        //
        //---------------------------------------------------------------------

        public RoutedEventHandler AuthTextLoadedHandler
        {
            get { return this.OnAuthTextLoaded; }
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
        private void OnAuthTextLoaded(object sender, RoutedEventArgs args)
        {
            TextBlock authTextBlock = base.GetNamedDependencyObject<TextBlock>("AuthText");
            if (authTextBlock == null)
            {
                return;
            }

            //
            /*
            Storyboard storyboard = new Storyboard();
            storyboard.Completed += this.OnAuthTextAnimationCompleted;
    
            //
            authTextBlock.BeginStoryboard(storyboard);
            */

            //
            Dispatcher uiDispatcher = Dispatcher.CurrentDispatcher;

            Task.Run(() =>
            {
                Thread.Sleep(2000);

                uiDispatcher.Invoke(() =>
                {
                    InternalEventAggregator.Current
                        .GetEvent<SwitchContentEvent>()
                        .Publish(ContentType.Main);
                });
            });
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAuthTextAnimationCompleted(object sender, EventArgs args)
        {
            InternalEventAggregator.Current
                .GetEvent<SwitchContentEvent>()
                .Publish(ContentType.Main);
        }

        //---------------------------------------------------------------------
        //
        //  constructor
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public CheckContentViewModel()
        {
            
        }
    }
}
