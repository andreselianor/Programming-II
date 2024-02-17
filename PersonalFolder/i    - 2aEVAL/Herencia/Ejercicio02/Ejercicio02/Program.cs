namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Ecos");

            Fauna fauna1 = new Fauna();
            Flora flora1 = new Flora();
            fauna1.Duel();
            flora1.Duel();

            Ecosystem flora2 = new Flora(9.0);
            flora2.Duel();

            Ecosystem fauna2 = new Fauna("Marimorena", AnimalType.CANIS, "Profesional");
            fauna2.Duel();
        }
    }
}