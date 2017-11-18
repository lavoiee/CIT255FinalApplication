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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CIT255_UWP_Final_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CurrencyPairsPage : Page
    {
        public CurrencyPairsPage()
        {
            this.InitializeComponent();
        }
        private void Exchanges_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ExchangesPage));
        }

        private void Currency_Pairs_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CurrencyPairsPage));
        }

        private void Trends_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TrendsPage));
        }

        private void Charts_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ChartsPage));
        }

        private void HeatMap_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HeatMapPage));
        }
    }
}
