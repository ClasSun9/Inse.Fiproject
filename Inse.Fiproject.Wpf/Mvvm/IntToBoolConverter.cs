using System;
using System.Windows;
using System.Windows.Data;
using System.Globalization;


namespace Inse.Fiproject.Wpf.Mvvm.Converter
{
    public class IntToBoolConverter : MarkupConverter, IValueConverter
    {
        //--------------------  field

        //  null

        //--------------------  property

        //  null

        //--------------------  event

        //  null

        //--------------------  function

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="parameter"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public object Convert(object value, Type type, object parameter, CultureInfo info)
        {
            bool result = false;
            int? target = value as int?;

            if (target.HasValue && target.Value != 0)
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="parameter"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type type, object parameter, CultureInfo info)
        {
            int   result = 0;
            bool? target = value as bool?;

            if (target.HasValue && target.Value)
            {
                result = 1;
            }

            return result;
        }

        //--------------------  constructor
        
        //  null
    }
}
