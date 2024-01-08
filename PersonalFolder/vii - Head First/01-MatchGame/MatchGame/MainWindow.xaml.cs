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
using System.Windows.Threading;

namespace MatchGame
{
    public partial class MainWindow : Window
    {
        // variables Timer
        DispatcherTimer timer = new DispatcherTimer();
        int tenthsOfSecondsElapsed;
        int matchesFound;

        // variables Random
        Random random = new Random();

        // variables pareja
        TextBlock lastTextBlockClicked;
        bool findingMatch = false;


        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;

            CreateGame();
        }


        public void CreateGame()
        {
            // Creacion Lista de parejas
            List<string> listPairs = new List<string>()
            {
                "👩","👩",
                "👨","👨",
                "🧑","🧑",
                "👧","👧",
                "👼","👼",
                "👱‍♀️","👱‍♀️",
                "👨‍🦱","👨‍🦱",
                "👸","👸"
            };

            // Distribucion de parejas en el tablero
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    textBlock.Visibility = Visibility.Visible;
                    int index = random.Next(listPairs.Count);
                    string nextPair = listPairs[index];
                    textBlock.Text = nextPair;
                    listPairs.RemoveAt(index);
                }
            }

            // Inicio del juego
            timer.Start();
            tenthsOfSecondsElapsed = 0;
            matchesFound = 0;
        }


        // Funcionamiento del botón del ratón
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {          
            TextBlock textBlock = sender as TextBlock;

            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }


        // Temporizador
        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;
            timeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchesFound == 8)
            {
                timer.Stop();
                timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
            }
        }


        // Reinicio del juego
        private void timeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                CreateGame();
            }
        }
    }
}
