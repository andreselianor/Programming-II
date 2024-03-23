namespace DelegadosConclusion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TEST FILTER

            FilterClass<string> test1 = new FilterClass<string>();

            FilterClass<string>.DelegateFilter del1;
            del1 = new FilterClass<string>.DelegateFilter(element => element.Length > 0);

            test1.Filter(del1);
            test1.Filter(element => element.Length > 0);
            test1.Filter(element => { return element.Length > 0; });
            test1.Filter(element =>
            {
                return element.Length > 0;
            });


            // TEST SORT

            SortClass<string> test2 = new SortClass<string>();

            SortClass<string>.DelegateSort del2;
            del2 = new SortClass<string>.DelegateSort((item1, item2) => item1.Length < item2.Length ? 1 : 0);

            test2.Sort(del2);
            test2.Sort((item1, item2) => item1.Length < item2.Length ? 1 : 0);
            test2.Sort((item1, item2) => { return item1.Length < item2.Length ? 1 : 0; });
            test2.Sort((item1, item2) =>
            {
                return item1.Length < item2.Length ? 1 : 0;
            });


            // TEST VISIT

            List<string> list = new List<string>();

            VisitClass<string> test3 = new VisitClass<string>();

            VisitClass<string>.DelegateVisit del3;
            del3 = new VisitClass<string>.DelegateVisit(element => element = "Elemento: " + element);

            test3.Visit(del3);
            test3.Visit(element => element = "Elemento: " + element);
            test3.Visit(element => {element = "Elemento: " + element;});
            test3.Visit(element =>
            {
                element = "Elemento: " + element;
            });
        }
    }
}