using Inse.Fiproject.Wpf.Mvvm;
using Inse.Fiproject.Wpf.Controls;
using Inse.Fiproject.Wpf.ViewModel;
using Inse.Fiproject.Youtube;


namespace Inse.Fiproject.Home.ViewModels
{
    public class HomeContentViewModel : AbstractViewModel
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
        
        public string ApplicationName
        {
            get { return YoutubeConnection.Service.ApplicationName; }
        }

        public string Name
        {
            get { return YoutubeConnection.Service.Name; }
        }

        public string BaseUri
        {
            get { return YoutubeConnection.Service.BaseUri; }
        }

        public string BasePath
        {
            get { return YoutubeConnection.Service.BasePath; }
        }

        public string BatchUri
        {
            get { return YoutubeConnection.Service.BatchUri; }
        }

        public string BatchPath
        {
            get { return YoutubeConnection.Service.BatchPath; }
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
        public HomeContentViewModel()
        {
            
        }
    }
}
