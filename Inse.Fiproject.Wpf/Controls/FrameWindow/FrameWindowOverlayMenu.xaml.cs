using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;


namespace Inse.Fiproject.Wpf.Controls
{
    public partial class FrameWindowOverlayMenu : UserControl
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
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLoaded(object sender, RoutedEventArgs args)
        {
            this.Focusable = true;
            this.Focus();

            Keyboard.ClearFocus();
            Keyboard.Focus(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnKeyDown(object sender, KeyEventArgs args)
        {
            // esc
            if (args.Key == Key.Escape)
            {
                FrameWindow window = this.DataContext as FrameWindow;
                if (window != null)
                {
                    window.CloseMenuCommand.Execute(null);
                }
            }

            args.Handled = false;
        }

        //--------------------  constructor

        public FrameWindowOverlayMenu()
        {
            this.Loaded  += this.OnLoaded;
            this.KeyDown += this.OnKeyDown;

            InitializeComponent();
        }
    }
}
