using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ProjectPHT.Commands;
using ProjectPHT.EFRepo;
using ProjectPHT.Entities;
using ProjectPHT.Repo;

namespace ProjectPHT.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        private User _createUser;
        public User CreateUser
        {
            get { return _createUser; }
            set { _createUser = value; OnPropertyChanged(nameof(CreateUser)); }



        }
        public ICommand CreateCommand { get; set; }
        public SignUpViewModel()
        {
            this.CreateUser = new User
            {
                UserID = 0,
                Name = "",
                Email = "",
                PasswordHash = "",
                DateOfBirth = DateTime.Now,
                Gender = "",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            CreateCommand = new RelayCommand(Creating);
        }

        private IUserRepo _repo = new EFUserRepo();
        public void Creating()
        {
            User user = new User
            {
                UserID = CreateUser.UserID,
                Name = CreateUser.Name,
                Email = CreateUser.Email,
                PasswordHash = CreateUser.PasswordHash,
                DateOfBirth = CreateUser.DateOfBirth,
                Gender = CreateUser.Gender,
                CreatedAt = CreateUser.CreatedAt,
                UpdatedAt = CreateUser.UpdatedAt,
            };
            var result = MessageBox.Show(messageBoxText: "Are you sure to create?",
                    caption: "Confirm",
                    button: MessageBoxButton.YesNo,
                    icon: MessageBoxImage.Question);
            if (result != MessageBoxResult.Yes)
            {
                return;
            }
            _repo.Create(user);

            this.CreateUser = new User
            {
                UserID = 0,
                Name = "",
                Email = "",
                PasswordHash = "",
                DateOfBirth = DateTime.Now,
                Gender = "",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            result = MessageBox.Show(messageBoxText: "Created Successfully",
                    caption: "Alert",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Information);


        }
    }
}
