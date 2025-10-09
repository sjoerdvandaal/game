using System.Collections.ObjectModel;
using System.Windows;

namespace Game1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Player> Players { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Players = new ObservableCollection<Player>
            {
                new Player { Name = "Alice", Score = 100 },
                new Player { Name = "Bob", Score = 150 }
            };

            DataContext = this;
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}