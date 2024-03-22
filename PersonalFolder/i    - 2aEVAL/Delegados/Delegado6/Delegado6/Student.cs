namespace Delegado6
{
    public class Student
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Student()
        {

        }
        public Student (string name, int age)
        {
            _name = name;
            _age = age;
        }
    }
}