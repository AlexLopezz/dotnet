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

namespace AccessKey
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

        private void bttOpen_Click(object sender, RoutedEventArgs e)
        {
            txtMessage.Text = "Escribiendo...";
        }

        private void bttClear_Click(object sender, RoutedEventArgs e)
        {
            txtMessage.Text = string.Empty;
        }

        private void bttClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
