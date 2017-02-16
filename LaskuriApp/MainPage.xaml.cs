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

namespace LaskuriApp
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

        private void eurotextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value = double.Parse(eurotextBox.Text);
            value = value * 5.94573;
            markkatextBox.Text = value.ToString("0.00");
        }

        private void markkatextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value = double.Parse(markkatextBox.Text);
            value = value / 5.94573;
            eurotextBox.Text = value.ToString("0.00");
        }
    }
}
