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

namespace MatchGame
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            CreateGame();
        }

        public void CreateGame()
        {
            List<string> listPairs = new List<string>()
            {
                "👩","👩",
                "👨","👨",
                "🧑","🧑",
                "👧","👧",
                "👼","👼",
                "👩‍🦰","👩‍",
                "👨‍🦱","👨‍🦱",
                "👸","👸"               
            };

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(listPairs.Count);
                string nextPair = listPairs[index];
                textBlock.Text = nextPair;
                listPairs.RemoveAt(index);
            }
        }
    }
}
