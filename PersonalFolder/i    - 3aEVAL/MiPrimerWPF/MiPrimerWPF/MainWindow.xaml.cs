using System.Windows;

namespace MiPrimerWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            bool? state = CheckBoxMain.IsChecked;
            CheckBoxMain.IsChecked = !state;

            ButtonMain.Content += "0";
        }
    }
}