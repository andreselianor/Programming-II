namespace Clase_Lunes
{
    public class Student : Person
    {
        private string _name;
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Student()
        {

        }

        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }
    }
}
