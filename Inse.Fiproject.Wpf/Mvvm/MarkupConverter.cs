using System;
using System.Windows.Markup;


namespace Inse.Fiproject.Wpf.Mvvm.Converter
{
    public class MarkupConverter : MarkupExtension
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
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        //--------------------  constructor

        //  null
    }
}
