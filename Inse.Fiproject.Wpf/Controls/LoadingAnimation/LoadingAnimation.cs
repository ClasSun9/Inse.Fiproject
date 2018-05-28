using System.Windows;
using System.Windows.Controls;


namespace Inse.Fiproject.Wpf.Controls
{
    [TemplateVisualState(GroupName = animationGroup, Name = activationState)]
    [TemplateVisualState(GroupName = animationGroup, Name = deactivationState)]
    public class LoadingAnimation : System.Windows.Controls.Control
    {
        //--------------------  field

        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(LoadingAnimation), new PropertyMetadata(OnIsActivePropertyChanged));

        private const string animationGroup    = "Animation";
        private const string activationState   = "Activation";
        private const string deactivationState = "Deactivateion";
        
        //--------------------  property

        public bool IsActive
        {
            get { return (bool)base.GetValue(IsActiveProperty); }
            set { base.SetValue(IsActiveProperty, value); }
        }

        //--------------------  event

        //  null

        //--------------------  function

        /// <summary>
        /// 
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.GoToCurrentState(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dependencyObject"></param>
        /// <param name="args"></param>
        private static void OnIsActivePropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            LoadingAnimation loadingAnimation = dependencyObject as LoadingAnimation;
             
            loadingAnimation.GoToCurrentState(true);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gotable"></param>
        private void GoToCurrentState(bool gotable)
        {
            string currentState = this.IsActive ? activationState : deactivationState;

            VisualStateManager.GoToState(this, currentState, gotable);
        }

        //--------------------  constructor

        /// <summary>
        /// 
        /// </summary>
        static LoadingAnimation()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoadingAnimation), new FrameworkPropertyMetadata(typeof(LoadingAnimation)));
        }

        /// <summary>
        /// 
        /// </summary>
        public LoadingAnimation()
        {
            this.IsActive = false;
        }
    }
}
