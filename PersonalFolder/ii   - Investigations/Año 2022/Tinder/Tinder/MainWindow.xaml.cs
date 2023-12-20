using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tinder
{
    public class User
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Picture { get; set; }
        public string TypeFavourite { get; set; }
        public string Hobbies { get; set; }
    }

    public partial class MainWindow : Window
    {

        ObservableCollection<User> listUser = new ObservableCollection<User>();
        ObservableCollection<User> listDetail = new ObservableCollection<User>();

        #region Instancias
        User User1 = new User()
        {
            Name = "Aaron B.",
            Hobbies = "Pesca",
            Picture = "resources/foto1.jpg",
            Rating = 1

        };

        User User2 = new User()
        {
            Name = "Belli Cordoba",
            Hobbies = "Cocina",
            Picture = "resources/foto2.jpg",
            Rating = 4
        };

        User User3 = new User()
        {
            Name = "Deltoya Efrain",
            Hobbies = "Voluntariado",
            Picture = "resources/foto3.jpg",
            Rating = 2
        };

        User User4 = new User()
        {
            Name = "Fran Golgota",
            Hobbies = "Caza",
            Picture = "resources/foto4.jpg",
            Rating = 3
        };

        User User5 = new User()
        {
            Name = "Hipatio Ilito",
            Hobbies = "Costura",
            Picture = "resources/foto5.jpg",
            Rating = 2
        };

        User User6 = new User()
        {
            Name = "Josefa Kalida",
            Hobbies = "Futbol",
            Picture = "resources/foto6.jpg",
            Rating = 4
        };

        User User7 = new User()
        {
            Name = "Lalo Moreno",
            Hobbies = "Negocios",
            Picture = "resources/foto7.jpg",
            Rating = 2
        };

        User User8 = new User()
        {
            Name = "Noriberto Opalo",
            Hobbies = "Musica",
            Picture = "resources/foto8.jpg",
            Rating = 4
        };

        User User9 = new User()
        {
            Name = "Perfido Quevedo",
            Hobbies = "Seguridad",
            Picture = "resources/foto11.jpg",
            Rating = 4
        };

        #endregion

        #region Metodos
        public void SetUserList()
        {
            listUser.Add(User1);
            listUser.Add(User2);
            listUser.Add(User3);
            listUser.Add(User4);
            listUser.Add(User5);
            listUser.Add(User6);
            listUser.Add(User7);
            listUser.Add(User8);
            listUser.Add(User9);
        }

        public void SetDetailUser()
        {
            listDetail = listUser;
        }

        public void SetDetailNextUser(int contador)
        {
            listDetail.Clear();
            listDetail.Add(User3);
            
        }


        #endregion

        public MainWindow()
        {
            
            InitializeComponent();
            SetUserList();
            //SetDetailNextUser();

            candidatesList.ItemsSource = listUser;
            detailList.ItemsSource = listDetail;



            //Controlador C1 = new Controlador();
            //C1.Conectar();                   

        }

        public void CambioUsuario(object sender, RoutedEventArgs e)
        {
            
            //SetDetailNextUser();
        }
        /*
        public void detalle(object sender, RoutedEventArgs e)
        {
            /*
            Button b = (Button)sender;
            User p = (User)b.DataContext;
            //MessageBox.Show(p.Description);
            
            detailViewUser.Add(new User()
            {
                Name = "Fran Golgota",
                Hobbies = "Caza",
                Picture = "resources/foto4.jpg",
                Rating = 3
            });
        }
    */


        /*
        public void detalle(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            User p = (User)b.DataContext;
            //MessageBox.Show(p.Description);
            detailViewUser.Add(p);
        }*/

        /*
        public void MouseMove(object sender, MouseEventArgs e)
        {
            // Get the x and y coordinates of the mouse pointer.
            //System.Windows.Mou position = e.GetPosition(this);

            double pX = e.GetPosition(this).X;
            //double pY = position.Y;
            Point pointToWindow = Mouse.GetPosition(this);
            Thickness myThickness = new Thickness();
            myThickness.Bottom = 5;
            myThickness.Left = -Mouse.GetPosition(this).X + 300;
            myThickness.Right = Mouse.GetPosition(this).X;
            myThickness.Top = 20;
            info.Margin = myThickness;
            //info.Margin = Mouse.GetPosition;
        }
        */
    }
}
