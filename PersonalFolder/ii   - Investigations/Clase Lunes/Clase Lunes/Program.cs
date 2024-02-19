namespace Clase_Lunes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("pepito", 25);
            Person s3 = new Student();
            Person s4 = new Student("Josefo", 15);
            Person s5 = new Student("Contrario", 100);

            s1 = s2;
            s4 = s2;
            s5 = s2;
        }
    }
}