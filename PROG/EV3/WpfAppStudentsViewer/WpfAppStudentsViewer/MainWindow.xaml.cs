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
        private IDatabase database = ControllerSingleTN.Controller.Database;

        public MainWindow()
        {
            InitializeComponent();

            database.AddStudent(new Student("Pedro", 20, "Este es el primer alumno que muestra la base de datos", 1));
            database.AddStudent(new Student("Josete", 40, "Este es la ficha del segundo alumno", 2));
            SetDataContext();
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

        private void SetDataContext()
        {
            DataContext = database.List[studentID - 1];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow window = new AddStudentWindow();
            window.ShowDialog();
        }
    }
}