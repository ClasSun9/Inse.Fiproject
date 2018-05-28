using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Inse.Fiproject.Wpf.Mvvm
{
    public class PropertyChangedNotifier : INotifyPropertyChanged
    {
        //--------------------  field

        //  null

        //--------------------  property

        //  null

        //--------------------  event

        public event PropertyChangedEventHandler PropertyChanged;

        //--------------------  function

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storage"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            this.NotifyPropertyChanged(propertyName);

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //--------------------  constructor

        public PropertyChangedNotifier()
        {

        }
    }
}
