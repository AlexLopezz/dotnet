﻿using System;
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

namespace MenuContextWPF
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

        private void cmnuPToCm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double result = Conversor.InchesToCm(double.Parse(txtExample.Text));
                MessageBox.Show($"El resultado es: {result}");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores validos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cmnuCmToP_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double result = Conversor.CmToInches(double.Parse(txtExample.Text));
                MessageBox.Show($"El resultado es: {result}");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese valores validos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
