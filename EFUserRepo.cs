using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ProjectPHT.Entities;
using ProjectPHT.Repo;

namespace ProjectPHT.EFRepo
{
    public class EFUserRepo : IUserRepo
    {
        private static EFUserRepo _instance;
        public ObservableCollection<User> Users { get; set; }
        public static EFUserRepo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EFUserRepo();
                return _instance;
            }

        }
        //public User CurrentUser { get; set; } = null;
        private PHT_DbEntities _context;
        public EFUserRepo()
        {
            _context = new PHT_DbEntities();
        }
        public void Create(User user)
        {
            //throw new NotImplementedException();
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public string GetPassword(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(passwordBytes);

                // Convert the hash bytes to a hexadecimal string
                string inputHash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return inputHash;
            }


        }
        /*public void Login(User user)
        {
            var HashedPassword = GetPassword(user.PasswordHash);
            var User = _context.Users.FirstOrDefault(u => u.Email == user.Email && u.PasswordHash == HashedPassword);
            if (User == null)
            {
                throw new Exception("Invalid username or password");
            }
            else
            {
                CurrentUser = User;
            }

        }*/
        public bool IsValidUser(User user)
        {
            //var HashedPassword = GetPassword(user.PasswordHash);
            var User = _context.Users.FirstOrDefault(u => u.Email == user.Email && u.PasswordHash == user.PasswordHash);
            if (User == null)
            {
                MessageBox.Show("Invalid email or password");
                return false;
            }
            else
            {
                //CurrentUser = User;
                return true;
            }

            //return user != null;
        }
        public void Delete(User userModel)
        {
            var userToDelete = _context.Users.Find(userModel.UserID);
            if (userToDelete != null)
            {
                _context.Users.Remove(userToDelete);
                _context.SaveChanges();
            }
        }
        public void Update(User userModel)
        {
            var existingUser = _context.Users.Find(userModel.UserID);
            if (existingUser != null)
            {
                _context.Entry(existingUser).CurrentValues.SetValues(userModel);
                // existingUser.Username = userModel.Username;
                _context.SaveChanges();
            }
        }
        public ObservableCollection<User> ReadAll()
        {
            return new ObservableCollection<User>(_context.Users.ToList());
        }
    }
}
