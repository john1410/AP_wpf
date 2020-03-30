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
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for InputForm.xaml
    /// </summary>
    public partial class InputForm : Page
    {
        
        public InputForm()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)(sender);
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }


        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow.inputform = this;
            tabctr.SelectedIndex = 1;
            this.NavigationService.Navigate(MainWindow.home);
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
            }

        }
    }
}
