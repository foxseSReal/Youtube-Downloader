using System.Windows;
using System.Windows.Input;

namespace Downloader
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

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            /*Burada DoubleClick ile Muzik oynatilacak*/


        }

        private void Convert_ButtonClick(object sender, RoutedEventArgs e)
        {
                
            if (ConvertToComboBox.SelectedValue == null) MessageBox.Show("Lütfen Dönüştürmek İstediğiniz Formatı Seçiniz", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);

            else
            {

            }
        }
    }
}