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
using Novel_App.View.User.MyChapter;
using Novel_App.ViewModel;
using Novel_App.ViewModel.User;

namespace Novel_App.View.User
{
    /// <summary>
    /// Interaction logic for UserHomePageView.xaml
    /// </summary>
    public partial class UserHomePageView : Window
    {
        public UserHomePageView()
        {
            InitializeComponent();
            DataContext = new HomepageViewModel();
            FrMain.Content = new NovelsView();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            FrMain.Content = new NovelsView();
        }

      
        private void Mynovel_Click(object sender, RoutedEventArgs e)
        {
            FrMain.Content = new MyNovelView();
        }
    }
}
