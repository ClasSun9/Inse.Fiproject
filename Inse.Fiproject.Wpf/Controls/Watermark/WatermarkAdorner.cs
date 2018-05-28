using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Documents;


namespace Inse.Fiproject.Wpf.Controls
{
    public class WatermarkAdorner  : Adorner
    {
        //--------------------  field

        private ContentPresenter contentPresenter;

        //--------------------  property

        protected override int VisualChildrenCount
        {
            get { return 1; }
        }

        private UIElement Control
        {
            get { return this.AdornedElement; }
        }

        //--------------------  event

        //  null

        //--------------------  function

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override Visual GetVisualChild(int index)
        {
            return this.contentPresenter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns></returns>
        protected override Size MeasureOverride(Size constraint)
        {
            this.contentPresenter.Measure(constraint);

            return this.Control.RenderSize;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="finalSize"></param>
        /// <returns></returns>
        protected override Size ArrangeOverride(Size finalSize)
        {
            this.contentPresenter.Arrange(new Rect(finalSize));

            return finalSize;
        }

        //--------------------  constructor

        public WatermarkAdorner(UIElement adornedElement, object watermark) : base(adornedElement)
        {
            this.contentPresenter = new ContentPresenter();
            this.contentPresenter.Content    = watermark;
            this.contentPresenter.Opacity    = 0.7;
            this.contentPresenter.Visibility = Visibility.Visible;

            Binding binding = new Binding("IsVisible");
            binding.Source = adornedElement;
            binding.Converter = new BooleanToVisibilityConverter();
            this.SetBinding(VisibilityProperty, binding);

            if (adornedElement is Control)
            {
                Control control = adornedElement as Control;

                this.contentPresenter.Margin = new Thickness(control.Padding.Left + 2 + control.BorderThickness.Left,
                    control.Padding.Top + 2 + control.BorderThickness.Top,
                    control.Padding.Right + 2 + control.BorderThickness.Right,
                    control.Padding.Bottom + 2 + control.BorderThickness.Bottom);

                this.contentPresenter.HorizontalAlignment = HorizontalAlignment.Left;
                this.contentPresenter.VerticalAlignment   = VerticalAlignment.Center;
            }
            else
            {
                this.contentPresenter.HorizontalAlignment = HorizontalAlignment.Center;
                this.contentPresenter.VerticalAlignment   = VerticalAlignment.Center;
            }
        }
    }
}
