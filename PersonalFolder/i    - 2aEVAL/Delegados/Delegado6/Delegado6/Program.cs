namespace Delegado6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classroom c1 = new Classroom();

            c1.CreateList();
            c1.DisplayNames();

            // LAMBDA Filter
            List<string> listFilter = new List<string>();
            listFilter = c1.Filter((student) =>
            {
                if (student.Name == "Sarah")
                    return true;
                return false;
            });

            foreach(string s in listFilter)
            {
                Console.WriteLine(s);
            }

            // LAMBDA Sort
            List<Student> listSort = new List<Student>();
            listSort = c1.Sort((student, student2) =>
            {
                if (student.Age > student2.Age)
                    return 1;
                else
                    return -1;
            });

            foreach(Student s in listSort)
            {
                Console.WriteLine(s.Age);
            }
        }
    }
}