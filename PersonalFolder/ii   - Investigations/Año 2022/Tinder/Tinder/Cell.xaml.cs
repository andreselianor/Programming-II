﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tinder
{
    /// <summary>
    /// Lógica de interacción para Cell.xaml
    /// </summary>
    public partial class Cell : UserControl
    {
        public Cell()
        {
            InitializeComponent();
        }
        /*
        void clickUser(object sender, RoutedEventArgs e)
        {

            User u = (User)sender;
            MainWindow ventana = new MainWindow();
            User usuarioDetalle = new User();
            ventana.SetDetailUser(u);
        }*/
    }
}
