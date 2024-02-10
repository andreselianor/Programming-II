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


            PaintVisuals();
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
        }

        public void PaintCars()
        {
            PaintGlamourCar();
            PaintPierreCar();
            PaintTroglodyteCar();
            PaintWoodCar();
        }

        public void PaintGlamourCar()
        {
            //GlamourCarVisual.Width = 30.0;
            //GlamourCarVisual.Height = 30.0;          
            
            Canvas.SetLeft(GlamourCarVisual, carGlamour.Position);
            //Canvas.SetBottom(GlamourCarVisual, canvas1.Height);

            //SolidColorBrush car1Brush = new SolidColorBrush();
            //car1Brush.Color = Color.FromArgb(255, 255, 255, 0);
            //GlamourCarVisual.Fill = car1Brush;
        }

        public void PaintPierreCar()
        {
            Canvas.SetLeft(PierreCarVisual, carPierre.Position);
        }

        public void PaintTroglodyteCar()
        {
            Canvas.SetLeft(TroglodyteCarVisual, carTroglodyte.Position);
        }

        public void PaintWoodCar()
        {
            Canvas.SetLeft(WoodCarVisual, carWood.Position);
        }

        public void DisplayText()
        {
            PierreText.Text = "Pierre avanza maldiciendo en idiomas incomprensibles";
            GlamourText.Text = "Penelope circula serena y segura por su carril a la velocidad recomendada";
        }

        private void AdvanceClick(object sender, RoutedEventArgs e)
        {
            carGlamour.Simulate();
            carPierre.Simulate();
            carTroglodyte.Simulate();
            carWood.Simulate();
            PaintCars();
            DisplayText();
            Class
        }
    }
}