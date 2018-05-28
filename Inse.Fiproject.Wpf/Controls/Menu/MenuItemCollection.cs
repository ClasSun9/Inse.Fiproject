using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Inse.Fiproject.Wpf.Controls
{
    public class MenuItemCollection : ObservableCollection<MenuItem>
    {
        //--------------------  field

        //  null

        //--------------------  property

        //  null

        //--------------------  event

        //  null

        //--------------------  function

        //  null

        //--------------------  constructor

        /// <summary>
        /// 
        /// </summary>
        public MenuItemCollection()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuItems"></param>
        public MenuItemCollection(IEnumerable<MenuItem> menuItems = null)
        {
            if (menuItems != null)
            {
                foreach (MenuItem menuItem in menuItems)
                {
                    base.Add(menuItem);
                }
            }
        }
    }
}
