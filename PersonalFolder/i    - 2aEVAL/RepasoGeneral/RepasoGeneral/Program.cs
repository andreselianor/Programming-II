using RepasoGeneral.Jerarquia;

namespace RepasoGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* INHERITANCE
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
            */

            /* SWITCH
            FunctionSwitch function1 = new FunctionSwitch();
            function1.TestingSwitch1();
            function1.IntControl = 10;
            function1.TestingSwitch1();
            function1.IntControl = 1;
            function1.TestingSwitch1();

            string result = FunctionSwitchStatic.TestingSwitchStatic(10);
            string result2 = FunctionSwitchStatic.TestingSwitchStatic(2);
            string result3 = FunctionSwitchStatic.TestingSwitchStatic(-1);

            function1.TestingSwitch2();
            function1.TestingSwitch2();
            function1.TestingSwitch2();

            function1.StringControl = "SI";
            string result4 = function1.TestingSwitch3();
            */

            /* FOREACH
            Foreach functionForeach = new Foreach();

            functionForeach.CreateList();

            functionForeach.AddValuesToDictionary();
            functionForeach.Clear();
            functionForeach.AddValuesToDictionary2();
            functionForeach.DisplayDictionary();
            */

            /* RECURSIVE
            int result = RecursiveFunctionStatic.GetRecursiveSum(0);
            result = RecursiveFunctionStatic.GetProductory(5);
            result = RecursiveFunctionStatic.GetPow(5, 4);
            */

            /* TUPLA
            Tupla tupla = new Tupla();
            (string s1, string s2, string s3) result1 = tupla.GiveMeProblematicNames();
            Console.WriteLine(result1.s1);
            Console.WriteLine(result1.s2);
            Console.WriteLine(result1.s3);
            Console.WriteLine(tupla.GetNegative(16));
            Console.WriteLine(tupla.GetVariable());
            */

            /* FUNCION POR DEFECTO
            ISchool school = new Person();
            school.FuncionDefecto(1,"Jorge");
            */

            /* REFERENCES
            int numero1 = 5, numero2;
            References.ReferenceOut(out numero1,out numero2);
            Console.WriteLine("" + numero1 +"-" + numero2);
            numero1 = 10; numero2 = 50;

            int numero3 = 15;
            int numero4 = 35;
            References.ReferenceRef(ref numero3, ref numero4);
            Console.WriteLine("" + numero3 + "-" + numero4);
            numero3 = 1920; numero4 = 720;

            int numero5 = 500;
            int numero6 = 1000;
            int result = References.ReferenceIn(in numero5, numero6);
            Console.WriteLine(result);
            numero5 = 1920; numero6 = 10;
            */

            /* SOBRECARGA DE OPERADORES            
            Sobrecarga sobre1 = new Sobrecarga();
            sobre1._value = 100;

            Sobrecarga sobre2 = new Sobrecarga();
            sobre2._value = 50;

            int result1 = sobre1 + sobre2;
            string result2 = sobre1 - sobre2;
            double result3 = sobre1 * sobre2;
            GenderPicker result4 = sobre1 / sobre2;
            */

            /* GENERICO
            Generic<int> generic = new Generic<int>();
            */

            /* LAMBDA
            Person p = new Person();
            p.Name = "Juan";
            Person h = p;

            ListDel l = new ListDel();
            l.CreateList();
            List<City> cities = l.Filter(name => name == "Madrid");
            cities = l.Sort((city1, city2) =>
            {
                if (city1.population > city2.population)
                    return 1;
                else
                    return 0;
            });
            */

            /* Herencia
            Concursante c1 = new Concursante();
            Concursante c2 = new Torre(5.0);
            Torre c3 = new Torre(6.0);

            double r1 = c1.F1();
            double r2 = c2.F1();
            double r3 = c3.F1();

            c1.SetTest(5);
            c2.SetTest(7);
            c3.SetTest(10);

            double w1 = c1.Test;
            double w2 = c2.Test;
            double w3 = c3.Test;

            c2.SetAge();
            */

            Coleccion c1 = new Coleccion();
            c1.Add(1);
            c1.Add(15);
            c1.Add(150);
            List<int> clone = c1.Clone();
            c1.Add(60);

            Coleccion2<char> c2 = new Coleccion2<char>();
            c2.Add('a');
            c2.Add('e');
            c2.Add('i');
            List<char> clone2 = c2.Clone();
            c2.Add('r');

            Coleccion3 c3 = new Coleccion3();
            c3.AddDato(5);
            c3.AddDato(15);
            c3.AddDato(25);
            c3.AddDato(35);
            Coleccion3 clone3 = c3.Clone();
            c3.AddDato(105);

        }
    }
}