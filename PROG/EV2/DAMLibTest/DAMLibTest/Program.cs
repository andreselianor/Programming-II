using DAMLib;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ItemSet<string> item1 = new ItemSet<string>();
            //ItemSet<string>.Item elemento1 = new ItemSet<string>.Item("Corretear",11);
            //int hash = elemento1.GetHashCode();
            Prueba<string> prueba1 = new Prueba<string>();
            prueba1.value = "Picapiedra";
            int number = prueba1.value.GetHashCode();
        }
    }

    public class Prueba<T>
    {
        public T value;
        public override int GetHashCode()
        {
            return 10;
            //return  133 * 533 * base.GetHashCode();
        }
    }
}