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
using System.Xml.Linq;
using LibraryFilmMax;
using MongoDB.Driver;

namespace TestsControl
{
    public partial class MainWindow : Window
    {
        IDatabase db = new Database();
        public MainWindow()
        {
            InitializeComponent();
            db.ConnectMongoDB();
        }

        private void finder_Click(object sender, RoutedEventArgs e)
        {
            string UL = box.Text;
            var filter = Builders<User>.Filter.Eq(user => user.security.loginName, UL);
            User u = db.UsersCollection.Find(filter).First();
            
            result.Text = u.userName + u.lastName + u.phone + u.security.loginName + u.security.loginPassword;
        }
    }
}