﻿namespace ExamenBlueprint
{
    public interface IShape
    {
        string Name { get; set; }
        Color Color { get; set; }
        bool HasArea { get; }
        double Area { get; }
        double Perimeter { get; }
        Point2D Center { get; }

        Rect2D Rect()
        {
            Rect2D rect = new Rect2D();
            return rect;
        }

        void Draw(ICanvas canvas);
    }
}