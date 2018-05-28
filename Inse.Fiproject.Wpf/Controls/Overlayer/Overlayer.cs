using System;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Controls;
using System.Windows.Documents;


namespace Inse.Fiproject.Wpf.Controls
{
    [ContentProperty("OverlayContent")]
    [TemplatePart(Name = "PART_OverlayLayer", Type = typeof(AdornerDecorator))]
    [TemplatePart(Name = "PART_OverlayElement", Type = typeof(Border))]
    public class Overlayer : Control
    {
        //---------------------------------------------------------------------
        //
        //  field
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty OverlayContentProperty = DependencyProperty.Register("OverlayContent",
            typeof(object),
            typeof(Overlayer),
            new FrameworkPropertyMetadata(null, OnOverlayContentPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty OverlayContentUriProperty = DependencyProperty.Register("OverlayContentUri",
            typeof(Uri),
            typeof(Overlayer),
            new FrameworkPropertyMetadata(null, OnOverlayContentUriPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty OverlayVisibilityProperty = DependencyProperty.Register("OverlayVisibility",
            typeof(Visibility),
            typeof(Overlayer),
            new FrameworkPropertyMetadata(Visibility.Hidden, OnOverlayVisibilityPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty IsOverlayHitTestVisibleProperty = DependencyProperty.Register("IsOverlayHitTestVisible",
            typeof(bool),
            typeof(Overlayer),
            new FrameworkPropertyMetadata(true));

        private UIElement overlayElement = null;

        private bool hasContent = false;

        //---------------------------------------------------------------------
        //
        //  property
        //
        //---------------------------------------------------------------------

        public object OverlayContent
        {
            get { return (object)base.GetValue(OverlayContentProperty); }
            set { base.SetValue(OverlayContentProperty, value); }
        }

        public Uri OverlayContentUri
        {
            get { return (Uri)base.GetValue(OverlayContentUriProperty); }
            set { base.SetValue(OverlayContentUriProperty, value); }
        }

        public Visibility OverlayVisibility
        {
            get { return (Visibility)base.GetValue(OverlayVisibilityProperty); }
            set { base.SetValue(OverlayVisibilityProperty, value); }
        }

        public bool IsOverlayHitTestVisible
        {
            get { return (bool)base.GetValue(IsOverlayHitTestVisibleProperty); }
            set { base.SetValue(IsOverlayHitTestVisibleProperty, value); }
        }

        //---------------------------------------------------------------------
        //
        //  event
        //
        //---------------------------------------------------------------------

        

        //---------------------------------------------------------------------
        //
        //  function
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        private static void OnOverlayContentPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            Overlayer overlayer = dependencyObject as Overlayer;
            if (overlayer == null)
            {
                return;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        private static void OnOverlayContentUriPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            Overlayer overlayer = dependencyObject as Overlayer;
            if (overlayer == null)
            {
                return;
            }
            

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        private static void OnOverlayVisibilityPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            Overlayer overlayer = dependencyObject as Overlayer;
            if (overlayer == null)
            {
                return;
            }

            if (overlayer.overlayElement != null)
            { 

            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.overlayElement = base.GetTemplateChild("PART_OverlayElement") as UIElement;
        }

        //---------------------------------------------------------------------
        //
        //  constructor
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        static Overlayer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Style), new FrameworkPropertyMetadata(typeof(Overlayer)));
        }

        /// <summary>
        /// 
        /// </summary>
        public Overlayer()
        {

        }
    }
}
