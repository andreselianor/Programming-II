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
        private double _distance = 500.0;

        GlamourCar carGlamour = new GlamourCar();
        PierreCar carPierre = new PierreCar();
        TroglodyteCar carTroglodyte = new TroglodyteCar();
        WoodCar carWood = new WoodCar();


        public MainWindow()
        {
            InitializeComponent();

            IRace game = new Race();
            game.StartRace(_distance);

            PaintCars();
        }


        public void PaintVisuals()
        {
            // Codigo para pintar la linea de la carrera
            /*
            AlternativeRaceLength.X1 = 0;
            AlternativeRaceLength.X2 = _distance;

            AlternativeRaceLength.VerticalAlignment = VerticalAlignment.Center;
            AlternativeRaceLength.StrokeThickness = 5;           

            SolidColorBrush LineBrush = new SolidColorBrush();
            LineBrush.Color = Color.FromArgb(255, 0, 0, 0);
            AlternativeRaceLength.Stroke = LineBrush;
            */
            if (carGlamour.Position < 500)
                Canvas.SetLeft(GlamourPortrait, carGlamour.Position);
            else
                Canvas.SetLeft(GlamourPortrait, 500);
        }

        public void PaintCars()
        {
            PaintGlamourCar();
            PaintPierreCar();
            PaintTroglodyteCar();
            PaintWoodCar();

            PaintVisuals();

            PaintWinners();

        }

        public void PaintGlamourCar()
        {
            if (carGlamour.Position < 500)
                Canvas.SetLeft(GlamourCarVisual, carGlamour.Position);
            else
                Canvas.SetLeft(GlamourCarVisual, 500);

            //GlamourCarVisual.Width = 30.0;
            //GlamourCarVisual.Height = 30.0;
            //Canvas.SetBottom(GlamourCarVisual, canvas1.Height);
            //SolidColorBrush car1Brush = new SolidColorBrush();
            //car1Brush.Color = Color.FromArgb(255, 255, 255, 0);
            //GlamourCarVisual.Fill = car1Brush;
        }

        public void PaintPierreCar()
        {
            if (carPierre.Position < 500)
                Canvas.SetLeft(PierreCarVisual, carPierre.Position);
            else
                Canvas.SetLeft(PierreCarVisual, 500);
        }

        public void PaintTroglodyteCar()
        {
            if (carTroglodyte.Position < 500)
                Canvas.SetLeft(TroglodyteCarVisual, carTroglodyte.Position);
            else
                Canvas.SetLeft(TroglodyteCarVisual, 500);
        }

        public void PaintWoodCar()
        {
            if (carWood.Position < 500)
                Canvas.SetLeft(WoodCarVisual, carWood.Position);
            else
                Canvas.SetLeft(WoodCarVisual, 500);
        }

        public void PaintWinners()
        {
            if (carGlamour.Position > 500.0)
            {
                position1.Visibility = Visibility.Visible;
                finish.Visibility = Visibility.Visible;
                Grid.SetRow(position1, 1);
            }

            if (carPierre.Position > 500.0)
            {
                position2.Visibility = Visibility.Visible;
                Grid.SetRow(position2, 0);
            }

            if (carWood.Position > 500.0)
            {
                position3.Visibility = Visibility.Visible;
                Grid.SetRow(position3, 3);
            }

            if (carTroglodyte.Position > 500.0)
            {
                position4.Visibility = Visibility.Visible;
                Grid.SetRow(position4, 4);
            }
        }

        public void DisplayText()
        {
            PierreText.Text = "Pierre avanza maldiciendo en idiomas incomprensibles";
            GlamourText.Text = "Penelope circula serena y segura por su carril a la velocidad recomendada";
            ForestCarText.Text = "Castor y Pollux circulan con firmeza mientras afilan su hacha de captura";
            TroglodyteText.Text = "Los trogloditas avanzan dando tumbos y golpeando cada una de sus cabezas con sus romas porras";
        }

        private void AdvanceClick(object sender, RoutedEventArgs e)
        {
            carGlamour.Simulate();
            carPierre.Simulate();
            carTroglodyte.Simulate();
            carWood.Simulate();
            PaintCars();
            DisplayText();
        }

        //public void PaintVisuals()
        //{
        //    // Codigo para pintar la linea de la carrera           
        //    AlternativeRaceLength.X1 = 0;
        //    AlternativeRaceLength.X2 = _distance;

        //    AlternativeRaceLength.VerticalAlignment = VerticalAlignment.Center;
        //    AlternativeRaceLength.StrokeThickness = 5;           

        //    SolidColorBrush LineBrush = new SolidColorBrush();
        //    LineBrush.Color = Color.FromArgb(255, 0, 0, 0);
        //    AlternativeRaceLength.Stroke = LineBrush;            
        //}
    }
}