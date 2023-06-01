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

namespace MessageBoxWPF
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

        private void bttMessage_Click(object sender, RoutedEventArgs e)
        {
            /*
            //Solo mensaje
            MessageBox.Show("Mensaje de bienvenida");
            //Mensaje con un titulo
            MessageBox.Show("Hola como estas?", "Saludo");

            //Tambien se pueden colocar botones extras: OK, OK-Cancel, Yes-No-Cancel, Yes-No
            MessageBox.Show("Elija algunas de las opciones disponibles", "Elija una respuesta", MessageBoxButton.OK); //Por defecto, viene con el boton de OK. (Si no especificamos el boton)
            MessageBox.Show("Elija algunas de las opciones disponibles", "Elija una respuesta", MessageBoxButton.OKCancel);
            MessageBox.Show("Elija algunas de las opciones disponibles", "Elija una respuesta", MessageBoxButton.YesNoCancel);
            MessageBox.Show("Elija algunas de las opciones disponibles", "Elija una respuesta", MessageBoxButton.YesNo);
            */
            //Tambien podemos realizar un boton con una imagen en especifico: Asterisk, Error, Hand, Information, None, Question, Stop, Warning
            MessageBox.Show("", "Titulo", MessageBoxButton.OK, MessageBoxImage.Asterisk); // Funciona como una ventana de informacion
            MessageBox.Show("", "Titulo", MessageBoxButton.OK, MessageBoxImage.Error); // Funciona como una ventana de error
            MessageBox.Show("", "Titulo", MessageBoxButton.OK, MessageBoxImage.Hand); // Funciona como una ventana de error
            MessageBox.Show("", "Titulo", MessageBoxButton.OK, MessageBoxImage.Information); // Funciona como una ventana de informacion
            MessageBox.Show("", "Titulo", MessageBoxButton.OK, MessageBoxImage.None); // Funciona como una ventana tradicional.
            MessageBox.Show("", "Titulo", MessageBoxButton.OK, MessageBoxImage.Question); // Funciona como una ventana de informacion
            MessageBox.Show("", "Titulo", MessageBoxButton.OK, MessageBoxImage.Stop); // Funciona como una ventana de error
            MessageBox.Show("", "Titulo", MessageBoxButton.OK, MessageBoxImage.Warning); // Funciona como una ventana de precaucion


            //Mensaje con boton preseleccionado por defecto: Si tocamos enter, se tomara el boton preseleccionado:
            MessageBox.Show("Ventana con boton por defecto", "Titulo", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.Yes); //
        }
    }
}
