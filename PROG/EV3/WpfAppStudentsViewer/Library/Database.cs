using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Library
{
    public class Database : IDatabase
    {
        private List<Student> _studentsList = new List<Student>();
        public long AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException();

            _studentsList.Add(student);
            return student.GetHashCode();
        }
    }
}
