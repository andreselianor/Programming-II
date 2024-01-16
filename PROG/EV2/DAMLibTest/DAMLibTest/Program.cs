using DAMLib;

namespace DAMLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            ItemSet<int> itemset1 = new ItemSet<int>();            
            int result0 = itemset1.Count;
            itemset1.Add(15);
            int result1 = itemset1.Count;
            bool result2 = itemset1.Contains(20);
            bool result3 = itemset1.Contains(15);
            itemset1.RemoveAt(0);
            itemset1.Add(60);
            itemset1.Add(150);
            int result4 = itemset1.IndexOf(150);
            bool result5 = itemset1.IsEmpty;
            itemset1.RemoveAt(0);
            itemset1.RemoveAt(0);
            result5 = itemset1.IsEmpty;
        }
    }
}