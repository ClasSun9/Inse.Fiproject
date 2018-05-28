using Inse.Fiproject.Wpf.Mvvm;
using System.Windows;
using System.Collections.Generic;



namespace Inse.Fiproject.Wpf.ViewModel
{
    public class AbstractViewModel : PropertyChangedNotifier
    {
        //--------------------  field

        private Dictionary<string, DependencyObject> namedDependencyObjects;

        //--------------------  property

        public AbstractViewModel This
        {
            get { return this; }
        }

        public Dictionary<string, DependencyObject> NamedDependencyObjects
        {
            get { return this.namedDependencyObjects; }
        }

        //--------------------  event

        //  null

        //--------------------  function

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public T GetNamedDependencyObject<T>(string name) where T : class
        {
            return this.namedDependencyObjects[name] as T;
        }

        //--------------------  constructor

        public AbstractViewModel()
        {
            this.namedDependencyObjects = new Dictionary<string, DependencyObject>();
        }
    }
}
