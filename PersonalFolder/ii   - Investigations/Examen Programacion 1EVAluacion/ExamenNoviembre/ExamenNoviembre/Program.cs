namespace ExamenNoviembre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notes notes = new Notes(Subjects.MATEMATICAS, 5.0);
            notes.SetQualificationForSignature(Subjects.CIENCIA, 8.0);
            double result = notes.GetAverageNote();

            Classroom classroom = new Classroom();
            Student student1 = new Student("Jos", 5);
            Student student2 = new Student("Mario", 10);
            classroom.AddStudent(student1);
            classroom.AddStudent(student2);
            

            Student result1 = Stadistics.GetYoungestStudent(classroom);
        }
    }
}