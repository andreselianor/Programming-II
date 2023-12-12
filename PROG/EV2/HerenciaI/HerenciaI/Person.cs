namespace HerenciaI
{
    public enum Gender
    {
        MALE,
        FEMALE,
        NONBINARY
    }
    public class Person
    {
        public string _name;
        public Gender _gender;

        public Person() : this("Pedro", Gender.NONBINARY)
        {

        }

        public Person(string name, Gender gender)
        {
            _name = name;
            _gender = gender;
        }
    }
}
