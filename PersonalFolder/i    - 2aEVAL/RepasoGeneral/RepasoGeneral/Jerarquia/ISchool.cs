namespace RepasoGeneral.Jerarquia
{
    public interface ISchool
    {
        int GetCountStudents();
        Student GetStudentAt(int index);
        List<string> GetCollectionNames();

        void FuncionDefecto(int index, string name)
        {
            Student student = new Student();
            student.Note = 5;
            student.Name = "Loj";
            Console.WriteLine(student.Note.ToString() + " " + student.Name);
        }
    }
}
