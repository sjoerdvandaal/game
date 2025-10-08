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
using System.Windows.Shapes;

namespace game
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private string _playerName;

        public GameWindow(string playerName)
        {
            InitializeComponent();
            _playerName = playerName;
            PlayerNameTextBlock.Text = playerName;
        }


        private void GameWindow_Back_Button_Click(object sender, RoutedEventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }

        private void GameWindow_Finnish_Game_Button_Click(object sender, RoutedEventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }

    }
}
