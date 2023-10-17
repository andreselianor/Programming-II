namespace Figuras
{
    abstract public class Planas : Figura
    {
        public Planas(string nombre) : base(nombre)
        {

        }

        abstract public void CalculateArea();
    }
}
