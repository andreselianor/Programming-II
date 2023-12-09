namespace ExamenNoviembre
{
    public enum Subjects
    {
        MATEMATICAS,
        CIENCIA,
        HISTORIA,
        LENGUA
    }


    public class Notes
    {
        // Esta es la primera aproximacion
        private double _note;
        private Subjects _subjects;

        // Esta es la mejor opcion
        private Dictionary<Subjects, double> _notesDict = new Dictionary<Subjects, double>();




        public Notes()
        {

        }

        // Tengo dudas con toda la sintaxis de los diccionarios, he intentado que no existan errores de compilacion
        public Notes(Subjects subject, double note)
        {
            _notesDict[subject] = note;
        }




        public Dictionary<Subjects, double> NotesDictionary => _notesDict;





        public double GetQualificationForSignature(Subjects subjects)
        {
            return _notesDict[subjects];
        }

        public void SetQualificationForSignature(Subjects subjects, double note)
        {
            _notesDict[subjects] = note;
        }

        public double GetAverageNote()
        {
            double average = 0;
            int count = 0;

            foreach (var v in _notesDict)
            {                
                average += v.Value;
                count++;
            }

            return average / count;            
        }

        public Subjects GetSubjectWithMajorNote()
        {
            // Subjects subjects = new Subjects();  TENGO DUDAS CON ESTA LINEA

            Subjects subject = Subjects.MATEMATICAS;
            double aux = 0.0;

            foreach (var v in _notesDict)
            {
                if(v.Value > aux)
                {
                    subject = v.Key;
                }
            }
            return subject;
        }

        public Subjects GetSubjetWithLowerNote()
        {
            Subjects subject = Subjects.MATEMATICAS;
            double aux = 10.0;

            foreach (var v in _notesDict)
            {
                if (v.Value < aux)
                {
                    subject = v.Key;
                }
            }
            return subject;
        }

        public double GetBestNote()
        {
            double note = 0;

            foreach (var v in _notesDict)
            {
                if (v.Value > note)
                {
                    note = v.Value;
                }
            }
            return note;
        }

        public double GetWorseNote()
        {
            double note = 10;

            foreach (var v in _notesDict)
            {
                if (v.Value < note)
                {
                    note = v.Value;
                }
            }
            return note;
        }
    }
}
