using System;
using System.Windows;
using System.Windows.Media;

namespace game
{
    public partial class App : Application
    {
        public static MediaPlayer BackgroundMusic;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            BackgroundMusic = new MediaPlayer();
            BackgroundMusic.Open(new Uri("Audio/AudioGame.mp3", UriKind.Relative));
            BackgroundMusic.Volume = 1.0;

            BackgroundMusic.MediaEnded += (s, args) =>
            {
                BackgroundMusic.Position = TimeSpan.Zero;
                BackgroundMusic.Play();
            };

            BackgroundMusic.Play(); // start music
        }
    }
}
