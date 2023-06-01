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

namespace PasswordBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string user, pass;
        public MainWindow()
        {
            InitializeComponent();
            user = "ADMIN";
            pass = "ADMIN";
        }

        private void bttSignIn_Click(object sender, RoutedEventArgs e)
        {
            if(!(string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(txtPassword.Password))){
                if (user.Equals(txtUser.Text))
                {
                    if (pass.Equals(txtPassword.Password))
                    {
                        MessageBox.Show("Inicio de sesion exitoso.");
                        txtPassword.Password = string.Empty;
                        txtUser.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto.");
                }
            }
            else
            {
                MessageBox.Show("No puede iniciar sesion, sino ingresa texto...");
            }
        }
    }
}
