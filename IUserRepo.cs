using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPHT.Entities;

namespace ProjectPHT.Repo
{
    public interface IUserRepo
    {
        //void Authenticate(string UserName, string PasswordHash);
        bool IsValidUser(User user);
        void Create(User user);
        void Update(User user);
        void Delete(User user);
        ObservableCollection<User> ReadAll();
    }
}
