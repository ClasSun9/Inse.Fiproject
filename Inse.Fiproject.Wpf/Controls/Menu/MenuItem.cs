using Inse.Fiproject.Wpf.Mvvm;
using System;


namespace Inse.Fiproject.Wpf.Controls
{
    public class MenuItem : PropertyChangedNotifier
    {
        //--------------------  field

        private string name;

        private Uri source;

        //--------------------  property

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Uri Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        //--------------------  event

        //  null

        //--------------------  function

        //  null

        //--------------------  constructor

        /// <summary>
        /// 
        /// </summary>
        public MenuItem()
        {

        }
    }
}
