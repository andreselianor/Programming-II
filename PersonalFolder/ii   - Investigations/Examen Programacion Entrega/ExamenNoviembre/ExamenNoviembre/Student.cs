namespace ExamenNoviembre
{
    public enum Gender
    {
        HOMBRE,
        MUJER,
        NOBINARIO
    }

    public class Student
    {
        private string _name = "";
        private int _age;
        private Gender _gender;
        private double _height;
        private double _weight;
        private Notes _notes = new Notes();




        public string Name => _name;
        public double Height => _height;
        public double Weight => _weight;
        public Gender Gender => _gender;
        public int Age => _age;
        public Notes Notes => _notes;




        public Student()
        {

        }

        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }





        public double GetIMC()
        {
            return _weight / (_height * _height);
        }

        public double AverageNotesSubjects()
        {
            double averageResult = 0;
            int subjectNumber = 0;

            foreach(var note in _notes.NotesDictionary.Values)
            {
                averageResult += note;
            }

            foreach(var subject in _notes.NotesDictionary.Keys)
            {
                subjectNumber++;
            }

            return averageResult / subjectNumber;
        }

        public bool IsAdultPerson()
        {
            return _age >= 18;
        }

        public Student? Clone(Student student)
        {
            if (student == null)
                return null;

            Student studentClone = new Student();

            studentClone._name = student._name;
            studentClone._age = student._age;
            studentClone._gender = student._gender;
            studentClone._height = student._height;
            studentClone._weight = student._weight;

            return studentClone;
        }
    }
}
