namespace RepasoGeneral.Jerarquia
{
    public class Student : Person
    {
        public double Note;

        public Student()
        {

        }

        public Student(int another) : base(another)
        {

        }

        public override int FunctionNumber1(int alterNumber)
        {
            return 3;
        }

        public override int FunctionNumber2(int alterNumber)
        {
            return base.FunctionNumber2(2) + 33;
        }

        public int GetInterface(ISchool escuela)
        {
            return escuela.GetCountStudents();
        }
    }
}
