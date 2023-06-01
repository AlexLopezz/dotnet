using Microsoft.Win32;
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

namespace Image
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

        private void bttChargeImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image files (*.png/*.jpg)|*.png;*.jpg";

            if(openFile.ShowDialog() == true)
            {
                //Creamos una uri, con el path que nos indica el usuario al elegir la imagen:
                Uri uri = new Uri(openFile.FileName);
                //Establecemos a el source de la imagen, el path pero atraves de un Bitmap:
                imgImage.Source = new BitmapImage(uri);
            }
        }
    }
}
