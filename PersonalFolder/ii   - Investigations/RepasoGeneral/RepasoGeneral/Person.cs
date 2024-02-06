namespace RepasoGeneral
{
    public enum Gender
    {
        MALE,
        FEMALE,
        NOBINARY
    }
    public class Person : Entidad, ISchool
    {
        public string Name;
        public Gender GenderType;

        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int otro) : base(otro)
        {
            Name = name;

        }
        public Person(int deabajo) : base(deabajo)
        {

        }
        public Person(Gender genderType, string nombre) : this(nombre)
        {

        }

        public override int FunctionNumber1(int alterNumber)
        {
            return 2;
        }

        public override int FunctionNumber2(int alterNumber)
        {
            return 22 + this.FunctionNumber1(2);
        }

        public int GetCountStudents()
        {
            return 11;
        }

        public List<string> GetCollectionNames()
        {
            return new List<string>();
        }

        public int GetGender()
        {
            return (int)Gender.MALE;
        }

        public void SelectGender()
        {
            string[] array = Enum.GetNames(typeof(Gender));
            foreach(string str in array)
            {
                Console.WriteLine(str);
            }
            Array array2 = Enum.GetValues(typeof(Gender));
            foreach(int i in array2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
