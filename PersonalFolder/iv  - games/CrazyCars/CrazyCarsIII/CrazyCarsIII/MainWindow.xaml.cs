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

namespace CrazyCarsIII
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _distance = 0.0;
        public MainWindow()
        {
            InitializeComponent();

            IRace game = new Race();
            game.StartRace(100);


            PaintRace();
            
            
        }

        public void PaintRace()
        {
            RaceLength.X1 = 0;
            RaceLength.X2 = 400;

            RaceLength.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(RaceLength, 2);
            Grid.SetRow(RaceLength, 1);
            Grid.SetRowSpan(RaceLength, 2);
            RaceLength.StrokeThickness = 10;

            SolidColorBrush raceLine = new SolidColorBrush();
            raceLine.Color = Color.FromArgb(255, 0, 0, 0);
            RaceLength.Stroke = raceLine;

            Car1.Width = 40.0;
            Car1.Height = 40.0;

            //Canvas canvas = new Canvas();
            //canvas1.Width = 100;
            //canvas1.Height = 100;
            Grid.SetColumn(canvas1, 2);
            Grid.SetRow(canvas1, 1);
            Grid.SetRowSpan(canvas1, 2);
            Canvas.SetLeft(Car1, _distance);
            Canvas.SetBottom(Car1,100);
            //Car1.VerticalAlignment = VerticalAlignment.Center;


            SolidColorBrush car1Map = new SolidColorBrush();
            car1Map.Color = Color.FromArgb(255, 255, 255, 0);
            Car1.Fill = car1Map;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _distance += 10;
            PaintRace();
        }
    }
}
