using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace CourseAssistant
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/sunny.jpg", UriKind.Absolute));
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (A.IsSelected)
            {
                Myframe.Navigate(typeof(Assets.APage));

            }
            else if (B.IsSelected)
            {
                Myframe.Navigate(typeof(Assets.BPage));

            }
            else if (C.IsSelected)
            {
                Myframe.Navigate(typeof(Assets.CPage));

            }
            else if (D.IsSelected)
            {
                Myframe.Navigate(typeof(Assets.DPage));

            }
            else if (E.IsSelected)
            {
                Myframe.Navigate(typeof(Assets.EPage));

            }
            else if (F.IsSelected)
            {
                Myframe.Navigate(typeof(Assets.FPage));

            }
        }
    }
}
