namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios de Listas y Arrays");


            // LISTA
            //1.-

            List<int> list1;
            list1 = new List<int>();

            list1.Add(-50);
            list1.Add(0);
            list1.Add(-60);
            list1.Add(10);
            list1.Add(-20);

            //2.-

            List<double> list2 = new List<double> { 60.0, 0.0, -15.0, 22.0 };

            //3.-

            List<string> list3 = new List<string>
            {
                "objeto1",
                "objeto2",
                "objeto3",
                "objeto4"
            };


            // ARRAY
            //1.-
            int[] list4;
            list4 = new int[4];
            list4[0] = -50;
            list4[1] = 0;
            list4[2] = 15;
            list4[3] = 40;


            //2.-
            double[] list5 = new double[] { -50.0, 0.0, 15.0, 40.0 };

            //3.-
            string[] list6 = new string[] 
            {
               "Lugar1",
               "Lugar2",
               "Lugar3",
               "Lugar4"
            };

            List<int> list7 = null;


            double[] list8 = new double[]
            {
                0.0,
                1.0,
                5.0
            };

            int test1 = Functions.GetGreaterThanZero(list2);
            double test2 = Functions.GetGreaterThanZero(list5);

            bool test3 = Functions.ContainsNumber(list1, 5);
            bool test4 = Functions.ContainsNumber(list1, 15);

            int test5 = Functions.GetMajor(list1);
            int test6 = Functions.GetMajor(list7);

            int test7 = Functions.GetIndexMajor(list1);
            int test8 = Functions.GetIndexMajor2(list1);

            bool test9 = Functions.IsOrdered(list1);
            list7 = Functions.Sort(list1);

            bool test10 = Functions.BinarySearch(list8, 0.0);

        }
    }
}