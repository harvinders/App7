using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using App7.ViewModels;
using App7.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainViewModel ViewModel
        {
            get;
            set;
        }

        public MainPage()
        {
            Trace.WriteLine($"MainPage()");
            InitializeComponent();
            ViewModel = new MainViewModel();
        }

        ~MainPage()
        {
            Trace.WriteLine($"~MainPage");
        }

        private void ItemsRepeater_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var clickedElement = (e.OriginalSource as UIElement);

            var newsView = clickedElement.GetFirstAncestorOfType<NewsView>();
            if (null == newsView)
                return;
            this.Frame.Navigate(typeof(DetailsPage), newsView.ViewModel.Name);

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
