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
using Novel_App.View.User;

namespace Novel_App.View.Admin
{
    /// <summary>
    /// Interaction logic for AdminDashboardView.xaml
    /// </summary>
    public partial class AdminDashboardView : Window
    {
        public AdminDashboardView()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            FrMain.Content = null;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            FrMain.Content = null;
        }

        private void Mynovel_Click(object sender, RoutedEventArgs e)
        {
            FrMain.Content = new MyNovelView();
        }
    }
}
