using static DAMLib.TestUnidad;

namespace DAMLib
{
    public class TestUnidad
    {
        // Test de caja blanca
        public int Count { get; set; }
        public bool IsEmpty { get; set; }
        public bool Contains { get; set; }

        public static TestUnidad Test1(ISet<string> set)
        {
            TestUnidad test1 = new TestUnidad();
            {
                set.Add("libreria");
                test1.Count = set.Count;
                test1.IsEmpty = set.IsEmpty;
                test1.Contains = set.Contains("libreria");
            }
            return test1;
        }
    }
}