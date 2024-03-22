using System.Runtime.CompilerServices;

namespace ConsoleApp3
{
    internal class Program
    {
        public delegate bool Del1(int a, int b);

        //public delegate bool IsMajorAThanB<T>(T a, T b);
        public static void Sort<T>(T[] values, Comparison<T> major)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    T vi = values[i];
                    T vj = values[j];
                    if (major(vi, vj) < 0)
                    {
                        T aux = values[i];
                        values[i] = values[j];
                        values[j] = aux;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string[] values = new string[] { "0", "-1", "2", "-3", "4", "juan"};
            int modo = -1;

            Sort(values, (v1,v2) =>
            {
                return v1.CompareTo(v2) * modo;
            });
        }
    }
}