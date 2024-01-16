using DAMLib;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            ItemSet<int> itemset1 = new ItemSet<int>();
            
            itemset1.Add(150);
            int result1 = itemset1.IndexOf(150);
            int number = 150;
            int result = number.GetHashCode();

            ItemSet<string> itemset2 = new ItemSet<string>();

            itemset2.Add("Juan");
            int result10 = itemset2.IndexOf("Juan");
            int result2 = itemset2._itemset[0].Element.GetHashCode();
        }
    }
}