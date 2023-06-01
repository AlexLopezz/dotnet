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

namespace ToolBarWPF
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

        private void btt1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Es hora de ir de compras!!!");
        }

        private void btt2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Es hora de levantarse!!!");
        }

        private void btt3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Es hora de jugar a tus apps!");
        }

        private void btt4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tocaste a Luffy, el papasito!");
        }
    }
}
