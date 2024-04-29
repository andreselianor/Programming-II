namespace WpfAppStudentsViewer
{
    public class Application
    {
        private List<Student> _studentsList = new List<Student>();
        private static Application _application = new Application();

        public static Application AppGetter => _application;
        private Application() { }

        public Student GetStudentAt(int index)
        {
            if (index < 0 || index >= _studentsList.Count)
                throw new ArgumentOutOfRangeException;
            
            return _studentsList[index];
        }
        public Student GetNextStudent(int index)
        {
            if (index < 0 || index >= _studentsList.Count)
                throw new ArgumentOutOfRangeException;

            return _studentsList[index + 1];
        }
    }
}