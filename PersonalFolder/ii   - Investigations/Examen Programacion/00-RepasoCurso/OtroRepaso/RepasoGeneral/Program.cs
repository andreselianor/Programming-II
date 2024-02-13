namespace RepasoGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entidad e1 = new Person();
            //Person p1 = new Entity();
            Entidad e2 = new Person();
            Entidad e3 = new Person(5);
            Person p1 = new Person();
            Person p2 = new Person("Arevalo");
            Person p3 = new Person("Jordi", 5);
            Entidad e4 = new Student();

            Student s1 = new Student();

            int result1 = e1.FunctionNumber1(2);
            int result2 = p1.FunctionNumber1(2);
            int result3 = s1.FunctionNumber1(2);

            Entidad e5 = new Person();

            int result4 = e5.FunctionNumber1(2);
            int result5 = p1.FunctionNumber1(2);
            int result6 = s1.FunctionNumber1(2);



            int result7 = e1.FunctionNumber2(2);
            int result8 = p1.FunctionNumber2(2);
            int result9 = s1.FunctionNumber2(2);


            int result10 = e5.FunctionNumber2(2);
            int result11 = p1.FunctionNumber2(2);
            int result12 = s1.FunctionNumber2(2);

            ISchool escuela = new Person();

            int result13 = s1.GetInterface(escuela);
        }
    }
}