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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MSC_UWP_AdaptiveUI_Samples.Views {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplitViewPage : Page {
        public SplitViewPage() {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e) {

            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void Item1_Click(object sender, RoutedEventArgs e) {

            this.myFrame.Navigate(typeof(View1));
        }

        private void Item2_Click(object sender, RoutedEventArgs e) {

            this.myFrame.Navigate(typeof(View2));
        }

        private void Item3_Click(object sender, RoutedEventArgs e) {

            this.myFrame.Navigate(typeof(View3));
        }
    }
}
