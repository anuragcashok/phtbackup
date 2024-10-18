using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPHT.Commands;
using ProjectPHT.EFRepo;
using ProjectPHT.Repo;
using System.Windows.Input;
using System.Windows;
using ProjectPHT.Entities;
using ProjectPHT.Pages;

namespace ProjectPHT.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private User _currentUser;
        public User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; OnPropertyChanged(nameof(CurrentUser)); }

        }
        public ICommand LoginCommand { get; set; }
        public LoginViewModel()
        {
            CurrentUser = new User
            {
                Email = "",
                PasswordHash = ""
            };
            LoginCommand = new RelayCommand(Login);
        }

        private IUserRepo _repo = new EFUserRepo();
        public void Login()
        {
            if (_repo.IsValidUser(CurrentUser))
            {
                MessageBox.Show(messageBoxText: "Login Successfull");
                if (CurrentUser.Email == "admin" && CurrentUser.PasswordHash == "123")
                {
                    PHTConfig.adminDashboardWindow.Show();
                }
                else
                {
                    PHTConfig.userDashBoardWindow.Show();
                }
            }
            else
            {
                MessageBox.Show("Login Unsuccessfull");
            }
        }
    }
}
