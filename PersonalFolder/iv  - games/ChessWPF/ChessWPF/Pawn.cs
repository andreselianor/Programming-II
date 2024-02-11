using System.Windows.Documents;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System;

namespace ChessWPF
{
    public class Pawn : Figure
    {       
        public Pawn(Position position, Color color)
        {
            _figureType = FigureType.PAWN;
            _color = color;
            _position = position;
        }

        public override void PaintFigure(Grid grid)
        {
            if(_color == Color.WHITE)
            {
                Image pawnImage = new Image();
                pawnImage.Source = new BitmapImage(new Uri("resources/whitePawn.png", UriKind.Relative));

                Grid.SetRow(pawnImage, _position.X);
                Grid.SetColumn(pawnImage, _position.Y);

                grid.Children.Add(pawnImage);
            }

            if (_color == Color.RED)
            {
                Image pawnImage = new Image();
                pawnImage.Source = new BitmapImage(new Uri("resources/redPawn.png", UriKind.Relative));

                Grid.SetRow(pawnImage, _position.X);
                Grid.SetColumn(pawnImage, _position.Y);

                grid.Children.Add(pawnImage);
            }
        }
    }
}