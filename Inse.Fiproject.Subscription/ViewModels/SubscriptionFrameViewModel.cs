using Inse.Fiproject.Wpf.Mvvm;
using Inse.Fiproject.Wpf.Controls;
using Inse.Fiproject.Wpf.ViewModel;


namespace Inse.Fiproject.Subscription.ViewModels
{
    public class SubscriptionFrameViewModel : AbstractViewModel
    {
        //---------------------------------------------------------------------
        //
        //  field
        //
        //---------------------------------------------------------------------

        private object currentContent = new Views.SubscriptionContent();

        //---------------------------------------------------------------------
        //
        //  property
        //
        //---------------------------------------------------------------------

        public object CurrentContent
        {
            get { return this.currentContent; }
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

        //  null

        //---------------------------------------------------------------------
        //
        //  constructor
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionFrameViewModel()
        {

        }
    }
}
