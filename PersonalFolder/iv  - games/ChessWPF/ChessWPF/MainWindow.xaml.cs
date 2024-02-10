using ChessWPF.resources;
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
//using static System.Net.Mime.MediaTypeNames;

namespace ChessWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[,] board;
        public MainWindow()
        {
            InitializeComponent();

            CreateBoard();

            //PaintBoard();
        }

        public void CreateBoard()
        {
            board = new int[9, 9];
            Pawn pawn1 = new Pawn(7, 6);

            PaintPieces(pawn1);            
        }

        public void PaintPieces(Pawn pieces)
        {
            Image pawn1Image = new Image();
            pawn1Image.Source = new BitmapImage(new Uri("resources/redPawn.png", UriKind.Relative));

            Grid.SetRow(pawn1Image, pieces._xPosition);
            Grid.SetColumn(pawn1Image, pieces._yPosition);

            gridBoard.Children.Add(pawn1Image);
        }

        public void PaintBoard()
        {
            SolidColorBrush checkerColor = new SolidColorBrush();
            checkerColor.Color = Color.FromArgb(255, 200, 180, 200);

            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j +=2 )
                {
                    if (i % 2 == 0)
                    {
                        Rectangle r1 = new Rectangle();
                        r1.Fill = checkerColor;

                        Grid.SetRow(r1, i);
                        Grid.SetColumn(r1, j);

                        gridBoard.Children.Add(r1);
                    }
                    else
                    {                        
                        Rectangle r1 = new Rectangle();
                        r1.Fill = checkerColor;

                        Grid.SetRow(r1, i);
                        Grid.SetColumn(r1, j + 1);

                        gridBoard.Children.Add(r1);                                              
                    }
                }
            }
        }

        public void PaintAvailableMovements()
        {
            SolidColorBrush availableMovements = new SolidColorBrush();
            availableMovements.Color = Color.FromArgb(255, 200, 230, 200);

        }

        private void WhitePawnA_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PaintAvailableMovements();
        }
    }
}
