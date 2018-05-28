using Inse.Fiproject.Wpf.Mvvm;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.Generic;


namespace Inse.Fiproject.Wpf.Controls
{
    public class Dialog : Window
    {
        //--------------------  field

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty ButtonsProperty = DependencyProperty.Register("Buttons", 
            typeof(IEnumerable<Button>), 
            typeof(Dialog));

        public static readonly string okString     = "예";
        public static readonly string cancelString = "취소";
        public static readonly string yesString    = "예";
        public static readonly string noString     = "아니오";
        public static readonly string closeString  = "닫기";

        private MessageBoxResult resultType = MessageBoxResult.None;

        private ICommand closeCommand;

        //--------------------  property

        public ICommand CloseCommand
        {
            get { return this.closeCommand; }
        }

        public Button OkButton
        {
            get { return this.CreateDialogButton(okString, MessageBoxResult.OK); }
        }

        public Button CancelButton
        {
            get { return this.CreateDialogButton(cancelString, MessageBoxResult.Cancel); }
        }

        public Button YesButton
        {
            get { return this.CreateDialogButton(yesString, MessageBoxResult.Yes); }
        }

        public Button NoButton
        {
            get { return this.CreateDialogButton(noString, MessageBoxResult.No); }
        }

        public Button CloseButton
        {
            get { return this.CreateDialogButton(closeString, MessageBoxResult.OK); }
        }

        public IEnumerable<Button> Buttons
        {
            get { return (IEnumerable<Button>)GetValue(ButtonsProperty); }
            set { SetValue(ButtonsProperty, value); }
        }

        public MessageBoxResult MessageBoxResult
        {
            get { return this.resultType; }
        }

        //--------------------  function

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        private void OnClose(MessageBoxResult? parameter)
        {
            if (parameter.HasValue == true)
            {
                this.resultType = parameter.Value;

                if (this.resultType == MessageBoxResult.OK || this.resultType == MessageBoxResult.Yes)
                {
                    this.DialogResult = true;
                } else 
                if (this.resultType == MessageBoxResult.Cancel || this.resultType == MessageBoxResult.No)
                {
                    this.DialogResult = false;
                }
                else
                {
                    this.DialogResult = null;
                }
            }
            base.Close();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="args"></param>
        private void OnKeyDown(object sender, KeyEventArgs args)
        {
            if (args.Key == Key.Enter || args.Key == Key.Escape)
            {
                foreach (Button button in this.Buttons)
                {
                    if ((string)button.Content == okString)
                    {
                        this.OnClose(MessageBoxResult.OK);
                    } else 
                    if ((string)button.Content == yesString)
                    {
                        this.OnClose(MessageBoxResult.Yes);
                    } else 
                    if ((string)button.Content == closeString)
                    {
                        this.OnClose(MessageBoxResult.OK);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        private Button CreateDialogButton(string content, MessageBoxResult result)
        {
            return new Button
            {
                Content = content,
                Command = this.closeCommand,
                CommandParameter = result,
                MinWidth = 64,
                MinHeight = 36,
                Margin = new Thickness(4, 0, 0, 0)
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="button"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        public static MessageBoxResult ShowMessage(string title, string message, MessageBoxButton button, Window owner = null)
        {
            Dialog dialog = new Dialog
            {
                Title = title,
                Content = new TextBlock() { Text = message, TextWrapping = TextWrapping.Wrap, VerticalAlignment = VerticalAlignment.Center },
                MaxWidth = 640,
                MaxHeight = 240,
                MinWidth = 0,
                MinHeight = 0
            };

            if (owner != null)
            {
                dialog.Owner = owner;
            }

            dialog.Buttons = GetButtons(dialog, button);
            dialog.ShowDialog();
            return dialog.resultType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dialog"></param>
        /// <param name="buttonType"></param>
        /// <returns></returns>
        private static IEnumerable<Button> GetButtons(Dialog dialog, MessageBoxButton buttonType)
        {
            switch (buttonType)
            {
                case MessageBoxButton.OK:
                    yield return dialog.CloseButton;
                    break;

                case MessageBoxButton.OKCancel:
                    yield return dialog.OkButton;
                    yield return dialog.CancelButton;
                    break;

                case MessageBoxButton.YesNo:
                    yield return dialog.YesButton;
                    yield return dialog.NoButton;
                    break;

                case MessageBoxButton.YesNoCancel:
                    yield return dialog.YesButton;
                    yield return dialog.NoButton;
                    yield return dialog.CancelButton;
                    break;
            }
        }

        //--------------------  constructor

        /// <summary>
        /// 
        /// </summary>
        static Dialog()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Dialog), new FrameworkPropertyMetadata(typeof(Dialog)));
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Dialog()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            this.KeyDown += new KeyEventHandler(this.OnKeyDown);

            this.closeCommand = new RelayCommand<MessageBoxResult?>(OnClose);

            this.Buttons = new Button[] { this.CloseButton };

            if (Application.Current != null && Application.Current.MainWindow != this && Application.Current.MainWindow.Visibility == Visibility.Visible)
            {
                this.Owner = Application.Current.MainWindow;
            }
        }
    }
}
