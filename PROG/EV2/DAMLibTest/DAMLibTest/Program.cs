using DAMLib;
using System.Text.Json;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            SetWithHash<string> set = new SetWithHash<string>();
            set.Add("PEPE");
            set.Add("JUAN");
            set.Add("marilo");
            set.Add("MARILO");

            int number = set.IndexOf("MARILO");
        }
    }
}