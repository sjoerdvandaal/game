using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace game
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

        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 naam_invoeren = new Window1();
            naam_invoeren.Visibility = Visibility.Visible;
        }

        private void High_Scores_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Settings_Button_Click(object sender, RoutedEventArgs e)
        {
            var settings = new SettingsWindow
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.Manual,
                WindowState = this.WindowState // StartPage imitate
            };

            
            if (this.WindowState != WindowState.Maximized)
            {
                settings.Width = this.Width;
                settings.Height = this.Height;
                settings.Left = this.Left;
                settings.Top = this.Top;
            }

            settings.ShowDialog();
        }




        private void Quit_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}