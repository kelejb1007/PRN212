using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Novel_App.Model;
using Novel_App.Utilities;
using Novel_App.View;
using Novel_App.View.Admin;
using Novel_App.View.User;

namespace Novel_App.ViewModel.User
{
    class HomepageViewModel : BaseViewModel
    {
        public ICommand LogoutCommand { get; }

        public HomepageViewModel()
        {
            LogoutCommand = new RelayCommand(Logout);
        }

        private void Logout(object obj)
        {
            var UserView = new Login();
            UserView.Show();
            Application.Current.Windows[0]?.Close();
        }
    }
}
