using System.Windows;

namespace FilmMax
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Enter(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.ShowDialog();
        }
    }
}