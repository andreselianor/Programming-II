namespace ExamenNoviembre
{
    public class Classroom
    {
        private List<Student> _studentsList = new List<Student>();
        private string name = "";



        public Classroom()
        {

        }

        public Classroom(List<Student> studentsList)
        {
            _studentsList = studentsList;
        }




        public List<Student> StudentList => _studentsList;




        public void AddStudent(Student student)
        {
            if (student == null)
                return;

            _studentsList.Add(student);
        }

        public void RemoveStudentAt(int index)
        {
            if (index < 0 || index >= _studentsList.Count)
                return;

            _studentsList.RemoveAt(index);
        }

        public bool ContainsStudentWithName(string name)
        {
            for(int i = 0; i < _studentsList.Count; i++)
            {
                if (_studentsList[i].Name == name)
                    return true;
            }
            return false;
        }

        public void RemoveStudentWithName(string name)
        {
            for(int i = 0; i < _studentsList.Count; i++)
            {
                if(_studentsList[i].Name == name)
                {
                    _studentsList.RemoveAt(i);
                    i--;
                }
            }
        }


        // Alternativa: Esta funcion puede devolver un 'int'
        public int RemoveStudentWithNameAlternative(string name)
        {
            for (int i = 0; i < _studentsList.Count; i++)
            {
                if (_studentsList[i].Name == name)
                {
                    _studentsList.RemoveAt(i);
                    return 1;   // Devuelve '1' en caso que al menos borre un student
                }
            }
            return -1;  // En caso que no exista student
        }



        public int GetStudentsCount()
        {
            return _studentsList.Count;
        }

        public Student? GetStudentAt(int index)
        {
            if (index < 0 || index >= _studentsList.Count)
                return null;

            return _studentsList[index];
        }
    }
}
