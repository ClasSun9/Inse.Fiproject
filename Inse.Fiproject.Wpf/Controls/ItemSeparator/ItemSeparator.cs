using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Controls;


namespace Inse.Fiproject.Wpf.Controls
{
    public enum SeparateDirection
    {
        Horizontally,
        Vertically
    }

    public class ItemSeparator : System.Windows.Controls.Control
    {
        //--------------------  field
        
        /// <summary> 
        /// 
        /// </summary>
        public static readonly DependencyProperty ThicknessProperty = DependencyProperty.Register("Thickness", 
            typeof(double), 
            typeof(ItemSeparator), 
            new FrameworkPropertyMetadata(2.0, OnThicknessPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty SeparateDirectionProperty = DependencyProperty.Register("SeparateDirection",
            typeof(SeparateDirection),
            typeof(ItemSeparator),
            new FrameworkPropertyMetadata(SeparateDirection.Vertically, OnSeparateDirectionPropertyChanged));
        
        //--------------------  property
        
        public double Thickness
        {
            get { return (double)GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }

        public SeparateDirection SeparateDirection
        {
            get { return (SeparateDirection)GetValue(SeparateDirectionProperty); }
            set { SetValue(SeparateDirectionProperty, value); }
        }

        //--------------------  event

        //  null

        //--------------------  function
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnThicknessPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            (dependencyObject as ItemSeparator)?.UpdateBorderThickness();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnSeparateDirectionPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            (dependencyObject as ItemSeparator)?.UpdateAlignment();
            (dependencyObject as ItemSeparator)?.UpdateBorderThickness();
        }
        
        /// <summary>
        /// 
        /// </summary>
        private void UpdateAlignment()
        {
            switch (this.SeparateDirection)
            {
                case SeparateDirection.Horizontally:
                    this.HorizontalAlignment = HorizontalAlignment.Stretch;
                    this.VerticalAlignment   = VerticalAlignment.Center;
                    break;

                case SeparateDirection.Vertically:
                    this.HorizontalAlignment = HorizontalAlignment.Center;
                    this.VerticalAlignment   = VerticalAlignment.Stretch;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateBorderThickness()
        {
            double left   = 0.0;
            double right  = 0.0;
            double top    = 0.0;
            double bottom = 0.0; 
            
            switch (this.SeparateDirection)
            {
                case SeparateDirection.Horizontally:
                    top    = this.Thickness / 2.0;
                    bottom = this.Thickness / 2.0;
                    break;

                case SeparateDirection.Vertically:
                    left  = this.Thickness / 2.0;
                    right = this.Thickness / 2.0;
                    break;
            }

            this.BorderThickness = new Thickness(left, top, right, bottom);
        }

        //--------------------  constructor

        /// <summary>
        /// 
        /// </summary>
        static ItemSeparator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ItemSeparator), new FrameworkPropertyMetadata(typeof(ItemSeparator)));
        }

        /// <summary>
        /// 
        /// </summary>
        public ItemSeparator()
        {

        }
    }
}