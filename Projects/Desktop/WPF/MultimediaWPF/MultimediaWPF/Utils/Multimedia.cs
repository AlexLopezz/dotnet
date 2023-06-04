using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MultimediaWPF.Utils
{
    /*
     * Esta clase es la encargada de manipular el control MediaElement 
     * que se encuentra en la interfaz grafica.
     */ 
    public class Multimedia
    {
        public MediaElement Media { get; set; }
        public string StatusMedia { get; set; }
        public Multimedia(MediaElement Media)
        {
            this.Media = Media;
            this.Media.LoadedBehavior = MediaState.Manual;
            this.StatusMedia = Reproductor.PLAY.ToString();
        }
        public void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Your path video here...";
            openFileDialog.Filter = "Only video (.mp4)|*.mp4";

            if (openFileDialog.ShowDialog() == true)
            {
                Media.Source = new Uri(openFileDialog.FileName);
                this.Play();
            }
        }
        public void Play()
        {
            Media.Play();
            StatusMedia = Reproductor.PAUSE.ToString();
        }
        public void Pause()
        {
            Media.Pause();
            StatusMedia = Reproductor.PLAY.ToString();
        }
        public void Stop()
        {
            Media.Stop();
            StatusMedia = Reproductor.REPLAY.ToString();
        }
        public void Muted() => this.Media.IsMuted = true;
        public void UnMuted() => this.Media.IsMuted = false;
        public void ForwardMedia() => Media.Position+= TimeSpan.FromSeconds(10);
        public void BackMedia() => Media.Position-= TimeSpan.FromSeconds(10);
        public void TurnDownVolume() => Media.Volume -= 0.1;
        public void TurnUpVolume() => Media.Volume += 0.1;
        public double GetVolume() => Media.Volume;
        public bool HasSource() => this.Media.Source != null;
        public bool IsPlaying() => StatusMedia.Equals(Reproductor.PAUSE.ToString());
    }
}
