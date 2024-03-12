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
        public static TestUnidad Test2(ISet<string> set)
        {
            TestUnidad test2 = new TestUnidad();
            {
                set.Add("Sergio Ramos");
                test2.Count = set.Count;
                test2.IsEmpty = set.IsEmpty;
                test2.Contains = set.Contains("Camero");
                test2.Contains = set.Contains("Sergio Ramos");

                set.Add("Gerardo Pique");
                test2.Count = set.Count;
                test2.IsEmpty = set.IsEmpty;
                test2.Contains = set.Contains("Sergio Ramos");
                test2.Contains = set.Contains("Gerardo");

                set.Add("David de Egea");
                test2.Count = set.Count;
                test2.IsEmpty = set.IsEmpty;
                test2.Contains = set.Contains("Florero");
                test2.Contains = set.Contains("Gerardo Qings league");
                test2.Contains = set.Contains("!Zamora");
            }
            return test2;
        }
        public static TestUnidad Test3(ISet<string> set)
        {
            TestUnidad test3 = new TestUnidad();
            {
                set.Add("Fiat_500");
                test3.Count = set.Count;
                test3.IsEmpty = set.IsEmpty;
                test3.Contains = set.Contains("Fiat_500");
                test3.Contains = set.Contains("Innovacion italiana");

                set.Add("Toyota");
                test3.Count = set.Count;
                test3.IsEmpty = set.IsEmpty;
                test3.Contains = set.Contains("Tecnologia");
                test3.Contains = set.Contains("Tecnologia y fiabilidad");
                test3.Contains = set.Contains("Sus piezas son de muy facil recambio");

                set.Add("Aixam");
                test3.Count = set.Count;
                test3.IsEmpty = set.IsEmpty;
                test3.Contains = set.Contains("Coche");
                test3.Contains = set.Contains("Practico y facil de aparcar");
                test3.Contains = set.Contains("Limite de velocidad");
            }
            return test3;        
        }
    }
}