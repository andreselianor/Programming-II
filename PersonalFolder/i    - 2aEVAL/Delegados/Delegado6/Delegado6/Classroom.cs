namespace Delegado6
{
    public delegate bool DelegateFilter(Student student);
    public delegate int DelegateSort(Student student, Student student2);
    public class Classroom
    {
        private List<Student> _studentsList = new List<Student>();

        public void CreateList()
        {
            Student s1 = new Student() { Age = 15, Name = "Peter" };
            _studentsList.Add(s1);

            Student s2 = new Student() { Age = 25, Name = "Sarah" };
            _studentsList.Add(s2);

            Student s3 = new Student() { Age = 42, Name = "Leroy" };
            _studentsList.Add(s3);

            Student s4 = new Student() { Age = 2, Name = "Nina" };
            _studentsList.Add(s4);

            Student s5 = new Student() { Age = 65, Name = "Large" };
            _studentsList.Add(s5);
        }

        public List<string> Filter(DelegateFilter del)
        {
            List<string> listResultNames = new List<string>();
            for (int i = 0; i < _studentsList.Count; i++)
            {
                if (del(_studentsList[i]))
                {
                    listResultNames.Add(_studentsList[i].Name);
                }
            }
            return listResultNames;
        }

        public List<Student> Sort(DelegateSort del)
        {
            List<Student> list = _studentsList;

            for(int j = 0; j < list.Count - 1; j++)
            {
                for (int i = j + 1; i < list.Count; i++)
                {
                    if (del(list[j], list[i]) >= 1)
                    {
                        Student aux;
                        aux = list[j];
                        list[j] = list[i];
                        list[i] = aux;
                    }
                }
            }            
            return list;
        }

        public void DisplayNames()
        {
            foreach (Student s in _studentsList)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
