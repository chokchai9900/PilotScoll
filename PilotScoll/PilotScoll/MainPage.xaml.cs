using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PilotScoll
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            hybridWebView.Navigated += async (sender, e) =>
            {
                var h = await hybridWebView.EvaluateJavaScriptAsync("document.body.offsetHeight;");
                var contentHeight = Int32.Parse(h);
                hybridWebView.HeightRequest = contentHeight + 50;
            };
        }

        private  void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Console.WriteLine($"Scroll position WebView: {e.ScrollY}");
            Console.WriteLine($"Scroll position ScrollView: {hybridWebView.TranslationY}");
        }
    }
}
