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

namespace CheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string txbMessage;
        public MainWindow()
        {
            InitializeComponent();
            txbMessage = txbTotal.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCount.Text))
            {
                string message = $"Hay un total de {txtCount.Text} ";
                if (cbCebolla.IsChecked == true) message += "cebolla/s ";
                if (cbPapa.IsChecked == true) message += "papa/s ";
                if (cbTomate.IsChecked == true) message += "tomate/s";

                txbTotal.Text = message;
            }
            
        }
    }
}
