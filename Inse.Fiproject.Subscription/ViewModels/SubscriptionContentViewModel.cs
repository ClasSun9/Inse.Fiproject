using Inse.Fiproject.Wpf.Mvvm;
using Inse.Fiproject.Wpf.Controls;
using Inse.Fiproject.Wpf.ViewModel;

using Inse.Fiproject.Youtube;

using Google;
using Google.Apis;
using Google.Apis.YouTube;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Inse.Fiproject.Subscription.ViewModels
{
    public class SubscriptionContentViewModel : AbstractViewModel
    {
        //---------------------------------------------------------------------
        //
        //  field
        //
        //---------------------------------------------------------------------

        private ObservableCollection<Google.Apis.YouTube.v3.Data.Subscription> subscriptions;
        private Google.Apis.YouTube.v3.Data.Subscription selectedSubscription;

        //---------------------------------------------------------------------
        //
        //  property
        //
        //---------------------------------------------------------------------

        public RoutedEventHandler ViewLoadedHandler
        {
            get { return this.OnViewLoaded; }
        }

        public ObservableCollection<Google.Apis.YouTube.v3.Data.Subscription> Subscriptions
        {
            get { return this.subscriptions; }
        }

        public Google.Apis.YouTube.v3.Data.Subscription SelectedSubscription
        {
            get { return this.selectedSubscription; }
            set { base.SetProperty<Google.Apis.YouTube.v3.Data.Subscription>(ref this.selectedSubscription, value, nameof(this.SelectedSubscription)); }
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
        private async void OnViewLoaded(object sender, RoutedEventArgs args)
        {
            // id, channelId, mySubscribers, myRecentSubscribers, idParam, mine
            var request = YoutubeConnection.Service.Subscriptions.List("snippet, contentDetails");
            request.Mine       = true;
            request.MaxResults = 50;

            //
            var response = await request.ExecuteAsync();

            //
            this.subscriptions = new ObservableCollection<Google.Apis.YouTube.v3.Data.Subscription>();

            foreach (var item in response.Items)
            {
                this.subscriptions.Add(item);
            }
            
            base.NotifyPropertyChanged(nameof(this.Subscriptions));
        }

        //---------------------------------------------------------------------
        //
        //  constructor
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionContentViewModel()
        {
            
        }
    }
}
