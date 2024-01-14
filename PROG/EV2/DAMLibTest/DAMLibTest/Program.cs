using DAMLib;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            SetWithHash<int> setWith = new SetWithHash<int>();

            setWith.Add(1);
            setWith.Add(2);
            setWith.Add(3);

            int result1 = setWith.IndexOf(3);
            int result2 = setWith.HashWithIndex(0);
            setWith.Add(3);
            string result3 = setWith.ToString();
        }
    }
}