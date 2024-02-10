namespace RepasoCurso
{
    public enum GenderType
    {
        MALE,
        FEMALE,
        NONBINARY
    }

    public class Persona
    {
        private string _name;
        private int _age;
        private string _DNI;
        private GenderType _gender;
        private double _weight;
        private double _height;

        public Persona()
        {
            _gender = GenderType.NONBINARY;
        }

        public Persona(string name, int age, GenderType gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }

        public Persona(string name, int age, GenderType gender, string DNI, double weight, double height)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _DNI = DNI;
            //_DNI = GenerateDNI();
            _weight = weight;
            _height = height;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string GetDNI()
        {
            return _DNI;
        }

        public string DNI => _DNI;

        public double CalculateIMC()
        {
            return _weight / (_height * _height);
        }

        public bool IsMajorAge()
        {
            return _age >= 18;
        }

        public bool IsCorrectGender(GenderType gender)
        {
            return _gender == gender;
        }

        public override string ToString()
        {
            return $"{Name} {DNI}";
        }

        private string GenerateDNI()
        {
            Random random = new Random();
            int numberDNI = random.Next(99999999);
            int letter = numberDNI % 23;

            char letterDNI = GetDNILetter(letter);

            return "" + numberDNI + letterDNI;
        }

        private char GetDNILetter(int module)
        {
            char result = ' ';
            switch (module)
            {
                case 0:
                    result = 'T';
                    break;
                default:
                    result = 'J';
                    break;
            }
            return result;
        }
    }
}