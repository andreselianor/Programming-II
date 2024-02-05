namespace ExercismIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            string result = t1.Texto("escribir");
            string result2 = t1.Texto("otra cosa");
            string result3 = t1.Texto(null);
            string result4 = t1.Texto();
        }
    }
}