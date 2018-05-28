using Inse.Fiproject.Wpf.Mvvm;
using Inse.Fiproject.Wpf.Controls;
using Inse.Fiproject.Wpf.ViewModel;


namespace Inse.Fiproject.Settings.ViewModels
{
    public class SettingsFrameViewModel : AbstractViewModel
    {
        //---------------------------------------------------------------------
        //
        //  field
        //
        //---------------------------------------------------------------------

        private object currentContent = new Views.SettingsContent();

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
        public SettingsFrameViewModel()
        {

        }
    }
}
