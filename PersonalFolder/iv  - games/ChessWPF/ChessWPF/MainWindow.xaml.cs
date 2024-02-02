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

            PaintChess();
            SetRectangle();
        }

        public void CreateBoard()
        {
            board = new int[9, 9];
        }

        public void SetRectangle()
        {
            Grid.SetColumn(prototype,3);
            Grid.SetRow(prototype, 5);
        }
        
        public void PaintChess()
        {
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255,200, 180, 200);
            prototype.Fill = mySolidColorBrush;
        }        
    }
}
