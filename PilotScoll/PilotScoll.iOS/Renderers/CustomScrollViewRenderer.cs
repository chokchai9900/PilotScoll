using Foundation;
using PilotScoll.CustomsView;
using PilotScoll.iOS.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomScrollView), typeof(CustomScrollViewRenderer))]
namespace PilotScoll.iOS.Renderers
{

    public class CustomScrollViewRenderer : ScrollViewRenderer
    {
        public CustomScrollViewRenderer()
        {

        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            Bounces = false;
        }
    }
}