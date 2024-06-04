using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Library
{
    public class Database : IDatabase
    {
        private List<Student> _studentsList = new List<Student>();

        public List<Student> List => _studentsList;
        public long AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException();

            _studentsList.Add(student);
            return student.GetHashCode();
        }

        public Student GetStudentAt(int index)
        {
            if (index < 0 || index >= _studentsList.Count)
                throw new ArgumentOutOfRangeException();

            return _studentsList[index];
        }
        public Student GetNextStudent(int index)
        {
            if (index < 0 || index >= _studentsList.Count)
                throw new ArgumentOutOfRangeException();

            return _studentsList[index + 1];
        }

        public int GetIndexOf(Student student)
        {
            if(student == null)
                throw new ArgumentNullException();

            for(int i = 0; i < _studentsList.Count; i++)
            {
                if (student == _studentsList[i])
                    return i;
            }
            return -1;
        }

        public void GetPrefetchDatabase()
        {
            _studentsList = new List<Student>()
            {
                new Student("Jorge", 15, "Estudiante de primero",1),
                new Student("Jere", 18, "Algo travieso",3),
                new Student("Alicia", 22, "Mujercilla con nerviso de acero",4),
                new Student("Fermin", 12, "Cantaora",2),
                new Student("Carajo",16, "Excelente persona",7),
                new Student("Flamen", 24, "Ultimo de la cola",6)
            };            
        }
    }
}