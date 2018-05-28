using System;
using System.Windows;
using System.Windows.Data;
using System.Globalization;

namespace Inse.Fiproject.Wpf.Mvvm.Converter
{
    public class BoolToVisibilityConverter : MarkupConverter, IValueConverter
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
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility result = Visibility.Collapsed;

            bool? target = value as bool?;
            if (target.HasValue && target.Value == true)
            {
                result = Visibility.Visible;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        //--------------------  constructor

        //  null
    }
}
