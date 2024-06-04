using System;
using System.Collections.Generic;

namespace Library
{
    public interface IDatabase
    {
        long AddStudent(Student student);
        int GetIndexOf(Student student);
        List<Student> List { get; }
        void GetPrefetchDatabase();
    }
}
