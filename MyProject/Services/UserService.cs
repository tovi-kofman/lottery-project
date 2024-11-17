using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;
using MyProject.Interface;
using System;

namespace MyProject.Services
{
    public class UserService
    {
        //static DataContext DataContextManager { get; set; }
        //public DataContext DataContextManager = ManagerDataContext.DataContext;
        readonly IDataContext  _dataContext;
        public UserService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<User> GetUsers()
        {
            return _dataContext.LoadData<User>();
        }
        public User GetUserById(int id)
        {
            return _dataContext.LoadData<User>().FirstOrDefault(x => x.UserId == id);
        }
        public bool AddUser(User user)
        {
            TzValid tzValid = new TzValid();
            ErrorTZ error;
            if (tzValid.ISOK(user.Tz, out error))
            {
                var users = _dataContext.LoadData<User>();
                users.Add(user);
                return _dataContext.SaveData(users);
            }
            else { Console.WriteLine(error); }
           return false;
        }
        public bool UpdateUser(int id,User user)
        {
            var users = _dataContext.LoadData<User>();
            foreach (User u in users)
            {
                if (u.UserId == id)
                {
                    u.Address = user.Address;
                    u.Password = user.Password;
                    u.Email = user.Email;
                    u.FirstName = user.FirstName;
                    u.LastName = user.LastName;
                    u.PhoneNumber = user.PhoneNumber;
                    u.AccountType = user.AccountType;

                    return _dataContext.SaveData(users);
                }
            }
            return false;
        }
        public bool RemoveUser(int id)
        {
            var users = _dataContext.LoadData<User>();
             users.Remove(users.FirstOrDefault(x => x.UserId== id));
            return _dataContext.SaveData(users);
        }

       
    }

}