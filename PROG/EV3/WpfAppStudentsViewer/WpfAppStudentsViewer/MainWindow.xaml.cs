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
        private int studentIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            //ControllerSingleTN.Controller._database.AddStudent();
            IDatabase database = ControllerSingleTN.Controller._database;
            database.AddStudent(new Student());
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.AppGetter.GetNextStudent(studentIndex++);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddStudentWindow window = new AddStudentWindow();
            window.ShowDialog();
        }
    }
}