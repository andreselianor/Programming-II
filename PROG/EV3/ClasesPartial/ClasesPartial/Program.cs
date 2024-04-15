using System.Threading.Channels;

namespace ClasesPartial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student test1 = new Student();
            test1.TestA();
            test1.TestB();

            /* TODO
             * 
             * clases static
             * */
        }
    }

    public partial class Student
    {
        public void TestA()
        {
            Console.WriteLine("Esta es la definicion de la clase parcial numero 1");
        }
    }

    public partial class Student
    {
        public void TestB()
        {
            Console.WriteLine("Esta es la segunda parte de la clase parcial student");
        }
    }
}