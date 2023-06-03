using Microsoft.Win32;
using MultimediaWPF.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        Multimedia multimedia;
        public MainWindow()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            EnabledButtons(false);
            LoadMedia();
        }
        void LoadMedia()
        {
            multimedia = new Multimedia(meMedia);
            bttPlayPause.Content = multimedia.StatusMedia;
        }
        void EnabledButtons(bool hasSourceMedia)
        {
            bttAddVolume.IsEnabled = hasSourceMedia;
            bttSubstractVolume.IsEnabled = hasSourceMedia;
            bttPlayPause.IsEnabled = hasSourceMedia;
            bttMuted.IsEnabled = hasSourceMedia;
            bttForward.IsEnabled = hasSourceMedia;
            bttBack.IsEnabled = hasSourceMedia;
            bttStop.IsEnabled = hasSourceMedia;
        }
        void UpdateVolume(double volume)
        {
            double vol = Math.Round(volume * 100);
            tbVolume.Text = (vol).ToString();
        }
        void UpdateStatusMedia() => bttPlayPause.Content = multimedia.StatusMedia;

        int getCurrentVolume() => int.Parse(tbVolume.Text);
        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog.FileName = "Your path video here...";
            openFileDialog.Filter = "Only video (.mp4)|*.mp4";

            if(openFileDialog.ShowDialog() == true)
            {
                meMedia.Source = new Uri(openFileDialog.FileName);
                EnabledButtons(true);
                UpdateVolume(meMedia.Volume);
                meMedia.Play();
            }
        }
        private void mnuClose_Click(object sender, RoutedEventArgs e) => this.Close();
        private void bttPlayPause_Click(object sender, RoutedEventArgs e)
        {
            if (multimedia.IsPlaying())
            {
                multimedia.Pause();
                UpdateStatusMedia();
            }
            else
            {
                multimedia.Play();
                UpdateStatusMedia();
            }
            multimedia.Media.Opacity = 100;
        }
        private void bttBack_Click(object sender, RoutedEventArgs e) => multimedia.BackMedia();
        private void bttStop_Click(object sender, RoutedEventArgs e)
        {
            multimedia.Stop();
            UpdateStatusMedia();
            multimedia.Media.Opacity = 0;
        }
        private void bttForward_Click(object sender, RoutedEventArgs e) => multimedia.ForwardMedia();
        private void bttMuted_Click(object sender, RoutedEventArgs e)
        {
            meMedia.IsMuted = meMedia.IsMuted ? false : true;
            stStatusMuted.Foreground = meMedia.IsMuted ? Brushes.Red : Brushes.Gray;
        }
        private void bttSubstractVolume_Click(object sender, RoutedEventArgs e)
        {
            if (getCurrentVolume() != 0)
            {
                multimedia.TurnDownVolume();
                UpdateVolume(multimedia.GetVolume());
            } 
        }
        private void bttAddVolume_Click(object sender, RoutedEventArgs e)
        {
            if(getCurrentVolume() != 100)
            {
                multimedia.TurnUpVolume();
                UpdateVolume(multimedia.GetVolume());
            }
        }
        private void mnuAbout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
