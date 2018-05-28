using Inse.Fiproject.Wpf.Mvvm;
using Inse.Fiproject.Wpf.Controls;
using Inse.Fiproject.Wpf.ViewModel;


namespace Inse.Fiproject.Home.ViewModels
{
    public class HomeFrameViewModel : AbstractViewModel
    {
        //---------------------------------------------------------------------
        //
        //  field
        //
        //---------------------------------------------------------------------

        private object currentContent = new Views.HomeContent();

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
        public HomeFrameViewModel()
        {

        }
    }
}
