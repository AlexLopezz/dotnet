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

namespace MultimediaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openFileDialog;
        public MainWindow()
        {
            InitializeComponent();
            meMedia.LoadedBehavior = MediaState.Manual;
            openFileDialog = new OpenFileDialog();
            bttPlayPause.IsEnabled = false;
        }

        bool isPlaying() => bttPlayPause.Content.Equals("Play");
        void updateVolume(double volume)
        {
            double vol = Math.Round(volume * 100);
            tbVolume.Text = (vol).ToString();
        }
        bool CanAddSubstractVolume() => meMedia.Volume > 0 || meMedia.Volume < 1;

        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog.FileName = "Your path video here...";
            openFileDialog.Filter = "Only video (.mp4)|*.mp4";

            if(openFileDialog.ShowDialog() == true)
            {
                meMedia.Source = new Uri(openFileDialog.FileName);
                bttPlayPause.IsEnabled = true;
                updateVolume(meMedia.Volume);
                meMedia.Play();
            }
        }
        private void mnuClose_Click(object sender, RoutedEventArgs e) => this.Close();
        private void bttPlayPause_Click(object sender, RoutedEventArgs e)
        {
            if (isPlaying())
            {
                bttPlayPause.Content = "Pause";
                meMedia.Pause();
            }
            else
            {
                bttPlayPause.Content = "Play";
                meMedia.Play();
            }
        }
        private void bttBack_Click(object sender, RoutedEventArgs e) => meMedia.Position -= TimeSpan.FromSeconds(10);
        private void bttStop_Click(object sender, RoutedEventArgs e)  => meMedia.Stop();
        private void bttForward_Click(object sender, RoutedEventArgs e) => meMedia.Position += TimeSpan.FromSeconds(10);
        private void bttMuted_Click(object sender, RoutedEventArgs e) => meMedia.IsMuted = meMedia.IsMuted ? false : true;
        private void bttSubstractVolume_Click(object sender, RoutedEventArgs e)
        {
            bttSubstractVolume.IsEnabled = double.Parse(tbVolume.Text) > 0;
            if (CanAddSubstractVolume())
            {
                meMedia.Volume-=0.1;
                updateVolume(meMedia.Volume);
            } 
        }
        private void bttAddVolume_Click(object sender, RoutedEventArgs e)
        {
            bttAddVolume.IsEnabled = int.Parse(tbVolume.Text) < 100;
            if (CanAddSubstractVolume())
            {
                meMedia.Volume+=0.1;
                updateVolume(meMedia.Volume);
            }
        }
    }
}
