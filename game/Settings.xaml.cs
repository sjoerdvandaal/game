using System.Windows;

namespace game
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MusicOnButton_Click(object sender, RoutedEventArgs e)
        {
            App.BackgroundMusic.Play();
        }

        private void MusicOffButton_Click(object sender, RoutedEventArgs e)
        {
            App.BackgroundMusic.Pause();
        }

        private void VolumeOnButton_Click(object sender, RoutedEventArgs e)
        {
            // Volume not finished
        }

        private void VolumeOffButton_Click(object sender, RoutedEventArgs e)
        {
            // Volume not finished
        }
    }
}
