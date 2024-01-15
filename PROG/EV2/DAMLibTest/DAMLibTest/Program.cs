using DAMLib;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            SetWithHash<int> setWith = new SetWithHash<int>();

            setWith.Add(10);
            setWith.Add(20);
            setWith.Add(30);

            int result1 = setWith.IndexOf(3);
            int result2 = setWith.HashWithIndex(1);
            setWith.Add(3);
            bool result4 = setWith.Contains(100);
            setWith.Remove(150);
            string result5 = setWith.ToString();
        }
    }
}