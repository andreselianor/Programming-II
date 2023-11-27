namespace ResumenFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   int[] array = Exam.MakeArray(5);
            // Exam.ListArray(array);
            List<int> list = new List<int>
            {
                100,
                50,
                0
            };
            list = Exam.SortList(list);
        }
    }
}