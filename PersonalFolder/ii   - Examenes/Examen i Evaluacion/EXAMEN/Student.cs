namespace EXAMEN
{
    public enum Gender
    {
        MALE,
        FEMALE,
        NONBINARY
    }
    public class Student
    {
        private string _name = "";
        private int _age;
        private Gender _gender;
        private double _height;
        private double _weight;
        private Notes _notes = new Notes();

        public Student()
        {

        }

        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name => _name;
        public Notes Notes => _notes;
        public int Age => _age;
        public Gender Gender => _gender;

        public double GetIMC()
        {
            if (_height <= 0)
                return double.NaN;

            if (_weight <= 0)
                return 0;

            return _weight / (_height * _height);
        }

        public double GetAverageNotes()
        {
            double result = 0.0;
            List<Signature> list = Notes.ListSignatures;

            for (int i = 0; i < list.Count; i++)
            {
                result += list[i].NotesSubject;
            }

            return result / Notes.ListSignatures.Count;
        }

        public double GetAverageNotesQuick()
        {
            return Notes.GetAverageNotes();
        }

        public bool IsMajorAge()
        {
            double legalAge = 18;
            return _age >= legalAge;
        }

        public Student Clone(Student student)
        {
            Student result = new Student();

            result._age = student._age;
            result._name = student._name;
            result._weight = student._weight;
            result._height = student._height;
            result._gender = student._gender;

            return result;
        }
    }
}
