using Inse.Fiproject.Wpf.Mvvm;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;


namespace Inse.Fiproject.Wpf.Controls
{
    [TemplatePart(Name = "PART_MainLayout", Type = typeof(UIElement))]
    public class FrameWindow : Window
    {
        //---------------------------------------------------------------------
        //
        //  field
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty HomeUriProperty = DependencyProperty.Register("HomeUri",
            typeof(Uri),
            typeof(FrameWindow),
            new FrameworkPropertyMetadata(null, OnHomeUriPropertyChanged));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty SettingsUriProperty = DependencyProperty.Register("SettingsUri",
            typeof(Uri),
            typeof(FrameWindow),
            new FrameworkPropertyMetadata(null));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty ContentUriProperty = DependencyProperty.Register("ContentUri", 
            typeof(Uri), 
            typeof(FrameWindow),
            new FrameworkPropertyMetadata(null));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty MenuItemsProperty = DependencyProperty.Register("MenuItems", 
            typeof(MenuItemCollection), 
            typeof(FrameWindow), 
            new FrameworkPropertyMetadata(null, OnMenuItemsPropertyChanaged));

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty SelectedMenuItemProperty = DependencyProperty.Register("SelectedMenuItem", 
            typeof(MenuItem), 
            typeof(FrameWindow), 
            new FrameworkPropertyMetadata(null, OnSelectedMenuItemPropertyChanged));
        
        private UIElement adornedElement = null;

        private ICommand goHomeCommand     = null;
        private ICommand goSettingsCommand = null;
        private ICommand openMenuCommand   = null;
        private ICommand closeMenuCommand  = null;

        private bool isOpenedMenu = false;

        //---------------------------------------------------------------------
        //
        //  property
        //
        //---------------------------------------------------------------------

        public Uri HomeUri
        {
            get { return (Uri)base.GetValue(HomeUriProperty); }
            set { base.SetValue(HomeUriProperty, value); }
        }

        public Uri SettingsUri
        {
            get { return (Uri)base.GetValue(SettingsUriProperty); }
            set { base.SetValue(SettingsUriProperty, value); }
        }

        public Uri ContentUri
        {
            get { return (Uri)GetValue(ContentUriProperty); }
            set { SetValue(ContentUriProperty, value); }
        }
        
        public MenuItemCollection MenuItems
        {
            get { return (MenuItemCollection)base.GetValue(MenuItemsProperty); }
            set { base.SetValue(MenuItemsProperty, value); }
        }

        public MenuItem SelectedMenuItem
        {
            get { return (MenuItem)base.GetValue(SelectedMenuItemProperty); }
            set { base.SetValue(SelectedMenuItemProperty, value); }
        }
        
        public ICommand GoSettingsCommand
        {
            get { return this.goSettingsCommand; }
        }

        public ICommand GoHomeCommand
        {
            get { return this.goHomeCommand; }
        }

        public ICommand OpenMenuCommand
        {
            get { return this.openMenuCommand; }
        }

        public ICommand CloseMenuCommand
        {
            get { return this.closeMenuCommand; }
        }
        
        //---------------------------------------------------------------------
        //
        //  event
        //
        //---------------------------------------------------------------------

        //  null

        //---------------------------------------------------------------------
        //
        //  function
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.adornedElement = (UIElement)base.GetTemplateChild("PART_MainLayout");
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <returns></returns>
        public static FrameWindow GetCurrentFrameWindow(DependencyObject dependencyObject)
        {
            Window window = Window.GetWindow(dependencyObject);
            if (window == null)
            {
                DependencyObject parent = VisualTreeHelper.GetParent(dependencyObject);
                while (parent is Window == false)
                {
                    parent = VisualTreeHelper.GetParent(parent);
                }

                window = (Window)parent;
            }

            return window as FrameWindow;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="overlayContent"></param>
        public void ShowOverlay(object overlayContent, bool isHitTestVisible = true, bool isBlurring = true)
        {
            this.isOpenedMenu = true;

            this.adornedElement.ShowOverlay(overlayContent, isHitTestVisible, isBlurring);
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void HideOverlay()
        {
            this.isOpenedMenu = false;

            this.adornedElement.HideOverlay();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        private static void OnHomeUriPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            FrameWindow frameWindow = dependencyObject as FrameWindow;
            if (frameWindow == null)
            {
                return;
            }

            frameWindow.ContentUri = frameWindow.HomeUri;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        private static void OnMenuItemsPropertyChanaged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            FrameWindow frameWindow = dependencyObject as FrameWindow;
            if (frameWindow == null)
            {
                return;
            }

            MenuItemCollection menuItems = args.NewValue as MenuItemCollection;
            if (menuItems == null)
            {
                return;
            }

            frameWindow.ContentUri = frameWindow.HomeUri;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        private static void OnSelectedMenuItemPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            FrameWindow frameWindow = dependencyObject as FrameWindow;
            if (frameWindow == null)
            {
                return;
            }

            MenuItem menuItem = args.NewValue as MenuItem;
            if (menuItem == null)
            {
                return;
            }

            frameWindow.ContentUri = menuItem.Source;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OnGoHome()
        {
            this.SelectedMenuItem = null;
            this.ContentUri = this.HomeUri;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OnGoSettings()
        {
            this.SelectedMenuItem = null;
            this.ContentUri = this.SettingsUri;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        private void OnOpenMenu()
        {
            this.ShowOverlay(new FrameWindowOverlayMenu() { DataContext = this });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        private void OnCloseMenu()
        {
            this.HideOverlay();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCanResizeWindow(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = this.ResizeMode == ResizeMode.CanResize ||
                              this.ResizeMode == ResizeMode.CanResizeWithGrip;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCanMinimizeWindow(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = this.ResizeMode != ResizeMode.NoResize;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCloseWindow(object sender, ExecutedRoutedEventArgs args)
        {
            SystemCommands.CloseWindow(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnMinimizeWindow(object sender, ExecutedRoutedEventArgs args)
        {
            SystemCommands.MinimizeWindow(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnMaximizeWindow(object sender, ExecutedRoutedEventArgs args)
        {
            SystemCommands.MaximizeWindow(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRestoreWindow(object sender, ExecutedRoutedEventArgs args)
        {
            SystemCommands.RestoreWindow(this);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnKeyDown(object sender, KeyEventArgs args)
        {
            bool shouldOpen = (args.Key == Key.OemTilde)
                && (args.KeyboardDevice.Modifiers == ModifierKeys.Control);
            
            //  ctrl + `
            if (shouldOpen && !this.isOpenedMenu)
            { 
                this.OnOpenMenu();
            }

            args.Handled = false;
        }
        
        //---------------------------------------------------------------------
        //
        //  constructor
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        static FrameWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FrameWindow), new FrameworkPropertyMetadata(typeof(FrameWindow)));
        }

        /// <summary>
        /// 
        /// </summary>
        public FrameWindow()
        {
            base.KeyDown += this.OnKeyDown;

            this.goHomeCommand     = new RelayCommand(this.OnGoHome);
            this.goSettingsCommand = new RelayCommand(this.OnGoSettings);
            this.openMenuCommand   = new RelayCommand(this.OnOpenMenu);
            this.closeMenuCommand  = new RelayCommand(this.OnCloseMenu);
            
            this.CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, OnCloseWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, OnMinimizeWindow, OnCanMinimizeWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, OnMaximizeWindow, OnCanResizeWindow));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, OnRestoreWindow, OnCanResizeWindow));
        }
    }
}
