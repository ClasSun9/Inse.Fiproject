using System;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;


namespace Inse.Fiproject.Wpf.Controls
{
    public static class UIElementlOverlayHelper
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
        /// <param name="uiElement"></param>
        /// <param name="overlayContent"></param>
        public static void ShowOverlay(this UIElement uiElement, object overlayContent, bool isHitTestVisible = true, bool isBlurring = true)
        {
            HideOverlay(uiElement);
            
            AdornerLayer adornerLayer = AdornerLayer.GetAdornerLayer(uiElement);
            if (adornerLayer == null)
            {
                return;
            }

            UIElementOverlayAdorner adorner = new UIElementOverlayAdorner(uiElement, overlayContent)
            {
                IsHitTestVisible = isHitTestVisible
            };

            adornerLayer.Add(adorner);

            if (isBlurring)
            {
                uiElement.Effect = new BlurEffect() { Radius = 3, KernelType = KernelType.Gaussian };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiElement"></param>
        /// <param name="overlayContentUri"></param>
        /// <param name="isHitTestVisible"></param>
        /// <param name="isBlurring"></param>
        public static void ShowOverlay(this UIElement uiElement, Uri overlayContentUri, bool isHitTestVisible = true, bool isBlurring = true)
        {
            HideOverlay(uiElement);

            AdornerLayer adornerLayer = AdornerLayer.GetAdornerLayer(uiElement);
            if (adornerLayer == null)
            {
                return;
            }

            UIElementOverlayAdorner adorner = new UIElementOverlayAdorner(uiElement, overlayContentUri)
            {
                IsHitTestVisible = isHitTestVisible
            };

            adornerLayer.Add(adorner);

            if (isBlurring)
            {
                uiElement.Effect = new BlurEffect() { Radius = 3, KernelType = KernelType.Gaussian };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiElement"></param>
        public static void HideOverlay(this UIElement uiElement)
        {
            Adorner adorner = uiElement.GetAdorner();
            if (adorner != null)
            {
                AdornerLayer.GetAdornerLayer(uiElement)?.Remove(adorner);
            }

            uiElement.Effect = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uiElement"></param>
        /// <returns></returns>
        public static Adorner GetAdorner(this UIElement uiElement)
        {
            Adorner result = null;

            AdornerLayer adornerLayer = AdornerLayer.GetAdornerLayer(uiElement);

            Adorner[] adorners = adornerLayer?.GetAdorners(uiElement);
            if (adorners != null)
            {
                foreach (var adorner in adorners)
                {
                    if (adorner is UIElementOverlayAdorner)
                    {
                        result = adorner;
                        break;
                    }
                }
            }

            return result;
        }

        //--------------------  constructor

        //  null
    }
}
