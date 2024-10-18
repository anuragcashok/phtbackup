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

namespace ProjectPHT.Pages
{
    /// <summary>
    /// Interaction logic for HomePageWindow.xaml
    /// </summary>
    public partial class HomePageWindow : Window
    {
        public HomePageWindow()
        {
            InitializeComponent();
        }
        //private void Window_Closed(object sender, EventArgs e)
        //{
        //    Application.Current.Shutdown();
        //}

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            PHTConfig.loginWindow.Show();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            PHTConfig.signUpWindow.Show();
        }

        private void btnContactSupport_Click(object sender, RoutedEventArgs e)
        {
            PHTConfig.contactSupportWindow.Show();
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
