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
using System.Windows.Shapes;

namespace PracticaPeliculas
{
    public partial class UserRegistration : Window
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserControlPanel userControlPanel = new UserControlPanel();
            userControlPanel.Show();
        }

        private void NewUser_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow newUserWindow = new RegistrationWindow();
            newUserWindow.Show();
        }
    }
}