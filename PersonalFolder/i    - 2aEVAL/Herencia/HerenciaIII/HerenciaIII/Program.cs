using System.Reflection;

namespace HerenciaIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.GetName();
            string result1 = person.GetSubject();

            Person person2 = new Student();
            person2.GetName();
            //person2.GetNote();
            Person person22 = new Teacher();
            //person22.subject = "Letras";

            Student student = new Student();
            student.GetName();
            student.GetNote();
            //student.GetSubject();

            Teacher teacher = new Teacher();
            teacher.GetName();
            teacher.GetSubject();
            //teacher.GetNote();

            Teacher person3 = new Teacher();
            person3.GetName();
            //person3.GetNote();
            person3.subject = "Science";
            string result2 = person3.GetSubject();
            
        }
    }

    public class Person
    {
        protected string name;

        public string GetName()
        {
            return name;
        }
        public virtual string GetSubject()
        {
            return "asignatura: ";
        }
    }
    public class Student : Person
    {
        protected int note;

        public int GetNote()
        {
            
            return note;
        }
    }

    public class Teacher : Person
    {
        public string subject;
        public override string GetSubject()
        {            
            return base.GetSubject() + subject;
        }
    }
}
