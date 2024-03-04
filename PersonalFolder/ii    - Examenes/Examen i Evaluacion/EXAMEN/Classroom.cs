namespace EXAMEN
{
    public class Classroom
    {
        private List<Student> _studentsList = new List<Student>();
        private string _name = "";

        public Classroom()
        {

        }

        public Classroom(List<Student> studentList)
        {
            _studentsList = studentList;
        }

        public List<Student> StudentList => _studentsList;
        public string Name => _name;
        
        public void AddStudent(Student student)
        {
            if (student == null)
                return;

            _studentsList.Add(student);
        }

        public void Removestudent(int index)
        {
            if (index < 0 || index > _studentsList.Count)
                return;

            _studentsList.RemoveAt(index);
        }

        public bool ContainsStudentWithName(string name)
        {
            if (name == null)
                return false;

            List<Student> list = _studentsList;

            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == name)
                    return true;
            }
            return false;
        }

        public void RemoveStudentWithName(string name)
        {
            if (name == null)
                return;

            List<Student> list = _studentsList;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == name)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        public int RemoveStudentWithNameALT(string name)
        {
            if (name == null)
                return -1;

            List<Student> list = _studentsList;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == name)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            return -1;
        }
    }
}
