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

namespace Events
{
    /* El IDE nos crea automaticamente por nosotros.
     * Extiende de la clase Window.
     * Esta ventana es la principal de toda la aplicacion.
     * Desde aqui, nosotros podemos capturar los eventos y manipular los controles
     * en base a ello.
     * Tambien podemos definir recursos globales y estilos globales.
     */ 

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    //Esta clase es de tipo partial, lo cual indica que estara definida en diferentes documentos.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void bttClick1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Oprimiste el boton 1.");
        }
        private void bttClick2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Oprimiste el boton 2.");
        }

        
    }
}
