namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios de Contenedores");

            List<double> list1;
            list1 = new List<double>();
            list1.Add(-5.0);
            list1.Add(1.6);
            list1.Add(3.7);
            list1.Add(-2.5);
            list1.Remove(1.6);
            list1.RemoveAt(0);
            list1[0] = list1[1];
            foreach(double d in list1)
            {
                Console.WriteLine(d);
            }
            int number = list1.Count();
            Console.WriteLine(number);


            double[] list2;
            list2 = new double[4];
            list2[0] = -2.0;
            list2[1] = 4.6;
            list2[2] = 3.7;
            list2[3] = 2.5;

            int number2 = list2.Length;
            Console.WriteLine(number2);
            /*

            int result1 = Functions.GetGreaterThanZero(list1);

            double[] list2;
            list2 = new double[4];
            list2[0] = -2.0;
            list2[1] = 4.6;
            list2[2] = 3.7;
            list2[3] = 2.5;

            int result2 = Functions.GetGreaterThanZero(list2);
            */
        }
    }
}