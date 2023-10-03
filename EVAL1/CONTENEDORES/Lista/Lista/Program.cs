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

            List<int> list3 = new List<int>();
            list3.Add(-2);
            list3.Add(-4);
            list3.Add(-6);
            list3.Add(8);


            bool result1 = Functions.ContainsNumber(list3, 8);
            int result2 = Functions.GetMajor(list3);
            int result3 = Functions.GetIndexMajor(list3);
        }
    }
}