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
    }
}