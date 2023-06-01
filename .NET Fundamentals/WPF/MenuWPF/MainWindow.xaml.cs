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

namespace MenuWPF
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

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mnuClear_Click(object sender, RoutedEventArgs e)
        {
            txtValue1.Text = string.Empty;
            txtValue2.Text = string.Empty;
            txtValue3.Text = string.Empty;
        }

        private void mnuSuma_Click(object sender, RoutedEventArgs e)
        {
            try {
                double suma = double.Parse(txtValue1.Text) + double.Parse(txtValue2.Text);
                txtValue3.Text = suma.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores validos para la operacion elegida.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void mnuResta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double resta = double.Parse(txtValue1.Text) - double.Parse(txtValue2.Text);
                txtValue3.Text = resta.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores validos para la operacion elegida.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void mnuMulti_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double multi = double.Parse(txtValue1.Text) * double.Parse(txtValue2.Text);
                txtValue3.Text = multi.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores validos para la operacion elegida.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void mnuDiv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double div = double.Parse(txtValue1.Text) / double.Parse(txtValue2.Text);
                txtValue3.Text = div.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores validos para la operacion elegida.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
