namespace EXAMEN
{
    public enum Subject
    {
        MATHS,
        SCIENCE,
        HISTORY,
        LANGUAGE
    }
    public class Signature
    {
        private Subject _subject;
        private double _noteSubject;


        public Subject Subject => _subject;
        public double NotesSubject => _noteSubject;


        public void SetQualification(double value)
        {
            _noteSubject = value;
        }
    }
}
