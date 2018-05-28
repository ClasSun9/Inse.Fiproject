using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Documents;


namespace Inse.Fiproject.Wpf.Controls
{
    public class UIElementOverlayAdorner : Adorner
    {
        //--------------------  field

        private readonly ContentPresenter contentPresenter;

        //--------------------  property

        protected override int VisualChildrenCount
        {
            get { return 1; }
        }

        private UIElement Control
        {
            get { return base.AdornedElement; }
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
            this.contentPresenter.Measure(this.Control.RenderSize);

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="adornedElement"></param>
        /// <param name="overlayContent"></param>
        public UIElementOverlayAdorner(UIElement adornedElement, object overlayContent) : base(adornedElement)
        {
            base.IsHitTestVisible = true;

            this.contentPresenter = new ContentPresenter();
            this.contentPresenter.IsHitTestVisible = true;
            this.contentPresenter.Content = overlayContent;
            this.contentPresenter.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.contentPresenter.VerticalAlignment = VerticalAlignment.Stretch;

            base.AddVisualChild(this.contentPresenter);
            base.AddLogicalChild(this.contentPresenter);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="adornedElement"></param>
        /// <param name="overlayContentUri"></param>
        public UIElementOverlayAdorner(UIElement adornedElement, Uri overlayContentUri) : base(adornedElement)
        {
            base.IsHitTestVisible = true;

            this.contentPresenter = new ContentPresenter();
            this.contentPresenter.IsHitTestVisible = true;
            this.contentPresenter.ContentSource = overlayContentUri.ToString();
            this.contentPresenter.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.contentPresenter.VerticalAlignment = VerticalAlignment.Stretch;

            base.AddVisualChild(this.contentPresenter);
            base.AddLogicalChild(this.contentPresenter);
        }
    }
}
