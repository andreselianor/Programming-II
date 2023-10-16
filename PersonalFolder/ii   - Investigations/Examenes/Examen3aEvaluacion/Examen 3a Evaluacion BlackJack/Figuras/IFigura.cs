namespace Figuras
{
    public interface IFigura
    {
        void AddFigure(Figura figureName);
        void RemoveFigureIndex(int index);
        void RemoveFigureName(Figura figureName);
        int GetNumberFigure();
        Figura GetFigureAt(int index);
    }
}
