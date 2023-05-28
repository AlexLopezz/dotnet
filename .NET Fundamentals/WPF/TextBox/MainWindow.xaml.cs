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

namespace TextBox
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
            txbMessage = txbMessageSend.Text;
        }
        private void bttSend_Click(object sender, RoutedEventArgs e)
        {
            string message = !string.IsNullOrEmpty(txtName.Text) ? $"Usuario: {txtName.Text}\nMensaje: {txtMessage.Text}"
                                                                : $"Mensaje: {txtMessage.Text}";
            if(!string.IsNullOrEmpty(txtMessage.Text)) txbMessageSend.Text = message;
        }

        private void bttClear_Click(object sender, RoutedEventArgs e)
        {
           txtName.Text = string.Empty;
           txtMessage.Text = string.Empty;
           txbMessageSend.Text = txbMessage;
        }

        private void bttSelect_Click(object sender, RoutedEventArgs e)
        {
            string seleccionado = txtMessage.SelectedText;
            txbMessageSend.Text = seleccionado;
        }
    }
}
