using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Documents;


namespace Inse.Fiproject.Wpf.Controls
{
    public static class WatermarkHelper
    {
        //--------------------  field

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty WatermarkProperty = DependencyProperty.RegisterAttached("Watermark", 
            typeof(object), 
            typeof(WatermarkHelper), 
            new PropertyMetadata(OnWatermarkPropertyChanged));

        //--------------------  property

        //  null

        //--------------------  event

        //  null

        //--------------------  function

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        public static object GetWatermark(DependencyObject dependencyObject)
        {
            return (object)dependencyObject.GetValue(WatermarkProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetWatermark(DependencyObject dependencyObject, object value)
        {
            dependencyObject.SetValue(WatermarkProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        private static void OnWatermarkPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            if (dependencyObject is TextBox)
            {
                TextBox textbox = dependencyObject as TextBox;
                textbox.Loaded            += OnEvent;
                textbox.GotKeyboardFocus  += OnEvent;
                textbox.LostKeyboardFocus += OnEvent;
                textbox.TextChanged       += OnEvent;
            } else
            if (dependencyObject is PasswordBox)
            {
                PasswordBox passwordbox = dependencyObject as PasswordBox;
                passwordbox.Loaded            += OnEvent;
                passwordbox.GotKeyboardFocus  += OnEvent;
                passwordbox.LostKeyboardFocus += OnEvent;
                passwordbox.PasswordChanged   += OnEvent;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private static void OnEvent(object sender, EventArgs args)
        {
            DependencyObject dependencyObject = sender as DependencyObject;
            if (ShouldShowWatermark(dependencyObject))
            {
                ShowWatermark(dependencyObject);   
            }
            else
            {
                HideWatermark(dependencyObject);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        private static bool ShouldShowWatermark(DependencyObject dependencyObject)
        {
            bool should_show = false;

            if (dependencyObject is TextBox)
            {
                TextBox textbox = dependencyObject as TextBox;
                if (string.IsNullOrEmpty(textbox.Text) && textbox.IsKeyboardFocused == false)
                {
                    should_show = true;
                }
            } else
            if (dependencyObject is PasswordBox)
            {
                PasswordBox passwordbox = dependencyObject as PasswordBox;
                if (string.IsNullOrEmpty(passwordbox.Password) && passwordbox.IsKeyboardFocused == false)
                {
                    should_show = true;
                }
            }

            return should_show;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depedencyObject"></param>
        private static void ShowWatermark(DependencyObject dependencyObject)
        {
            AdornerLayer adornerLayer = AdornerLayer.GetAdornerLayer(dependencyObject as Visual);
            if (adornerLayer != null)
            {
                adornerLayer.Add(new WatermarkAdorner(dependencyObject as UIElement, GetWatermark(dependencyObject)));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        private static void HideWatermark(DependencyObject dependencyObject)
        {
            Adorner[] adorners = AdornerLayer.GetAdornerLayer(dependencyObject as Visual)?.GetAdorners(dependencyObject as UIElement) ?? null;
            if (adorners != null)
            {
                foreach (Adorner adorner in adorners)
                {
                    if (adorner is WatermarkAdorner)
                    {
                        adorner.Visibility = Visibility.Hidden;
                        AdornerLayer.GetAdornerLayer(dependencyObject as Visual).Remove(adorner);
                    }
                }
            }
        }

        //--------------------  constructor
        
        //  null
    }
}
