using MultimediaWPF.Utils;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;

namespace MultimediaWPF
{
    /// <summary>
    /// Interaction logic for MultimediaGUI.xaml
    /// </summary>
    public partial class MultimediaGUI : Window
    {
        #region VARIABLES
        Multimedia multimedia;
        #endregion
        public MultimediaGUI()
        {
            InitializeComponent();
            EnabledButtons(false);
            multimedia = new Multimedia(meMedia);
        }
        #region UTILS
        /**
         * Habilitara los botones para manipular el video, dependiendo
         * del parametro booleano que recibe.
         */ 
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
        // Este metodo actualizara el volumen que vemos en la interfaz grafica.
        void UpdateVolume(double volume)
        {
            double vol = Math.Round(volume * 100);
            tbVolume.Text = (vol).ToString();
        }
        // Este metodo actualizara el contenido del boton Play/Pause en la interfaz grafica.
        void UpdateStatusMedia() => bttPlayPause.Content = multimedia.StatusMedia;
        //Este metodo obtendra el volumen actual, que se encuentra en la interfaz grafica.
        int getCurrentVolume() => int.Parse(tbVolume.Text);
        #endregion

        #region EVENTS
        /**
         * Este evento, abrira el archivo, .mp4 para su reproduccion
         * y ademas actualizara los botones y volumen correspondiente.
         */ 
        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            multimedia.Open();
            UpdateStatusMedia();
            EnabledButtons(true);
            UpdateVolume(multimedia.GetVolume());
        }
        /**
         * Este evento, como su nombre lo indica, cerrara la ventana y 
         * terminara la ejecucion del programa.
         */ 
        private void mnuClose_Click(object sender, RoutedEventArgs e) => this.Close();
        /*
         * Este evento, permitira redirigir al usuario al codigo fuente 
         * desarrollado por mi, siempre y cuando le dee al boton 'si'.
         */ 
        private void mnuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultMessageBox = MessageBox.Show("Creado por Alex Lopez, desea ver el codigo fuente en mi repositorio de GitHub?",
                                                                 "About my code!",
                                                                 MessageBoxButton.YesNo,
                                                                 MessageBoxImage.Question);

            if (resultMessageBox == MessageBoxResult.Yes)
            {
                string URLRepo = "https://github.com/AlexLopezz/DotNet/tree/main/Projects/Desktop/WPF/MultimediaWPF/MultimediaWPF";
                Process.Start(new ProcessStartInfo("cmd", $"/c start {URLRepo}") { CreateNoWindow = true });
            }
        }

        /*
         * Este evento es el encargado de manipular la reproduccion del video
         * es decir, reproducira y pondra pausa al video.
         */ 
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
        }
        /*
         * Este evento detendra la reproduccion del video, por lo cual
         * si le damos de nuevo al play, la reproduccion empezara de nuevo.
         */ 
        private void bttStop_Click(object sender, RoutedEventArgs e)
        {
            multimedia.Stop();
            UpdateStatusMedia();
        }
        /*
         * Este evento muteara/desmuteara el video dependiendo de si se encuentra
         * o no muteado.
         */ 
        private void bttMuted_Click(object sender, RoutedEventArgs e)
        {
            if (multimedia.Media.IsMuted) multimedia.UnMuted();
            else multimedia.Muted();

            stStatusMuted.Foreground = multimedia.Media.IsMuted ? Brushes.Red : Brushes.Gray;
        }
        //Este evento adelantara el video en un intervalo de 10 segundos. 
        private void bttForward_Click(object sender, RoutedEventArgs e) => multimedia.ForwardMedia();
        // Este evento retrocedera el video en un intervalo de 10 segundos.
        private void bttBack_Click(object sender, RoutedEventArgs e) => multimedia.BackMedia();
        //Este evento bajara el volumen de diez en diez hasta llegar a cero(0)
        private void bttSubstractVolume_Click(object sender, RoutedEventArgs e)
        {
            if (getCurrentVolume() > 0)
            {
                multimedia.TurnDownVolume();
                UpdateVolume(multimedia.GetVolume());
            }
        }
        //Este evento aumentara el volumen de diez en diez hasta llegar a cien(100).
        private void bttAddVolume_Click(object sender, RoutedEventArgs e)
        {
            if (getCurrentVolume() != 100)
            {
                multimedia.TurnUpVolume();
                UpdateVolume(multimedia.GetVolume());
            }
        }
        #endregion
    }
}
