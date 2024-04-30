using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppStudentsViewer
{
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string studentName;
            int studentAge;
            string studentDescription;
            int Id;

            studentName = NameSave.Text;
            studentAge = Int32.Parse(AgeSave.Text);
            studentDescription = DescriptionSave.Text;
            Id = ControllerSingleTN.Controller.Database.List.Count + 1;

            Student student = new Student(studentName, studentAge, studentDescription, Id);
            ControllerSingleTN.Controller.Database.AddStudent(student);
            Close();
        }
    }
}