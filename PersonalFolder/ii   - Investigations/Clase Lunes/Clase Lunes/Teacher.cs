namespace Clase_Lunes
{
    public class Teacher : Person
    {
        private string _subject;
        private int _level;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public Teacher()
        {

        }

        public Teacher(string subject,int level)
        {
            _subject = subject;
            _level = level;
        }
    }
}
