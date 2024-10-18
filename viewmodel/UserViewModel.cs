using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPHT.Commands;
using ProjectPHT.EFRepo;
using ProjectPHT.Repo;
using System.Windows.Input;
using System.Windows;
using ProjectPHT.Entities;
using System.Security.Cryptography;


namespace ProjectPHT.ViewModels
{
    public delegate void DWindoClose();

    public class UserViewModel : ViewModelBase
    {
        public DWindoClose WindowClose;
        public DWindoClose EditWindowClose;

        public IUserRepo _repo = EFUserRepo.Instance;

        private User _newUser;


        public User NewUser
        {
            get
            {
                return _newUser;
            }
            set
            {
                _newUser = value; OnPropertyChanged(nameof(NewUser));
            }
        }


        private User _selectedUser;


        public User SelectedUser
        {
            get
            {
                return _selectedUser;
            }
            set
            {
                _selectedUser = value; OnPropertyChanged(nameof(SelectedUser));
            }
        }



        private User _currentUser;


        public User CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value; OnPropertyChanged(nameof(CurrentUser));
            }
        }

        private ObservableCollection<User> _users;


        public ObservableCollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value; OnPropertyChanged(nameof(Users));
            }
        }

        public ICommand CreateCommand { get; set; }
        //public ICommand LoginCommand { get; set; }

        public ICommand UpdateCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public UserViewModel()
        {
            NewUser = new User
            {
                Name = "",
                Email = "",
                PasswordHash = "",
                DateOfBirth = DateTime.Now,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,

            };

            CurrentUser = new User
            {
                Name = "",
                Email = "",
                PasswordHash = ""
            };

            LoadUsers();
            CreateCommand = new RelayCommand(Create);
            //LoginCommand = new RelayCommand(Login);
            UpdateCommand = new RelayCommand(Update);
            DeleteCommand = new RelayCommand(Delete);
        }

        public void HashPassword()
        {
            string password = NewUser.PasswordHash;
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(passwordBytes);

                // Convert the hash bytes to a hexadecimal string
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                NewUser.PasswordHash = hashString;
            }
        }
        private void Delete()
        {
            if (this.SelectedUser == null)
            {
                var result1 = MessageBox.Show(messageBoxText: "Please select the user to Delete",
                        caption: "Alert",
                        button: MessageBoxButton.OK,
                        icon: MessageBoxImage.Information);
                return;
            }

            var res = MessageBox.Show(messageBoxText: "Are you sure to Delete this User?",
                    caption: "Confirm",
                    button: MessageBoxButton.YesNo,
                    icon: MessageBoxImage.Question);

            if (res != MessageBoxResult.Yes)
            {
                return;
            }

            _repo.Delete(this.SelectedUser);
            this.SelectedUser = this.SelectedUser;
            var result = MessageBox.Show(messageBoxText: $"Alert {SelectedUser.UserID} is Deleted successfully",
                       caption: "Alert",
                       button: MessageBoxButton.OK,
                       icon: MessageBoxImage.Information);
            LoadUsers();
        }

        private void Update()
        {

            if (this.SelectedUser == null)
            {
                return;
            }

            var res = MessageBox.Show(messageBoxText: "Are you sure to Update this User?",
                    caption: "Confirm",
                    button: MessageBoxButton.YesNo,
                    icon: MessageBoxImage.Question);

            if (res != MessageBoxResult.Yes)
            {
                return;
            }

            _repo.Update(this.SelectedUser);
            this.SelectedUser = this.SelectedUser;

            var result = MessageBox.Show(messageBoxText: $"Alert {SelectedUser.UserID} is updated successfully",
                        caption: "Alert",
                        button: MessageBoxButton.OK,
                        icon: MessageBoxImage.Information);
            LoadUsers();

            if (EditWindowClose != null)
            {
                EditWindowClose();
            }
        }

        private void LoadUsers()
        {
            Users = _repo.ReadAll();
        }

        private void Create()
        {
            HashPassword();
            var newUser = new User
            {
                Name = NewUser.Name,
                PasswordHash = NewUser.PasswordHash,
                Email = NewUser.Email,
                DateOfBirth = NewUser.DateOfBirth,
                Gender = NewUser.Gender,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            try
            {
                var result = MessageBox.Show(messageBoxText: "Are you sure to Create ?",
                    caption: "Confirm",
                    button: MessageBoxButton.YesNo,
                    icon: MessageBoxImage.Question);
                if (result != MessageBoxResult.Yes)
                {
                    return;
                }
                _repo.Create(newUser);/////

                result = MessageBox.Show(messageBoxText: "Created Successfully",
                    caption: "Alert",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Information);

                LoadUsers();

                if (WindowClose != null)
                {
                    WindowClose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        /*public bool CanLogin()
        {
            return CurrentUser.Name.Length > 0 && CurrentUser.PasswordHash.Length > 0;
        }

        private void Login()
        {
            try
            {
                _repo.Login(CurrentUser);
                MessageBox.Show($"Login SuccessFull");


                if (CurrentUser.Username == "admin")
                {

                    PHTConfig.adminDashboardWindow.Show();
                }
                else
                {
                    PHTConfig.userDashboardWindow.Show();
                }
                if (WindowClose != null)
                {
                    WindowClose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }*/




    }
}
