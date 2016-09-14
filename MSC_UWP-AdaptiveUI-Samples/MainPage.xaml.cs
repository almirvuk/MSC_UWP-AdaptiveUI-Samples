﻿using MSC_UWP_AdaptiveUI_Samples.Views;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MSC_UWP_AdaptiveUI_Samples
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ContactForm_Navigate(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(ContactForm));
        }

        private void SplitView_Navigate(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(SplitViewPage));
        }

        private void RelativePanel_Navigate(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(RelativePanelPage));
        }

        private void Pivot_Navigate(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(PivotPage));
        }
    }
}
