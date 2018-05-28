using Inse.Fiproject.Wpf.ViewModel;
using Inse.Fiproject.Wpf.Controls;
using System.Windows;
using System.Windows.Input;


namespace Inse.Fiproject.Wpf.Mvvm
{
    public static class AttachedBinder
    {
        #region /* DragEnterProperty */

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty DragEnterProperty = DependencyProperty.RegisterAttached("DragEnter",
            typeof(DragEventHandler),
            typeof(AttachedBinder),
            new PropertyMetadata(OnDragEnterPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static DragEventHandler GetDragEnter(DependencyObject dependencyObject)
        {
            return (DragEventHandler)dependencyObject.GetValue(DragEnterProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependenchObject"></param>
        /// <param name="value"></param>
        public static void SetDragEnter(DependencyObject dependenchObject, DragEventHandler value)
        {
            dependenchObject.SetValue(DragEnterProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnDragEnterPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            UIElement uiElement = dependencyObject as UIElement;
            if (uiElement == null)
            {
                return;
            }
            
            DragEventHandler newHandler = args.NewValue as DragEventHandler;
            if (newHandler == null)
            {
                return;
            }
            
            uiElement.DragEnter += newHandler;
        }

        #endregion

        #region /* DragLeaveProperty */

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty DragLeaveProperty = DependencyProperty.RegisterAttached("DragLeave",
            typeof(DragEventHandler),
            typeof(AttachedBinder),
            new PropertyMetadata(OnDragLeavePropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static DragEventHandler GetDragLeave(DependencyObject dependencyObject)
        {
            return (DragEventHandler)dependencyObject.GetValue(DragLeaveProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetDragLeave(DependencyObject dependencyObject, DragEventHandler value)
        {
            dependencyObject.SetValue(DragLeaveProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnDragLeavePropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            UIElement uiElement = dependencyObject as UIElement;
            if (uiElement == null)
            {
                return;
            }

            DragEventHandler newHandler = args.NewValue as DragEventHandler;
            if (newHandler == null)
            {
                return;
            }

            uiElement.DragLeave += newHandler;
        }

        #endregion

        #region /* DragOverProperty */

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty DragOverProperty = DependencyProperty.RegisterAttached("AttahcedDragOver",
            typeof(DragEventHandler),
            typeof(AttachedBinder),
            new PropertyMetadata(OnDragOverPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static DragEventHandler GetDragOver(DependencyObject dependencyObject)
        {
            return (DragEventHandler)dependencyObject.GetValue(DragOverProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetDragOver(DependencyObject dependencyObject, DragEventHandler value)
        {
            dependencyObject.SetValue(DragOverProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnDragOverPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            UIElement uiElement = dependencyObject as UIElement;
            if (uiElement == null)
            {
                return;
            }

            DragEventHandler newHandler = args.NewValue as DragEventHandler;
            if (newHandler == null)
            {
                return;
            }

            uiElement.DragOver += newHandler;
        }

        #endregion

        #region /* DropProperty */

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty DropProperty = DependencyProperty.RegisterAttached("Drop",
            typeof(DragEventHandler),
            typeof(AttachedBinder),
            new PropertyMetadata(OnDropPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static DragEventHandler GetDrop(DependencyObject dependencyObject)
        {
            return (DragEventHandler)dependencyObject.GetValue(DropProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetDrop(DependencyObject dependencyObject, DragEventHandler value)
        {
            dependencyObject.SetValue(DropProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnDropPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            UIElement uiElement = dependencyObject as UIElement;
            if (uiElement == null)
            {
                return;
            }

            DragEventHandler newHandler = args.NewValue as DragEventHandler;
            if (newHandler == null)
            {
                return;
            }

            uiElement.Drop += newHandler;
        }

        #endregion

        #region /* PreviewDragEnterProperty */

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty PreviewDragEnterProperty = DependencyProperty.RegisterAttached("PreviewDragEnter",
            typeof(DragEventHandler),
            typeof(AttachedBinder),
            new PropertyMetadata(OnPreviewDragEnterPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static DragEventHandler GetPreviewDragEnter(DependencyObject dependencyObject)
        {
            return (DragEventHandler)dependencyObject.GetValue(PreviewDragEnterProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependenchObject"></param>
        /// <param name="value"></param>
        public static void SetPreviewDragEnter(DependencyObject dependenchObject, DragEventHandler value)
        {
            dependenchObject.SetValue(PreviewDragEnterProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnPreviewDragEnterPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            UIElement uiElement = dependencyObject as UIElement;
            if (uiElement == null)
            {
                return;
            }

            DragEventHandler newHandler = args.NewValue as DragEventHandler;
            if (newHandler == null)
            {
                return;
            }

            uiElement.PreviewDragEnter += newHandler;
        }

        #endregion /* PreviewDragEnterProperty */

        #region /* PreviewDragLeaveProperty */

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty PreviewDragLeaveProperty = DependencyProperty.RegisterAttached("PreviewDragLeave",
            typeof(DragEventHandler),
            typeof(AttachedBinder),
            new PropertyMetadata(OnPreviewDragLeavePropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static DragEventHandler GetPreviewDragLeave(DependencyObject dependencyObject)
        {
            return (DragEventHandler)dependencyObject.GetValue(PreviewDragLeaveProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetPreviewDragLeave(DependencyObject dependencyObject, DragEventHandler value)
        {
            dependencyObject.SetValue(PreviewDragLeaveProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnPreviewDragLeavePropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            UIElement uiElement = dependencyObject as UIElement;
            if (uiElement == null)
            {
                return;
            }

            DragEventHandler newHandler = args.NewValue as DragEventHandler;
            if (newHandler == null)
            {
                return;
            }

            uiElement.PreviewDragLeave += newHandler;
        }

        #endregion

        #region /* PreviewDropProperty */

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty PreviewDropProperty = DependencyProperty.RegisterAttached("PreviewDrop",
            typeof(DragEventHandler),
            typeof(AttachedBinder),
            new PropertyMetadata(OnPreviewDropPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static DragEventHandler GetPreviewDrop(DependencyObject dependencyObject)
        {
            return (DragEventHandler)dependencyObject.GetValue(PreviewDropProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetPreviewDrop(DependencyObject dependencyObject, DragEventHandler value)
        {
            dependencyObject.SetValue(PreviewDropProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnPreviewDropPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            UIElement uiElement = dependencyObject as UIElement;
            if (uiElement == null)
            {
                return;
            }

            DragEventHandler newHandler = args.NewValue as DragEventHandler;
            if (newHandler == null)
            {
                return;
            }

            uiElement.PreviewDrop += newHandler;
        }

        #endregion

        #region /* KeyDownProperty */

        /// <summary>
        /// KeyDown Event Property
        /// </summary>
        public static readonly DependencyProperty KeyDownProperty = DependencyProperty.RegisterAttached("KeyDown",
            typeof(KeyEventHandler),
            typeof(AttachedBinder),
            new PropertyMetadata(OnAttahcedKeyDownPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static KeyEventHandler GetKeyDown(DependencyObject dependencyObject)
        {
            return (KeyEventHandler)dependencyObject.GetValue(KeyDownProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetKeyDown(DependencyObject dependencyObject, KeyEventHandler value)
        {
            dependencyObject.SetValue(KeyDownProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnAttahcedKeyDownPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            UIElement uiElement = dependencyObject as UIElement;
            if (uiElement == null)
            {
                return;
            }

            KeyEventHandler newHandler = args.NewValue as KeyEventHandler;
            if (newHandler == null)
            {
                return;
            }

            uiElement.KeyDown += newHandler;
        }

        #endregion

        #region /* PreviewKeyDownProperty */

        /// <summary>
        /// PreviewKeyDown Evenet Property
        /// </summary>
        public static readonly DependencyProperty PreviewKeyDownProperty = DependencyProperty.RegisterAttached("PreviewKeyDown",
            typeof(KeyEventHandler),
            typeof(AttachedBinder),
            new PropertyMetadata(OnPreviewKeyDownPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static KeyEventHandler GetPreviewKeyDown(DependencyObject dependencyObject)
        {
            return (KeyEventHandler)dependencyObject.GetValue(PreviewKeyDownProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetPreviewKeyDown(DependencyObject dependencyObject, KeyEventHandler value)
        {
            dependencyObject.SetValue(PreviewKeyDownProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnPreviewKeyDownPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            UIElement uiElement = dependencyObject as UIElement;
            if (uiElement == null)
            {
                return;
            }

            KeyEventHandler newHandler = args.NewValue as KeyEventHandler;
            if (newHandler == null)
            {
                return;
            }

            uiElement.PreviewKeyDown += newHandler;
        }

        #endregion

        #region /* LoadedProperty */

        /// <summary>
        /// Loaded Event Property
        /// </summary>
        public static readonly DependencyProperty LoadedProperty = DependencyProperty.RegisterAttached("Loaded", 
            typeof(RoutedEventHandler), 
            typeof(AttachedBinder), 
            new PropertyMetadata(OnLoadedPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static RoutedEventHandler GetLoaded(DependencyObject dependencyObject)
        {
            return (RoutedEventHandler)dependencyObject.GetValue(LoadedProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetLoaded(DependencyObject dependencyObject, RoutedEventHandler value)
        {
            dependencyObject.SetValue(LoadedProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnLoadedPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            FrameworkElement frameworkElement = dependencyObject as FrameworkElement;
            if (frameworkElement == null)
            {
                return;
            }

            RoutedEventHandler newHandler = args.NewValue as RoutedEventHandler;
            if (newHandler == null)
            {
                return;
            }

            frameworkElement.Loaded += newHandler;
        }

        #endregion

        #region /* DependencyObjectGetterProperty */

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty DependencyObjectGetterProperty = DependencyProperty.RegisterAttached("DependencyObjectGetter",
            typeof(AbstractViewModel),
            typeof(AttachedBinder),
            new PropertyMetadata(OnDependencyObjectGetterPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static AbstractViewModel GetDependencyObjectGetter(DependencyObject dependencyObject)
        {
            return (AbstractViewModel)dependencyObject.GetValue(DependencyObjectGetterProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="value"></param>
        public static void SetDependencyObjectGetter(DependencyObject dependencyObject, AbstractViewModel value)
        {
            dependencyObject.SetValue(DependencyObjectGetterProperty, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        public static void OnDependencyObjectGetterPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            AbstractViewModel abstractViewModel = args.NewValue as AbstractViewModel;
            if (abstractViewModel == null)
            {
                return;
            }

            FrameworkElement frameworkElement = dependencyObject as FrameworkElement;
            if (frameworkElement != null)
            {
                abstractViewModel.NamedDependencyObjects.Add(frameworkElement.Name, frameworkElement);
                return;
            }

            FrameworkContentElement frameworkContentElement = dependencyObject as FrameworkContentElement;
            if (frameworkContentElement != null)
            {
                abstractViewModel.NamedDependencyObjects.Add(frameworkContentElement.Name, frameworkContentElement);
                return;
            }
        }

        #endregion
    }
}
