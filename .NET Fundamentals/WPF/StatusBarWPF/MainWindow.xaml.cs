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

namespace StatusBarWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string countWords, countCharacters;
        public MainWindow()
        {
            InitializeComponent();
            countCharacters = txtCaracteres.Text;
            countWords = txtPalabras.Text;
        }

        private void txtNotePad_KeyDown(object sender, KeyEventArgs e)
        {
            int countC = txtNotePad.Text.Length + 1;
            string[] words = txtNotePad.Text.Split(" ");
            int countW = words.Length;

            txtCaracteres.Text = countCharacters + countC;
            txtPalabras.Text = countWords + countW;
        }
    }
}
