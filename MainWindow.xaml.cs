using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FHeinePersonligProfil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CV_Click(object sender, RoutedEventArgs e)
        {
            // Opens CV 
            WebView.Source = new Uri("https://job.jobnet.dk/CV/Frontpage?pageId=901#a5790b9f-9bd7-4079-b7c5-2e03efa2231a");
        }
        private void Pic1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Show the WebView
                WebView.Visibility = Visibility.Visible;

                // Hide the ContentArea
                ContentArea.Visibility = Visibility.Collapsed;

                // Opens the source 'Github'
                WebView.Source = new Uri("https://github.com/frederikwael/BinaryConverter.git");
            }
            catch (Exception ex) 
                // Error if the link don't work
                MessageBox.Show($"Failed to read link: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Pic2_Click2(object sender, RoutedEventArgs e)
        {
            try
            {
                // Content visibility
                WebView.Visibility = Visibility.Visible;
                ContentArea.Visibility = Visibility.Collapsed;
               

                // Opens the source 'X'
                WebView.Source = new Uri("https://x.com/xfreddio");
                
                // Opens the source 'Facebook'
                WebView.Source = new Uri("https://www.facebook.com/frederikwael?locale=da_DK");
            }
            catch (Exception ex)
                // Error if the link don't work
                MessageBox.Show($"Failed to read link: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
    }
}
