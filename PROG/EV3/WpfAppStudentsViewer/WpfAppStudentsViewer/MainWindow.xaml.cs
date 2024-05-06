using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Library;

namespace WpfAppStudentsViewer
{
    public partial class MainWindow : Window
    {
        private int studentID = 1;
        private int _position = 0;
        private IDatabase database = ControllerSingleTN.Controller.Database;
        private Student _student = new Student();

        public MainWindow()
        {            
            InitializeComponent();
            GetFirstStudent();
        }
        public void GetFirstStudent()
        {
            if (database.List.Count > 0)
                _student = database.List[_position];
        }
        public void GetNextStudent(object sender, RoutedEventArgs e)
        {
            if (_position < database.List.Count - 1)
            {
                _position++;
                _student = database.List[_position];
            }
            DisplayUI();
        }
        public void GetPreviousStudent(object sender, RoutedEventArgs e)
        {
            if (_position > 0)
            {
                _position--;
                _student = database.List[_position];
            }
            DisplayUI();
        }
        public Student GetStudentAt(int index)
        {
            return database.List[index];
        }
        private void DisplayUI()
        {
            UIName.Text = _student.Name;
            UIAge.Text = _student.Age.ToString();
            UIDescription.Text = _student.Description;
        }
        private void DatabaseBTN_Click(object sender, RoutedEventArgs e)
        {
            database.GetPrefetchDatabase();
            Viewer.Text = DisplayStudents();
            //SetDataContext();
        }
        private string DisplayStudents()
        {
            string result = string.Empty;
            foreach (Student s in database.List)
            {
                result += s.Id + " " + s.Name + " " + s.Age + "\n";
            }
            return result;
        }
        private void SortBTN_Click(object sender, RoutedEventArgs e)
        {
            Sort();
            Viewer.Text = DisplayStudents();
        }

        private void Sort()
        {
            Student aux;
            for (int i = 0; i < database.List.Count - 1; i++)
            {
                for (int j = i + 1; j < database.List.Count; j++)
                {
                    if (database.List[i].Id > database.List[j].Id)
                    {
                        aux = database.List[i];
                        database.List[i] = database.List[j];
                        database.List[j] = aux;
                    }
                }
            }
        }

        public delegate bool DelegateFilter(int age);
        private void FilterBTN_Click(object sender, RoutedEventArgs e)
        {
            List<Student> result = new List<Student>();
            DelegateFilter filter = new DelegateFilter(age => age > 18);
            foreach (Student s in database.List)
            {
                if (filter(s.Age))
                    result.Add(s);
            }
            DisplayFilter(result);
        }
        private void DisplayFilter(List<Student> list)
        {
            string result = string.Empty;
            foreach (Student s in list)
            {
                result += s.Id + " " + s.Name + " " + s.Age + "\n";
            }
            Viewer.Text = result;
        }



        // FUNCIONES UTILIZANDO BINDINGS

        private void SetDataContext()
        {
            DataContext = database.List[studentID - 1];
        }

        private void Adelante_Click(object sender, RoutedEventArgs e)
        {
            if (studentID < database.List.Count)
                studentID++;
            SetDataContext();
        }
        private void Atras_Click(object sender, RoutedEventArgs e)
        {
            if (studentID > 1)
                studentID--;
            SetDataContext();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow window = new AddStudentWindow();
            window.ShowDialog();
        }        
    }
}