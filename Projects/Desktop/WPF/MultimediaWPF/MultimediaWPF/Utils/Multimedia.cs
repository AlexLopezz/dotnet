using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MultimediaWPF.Utils
{
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

        public void Play()
        {
            Media.Play();
            StatusMedia = Reproductor.PLAY.ToString();
        }
        public void Pause()
        {
            Media.Pause();
            StatusMedia = Reproductor.PAUSE.ToString();
        }
        public void Stop()
        {
            Media.Stop();
            StatusMedia = Reproductor.PLAY.ToString();
        }
        public void ForwardMedia() => Media.Position+= TimeSpan.FromSeconds(10);
        public void BackMedia() => Media.Position-= TimeSpan.FromSeconds(10);
        public void TurnDownVolume() => Media.Volume -= 0.1;
        public void TurnUpVolume() => Media.Volume += 0.1;
        public double GetVolume() => Media.Volume;
        public string ChangeStatusMedia()
        {
            StatusMedia = StatusMedia.Equals(Reproductor.PLAY.ToString()) ?
                                                                            Reproductor.PAUSE.ToString() :
                                                                            StatusMedia;
            return StatusMedia;
        }
        public bool IsPlaying() => StatusMedia.Equals(Reproductor.PLAY.ToString());


    }
}
